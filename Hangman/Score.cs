using System;

namespace Hangman
{
    [Serializable]
    class ScoreItem : IComparable<ScoreItem>
    {
        /// <summary>
        /// Stores the dificulty of the specific Score
        /// </summary>
        public Dificulty Dificulty { get; }

        /// <summary>
        /// stores the dificulty of the specific Score
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// stores the score
        /// </summary>
        public int Score { get; }

        /// <summary>
        /// Constructor for the score item
        /// </summary>
        public ScoreItem(Dificulty dificulty, string name, int score) {
            Dificulty = dificulty;
            Name = name;
            Score = score;
        }
        /// <summary>
        /// comparison between two score items
        /// </summary>
        public int CompareTo(ScoreItem other)
        {
            return Score.CompareTo(other.Score);
        }
    }
}
