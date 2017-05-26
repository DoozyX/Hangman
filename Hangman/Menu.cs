using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace Hangman {
    public partial class Hangman : Form {
        /// <summary>
        /// Current game playing
        /// </summary>
        private HangmanGame hangmanGame;

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
                //Menu
                pbMenuHangman.BackColor = Color.Transparent;
                //SPMenu
                lblSPName.BackColor = Color.Transparent;
                rbSPDif.BackColor = Color.Transparent;
                rbSPDif2.BackColor = Color.Transparent;
                rbSPDif3.BackColor = Color.Transparent;
                lblSPDif.BackColor = Color.Transparent;
                lblSPCat.BackColor = Color.Transparent;
                //SPGame
                pbWood.BackColor = Color.Transparent;
                pbHead.BackColor = Color.Transparent;
                pbBody.BackColor = Color.Transparent;
                pbLeftArm.BackColor = Color.Transparent;
                pbRightArm.BackColor = Color.Transparent;
                pbLeftLeg.BackColor = Color.Transparent;
                pbRightLeg.BackColor = Color.Transparent;
                lblScore.BackColor = Color.Transparent;
                lblScore2.BackColor = Color.Transparent;
                pnlLetters.BackColor = Color.Transparent;
                //SPRes
                lblSPRes1.BackColor = Color.Transparent;
                lblSPRes2.BackColor = Color.Transparent;
                lblSPREsScore.BackColor = Color.Transparent;
                lblSPGuessWord.BackColor = Color.Transparent;
                pbSPHanged.BackColor = Color.Transparent;
                lblCorrectTitle.BackColor = Color.Transparent;
                lblSPResCorrect.BackColor = Color.Transparent;
                //Two Players
                lblSoon.BackColor = Color.Transparent;
                //High Scores
                lblHighScoreTitle.BackColor = Color.Transparent;
                lblHighScores.BackColor = Color.Transparent;
                //Help
                lblHelpTitle.BackColor = Color.Transparent;
                lblHelp.BackColor = Color.Transparent;

            //find categories
            string wordsPath = @"../../Resources/words/";
            string[] fileEntries = Directory.GetFiles(wordsPath);
            List<ListItem> categories = fileEntries.Select(fileName => new ListItem(Path.GetFileNameWithoutExtension(fileName), fileName)).ToList();
            cbCategories.DataSource = categories;
        }

        //Menu Page
        private void btnSinglePlayer_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabSinglePlayer;
            tbSPName.Select();

        }

        private void btnTwoPlayers_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabTwoPlayers;
        }

        private void btnHighScores_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabHighScores;
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabHelp;
        }

        //Two Players
        private void btnTwoBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

        //High Scores
        private void btnHighScoreBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

        //Help
        private void btmHelpBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }


        /// <summary>
        /// Single Player
        /// </summary>
        private void tbSPName_Validating(object sender, CancelEventArgs e)
        {
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

        private void ResetLetters() {
            foreach (Button btn in pnlLetters.Controls) {
                btn.Enabled = true;
            }
        }

        private void NewGame() {
            ClearSpMan();
            ResetLetters();
            hangmanGame.NewGame();
            lblSPGuessWord.Text = hangmanGame.GetWordMask();
            lblScore.Text = hangmanGame.GetScore().ToString();
        }

        private void UpdateGameState() {

            int wrong = hangmanGame.GetWrongCount();
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
                    break;
            }
            //for future
            if (hangmanGame.CheckGameOver()) {
                EndGame();
            }

            if (hangmanGame.CheckGuessed()) {
                hangmanGame.NewWord();
                ResetLetters();
                ClearSpMan();
            }
            lblSPGuessWord.Text = hangmanGame.GetWordMask();
            lblScore.Text = hangmanGame.GetScore().ToString();
        }

        private void EndGame() {
            //do scores thing
            lblSPREsScore.Text = hangmanGame.GetScore().ToString();
            lblSPResCorrect.Text = hangmanGame.GetWord();
            tabControlSinglePlayer.SelectedTab = tabPageSPResult;
        }
        /// <summary>
        /// Starts new game
        /// </summary>
        private void btnSPPlay_Click(object sender, EventArgs e)
        {
            Dificulty dificulty;
            if (rbSPDif.Checked) {
                dificulty = Dificulty.Eazy;
            } else if (rbSPDif2.Checked) {
                dificulty = Dificulty.Medium;
            } else {
                dificulty = Dificulty.Hard;
            }

            ListItem category = cbCategories.SelectedItem as ListItem;
            hangmanGame = new HangmanGame(tbSPName.Text, dificulty, category.Text, category.Value);

            NewGame();

            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerGame;
            //check later
        }
        private void btnSPBack_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabMenu;
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;

            hangmanGame.GuessLetter(btn.Text[0]);
            
            UpdateGameState();
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

        private void btnSPResBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerMenu;
        }

        private void btnSPResNew_Click(object sender, EventArgs e)
        {
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerGame;
            NewGame();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}