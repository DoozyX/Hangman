using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Player {
        public string Name { get; }
        public int Score { get; private set; }

        public Player(string name) {
            Name = name;
            Score = 0;
        }

        public void AddScore(int score) {
            Score += score;
        }

        public void ResetScore() {
            Score = 0;
        }
    }
}
