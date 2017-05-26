using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman {
    public partial class Hangman : Form {
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
            //SPRes
            lblSPRes1.BackColor = Color.Transparent;
            lblSPRes2.BackColor = Color.Transparent;
            lblSPREsScore.BackColor = Color.Transparent;
            lblSPGuessWord.BackColor = Color.Transparent;
            //Two Players
            lblSoon.BackColor = Color.Transparent;
            //High Scores
            lblHighScoreTitle.BackColor = Color.Transparent;
            lblHighScores.BackColor = Color.Transparent;
            //Help
            lblHelpTitle.BackColor = Color.Transparent;
            lblHelp.BackColor = Color.Transparent;
        }

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

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnTwoBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

        private void btnHighScoreBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

        private void btmHelpBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
        }

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

        private void btnSPBack_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabMenu;
        }

        private void clearSPMan() {
            pbHead.Visible = false;
            pbBody.Visible = false;
            pbLeftArm.Visible = false;
            pbRightArm.Visible = false;
            pbLeftLeg.Visible = false;
            pbRightLeg.Visible = false;
        }

        private void btnSPPlay_Click(object sender, EventArgs e)
        {
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerGame;
            clearSPMan();
            //TO:DO: finish
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            //TO:DO: finish
        }

        private void btnSPResBack_Click(object sender, EventArgs e) {
            tabControlMenu.SelectedTab = tabMenu;
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerMenu;
            //TO DO: finish
        }

        private void btnSPResNew_Click(object sender, EventArgs e)
        {
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerGame;
            clearSPMan();
            //TO:DO: finish
        }

        private void btnSPGameBack_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabMenu;
            tabControlSinglePlayer.SelectedTab = tabPageSinglePlayerMenu;
            //TO DO: finish
        }
    }
}