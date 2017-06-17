using System;

namespace Hangman {
    public class HangmanTwoPlayerGame : HangmanGame {
        public Player PlayerTwo { get; private set; }
        public Player CurrentPlayer { get; private set; }
        public Player GuessingPlayer { get; private set; }

        public HangmanTwoPlayerGame(string playerName, string playerTwoName) : base(playerName) {
            PlayerTwo = new Player(playerTwoName);
        }

        public void NewWord(string word) {
            Word = new HangmanWord(word);
        }

        public override void GuessLetter(char letter) {
            if (Word.GuessLetter(letter)) {
                GuessingPlayer.AddScore(1);
            }
        }

        public int GetScoreTwo() {
            return PlayerTwo.Score;
        }

        public void NewGame(string word) {
            Word = new HangmanWord(word);
        }

        public string GetRandomPlayer() {
            Random random = new Random();
            int n = random.Next(2);
            if (n == 0) {
                CurrentPlayer = Player;
                GuessingPlayer = PlayerTwo;
                return Player.Name;
            }
            CurrentPlayer = PlayerTwo;
            GuessingPlayer = Player;
            return PlayerTwo.Name;
        }

        public void SwitchPlayer() {
            if (CurrentPlayer == Player) {
                GuessingPlayer = Player;
                CurrentPlayer = PlayerTwo;
            } else {
                CurrentPlayer = Player;
                GuessingPlayer = PlayerTwo;
            }
        }
    }
}