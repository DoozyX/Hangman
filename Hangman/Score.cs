using System;

namespace Hangman
{
    [Serializable]
    class ScoreItem : IComparable<ScoreItem>
    {
        public Dificulty Dificulty { get; }
        public string Name { get; }
        public int Score { get; }  

        public ScoreItem(Dificulty dificulty, string name, int score) {
            Dificulty = dificulty;
            Name = name;
            Score = score;
        }

        public int CompareTo(ScoreItem other)
        {
            return Score.CompareTo(other.Score);
        }
    }
}
