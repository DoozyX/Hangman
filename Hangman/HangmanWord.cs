using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman {
    /// <summary>
    /// Class for representing the current game
    /// </summary>
    public class HangmanWord {
        /// <summary>
        /// current Word
        /// </summary>
        public string Word { get; }


        /// <summary>
        /// Letters of witch the word is made of
        /// </summary>
        public HashSet<char> WordLetters { get; set; }

        /// <summary>
        /// Number of wrong letters
        /// </summary>
        public int WrongCount { get; set; }

        /// <summary>
        /// Maximum wrong letters
        /// </summary>
        public static readonly int MaxWrongCount = 6;

        /// <summary>
        /// Constructor for new game. It initalize the word and others structures for the class.
        /// </summary>
        /// <param name="word">Word witch should be guessed</param>
        public HangmanWord(string word) {
            Word = word;
            WordLetters = new HashSet<char>();
            foreach (char c in Word) {
                WordLetters.Add(char.ToUpper(c));
            }
            WrongCount = 0;
        }

        /// <summary>
        /// Returns if the word is guessed
        /// </summary>
        public bool IsGuessed => WordLetters.Count == 0;

        /// <summary>
        /// Checks for Game Over
        /// </summary>
        /// <returns>Return if the game is over</returns>
        public bool IsGameOver => WrongCount == MaxWrongCount;

        /// <summary>
        /// Cheks if the letter is correct
        /// </summary>
        /// <param name="letter">Guessed letter</param>
        /// <returns>Returns if the letter is correct</returns>
        public bool GuessLetter(char letter) {
            if (WordLetters.Contains(letter)) {
                WordLetters.Remove(letter);
                return true;
            } 
            WrongCount++;
            return false;
        }

        /// <summary>
        /// Makes mask for the word. Letters witch are not guessed are replaced with '_'
        /// </summary>
        /// <returns>String as mask for the word</returns>
        public string WordMask() {
            StringBuilder guess = new StringBuilder();
            for (int i = 0; i < Word.Length; i++) {
                char c = Word[i];
                c = Char.ToUpper(c);
                if (WordLetters.Contains(c)) {
                    guess.Append("_");
                } else {
                    guess.Append(Word[i]);
                }
                if (i != Word.Length - 1)
                    guess.Append(" ");
            }
            return guess.ToString();
        }

    }
}

