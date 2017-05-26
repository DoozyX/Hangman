# Hangman
Hangman Game

Windows Forms Project by: Slobodan Kletnikov

##1. Опис на апликацијата
Апликацијата што ја развив е играта Бесилка(Hangman).

##2. Упатство за користењe


![Menu](https://image.prntscr.com/image/5083466650dd455f900d47e21a7afb6a.png)

На почетниот прозорец (слика 1) при стартување на апликацијата можe да се одбере нова игра каде играчот може да игра сам против компјутерот
, да играм со некој другар (Two Players) така што едниот ке напише збор а другиот ке го погаѓа и обратно, да видиме што преставува играта (Help)
и да видиме листа со рекорди (High scores).

###2.1 Single Player
![SinglePlayer](https://image.prntscr.com/image/6bd337b62fc8473db1b16d6f8322f60e.png)

Доколку сакаме да играм против компјутерот го пишуваме нашето име, тежината на играта Easy, Medium или Hard и категоријата од која сакаме да погодуваме зборови

###2.2 Two Players
Овозможено е играње на два играчи каде дниот ке напише збор а другиот ке го погаѓа и обратно.

###2.3 High Scores
![HighScore](https://image.prntscr.com/image/e020fefc13fe46c591e5c1915e51a1c6.png)

Тука sе прикажуваат најдобрите 5 играчи за секоја тежина, сортирани според нивниот score
После секоја игра се меморира резултатот за таа игра за моменталниот играч.

Податоците се сериализирани и се достапни и после исклучување на играта.
###2.4 Правилата се:
Корисникот притска на една од буквите, со притискањето таа се оневозможува со што доколку е точна се внесува мо зборот и се додава поен, во спротивно се
додава нов дел на бесење на човекот се додека не се додата сите 6 делови од телото.
##3. Претставување на проблемот

###3.1 Податочни структури

Главните податоци и функции за играта се чуваат во класа HangmanGamе. Главен податок е класата HangmanWord во која се чуваат податоците и состојбата за тој збор.

Секоја променлива и функција содржи xml summary, со детално објаснување.

/// <summary>
/// This class represents the game Hangman where person can guess the letters of the word until he fail 6 letters
/// </summary>
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
        /// Checks if the letter is correct
        /// </summary>
        /// <returns>Returns if the letter is correct</returns>
        public bool CheckGuessed() {
            return _word.IsGuessed;
        }

        /// <summary>
        /// Returns the score
        /// </summary>
        /// <returns/>Returns the score of the game/returns>
        public int GetScore() {
            return _score;
        }

        /// <summary>
        /// Returns number of wrong letter have been guesed
        /// </summary>
        /// <returns>Returns number of wrong letter have been guesed</returns>
        public int GetWrongCount() {
            return _word.WrongCount;
        }

        /// <summary>
        /// Starts a new game
        /// </summary>
        public void NewGame() {
            _word = new HangmanWord(GetRandomWord());
            _score = 0;
        }
        /// <summary>
        /// A new word for guessing is generated
        /// </summary>
        public void NewWord() {
            _word = new HangmanWord(GetRandomWord());
        }

        /// <summary>
        /// Returns the word
        /// </summary>
        public string GetWord() {
            return _word.Word;
        }
}


