﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public string PlayerName { get; }
        /// <summary>
        /// Word witch needs to be guessed
        /// </summary>
        private HangmanWord _word;
        /// <summary>
        /// Dificulty of the game
        /// </summary>
        public Dificulty Dificulty { get; }

        /// <summary>
        /// List of possible words from given category
        /// </summary>
        private List<string> words;
        /// <summary>
        /// Score for the current game
        /// </summary>
        private int _score;

        /// <summary>
        /// Constructor for new game. It initalize the word and others structures for the class.
        /// </summary>
        public HangmanGame(string playerName, Dificulty dificulty, string categoryPath) {
            PlayerName = playerName;
            Dificulty = dificulty;
            words = GetWordsFromFile(categoryPath);
            _word = new HangmanWord(GetRandomWord());
            _score = 0;
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
        private string GetRandomWord() {
            Random random = new Random();
            int randomPos = random.Next(words.Count);
            return words[randomPos];
        }

        /// <summary>
        /// Makes mask for the word. Letters witch are not guessed are replaced with '_'
        /// </summary>
        /// <returns>String as mask for the word</returns>
        public string GetWordMask() {
            return _word.WordMask();
        }

        /// <summary>
        /// Cheks if the letter is correct
        /// </summary>
        /// <param name="letter">Guessed letter</param>
        /// <returns>Returns if the letter is correct</returns>
        public void GuessLetter(char letter) {
            if (_word.GuessLetter(letter)) {
                _score++;
            }
        }

        /// <summary>
        /// Checks for Game Over
        /// </summary>
        /// <returns>Return if the game is over</returns>
        public bool CheckGameOver() {
            return _word.IsGameOver;
        }

        /// <summary>
        /// Cheks if the letter is correct
        /// </summary>
        /// <returns>Returns if the letter is correct</returns>
        public bool CheckGuessed() {
            return _word.IsGuessed;
        }

        public int GetScore() {
            return _score;
        }

        public int GetWrongCount() {
            return _word.WrongCount;
        }

        public void NewGame() {
            _word = new HangmanWord(GetRandomWord());
            _score = 0;
        }

        public void NewWord() {
            _word = new HangmanWord(GetRandomWord());
        }

        public string GetWord() {
            return _word.Word;
        }
    }
}
