using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    enum Dificulty
    {
        Eazy,
        Medium,
        Hard
    }
          
    class HangmanGame {
        /// <summary>
        /// Name of the Player
        /// </summary>
        private string playerName;
        /// <summary>
        /// Word witch needs to be guessed
        /// </summary>
        private HangmanWord word;
        /// <summary>
        /// Dificulty of the game
        /// </summary>
        private Dificulty dificulty;
        /// <summary>
        /// Category and its path from witch the word will be choosen
        /// </summary>
        private string category;
        private string categoryPath;
        /// <summary>
        /// List of possible words from given category
        /// </summary>
        private List<string> words;
        /// <summary>
        /// Score for the current game
        /// </summary>
        private int score;

        /// <summary>
        /// Constructor for new game. It initalize the word and others structures for the class.
        /// </summary>
        public HangmanGame(string playerName, Dificulty dificulty, string category, string categoryPath) {
            this.playerName = playerName;
            this.dificulty = dificulty;
            this.category = category;
            this.categoryPath = categoryPath;
            words = GetWordsFromFile(categoryPath);
            word = new HangmanWord(getRandomWord());
            score = 0;
        }

        /// <summary>
        /// Sets the list of all possible words from the given path
        /// </summary>
        private List<string> GetWordsFromFile(string path) {
            if (File.Exists(path)) {
                return File.ReadAllLines(path).ToList();
            }
            return new List<string>();
        }

        /// <summary>
        /// Chooses a random word from the possible list of words
        /// </summary>
        /// <returns>Returns the random word</returns>
        private string getRandomWord() {
            Random random = new Random();
            int randomPos = random.Next(words.Count);
            return words[randomPos];
        }

        /// <summary>
        /// Makes mask for the word. Letters witch are not guessed are replaced with '_'
        /// </summary>
        /// <returns>String as mask for the word</returns>
        public string GetWordMask() {
            return word.WordMask();
        }

        /// <summary>
        /// Cheks if the letter is correct
        /// </summary>
        /// <param name="letter">Guessed letter</param>
        /// <returns>Returns if the letter is correct</returns>
        public void GuessLetter(char letter) {
            if (word.GuessLetter(letter)) {
                score++;
            }
        }

        /// <summary>
        /// Checks for Game Over
        /// </summary>
        /// <returns>Return if the game is over</returns>
        public bool CheckGameOver() {
            return word.IsGameOver;
        }

        /// <summary>
        /// Cheks if the letter is correct
        /// </summary>
        /// <param name="letter">Guessed letter</param>
        /// <returns>Returns if the letter is correct</returns>
        public bool CheckGuessed() {
            return word.IsGuessed;
        }

        public int GetScore() {
            return score;
        }

        public int GetWrongCount() {
            return word.WrongCount;
        }

        public void NewGame() {
            word = new HangmanWord(getRandomWord());
            score = 0;
        }

        public void NewWord() {
            word = new HangmanWord(getRandomWord());
        }

        public string GetWord() {
            return word.Word;
        }
    }
}
