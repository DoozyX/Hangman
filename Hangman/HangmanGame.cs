using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hangman
{
    /// <summary>
    /// Enumeration for possible dificulties of the game
    /// </summary>
    public enum Dificulty
    {
        Eazy,
        Medium,
        Hard
    }
    /// <summary>
    /// This class represents the game Hangman where person can guess the letters of the word until he fail 6 letters
    /// </summary>
    public class HangmanGame {
        /// <summary>
        /// Player of the game
        /// </summary>
        public Player Player { get; private set; }
        /// <summary>
        /// Word witch needs to be guessed
        /// </summary>
        protected HangmanWord Word;
        /// <summary>
        /// Dificulty of the game
        /// </summary>
        public Dificulty Dificulty { get; }

        /// <summary>
        /// List of possible words from given category
        /// </summary>
        private readonly List<string> _words;

        /// <summary>
        /// Constructor for new game. It initalize the word and others structures for the class.
        /// </summary>
        public HangmanGame(string playerName, Dificulty dificulty, string categoryPath) {
            Player = new Player(playerName);
            Dificulty = dificulty;
            _words = GetWordsFromFile(categoryPath);
            Word = new HangmanWord(GetRandomWord());
        }
        public HangmanGame(string playerName)
        {
            Player = new Player(playerName);
            Dificulty = Dificulty.Eazy;
            Word = new HangmanWord("unknown");
        }

        /// <summary>
        /// Sets the list of all possible words from the given path
        /// </summary>
        private static List<string> GetWordsFromFile(string path) {
            return File.Exists(path) ? File.ReadAllLines(path).ToList() : new List<string>();
        }

        /// <summary>
        /// Chooses a random word from the possible list of words
        /// </summary>
        /// <returns>Returns the random word</returns>
        private string GetRandomWord() {
            Random random = new Random();
            int randomPos = random.Next(_words.Count);
            return _words[randomPos];
        }

        /// <summary>
        /// Makes mask for the word. Letters witch are not guessed are replaced with '_'
        /// </summary>
        /// <returns>String as mask for the word</returns>
        public string GetWordMask() {
            return Word.WordMask();
        }

        /// <summary>
        /// Cheks if the letter is correct
        /// </summary>
        /// <param name="letter">Guessed letter</param>
        /// <returns>Returns if the letter is correct</returns>
        public virtual void GuessLetter(char letter) {
            if (Word.GuessLetter(letter)) {
                Player.AddScore(1);
            }
        }

        /// <summary>
        /// Checks for Game Over
        /// </summary>
        /// <returns>Return if the game is over</returns>
        public bool CheckGameOver() {
            return Word.IsGameOver;
        }

        /// <summary>
        /// Checks if the letter is correct
        /// </summary>
        /// <returns>Returns if the letter is correct</returns>
        public bool CheckGuessed() {
            return Word.IsGuessed;
        }

        /// <summary>
        /// Returns the score
        /// </summary>
        /// <returns/>Returns the score of the game/returns>
        public int GetScore() {
            return Player.Score;
        }

        /// <summary>
        /// Returns number of wrong letter have been guesed
        /// </summary>
        /// <returns>Returns number of wrong letter have been guesed</returns>
        public int GetWrongCount() {
            return Word.WrongCount;
        }

        /// <summary>
        /// Starts a new game
        /// </summary>
        public void NewGame() {
            Word = new HangmanWord(GetRandomWord());
            Player.ResetScore();
        }
        /// <summary>
        /// A new word for guessing is generated
        /// </summary>
        public void NewWord() {
            Word = new HangmanWord(GetRandomWord());
        }

        /// <summary>
        /// Returns the word
        /// </summary>
        public string GetWord() {
            return Word.Word;
        }
    }
}
