using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace Hangman {
    public sealed partial class Hangman : Form {
        private const string ScoresPath = @"../../Resources/scores.txt";
        private const string WordsPath = @"../../Resources/words/";

        /// <summary>
        /// Current game playing
        /// </summary>
        private HangmanGame _hangmanGame;

        /// <summary>
        /// High Scores for the game
        /// </summary>
        private Scores _highScores;

        /// <summary>
        /// Initialize the form
        /// </summary>
        public Hangman() {
            InitializeComponent();
            DoubleBuffered = true;

            //Hide tab control buttons
            tabControlMenu.Appearance = TabAppearance.FlatButtons;
            tabControlMenu.ItemSize = new Size(0, 1);
            tabControlMenu.SizeMode = TabSizeMode.Fixed;
            tabControlSinglePlayer.Appearance = TabAppearance.FlatButtons;
            tabControlSinglePlayer.ItemSize = new Size(0, 1);
            tabControlSinglePlayer.SizeMode = TabSizeMode.Fixed;
            //Make text and images transparent
            foreach (Control control in tabControlMenu.Controls) {
                control.BackColor = Color.Transparent;
            }
            foreach (Control control in tabControlSinglePlayer.Controls) {
                control.BackColor = Color.Transparent;
            }

            //find categories

            string[] fileEntries = Directory.GetFiles(WordsPath);
            List<ListItem> categories =
                fileEntries.Select(fileName => new ListItem(Path.GetFileNameWithoutExtension(fileName), fileName))
                    .ToList();
            cbCategories.DataSource = categories;

            //High Scores
            DeserializeScores();
        }

        /// <summary>
        /// Swaping between view in Menu Form
        /// </summary>
        private void btnSinglePlayer_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabSinglePlayer;
            tbSPName.Select();
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabTwoPlayers;
        }

        private void btnHighScores_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabHighScores;
            SetHighScores();
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabHelp;
        }

        /// <summary>
        /// Swaping between view in Two Players
        /// </summary>
        private void btnTwoBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

        /// <summary>
        /// Swaping between view in High Scores
        /// </summary>
        private void btnHighScoreBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

        /// <summary>
        /// Swaping between view in Help
        /// </summary>
        private void btmHelpBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }


        /// <summary>
        /// Swaping between view in Sinle Player
        /// </summary>
        private void btnSPBack_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabMenu;
        }

        private void btnSPGameBack_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabMenu;
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerMenu;
        }

        private void btnSPGameNew_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnSPResBack_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabMenu;
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerMenu;
        }

        private void btnSPResNew_Click(object sender, EventArgs e)
        {
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerGame;
            NewGame();
        }
        /// <summary>
        /// Validates that a name is entered
        /// </summary>
        private void tbSPName_Validating(object sender, CancelEventArgs e) {
            if (tbSPName.Text.Trim().Length == 0) {
                e.Cancel = true;
                errorProvider1.SetError(tbSPName, "Enter Name!");
            } else {
                errorProvider1.SetError(tbSPName, null);
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Clear the Hangman
        /// </summary>
        private void ClearSpMan() {
            pbHead.Visible = false;
            pbBody.Visible = false;
            pbLeftArm.Visible = false;
            pbRightArm.Visible = false;
            pbLeftLeg.Visible = false;
            pbRightLeg.Visible = false;
        }
        /// <summary>
        /// Reset the letters to active
        /// </summary>
        private void ResetLetters() {
            foreach (Button btn in pnlLetters.Controls) {
                btn.Enabled = true;
            }
        }

        /// <summary>
        /// Set variables for new game
        /// </summary>
        private void NewGame() {
            ClearSpMan();
            ResetLetters();
            _hangmanGame.NewGame();
            lblSPGuessWord.Text = _hangmanGame.GetWordMask();
            lblScore.Text = _hangmanGame.GetScore().ToString();
        }

        /// <summary>
        /// Checks for uptades in the current state of the game
        /// </summary>
        private void UpdateGameState() {
            int wrong = _hangmanGame.GetWrongCount();
            switch (wrong) {
                case 0:
                    ClearSpMan();
                    break;
                case 1:
                    pbHead.Visible = true;
                    break;
                case 2:
                    pbBody.Visible = true;
                    break;
                case 3:
                    pbLeftArm.Visible = true;
                    break;
                case 4:
                    pbRightArm.Visible = true;
                    break;
                case 5:
                    pbLeftLeg.Visible = true;
                    break;
                default:
                    pbRightLeg.Visible = true;
                    EndGame();
                    return;
            }
            //for future
            if (_hangmanGame.CheckGameOver()) {
                EndGame();
            }

            if (_hangmanGame.CheckGuessed()) {
                _hangmanGame.NewWord();
                ResetLetters();
                ClearSpMan();
            }
            lblSPGuessWord.Text = _hangmanGame.GetWordMask();
            lblScore.Text = _hangmanGame.GetScore().ToString();
        }

        /// <summary>
        /// Resets the elements after the games and and adds the score
        /// </summary>
        private void EndGame() {
            lblSPREsScore.Text = _hangmanGame.GetScore().ToString();
            lblSPResCorrect.Text = _hangmanGame.GetWord();
            tabControlSinglePlayer.SelectedTab = tabPageSPResult;
            _highScores.AddScore(new ScoreItem(_hangmanGame.Dificulty, _hangmanGame.PlayerName, _hangmanGame.GetScore()));
        }

        /// <summary>
        /// Starts new game
        /// </summary>
        private void btnSPPlay_Click(object sender, EventArgs e) {
            Dificulty dificulty;
            if (rbSPDif.Checked) {
                dificulty = Dificulty.Eazy;
            } else if (rbSPDif2.Checked) {
                dificulty = Dificulty.Medium;
            } else {
                dificulty = Dificulty.Hard;
            }

            ListItem category = cbCategories.SelectedItem as ListItem;
            if (category != null)
                _hangmanGame = new HangmanGame(tbSPName.Text, dificulty, category.Value);

            NewGame();

            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerGame;
        }

        /// <summary>
        /// Whenever a letter is clicked the button is disabled, puts the letter in the word to be checked, and updates the view
        /// </summary>
        private void Letter_Click(object sender, EventArgs e) {
            Button btn = (Button) sender;
            btn.Enabled = false;

            _hangmanGame.GuessLetter(btn.Text[0]);

            UpdateGameState();
        }


        
        /// <summary>
        /// Saves the scores
        /// </summary>
        /// 
        private void SerializeScores() {
            using (FileStream str = new FileStream(ScoresPath, FileMode.Create)) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, _highScores);
            }
        }
        /// <summary>
        /// Loads the high scores
        /// </summary>
        private void DeserializeScores() { 
            try {
                using (FileStream str = File.OpenRead(ScoresPath)) {
                    BinaryFormatter bf = new BinaryFormatter();
                    _highScores = (Scores) bf.Deserialize(str);
                }
                File.Delete(ScoresPath);
            } catch (Exception) {
                _highScores = new Scores();
            }
        }

        /// <summary>
        /// Writes the top high scores on the view
        /// </summary>
        private void SetHighScores() {
            Dificulty dificulty;
            Enum.TryParse(cbScoresDificulty.SelectedItem.ToString(), true, out dificulty);
            List<ScoreItem> difHighScores = _highScores.GetTopScores(dificulty);
            StringBuilder stringBuilder = new StringBuilder();
            int i = 0;
            foreach (ScoreItem score in difHighScores) {
                stringBuilder.Append($"{++i}. {score.Name,-20}{score.Score}\n");
            }
            lblHighScores.Text = stringBuilder.ToString();
        }

        /// <summary>
        /// Changes the high scores depening on dificulty
        /// </summary>
        private void cbScoresDificulty_SelectedIndexChanged(object sender, EventArgs e) {
            SetHighScores();
        }

        /// <summary>
        /// Closes the game
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        /// Whenever the game is closed scores are saved
        /// </summary>
        private void Hangman_FormClosing(object sender, FormClosingEventArgs e) {
            SerializeScores();
        }


    }
}