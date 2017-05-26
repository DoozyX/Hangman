using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    [Serializable]
    class Scores {
        /// <summary>
        /// Maximum number of scores to be shown in the high scores
        /// </summary>
        public static readonly int NScores = 5;
        /// <summary>
        /// Lists where the scores will be stored
        /// </summary>
        private List<ScoreItem> scoresEazy;
        private List<ScoreItem> scoresMedium;
        private List<ScoreItem> scoresHard;

        /// <summary>
        /// Consturctor for empty Lists
        /// </summary>
        public Scores() {
            scoresEazy = new List<ScoreItem>();
            scoresMedium = new List<ScoreItem>();
            scoresHard = new List<ScoreItem>();
        }

        /// <summary>
        /// Adds the score the the list depenending of the mode
        /// </summary>
        public void AddScore(ScoreItem score) {
            if (score.Dificulty == Dificulty.Eazy) {
                scoresEazy.Add(score);
            } else if (score.Dificulty == Dificulty.Medium) {
                scoresMedium.Add(score);
            } else {
                scoresHard.Add(score);
            }
        }

        /// <summary>
        /// Sorts all the lists in reversed order
        /// </summary>
        public void Sort() {
            scoresEazy.Sort();
            scoresEazy.Reverse();
            scoresMedium.Sort();
            scoresMedium.Reverse();
            scoresHard.Sort();
            scoresHard.Reverse();
        }

        /// <summary>
        /// Returns a list of first scores of the list with selected dificulty
        /// </summary>
        public List<ScoreItem> GetTopScores(Dificulty dificulty) {
            Sort();
            if (dificulty == Dificulty.Eazy) {
                return scoresEazy.Take(NScores).ToList();
            }
            if (dificulty == Dificulty.Medium) {
                return scoresMedium.Take(NScores).ToList();
            }
            return scoresHard.Take(NScores).ToList();
        }
    }
}
