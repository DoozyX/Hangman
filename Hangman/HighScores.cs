using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    [Serializable]
    class Scores {
        public static readonly int NScores = 5;
        private List<ScoreItem> scoresEazy;
        private List<ScoreItem> scoresMedium;
        private List<ScoreItem> scoresHard;

        public Scores() {
            scoresEazy = new List<ScoreItem>();
            scoresMedium = new List<ScoreItem>();
            scoresHard = new List<ScoreItem>();
        }

        public void AddScore(ScoreItem score) {
            if (score.Dificulty == Dificulty.Eazy) {
                scoresEazy.Add(score);
            } else if (score.Dificulty == Dificulty.Medium) {
                scoresMedium.Add(score);
            } else {
                scoresHard.Add(score);
            }
        }

        public void Sort() {
            scoresEazy.Sort();
            scoresEazy.Reverse();
            scoresMedium.Sort();
            scoresMedium.Reverse();
            scoresHard.Sort();
            scoresHard.Reverse();
        }

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
