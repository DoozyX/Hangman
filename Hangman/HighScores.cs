using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    [Serializable]
    public class Scores {
        /// <summary>
        /// Maximum number of scores to be shown in the high scores
        /// </summary>
        public static readonly int NScores = 5;
        /// <summary>
        /// Lists where the scores will be stored
        /// </summary>
        private readonly List<ScoreItem> _scoresEazy;
        private readonly List<ScoreItem> _scoresMedium;
        private readonly List<ScoreItem> _scoresHard;

        /// <summary>
        /// Consturctor for empty Lists
        /// </summary>
        public Scores() {
            _scoresEazy = new List<ScoreItem>();
            _scoresMedium = new List<ScoreItem>();
            _scoresHard = new List<ScoreItem>();
        }

        /// <summary>
        /// Adds the score the the list depenending of the mode
        /// </summary>
        public void AddScore(ScoreItem score) {
            if (score.Dificulty == Dificulty.Eazy) {
                _scoresEazy.Add(score);
            } else if (score.Dificulty == Dificulty.Medium) {
                _scoresMedium.Add(score);
            } else {
                _scoresHard.Add(score);
            }
        }

        /// <summary>
        /// Returns a list of first scores of the list with selected dificulty
        /// </summary>
        public List<ScoreItem> GetTopScores(Dificulty dificulty) {
            switch (dificulty) {
                case Dificulty.Eazy:
                    _scoresEazy.Sort();
                    _scoresEazy.Reverse();
                    return _scoresEazy.Take(NScores).ToList();
                case Dificulty.Medium:
                    _scoresMedium.Sort();
                    _scoresMedium.Reverse();
                    return _scoresMedium.Take(NScores).ToList();
                case Dificulty.Hard:
                    _scoresHard.Sort();
                    _scoresHard.Reverse();
                    return _scoresHard.Take(NScores).ToList();
                default:
                    throw new ArgumentOutOfRangeException(nameof(dificulty), dificulty, null);
            }
        }
    }
}
