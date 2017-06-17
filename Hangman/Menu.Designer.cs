namespace Hangman
{
    sealed partial class Hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.pbMenuHangman = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.tabSinglePlayer = new System.Windows.Forms.TabPage();
            this.tabControlSinglePlayer = new System.Windows.Forms.TabControl();
            this.tabPageSinglePlayerMenu = new System.Windows.Forms.TabPage();
            this.btnSPBack = new System.Windows.Forms.Button();
            this.btmSPPlay = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblSPCat = new System.Windows.Forms.Label();
            this.rbSPDif3 = new System.Windows.Forms.RadioButton();
            this.rbSPDif2 = new System.Windows.Forms.RadioButton();
            this.rbSPDif = new System.Windows.Forms.RadioButton();
            this.lblSPDif = new System.Windows.Forms.Label();
            this.tbSPName = new System.Windows.Forms.TextBox();
            this.lblSPName = new System.Windows.Forms.Label();
            this.tabPageSinglePlayerGame = new System.Windows.Forms.TabPage();
            this.pnlSPHangman = new System.Windows.Forms.Panel();
            this.pbRightLeg = new System.Windows.Forms.PictureBox();
            this.pbLeftLeg = new System.Windows.Forms.PictureBox();
            this.pbRightArm = new System.Windows.Forms.PictureBox();
            this.pbLeftArm = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblSPGuessWord = new System.Windows.Forms.Label();
            this.btnSPGameNew = new System.Windows.Forms.Button();
            this.btnSPGameBack = new System.Windows.Forms.Button();
            this.pbWood = new System.Windows.Forms.PictureBox();
            this.tabPageSPResult = new System.Windows.Forms.TabPage();
            this.lblSPResCorrect = new System.Windows.Forms.Label();
            this.lblCorrectTitle = new System.Windows.Forms.Label();
            this.pbSPHanged = new System.Windows.Forms.PictureBox();
            this.lblSPREsScore = new System.Windows.Forms.Label();
            this.lblSPRes2 = new System.Windows.Forms.Label();
            this.btnSPResNew = new System.Windows.Forms.Button();
            this.btnSPResBack = new System.Windows.Forms.Button();
            this.lblSPRes1 = new System.Windows.Forms.Label();
            this.tabTwoPlayers = new System.Windows.Forms.TabPage();
            this.tabControlTwoPlayers = new System.Windows.Forms.TabControl();
            this.tabPageTPNames = new System.Windows.Forms.TabPage();
            this.btnTPNamesNext = new System.Windows.Forms.Button();
            this.tbTPPlayer2Name = new System.Windows.Forms.TextBox();
            this.tbTPPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.btnTPBack = new System.Windows.Forms.Button();
            this.tabPageTpWordSelect = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTPWSPlay = new System.Windows.Forms.Button();
            this.tbTPCurrentWord = new System.Windows.Forms.TextBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.btnTPWSBack = new System.Windows.Forms.Button();
            this.tabPageTPGame = new System.Windows.Forms.TabPage();
            this.lblTPGuesingText = new System.Windows.Forms.Label();
            this.lblTPGuessing = new System.Windows.Forms.Label();
            this.lblTPScore2 = new System.Windows.Forms.Label();
            this.lblTPPlayer2 = new System.Windows.Forms.Label();
            this.pnlTPHangman = new System.Windows.Forms.Panel();
            this.pbTPRightLeg = new System.Windows.Forms.PictureBox();
            this.pbTPLeftLeg = new System.Windows.Forms.PictureBox();
            this.pbTPRightArm = new System.Windows.Forms.PictureBox();
            this.pbTPLeftArm = new System.Windows.Forms.PictureBox();
            this.pbTPBody = new System.Windows.Forms.PictureBox();
            this.pbTPHead = new System.Windows.Forms.PictureBox();
            this.pnlTPLetters = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.lblTPScore1 = new System.Windows.Forms.Label();
            this.lblTPPlayer1 = new System.Windows.Forms.Label();
            this.lblTPGameWord = new System.Windows.Forms.Label();
            this.btnTPExit = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tabPageTPResult = new System.Windows.Forms.TabPage();
            this.lblTPPlayer2ScoreRes = new System.Windows.Forms.Label();
            this.lblTPPlayer2Res = new System.Windows.Forms.Label();
            this.lblTPPlayer1ScoreRes = new System.Windows.Forms.Label();
            this.lblTPPlayer1Res = new System.Windows.Forms.Label();
            this.lblTPCorrectWord = new System.Windows.Forms.Label();
            this.lblTPWordlbl = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnTpResCont = new System.Windows.Forms.Button();
            this.btnTpResExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHighScores = new System.Windows.Forms.TabPage();
            this.cbScoresDificulty = new System.Windows.Forms.ComboBox();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lblHighScoreTitle = new System.Windows.Forms.Label();
            this.btnHighScoreBack = new System.Windows.Forms.Button();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.btmHelpBack = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuHangman)).BeginInit();
            this.tabSinglePlayer.SuspendLayout();
            this.tabControlSinglePlayer.SuspendLayout();
            this.tabPageSinglePlayerMenu.SuspendLayout();
            this.tabPageSinglePlayerGame.SuspendLayout();
            this.pnlSPHangman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.pnlLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWood)).BeginInit();
            this.tabPageSPResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPHanged)).BeginInit();
            this.tabTwoPlayers.SuspendLayout();
            this.tabControlTwoPlayers.SuspendLayout();
            this.tabPageTPNames.SuspendLayout();
            this.tabPageTpWordSelect.SuspendLayout();
            this.tabPageTPGame.SuspendLayout();
            this.pnlTPHangman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPRightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPLeftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPRightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPLeftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPHead)).BeginInit();
            this.pnlTPLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabPageTPResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tabHighScores.SuspendLayout();
            this.tabHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabMenu);
            this.tabControlMenu.Controls.Add(this.tabSinglePlayer);
            this.tabControlMenu.Controls.Add(this.tabTwoPlayers);
            this.tabControlMenu.Controls.Add(this.tabHighScores);
            this.tabControlMenu.Controls.Add(this.tabHelp);
            this.tabControlMenu.Location = new System.Drawing.Point(-5, -5);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(795, 570);
            this.tabControlMenu.TabIndex = 6;
            // 
            // tabMenu
            // 
            this.tabMenu.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMenu.Controls.Add(this.pbMenuHangman);
            this.tabMenu.Controls.Add(this.lblTitle);
            this.tabMenu.Controls.Add(this.btnExit);
            this.tabMenu.Controls.Add(this.btnSinglePlayer);
            this.tabMenu.Controls.Add(this.btnHelp);
            this.tabMenu.Controls.Add(this.btnTwoPlayers);
            this.tabMenu.Controls.Add(this.btnHighScores);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(787, 544);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // pbMenuHangman
            // 
            this.pbMenuHangman.BackgroundImage = global::Hangman.Properties.Resources.Hangman;
            this.pbMenuHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMenuHangman.ErrorImage = null;
            this.pbMenuHangman.InitialImage = null;
            this.pbMenuHangman.Location = new System.Drawing.Point(374, 137);
            this.pbMenuHangman.Name = "pbMenuHangman";
            this.pbMenuHangman.Size = new System.Drawing.Size(380, 334);
            this.pbMenuHangman.TabIndex = 6;
            this.pbMenuHangman.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(99, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(570, 133);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Hangman";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Ivory;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(42, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.Ivory;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(42, 225);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(300, 50);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Ivory;
            this.btnHelp.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(42, 393);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(300, 50);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.BackColor = System.Drawing.Color.Ivory;
            this.btnTwoPlayers.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlayers.Location = new System.Drawing.Point(42, 281);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(300, 50);
            this.btnTwoPlayers.TabIndex = 1;
            this.btnTwoPlayers.Text = "Two Players";
            this.btnTwoPlayers.UseVisualStyleBackColor = false;
            this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.Ivory;
            this.btnHighScores.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(42, 337);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(300, 50);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // tabSinglePlayer
            // 
            this.tabSinglePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSinglePlayer.Controls.Add(this.tabControlSinglePlayer);
            this.tabSinglePlayer.Location = new System.Drawing.Point(4, 22);
            this.tabSinglePlayer.Name = "tabSinglePlayer";
            this.tabSinglePlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinglePlayer.Size = new System.Drawing.Size(787, 544);
            this.tabSinglePlayer.TabIndex = 1;
            this.tabSinglePlayer.Text = "Single Player";
            this.tabSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // tabControlSinglePlayer
            // 
            this.tabControlSinglePlayer.Controls.Add(this.tabPageSinglePlayerMenu);
            this.tabControlSinglePlayer.Controls.Add(this.tabPageSinglePlayerGame);
            this.tabControlSinglePlayer.Controls.Add(this.tabPageSPResult);
            this.tabControlSinglePlayer.Location = new System.Drawing.Point(-5, -5);
            this.tabControlSinglePlayer.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSinglePlayer.Name = "tabControlSinglePlayer";
            this.tabControlSinglePlayer.SelectedIndex = 0;
            this.tabControlSinglePlayer.Size = new System.Drawing.Size(795, 570);
            this.tabControlSinglePlayer.TabIndex = 0;
            // 
            // tabPageSinglePlayerMenu
            // 
            this.tabPageSinglePlayerMenu.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageSinglePlayerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSinglePlayerMenu.Controls.Add(this.btnSPBack);
            this.tabPageSinglePlayerMenu.Controls.Add(this.btmSPPlay);
            this.tabPageSinglePlayerMenu.Controls.Add(this.cbCategories);
            this.tabPageSinglePlayerMenu.Controls.Add(this.lblSPCat);
            this.tabPageSinglePlayerMenu.Controls.Add(this.rbSPDif3);
            this.tabPageSinglePlayerMenu.Controls.Add(this.rbSPDif2);
            this.tabPageSinglePlayerMenu.Controls.Add(this.rbSPDif);
            this.tabPageSinglePlayerMenu.Controls.Add(this.lblSPDif);
            this.tabPageSinglePlayerMenu.Controls.Add(this.tbSPName);
            this.tabPageSinglePlayerMenu.Controls.Add(this.lblSPName);
            this.tabPageSinglePlayerMenu.Location = new System.Drawing.Point(4, 22);
            this.tabPageSinglePlayerMenu.Name = "tabPageSinglePlayerMenu";
            this.tabPageSinglePlayerMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSinglePlayerMenu.Size = new System.Drawing.Size(787, 544);
            this.tabPageSinglePlayerMenu.TabIndex = 0;
            this.tabPageSinglePlayerMenu.Text = "Menu";
            this.tabPageSinglePlayerMenu.UseVisualStyleBackColor = true;
            // 
            // btnSPBack
            // 
            this.btnSPBack.BackColor = System.Drawing.Color.Ivory;
            this.btnSPBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPBack.Location = new System.Drawing.Point(103, 381);
            this.btnSPBack.Name = "btnSPBack";
            this.btnSPBack.Size = new System.Drawing.Size(221, 100);
            this.btnSPBack.TabIndex = 9;
            this.btnSPBack.Text = "Back";
            this.btnSPBack.UseVisualStyleBackColor = false;
            this.btnSPBack.Click += new System.EventHandler(this.btnSPBack_Click);
            // 
            // btmSPPlay
            // 
            this.btmSPPlay.BackColor = System.Drawing.Color.Ivory;
            this.btmSPPlay.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSPPlay.Location = new System.Drawing.Point(353, 381);
            this.btmSPPlay.Name = "btmSPPlay";
            this.btmSPPlay.Size = new System.Drawing.Size(221, 100);
            this.btmSPPlay.TabIndex = 8;
            this.btmSPPlay.Text = "Play";
            this.btmSPPlay.UseVisualStyleBackColor = false;
            this.btmSPPlay.Click += new System.EventHandler(this.btnSPPlay_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(433, 271);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(276, 52);
            this.cbCategories.TabIndex = 7;
            // 
            // lblSPCat
            // 
            this.lblSPCat.AutoSize = true;
            this.lblSPCat.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPCat.ForeColor = System.Drawing.Color.White;
            this.lblSPCat.Location = new System.Drawing.Point(41, 242);
            this.lblSPCat.Name = "lblSPCat";
            this.lblSPCat.Size = new System.Drawing.Size(386, 79);
            this.lblSPCat.TabIndex = 6;
            this.lblSPCat.Text = "Category:";
            // 
            // rbSPDif3
            // 
            this.rbSPDif3.AutoSize = true;
            this.rbSPDif3.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSPDif3.ForeColor = System.Drawing.Color.White;
            this.rbSPDif3.Location = new System.Drawing.Point(627, 191);
            this.rbSPDif3.Name = "rbSPDif3";
            this.rbSPDif3.Size = new System.Drawing.Size(136, 48);
            this.rbSPDif3.TabIndex = 5;
            this.rbSPDif3.Text = "Hard";
            this.rbSPDif3.UseVisualStyleBackColor = true;
            // 
            // rbSPDif2
            // 
            this.rbSPDif2.AutoSize = true;
            this.rbSPDif2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSPDif2.ForeColor = System.Drawing.Color.White;
            this.rbSPDif2.Location = new System.Drawing.Point(458, 191);
            this.rbSPDif2.Name = "rbSPDif2";
            this.rbSPDif2.Size = new System.Drawing.Size(178, 48);
            this.rbSPDif2.TabIndex = 4;
            this.rbSPDif2.Text = "Medium";
            this.rbSPDif2.UseVisualStyleBackColor = true;
            // 
            // rbSPDif
            // 
            this.rbSPDif.AutoSize = true;
            this.rbSPDif.Checked = true;
            this.rbSPDif.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSPDif.ForeColor = System.Drawing.Color.White;
            this.rbSPDif.Location = new System.Drawing.Point(341, 191);
            this.rbSPDif.Name = "rbSPDif";
            this.rbSPDif.Size = new System.Drawing.Size(126, 48);
            this.rbSPDif.TabIndex = 3;
            this.rbSPDif.TabStop = true;
            this.rbSPDif.Text = "Eazy";
            this.rbSPDif.UseVisualStyleBackColor = true;
            // 
            // lblSPDif
            // 
            this.lblSPDif.AutoSize = true;
            this.lblSPDif.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPDif.ForeColor = System.Drawing.Color.White;
            this.lblSPDif.Location = new System.Drawing.Point(33, 179);
            this.lblSPDif.Name = "lblSPDif";
            this.lblSPDif.Size = new System.Drawing.Size(317, 60);
            this.lblSPDif.TabIndex = 2;
            this.lblSPDif.Text = "Difficulty:";
            // 
            // tbSPName
            // 
            this.tbSPName.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSPName.Location = new System.Drawing.Point(341, 125);
            this.tbSPName.Name = "tbSPName";
            this.tbSPName.Size = new System.Drawing.Size(305, 51);
            this.tbSPName.TabIndex = 0;
            this.tbSPName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSPName_Validating);
            // 
            // lblSPName
            // 
            this.lblSPName.AutoSize = true;
            this.lblSPName.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPName.ForeColor = System.Drawing.Color.White;
            this.lblSPName.Location = new System.Drawing.Point(107, 100);
            this.lblSPName.Name = "lblSPName";
            this.lblSPName.Size = new System.Drawing.Size(228, 79);
            this.lblSPName.TabIndex = 0;
            this.lblSPName.Text = "Name:";
            // 
            // tabPageSinglePlayerGame
            // 
            this.tabPageSinglePlayerGame.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageSinglePlayerGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSinglePlayerGame.Controls.Add(this.pnlSPHangman);
            this.tabPageSinglePlayerGame.Controls.Add(this.pnlLetters);
            this.tabPageSinglePlayerGame.Controls.Add(this.lblScore);
            this.tabPageSinglePlayerGame.Controls.Add(this.lblScore2);
            this.tabPageSinglePlayerGame.Controls.Add(this.lblSPGuessWord);
            this.tabPageSinglePlayerGame.Controls.Add(this.btnSPGameNew);
            this.tabPageSinglePlayerGame.Controls.Add(this.btnSPGameBack);
            this.tabPageSinglePlayerGame.Controls.Add(this.pbWood);
            this.tabPageSinglePlayerGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageSinglePlayerGame.Name = "tabPageSinglePlayerGame";
            this.tabPageSinglePlayerGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSinglePlayerGame.Size = new System.Drawing.Size(787, 544);
            this.tabPageSinglePlayerGame.TabIndex = 1;
            this.tabPageSinglePlayerGame.Text = "Game";
            this.tabPageSinglePlayerGame.UseVisualStyleBackColor = true;
            // 
            // pnlSPHangman
            // 
            this.pnlSPHangman.Controls.Add(this.pbRightLeg);
            this.pnlSPHangman.Controls.Add(this.pbLeftLeg);
            this.pnlSPHangman.Controls.Add(this.pbRightArm);
            this.pnlSPHangman.Controls.Add(this.pbLeftArm);
            this.pnlSPHangman.Controls.Add(this.pbBody);
            this.pnlSPHangman.Controls.Add(this.pbHead);
            this.pnlSPHangman.Location = new System.Drawing.Point(166, 118);
            this.pnlSPHangman.Name = "pnlSPHangman";
            this.pnlSPHangman.Size = new System.Drawing.Size(156, 223);
            this.pnlSPHangman.TabIndex = 43;
            // 
            // pbRightLeg
            // 
            this.pbRightLeg.Image = ((System.Drawing.Image)(resources.GetObject("pbRightLeg.Image")));
            this.pbRightLeg.Location = new System.Drawing.Point(81, 166);
            this.pbRightLeg.Name = "pbRightLeg";
            this.pbRightLeg.Size = new System.Drawing.Size(53, 50);
            this.pbRightLeg.TabIndex = 12;
            this.pbRightLeg.TabStop = false;
            // 
            // pbLeftLeg
            // 
            this.pbLeftLeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftLeg.Image")));
            this.pbLeftLeg.Location = new System.Drawing.Point(19, 167);
            this.pbLeftLeg.Name = "pbLeftLeg";
            this.pbLeftLeg.Size = new System.Drawing.Size(54, 50);
            this.pbLeftLeg.TabIndex = 11;
            this.pbLeftLeg.TabStop = false;
            // 
            // pbRightArm
            // 
            this.pbRightArm.Image = global::Hangman.Properties.Resources.rightArm;
            this.pbRightArm.Location = new System.Drawing.Point(81, 74);
            this.pbRightArm.Name = "pbRightArm";
            this.pbRightArm.Size = new System.Drawing.Size(61, 50);
            this.pbRightArm.TabIndex = 10;
            this.pbRightArm.TabStop = false;
            // 
            // pbLeftArm
            // 
            this.pbLeftArm.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftArm.Image")));
            this.pbLeftArm.Location = new System.Drawing.Point(17, 75);
            this.pbLeftArm.Name = "pbLeftArm";
            this.pbLeftArm.Size = new System.Drawing.Size(54, 50);
            this.pbLeftArm.TabIndex = 9;
            this.pbLeftArm.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.Image = ((System.Drawing.Image)(resources.GetObject("pbBody.Image")));
            this.pbBody.Location = new System.Drawing.Point(68, 64);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(19, 120);
            this.pbBody.TabIndex = 8;
            this.pbBody.TabStop = false;
            // 
            // pbHead
            // 
            this.pbHead.Image = ((System.Drawing.Image)(resources.GetObject("pbHead.Image")));
            this.pbHead.Location = new System.Drawing.Point(42, 0);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(69, 69);
            this.pbHead.TabIndex = 7;
            this.pbHead.TabStop = false;
            // 
            // pnlLetters
            // 
            this.pnlLetters.Controls.Add(this.button25);
            this.pnlLetters.Controls.Add(this.button7);
            this.pnlLetters.Controls.Add(this.button26);
            this.pnlLetters.Controls.Add(this.button4);
            this.pnlLetters.Controls.Add(this.button27);
            this.pnlLetters.Controls.Add(this.button5);
            this.pnlLetters.Controls.Add(this.button28);
            this.pnlLetters.Controls.Add(this.button6);
            this.pnlLetters.Controls.Add(this.button29);
            this.pnlLetters.Controls.Add(this.button8);
            this.pnlLetters.Controls.Add(this.button30);
            this.pnlLetters.Controls.Add(this.button9);
            this.pnlLetters.Controls.Add(this.button31);
            this.pnlLetters.Controls.Add(this.button10);
            this.pnlLetters.Controls.Add(this.button15);
            this.pnlLetters.Controls.Add(this.button11);
            this.pnlLetters.Controls.Add(this.button16);
            this.pnlLetters.Controls.Add(this.button12);
            this.pnlLetters.Controls.Add(this.button17);
            this.pnlLetters.Controls.Add(this.button13);
            this.pnlLetters.Controls.Add(this.button18);
            this.pnlLetters.Controls.Add(this.button23);
            this.pnlLetters.Controls.Add(this.button19);
            this.pnlLetters.Controls.Add(this.button22);
            this.pnlLetters.Controls.Add(this.button20);
            this.pnlLetters.Controls.Add(this.button21);
            this.pnlLetters.Location = new System.Drawing.Point(328, 261);
            this.pnlLetters.Name = "pnlLetters";
            this.pnlLetters.Size = new System.Drawing.Size(403, 136);
            this.pnlLetters.TabIndex = 42;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Ivory;
            this.button25.CausesValidation = false;
            this.button25.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(275, 95);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(35, 40);
            this.button25.TabIndex = 68;
            this.button25.Text = "M";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Ivory;
            this.button7.CausesValidation = false;
            this.button7.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(120, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 40);
            this.button7.TabIndex = 46;
            this.button7.Text = "R";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Ivory;
            this.button26.CausesValidation = false;
            this.button26.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(234, 95);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(35, 40);
            this.button26.TabIndex = 67;
            this.button26.Text = "N";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.CausesValidation = false;
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(-1, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 40);
            this.button4.TabIndex = 43;
            this.button4.Text = "Q";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Ivory;
            this.button27.CausesValidation = false;
            this.button27.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(193, 95);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(35, 40);
            this.button27.TabIndex = 66;
            this.button27.Text = "B";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Ivory;
            this.button5.CausesValidation = false;
            this.button5.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(40, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 40);
            this.button5.TabIndex = 44;
            this.button5.Text = "W";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Ivory;
            this.button28.CausesValidation = false;
            this.button28.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(152, 95);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(35, 40);
            this.button28.TabIndex = 65;
            this.button28.Text = "V";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Ivory;
            this.button6.CausesValidation = false;
            this.button6.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(81, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 40);
            this.button6.TabIndex = 45;
            this.button6.Text = "E";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Ivory;
            this.button29.CausesValidation = false;
            this.button29.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(113, 95);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(35, 40);
            this.button29.TabIndex = 64;
            this.button29.Text = "C";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Ivory;
            this.button8.CausesValidation = false;
            this.button8.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(161, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 40);
            this.button8.TabIndex = 47;
            this.button8.Text = "T";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Ivory;
            this.button30.CausesValidation = false;
            this.button30.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(72, 95);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(35, 40);
            this.button30.TabIndex = 63;
            this.button30.Text = "X";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Ivory;
            this.button9.CausesValidation = false;
            this.button9.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(202, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 40);
            this.button9.TabIndex = 48;
            this.button9.Text = "Y";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Ivory;
            this.button31.CausesValidation = false;
            this.button31.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(31, 95);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(35, 40);
            this.button31.TabIndex = 62;
            this.button31.Text = "Z";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Ivory;
            this.button10.CausesValidation = false;
            this.button10.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(243, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 40);
            this.button10.TabIndex = 49;
            this.button10.Text = "U";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Ivory;
            this.button15.CausesValidation = false;
            this.button15.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(337, 49);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 40);
            this.button15.TabIndex = 61;
            this.button15.Text = "L";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Ivory;
            this.button11.CausesValidation = false;
            this.button11.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(284, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 40);
            this.button11.TabIndex = 50;
            this.button11.Text = "I";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Ivory;
            this.button16.CausesValidation = false;
            this.button16.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(296, 49);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 40);
            this.button16.TabIndex = 60;
            this.button16.Text = "K";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Ivory;
            this.button12.CausesValidation = false;
            this.button12.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(325, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 40);
            this.button12.TabIndex = 51;
            this.button12.Text = "O";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Ivory;
            this.button17.CausesValidation = false;
            this.button17.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(255, 49);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 40);
            this.button17.TabIndex = 59;
            this.button17.Text = "J";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Ivory;
            this.button13.CausesValidation = false;
            this.button13.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(366, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 40);
            this.button13.TabIndex = 52;
            this.button13.Text = "P";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Ivory;
            this.button18.CausesValidation = false;
            this.button18.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(214, 49);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(35, 40);
            this.button18.TabIndex = 58;
            this.button18.Text = "H";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Ivory;
            this.button23.CausesValidation = false;
            this.button23.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(11, 49);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(35, 40);
            this.button23.TabIndex = 53;
            this.button23.Text = "A";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Ivory;
            this.button19.CausesValidation = false;
            this.button19.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(173, 49);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 40);
            this.button19.TabIndex = 57;
            this.button19.Text = "G";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Ivory;
            this.button22.CausesValidation = false;
            this.button22.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(52, 49);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(35, 40);
            this.button22.TabIndex = 54;
            this.button22.Text = "S";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Ivory;
            this.button20.CausesValidation = false;
            this.button20.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(132, 49);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 40);
            this.button20.TabIndex = 56;
            this.button20.Text = "F";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.Letter_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Ivory;
            this.button21.CausesValidation = false;
            this.button21.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(93, 49);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 40);
            this.button21.TabIndex = 55;
            this.button21.Text = "D";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.Letter_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(659, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 79);
            this.lblScore.TabIndex = 41;
            this.lblScore.Text = "0";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.White;
            this.lblScore2.Location = new System.Drawing.Point(421, 39);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(250, 79);
            this.lblScore2.TabIndex = 40;
            this.lblScore2.Text = "Score:";
            // 
            // lblSPGuessWord
            // 
            this.lblSPGuessWord.AutoSize = true;
            this.lblSPGuessWord.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPGuessWord.ForeColor = System.Drawing.Color.White;
            this.lblSPGuessWord.Location = new System.Drawing.Point(314, 169);
            this.lblSPGuessWord.Name = "lblSPGuessWord";
            this.lblSPGuessWord.Size = new System.Drawing.Size(426, 79);
            this.lblSPGuessWord.TabIndex = 39;
            this.lblSPGuessWord.Text = "_ _ _ _ _ _ _ _ _";
            // 
            // btnSPGameNew
            // 
            this.btnSPGameNew.BackColor = System.Drawing.Color.Ivory;
            this.btnSPGameNew.CausesValidation = false;
            this.btnSPGameNew.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPGameNew.Location = new System.Drawing.Point(234, 451);
            this.btnSPGameNew.Name = "btnSPGameNew";
            this.btnSPGameNew.Size = new System.Drawing.Size(171, 50);
            this.btnSPGameNew.TabIndex = 12;
            this.btnSPGameNew.Text = "New Game";
            this.btnSPGameNew.UseVisualStyleBackColor = false;
            this.btnSPGameNew.Click += new System.EventHandler(this.btnSPGameNew_Click);
            // 
            // btnSPGameBack
            // 
            this.btnSPGameBack.BackColor = System.Drawing.Color.Ivory;
            this.btnSPGameBack.CausesValidation = false;
            this.btnSPGameBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPGameBack.Location = new System.Drawing.Point(56, 451);
            this.btnSPGameBack.Name = "btnSPGameBack";
            this.btnSPGameBack.Size = new System.Drawing.Size(150, 50);
            this.btnSPGameBack.TabIndex = 10;
            this.btnSPGameBack.Text = "Back";
            this.btnSPGameBack.UseVisualStyleBackColor = false;
            this.btnSPGameBack.Click += new System.EventHandler(this.btnSPGameBack_Click);
            // 
            // pbWood
            // 
            this.pbWood.Image = ((System.Drawing.Image)(resources.GetObject("pbWood.Image")));
            this.pbWood.Location = new System.Drawing.Point(30, 56);
            this.pbWood.Name = "pbWood";
            this.pbWood.Size = new System.Drawing.Size(257, 329);
            this.pbWood.TabIndex = 0;
            this.pbWood.TabStop = false;
            // 
            // tabPageSPResult
            // 
            this.tabPageSPResult.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageSPResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSPResult.Controls.Add(this.lblSPResCorrect);
            this.tabPageSPResult.Controls.Add(this.lblCorrectTitle);
            this.tabPageSPResult.Controls.Add(this.pbSPHanged);
            this.tabPageSPResult.Controls.Add(this.lblSPREsScore);
            this.tabPageSPResult.Controls.Add(this.lblSPRes2);
            this.tabPageSPResult.Controls.Add(this.btnSPResNew);
            this.tabPageSPResult.Controls.Add(this.btnSPResBack);
            this.tabPageSPResult.Controls.Add(this.lblSPRes1);
            this.tabPageSPResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageSPResult.Name = "tabPageSPResult";
            this.tabPageSPResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSPResult.Size = new System.Drawing.Size(787, 544);
            this.tabPageSPResult.TabIndex = 2;
            this.tabPageSPResult.Text = "Result";
            this.tabPageSPResult.UseVisualStyleBackColor = true;
            // 
            // lblSPResCorrect
            // 
            this.lblSPResCorrect.AutoSize = true;
            this.lblSPResCorrect.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPResCorrect.ForeColor = System.Drawing.Color.White;
            this.lblSPResCorrect.Location = new System.Drawing.Point(465, 237);
            this.lblSPResCorrect.Name = "lblSPResCorrect";
            this.lblSPResCorrect.Size = new System.Drawing.Size(135, 46);
            this.lblSPResCorrect.TabIndex = 50;
            this.lblSPResCorrect.Text = "word";
            // 
            // lblCorrectTitle
            // 
            this.lblCorrectTitle.AutoSize = true;
            this.lblCorrectTitle.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectTitle.ForeColor = System.Drawing.Color.White;
            this.lblCorrectTitle.Location = new System.Drawing.Point(322, 191);
            this.lblCorrectTitle.Name = "lblCorrectTitle";
            this.lblCorrectTitle.Size = new System.Drawing.Size(406, 46);
            this.lblCorrectTitle.TabIndex = 47;
            this.lblCorrectTitle.Text = "Correct word was:";
            // 
            // pbSPHanged
            // 
            this.pbSPHanged.BackgroundImage = global::Hangman.Properties.Resources.Hangman;
            this.pbSPHanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSPHanged.ErrorImage = null;
            this.pbSPHanged.InitialImage = null;
            this.pbSPHanged.Location = new System.Drawing.Point(-15, 54);
            this.pbSPHanged.Name = "pbSPHanged";
            this.pbSPHanged.Size = new System.Drawing.Size(380, 334);
            this.pbSPHanged.TabIndex = 46;
            this.pbSPHanged.TabStop = false;
            // 
            // lblSPREsScore
            // 
            this.lblSPREsScore.AutoSize = true;
            this.lblSPREsScore.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPREsScore.ForeColor = System.Drawing.Color.White;
            this.lblSPREsScore.Location = new System.Drawing.Point(587, 309);
            this.lblSPREsScore.Name = "lblSPREsScore";
            this.lblSPREsScore.Size = new System.Drawing.Size(72, 79);
            this.lblSPREsScore.TabIndex = 45;
            this.lblSPREsScore.Text = "0";
            // 
            // lblSPRes2
            // 
            this.lblSPRes2.AutoSize = true;
            this.lblSPRes2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPRes2.ForeColor = System.Drawing.Color.White;
            this.lblSPRes2.Location = new System.Drawing.Point(350, 309);
            this.lblSPRes2.Name = "lblSPRes2";
            this.lblSPRes2.Size = new System.Drawing.Size(250, 79);
            this.lblSPRes2.TabIndex = 44;
            this.lblSPRes2.Text = "Score:";
            // 
            // btnSPResNew
            // 
            this.btnSPResNew.BackColor = System.Drawing.Color.Ivory;
            this.btnSPResNew.CausesValidation = false;
            this.btnSPResNew.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPResNew.Location = new System.Drawing.Point(349, 424);
            this.btnSPResNew.Name = "btnSPResNew";
            this.btnSPResNew.Size = new System.Drawing.Size(208, 50);
            this.btnSPResNew.TabIndex = 43;
            this.btnSPResNew.Text = "New Game";
            this.btnSPResNew.UseVisualStyleBackColor = false;
            this.btnSPResNew.Click += new System.EventHandler(this.btnSPResNew_Click);
            // 
            // btnSPResBack
            // 
            this.btnSPResBack.BackColor = System.Drawing.Color.Ivory;
            this.btnSPResBack.CausesValidation = false;
            this.btnSPResBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPResBack.Location = new System.Drawing.Point(178, 424);
            this.btnSPResBack.Name = "btnSPResBack";
            this.btnSPResBack.Size = new System.Drawing.Size(150, 50);
            this.btnSPResBack.TabIndex = 42;
            this.btnSPResBack.Text = "Back";
            this.btnSPResBack.UseVisualStyleBackColor = false;
            this.btnSPResBack.Click += new System.EventHandler(this.btnSPResBack_Click);
            // 
            // lblSPRes1
            // 
            this.lblSPRes1.AutoSize = true;
            this.lblSPRes1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPRes1.ForeColor = System.Drawing.Color.White;
            this.lblSPRes1.Location = new System.Drawing.Point(358, 87);
            this.lblSPRes1.Name = "lblSPRes1";
            this.lblSPRes1.Size = new System.Drawing.Size(332, 79);
            this.lblSPRes1.TabIndex = 41;
            this.lblSPRes1.Text = "You Lost";
            // 
            // tabTwoPlayers
            // 
            this.tabTwoPlayers.BackColor = System.Drawing.Color.Transparent;
            this.tabTwoPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabTwoPlayers.Controls.Add(this.tabControlTwoPlayers);
            this.tabTwoPlayers.Controls.Add(this.label1);
            this.tabTwoPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabTwoPlayers.Name = "tabTwoPlayers";
            this.tabTwoPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwoPlayers.Size = new System.Drawing.Size(787, 544);
            this.tabTwoPlayers.TabIndex = 2;
            this.tabTwoPlayers.Text = "Two Players";
            // 
            // tabControlTwoPlayers
            // 
            this.tabControlTwoPlayers.Controls.Add(this.tabPageTPNames);
            this.tabControlTwoPlayers.Controls.Add(this.tabPageTpWordSelect);
            this.tabControlTwoPlayers.Controls.Add(this.tabPageTPGame);
            this.tabControlTwoPlayers.Controls.Add(this.tabPageTPResult);
            this.tabControlTwoPlayers.Location = new System.Drawing.Point(-5, -5);
            this.tabControlTwoPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlTwoPlayers.Name = "tabControlTwoPlayers";
            this.tabControlTwoPlayers.SelectedIndex = 0;
            this.tabControlTwoPlayers.Size = new System.Drawing.Size(795, 570);
            this.tabControlTwoPlayers.TabIndex = 4;
            // 
            // tabPageTPNames
            // 
            this.tabPageTPNames.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageTPNames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTPNames.Controls.Add(this.btnTPNamesNext);
            this.tabPageTPNames.Controls.Add(this.tbTPPlayer2Name);
            this.tabPageTPNames.Controls.Add(this.tbTPPlayer1Name);
            this.tabPageTPNames.Controls.Add(this.lblPlayer2Name);
            this.tabPageTPNames.Controls.Add(this.lblPlayer1Name);
            this.tabPageTPNames.Controls.Add(this.btnTPBack);
            this.tabPageTPNames.Location = new System.Drawing.Point(4, 22);
            this.tabPageTPNames.Name = "tabPageTPNames";
            this.tabPageTPNames.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTPNames.Size = new System.Drawing.Size(787, 544);
            this.tabPageTPNames.TabIndex = 0;
            this.tabPageTPNames.Text = "Names";
            this.tabPageTPNames.UseVisualStyleBackColor = true;
            // 
            // btnTPNamesNext
            // 
            this.btnTPNamesNext.BackColor = System.Drawing.Color.Ivory;
            this.btnTPNamesNext.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPNamesNext.Location = new System.Drawing.Point(334, 442);
            this.btnTPNamesNext.Name = "btnTPNamesNext";
            this.btnTPNamesNext.Size = new System.Drawing.Size(267, 50);
            this.btnTPNamesNext.TabIndex = 52;
            this.btnTPNamesNext.Text = "Next";
            this.btnTPNamesNext.UseVisualStyleBackColor = false;
            this.btnTPNamesNext.Click += new System.EventHandler(this.btnTPNamesNext_Click);
            // 
            // tbTPPlayer2Name
            // 
            this.tbTPPlayer2Name.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTPPlayer2Name.Location = new System.Drawing.Point(61, 303);
            this.tbTPPlayer2Name.Name = "tbTPPlayer2Name";
            this.tbTPPlayer2Name.Size = new System.Drawing.Size(496, 51);
            this.tbTPPlayer2Name.TabIndex = 51;
            // 
            // tbTPPlayer1Name
            // 
            this.tbTPPlayer1Name.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTPPlayer1Name.Location = new System.Drawing.Point(61, 146);
            this.tbTPPlayer1Name.Name = "tbTPPlayer1Name";
            this.tbTPPlayer1Name.Size = new System.Drawing.Size(496, 51);
            this.tbTPPlayer1Name.TabIndex = 50;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Name.Location = new System.Drawing.Point(47, 221);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(512, 79);
            this.lblPlayer2Name.TabIndex = 49;
            this.lblPlayer2Name.Text = "Player2 Name:";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Name.Location = new System.Drawing.Point(47, 64);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(510, 79);
            this.lblPlayer1Name.TabIndex = 48;
            this.lblPlayer1Name.Text = "Player1 Name:";
            // 
            // btnTPBack
            // 
            this.btnTPBack.BackColor = System.Drawing.Color.Ivory;
            this.btnTPBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPBack.Location = new System.Drawing.Point(61, 442);
            this.btnTPBack.Name = "btnTPBack";
            this.btnTPBack.Size = new System.Drawing.Size(267, 50);
            this.btnTPBack.TabIndex = 47;
            this.btnTPBack.Text = "Back";
            this.btnTPBack.UseVisualStyleBackColor = false;
            this.btnTPBack.Click += new System.EventHandler(this.btnTPBack_Click);
            // 
            // tabPageTpWordSelect
            // 
            this.tabPageTpWordSelect.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageTpWordSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTpWordSelect.Controls.Add(this.label3);
            this.tabPageTpWordSelect.Controls.Add(this.btnTPWSPlay);
            this.tabPageTpWordSelect.Controls.Add(this.tbTPCurrentWord);
            this.tabPageTpWordSelect.Controls.Add(this.lblCurrentPlayer);
            this.tabPageTpWordSelect.Controls.Add(this.btnTPWSBack);
            this.tabPageTpWordSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageTpWordSelect.Name = "tabPageTpWordSelect";
            this.tabPageTpWordSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTpWordSelect.Size = new System.Drawing.Size(787, 544);
            this.tabPageTpWordSelect.TabIndex = 1;
            this.tabPageTpWordSelect.Text = "Word Select";
            this.tabPageTpWordSelect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 79);
            this.label3.TabIndex = 57;
            this.label3.Text = "enter a word:";
            // 
            // btnTPWSPlay
            // 
            this.btnTPWSPlay.BackColor = System.Drawing.Color.Ivory;
            this.btnTPWSPlay.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPWSPlay.Location = new System.Drawing.Point(316, 406);
            this.btnTPWSPlay.Name = "btnTPWSPlay";
            this.btnTPWSPlay.Size = new System.Drawing.Size(267, 50);
            this.btnTPWSPlay.TabIndex = 56;
            this.btnTPWSPlay.Text = "Play";
            this.btnTPWSPlay.UseVisualStyleBackColor = false;
            this.btnTPWSPlay.Click += new System.EventHandler(this.btnTPWSPlay_Click);
            // 
            // tbTPCurrentWord
            // 
            this.tbTPCurrentWord.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTPCurrentWord.Location = new System.Drawing.Point(130, 283);
            this.tbTPCurrentWord.Name = "tbTPCurrentWord";
            this.tbTPCurrentWord.Size = new System.Drawing.Size(496, 51);
            this.tbTPCurrentWord.TabIndex = 55;
            this.tbTPCurrentWord.UseSystemPasswordChar = true;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(227, 74);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(276, 79);
            this.lblCurrentPlayer.TabIndex = 54;
            this.lblCurrentPlayer.Text = "Player";
            this.lblCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTPWSBack
            // 
            this.btnTPWSBack.BackColor = System.Drawing.Color.Ivory;
            this.btnTPWSBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPWSBack.Location = new System.Drawing.Point(43, 406);
            this.btnTPWSBack.Name = "btnTPWSBack";
            this.btnTPWSBack.Size = new System.Drawing.Size(267, 50);
            this.btnTPWSBack.TabIndex = 53;
            this.btnTPWSBack.Text = "Back";
            this.btnTPWSBack.UseVisualStyleBackColor = false;
            this.btnTPWSBack.Click += new System.EventHandler(this.btnTPWSBack_Click);
            // 
            // tabPageTPGame
            // 
            this.tabPageTPGame.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageTPGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTPGame.Controls.Add(this.lblTPGuesingText);
            this.tabPageTPGame.Controls.Add(this.lblTPGuessing);
            this.tabPageTPGame.Controls.Add(this.lblTPScore2);
            this.tabPageTPGame.Controls.Add(this.lblTPPlayer2);
            this.tabPageTPGame.Controls.Add(this.pnlTPHangman);
            this.tabPageTPGame.Controls.Add(this.pnlTPLetters);
            this.tabPageTPGame.Controls.Add(this.lblTPScore1);
            this.tabPageTPGame.Controls.Add(this.lblTPPlayer1);
            this.tabPageTPGame.Controls.Add(this.lblTPGameWord);
            this.tabPageTPGame.Controls.Add(this.btnTPExit);
            this.tabPageTPGame.Controls.Add(this.pictureBox7);
            this.tabPageTPGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageTPGame.Name = "tabPageTPGame";
            this.tabPageTPGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTPGame.Size = new System.Drawing.Size(787, 544);
            this.tabPageTPGame.TabIndex = 2;
            this.tabPageTPGame.Text = "Game";
            this.tabPageTPGame.UseVisualStyleBackColor = true;
            // 
            // lblTPGuesingText
            // 
            this.lblTPGuesingText.AutoSize = true;
            this.lblTPGuesingText.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPGuesingText.ForeColor = System.Drawing.Color.White;
            this.lblTPGuesingText.Location = new System.Drawing.Point(306, 448);
            this.lblTPGuesingText.Name = "lblTPGuesingText";
            this.lblTPGuesingText.Size = new System.Drawing.Size(232, 46);
            this.lblTPGuesingText.TabIndex = 55;
            this.lblTPGuesingText.Text = "is guessing";
            // 
            // lblTPGuessing
            // 
            this.lblTPGuessing.AutoSize = true;
            this.lblTPGuessing.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPGuessing.ForeColor = System.Drawing.Color.White;
            this.lblTPGuessing.Location = new System.Drawing.Point(118, 448);
            this.lblTPGuessing.Name = "lblTPGuessing";
            this.lblTPGuessing.Size = new System.Drawing.Size(192, 46);
            this.lblTPGuessing.TabIndex = 54;
            this.lblTPGuessing.Text = "Guessing";
            this.lblTPGuessing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTPScore2
            // 
            this.lblTPScore2.AutoSize = true;
            this.lblTPScore2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPScore2.ForeColor = System.Drawing.Color.White;
            this.lblTPScore2.Location = new System.Drawing.Point(653, 117);
            this.lblTPScore2.Name = "lblTPScore2";
            this.lblTPScore2.Size = new System.Drawing.Size(72, 79);
            this.lblTPScore2.TabIndex = 53;
            this.lblTPScore2.Text = "0";
            // 
            // lblTPPlayer2
            // 
            this.lblTPPlayer2.AutoSize = true;
            this.lblTPPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayer2.Location = new System.Drawing.Point(334, 117);
            this.lblTPPlayer2.Name = "lblTPPlayer2";
            this.lblTPPlayer2.Size = new System.Drawing.Size(327, 79);
            this.lblTPPlayer2.TabIndex = 52;
            this.lblTPPlayer2.Text = "Player2:";
            // 
            // pnlTPHangman
            // 
            this.pnlTPHangman.Controls.Add(this.pbTPRightLeg);
            this.pnlTPHangman.Controls.Add(this.pbTPLeftLeg);
            this.pnlTPHangman.Controls.Add(this.pbTPRightArm);
            this.pnlTPHangman.Controls.Add(this.pbTPLeftArm);
            this.pnlTPHangman.Controls.Add(this.pbTPBody);
            this.pnlTPHangman.Controls.Add(this.pbTPHead);
            this.pnlTPHangman.Location = new System.Drawing.Point(168, 117);
            this.pnlTPHangman.Name = "pnlTPHangman";
            this.pnlTPHangman.Size = new System.Drawing.Size(156, 223);
            this.pnlTPHangman.TabIndex = 51;
            // 
            // pbTPRightLeg
            // 
            this.pbTPRightLeg.Image = ((System.Drawing.Image)(resources.GetObject("pbTPRightLeg.Image")));
            this.pbTPRightLeg.Location = new System.Drawing.Point(81, 166);
            this.pbTPRightLeg.Name = "pbTPRightLeg";
            this.pbTPRightLeg.Size = new System.Drawing.Size(53, 50);
            this.pbTPRightLeg.TabIndex = 12;
            this.pbTPRightLeg.TabStop = false;
            // 
            // pbTPLeftLeg
            // 
            this.pbTPLeftLeg.Image = ((System.Drawing.Image)(resources.GetObject("pbTPLeftLeg.Image")));
            this.pbTPLeftLeg.Location = new System.Drawing.Point(19, 167);
            this.pbTPLeftLeg.Name = "pbTPLeftLeg";
            this.pbTPLeftLeg.Size = new System.Drawing.Size(54, 50);
            this.pbTPLeftLeg.TabIndex = 11;
            this.pbTPLeftLeg.TabStop = false;
            // 
            // pbTPRightArm
            // 
            this.pbTPRightArm.Image = global::Hangman.Properties.Resources.rightArm;
            this.pbTPRightArm.Location = new System.Drawing.Point(81, 74);
            this.pbTPRightArm.Name = "pbTPRightArm";
            this.pbTPRightArm.Size = new System.Drawing.Size(61, 50);
            this.pbTPRightArm.TabIndex = 10;
            this.pbTPRightArm.TabStop = false;
            // 
            // pbTPLeftArm
            // 
            this.pbTPLeftArm.Image = ((System.Drawing.Image)(resources.GetObject("pbTPLeftArm.Image")));
            this.pbTPLeftArm.Location = new System.Drawing.Point(17, 75);
            this.pbTPLeftArm.Name = "pbTPLeftArm";
            this.pbTPLeftArm.Size = new System.Drawing.Size(54, 50);
            this.pbTPLeftArm.TabIndex = 9;
            this.pbTPLeftArm.TabStop = false;
            // 
            // pbTPBody
            // 
            this.pbTPBody.Image = ((System.Drawing.Image)(resources.GetObject("pbTPBody.Image")));
            this.pbTPBody.Location = new System.Drawing.Point(68, 64);
            this.pbTPBody.Name = "pbTPBody";
            this.pbTPBody.Size = new System.Drawing.Size(19, 120);
            this.pbTPBody.TabIndex = 8;
            this.pbTPBody.TabStop = false;
            // 
            // pbTPHead
            // 
            this.pbTPHead.Image = ((System.Drawing.Image)(resources.GetObject("pbTPHead.Image")));
            this.pbTPHead.Location = new System.Drawing.Point(42, 0);
            this.pbTPHead.Name = "pbTPHead";
            this.pbTPHead.Size = new System.Drawing.Size(69, 69);
            this.pbTPHead.TabIndex = 7;
            this.pbTPHead.TabStop = false;
            // 
            // pnlTPLetters
            // 
            this.pnlTPLetters.Controls.Add(this.button1);
            this.pnlTPLetters.Controls.Add(this.button2);
            this.pnlTPLetters.Controls.Add(this.button3);
            this.pnlTPLetters.Controls.Add(this.button14);
            this.pnlTPLetters.Controls.Add(this.button24);
            this.pnlTPLetters.Controls.Add(this.button32);
            this.pnlTPLetters.Controls.Add(this.button33);
            this.pnlTPLetters.Controls.Add(this.button34);
            this.pnlTPLetters.Controls.Add(this.button35);
            this.pnlTPLetters.Controls.Add(this.button36);
            this.pnlTPLetters.Controls.Add(this.button37);
            this.pnlTPLetters.Controls.Add(this.button38);
            this.pnlTPLetters.Controls.Add(this.button39);
            this.pnlTPLetters.Controls.Add(this.button40);
            this.pnlTPLetters.Controls.Add(this.button41);
            this.pnlTPLetters.Controls.Add(this.button42);
            this.pnlTPLetters.Controls.Add(this.button43);
            this.pnlTPLetters.Controls.Add(this.button44);
            this.pnlTPLetters.Controls.Add(this.button45);
            this.pnlTPLetters.Controls.Add(this.button46);
            this.pnlTPLetters.Controls.Add(this.button47);
            this.pnlTPLetters.Controls.Add(this.button48);
            this.pnlTPLetters.Controls.Add(this.button49);
            this.pnlTPLetters.Controls.Add(this.button50);
            this.pnlTPLetters.Controls.Add(this.button51);
            this.pnlTPLetters.Controls.Add(this.button52);
            this.pnlTPLetters.Location = new System.Drawing.Point(330, 275);
            this.pnlTPLetters.Name = "pnlTPLetters";
            this.pnlTPLetters.Size = new System.Drawing.Size(403, 136);
            this.pnlTPLetters.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 40);
            this.button1.TabIndex = 68;
            this.button1.Text = "M";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.CausesValidation = false;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 40);
            this.button2.TabIndex = 46;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.CausesValidation = false;
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(234, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 40);
            this.button3.TabIndex = 67;
            this.button3.Text = "N";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Ivory;
            this.button14.CausesValidation = false;
            this.button14.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(-1, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 40);
            this.button14.TabIndex = 43;
            this.button14.Text = "Q";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Ivory;
            this.button24.CausesValidation = false;
            this.button24.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(193, 95);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(35, 40);
            this.button24.TabIndex = 66;
            this.button24.Text = "B";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Ivory;
            this.button32.CausesValidation = false;
            this.button32.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(40, 3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(35, 40);
            this.button32.TabIndex = 44;
            this.button32.Text = "W";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Ivory;
            this.button33.CausesValidation = false;
            this.button33.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(152, 95);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(35, 40);
            this.button33.TabIndex = 65;
            this.button33.Text = "V";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Ivory;
            this.button34.CausesValidation = false;
            this.button34.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(81, 3);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(35, 40);
            this.button34.TabIndex = 45;
            this.button34.Text = "E";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Ivory;
            this.button35.CausesValidation = false;
            this.button35.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(113, 95);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(35, 40);
            this.button35.TabIndex = 64;
            this.button35.Text = "C";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Ivory;
            this.button36.CausesValidation = false;
            this.button36.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(161, 3);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(35, 40);
            this.button36.TabIndex = 47;
            this.button36.Text = "T";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.Ivory;
            this.button37.CausesValidation = false;
            this.button37.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(72, 95);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(35, 40);
            this.button37.TabIndex = 63;
            this.button37.Text = "X";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Ivory;
            this.button38.CausesValidation = false;
            this.button38.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(202, 3);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(35, 40);
            this.button38.TabIndex = 48;
            this.button38.Text = "Y";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.Ivory;
            this.button39.CausesValidation = false;
            this.button39.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(31, 95);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(35, 40);
            this.button39.TabIndex = 62;
            this.button39.Text = "Z";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Ivory;
            this.button40.CausesValidation = false;
            this.button40.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(243, 3);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(35, 40);
            this.button40.TabIndex = 49;
            this.button40.Text = "U";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.Ivory;
            this.button41.CausesValidation = false;
            this.button41.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(337, 49);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(35, 40);
            this.button41.TabIndex = 61;
            this.button41.Text = "L";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.Ivory;
            this.button42.CausesValidation = false;
            this.button42.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.Location = new System.Drawing.Point(284, 3);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(35, 40);
            this.button42.TabIndex = 50;
            this.button42.Text = "I";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.Ivory;
            this.button43.CausesValidation = false;
            this.button43.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.Location = new System.Drawing.Point(296, 49);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(35, 40);
            this.button43.TabIndex = 60;
            this.button43.Text = "K";
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.Ivory;
            this.button44.CausesValidation = false;
            this.button44.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.Location = new System.Drawing.Point(325, 3);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(35, 40);
            this.button44.TabIndex = 51;
            this.button44.Text = "O";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.Ivory;
            this.button45.CausesValidation = false;
            this.button45.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.Location = new System.Drawing.Point(255, 49);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(35, 40);
            this.button45.TabIndex = 59;
            this.button45.Text = "J";
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.Ivory;
            this.button46.CausesValidation = false;
            this.button46.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button46.Location = new System.Drawing.Point(366, 3);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(35, 40);
            this.button46.TabIndex = 52;
            this.button46.Text = "P";
            this.button46.UseVisualStyleBackColor = false;
            this.button46.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.Ivory;
            this.button47.CausesValidation = false;
            this.button47.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button47.Location = new System.Drawing.Point(214, 49);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(35, 40);
            this.button47.TabIndex = 58;
            this.button47.Text = "H";
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.Ivory;
            this.button48.CausesValidation = false;
            this.button48.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button48.Location = new System.Drawing.Point(11, 49);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(35, 40);
            this.button48.TabIndex = 53;
            this.button48.Text = "A";
            this.button48.UseVisualStyleBackColor = false;
            this.button48.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.Ivory;
            this.button49.CausesValidation = false;
            this.button49.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button49.Location = new System.Drawing.Point(173, 49);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(35, 40);
            this.button49.TabIndex = 57;
            this.button49.Text = "G";
            this.button49.UseVisualStyleBackColor = false;
            this.button49.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.Ivory;
            this.button50.CausesValidation = false;
            this.button50.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button50.Location = new System.Drawing.Point(52, 49);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(35, 40);
            this.button50.TabIndex = 54;
            this.button50.Text = "S";
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.Color.Ivory;
            this.button51.CausesValidation = false;
            this.button51.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button51.Location = new System.Drawing.Point(132, 49);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(35, 40);
            this.button51.TabIndex = 56;
            this.button51.Text = "F";
            this.button51.UseVisualStyleBackColor = false;
            this.button51.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // button52
            // 
            this.button52.BackColor = System.Drawing.Color.Ivory;
            this.button52.CausesValidation = false;
            this.button52.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button52.Location = new System.Drawing.Point(93, 49);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(35, 40);
            this.button52.TabIndex = 55;
            this.button52.Text = "D";
            this.button52.UseVisualStyleBackColor = false;
            this.button52.Click += new System.EventHandler(this.TpLetterClick);
            // 
            // lblTPScore1
            // 
            this.lblTPScore1.AutoSize = true;
            this.lblTPScore1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPScore1.ForeColor = System.Drawing.Color.White;
            this.lblTPScore1.Location = new System.Drawing.Point(653, 38);
            this.lblTPScore1.Name = "lblTPScore1";
            this.lblTPScore1.Size = new System.Drawing.Size(72, 79);
            this.lblTPScore1.TabIndex = 49;
            this.lblTPScore1.Text = "0";
            // 
            // lblTPPlayer1
            // 
            this.lblTPPlayer1.AutoSize = true;
            this.lblTPPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayer1.Location = new System.Drawing.Point(330, 38);
            this.lblTPPlayer1.Name = "lblTPPlayer1";
            this.lblTPPlayer1.Size = new System.Drawing.Size(325, 79);
            this.lblTPPlayer1.TabIndex = 48;
            this.lblTPPlayer1.Text = "Player1:";
            // 
            // lblTPGameWord
            // 
            this.lblTPGameWord.AutoSize = true;
            this.lblTPGameWord.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPGameWord.ForeColor = System.Drawing.Color.White;
            this.lblTPGameWord.Location = new System.Drawing.Point(316, 183);
            this.lblTPGameWord.Name = "lblTPGameWord";
            this.lblTPGameWord.Size = new System.Drawing.Size(426, 79);
            this.lblTPGameWord.TabIndex = 47;
            this.lblTPGameWord.Text = "_ _ _ _ _ _ _ _ _";
            // 
            // btnTPExit
            // 
            this.btnTPExit.BackColor = System.Drawing.Color.Ivory;
            this.btnTPExit.CausesValidation = false;
            this.btnTPExit.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPExit.Location = new System.Drawing.Point(571, 488);
            this.btnTPExit.Name = "btnTPExit";
            this.btnTPExit.Size = new System.Drawing.Size(171, 50);
            this.btnTPExit.TabIndex = 46;
            this.btnTPExit.Text = "Exit";
            this.btnTPExit.UseVisualStyleBackColor = false;
            this.btnTPExit.Click += new System.EventHandler(this.btnTPExit_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(32, 55);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(257, 329);
            this.pictureBox7.TabIndex = 44;
            this.pictureBox7.TabStop = false;
            // 
            // tabPageTPResult
            // 
            this.tabPageTPResult.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabPageTPResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTPResult.Controls.Add(this.lblTPPlayer2ScoreRes);
            this.tabPageTPResult.Controls.Add(this.lblTPPlayer2Res);
            this.tabPageTPResult.Controls.Add(this.lblTPPlayer1ScoreRes);
            this.tabPageTPResult.Controls.Add(this.lblTPPlayer1Res);
            this.tabPageTPResult.Controls.Add(this.lblTPCorrectWord);
            this.tabPageTPResult.Controls.Add(this.lblTPWordlbl);
            this.tabPageTPResult.Controls.Add(this.pictureBox8);
            this.tabPageTPResult.Controls.Add(this.btnTpResCont);
            this.tabPageTPResult.Controls.Add(this.btnTpResExit);
            this.tabPageTPResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageTPResult.Name = "tabPageTPResult";
            this.tabPageTPResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTPResult.Size = new System.Drawing.Size(787, 544);
            this.tabPageTPResult.TabIndex = 3;
            this.tabPageTPResult.Text = "Result";
            this.tabPageTPResult.UseVisualStyleBackColor = true;
            // 
            // lblTPPlayer2ScoreRes
            // 
            this.lblTPPlayer2ScoreRes.AutoSize = true;
            this.lblTPPlayer2ScoreRes.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayer2ScoreRes.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayer2ScoreRes.Location = new System.Drawing.Point(672, 304);
            this.lblTPPlayer2ScoreRes.Name = "lblTPPlayer2ScoreRes";
            this.lblTPPlayer2ScoreRes.Size = new System.Drawing.Size(72, 79);
            this.lblTPPlayer2ScoreRes.TabIndex = 62;
            this.lblTPPlayer2ScoreRes.Text = "0";
            // 
            // lblTPPlayer2Res
            // 
            this.lblTPPlayer2Res.AutoSize = true;
            this.lblTPPlayer2Res.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayer2Res.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayer2Res.Location = new System.Drawing.Point(353, 304);
            this.lblTPPlayer2Res.Name = "lblTPPlayer2Res";
            this.lblTPPlayer2Res.Size = new System.Drawing.Size(327, 79);
            this.lblTPPlayer2Res.TabIndex = 61;
            this.lblTPPlayer2Res.Text = "Player2:";
            // 
            // lblTPPlayer1ScoreRes
            // 
            this.lblTPPlayer1ScoreRes.AutoSize = true;
            this.lblTPPlayer1ScoreRes.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayer1ScoreRes.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayer1ScoreRes.Location = new System.Drawing.Point(672, 225);
            this.lblTPPlayer1ScoreRes.Name = "lblTPPlayer1ScoreRes";
            this.lblTPPlayer1ScoreRes.Size = new System.Drawing.Size(72, 79);
            this.lblTPPlayer1ScoreRes.TabIndex = 60;
            this.lblTPPlayer1ScoreRes.Text = "0";
            // 
            // lblTPPlayer1Res
            // 
            this.lblTPPlayer1Res.AutoSize = true;
            this.lblTPPlayer1Res.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayer1Res.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayer1Res.Location = new System.Drawing.Point(349, 225);
            this.lblTPPlayer1Res.Name = "lblTPPlayer1Res";
            this.lblTPPlayer1Res.Size = new System.Drawing.Size(325, 79);
            this.lblTPPlayer1Res.TabIndex = 59;
            this.lblTPPlayer1Res.Text = "Player1:";
            // 
            // lblTPCorrectWord
            // 
            this.lblTPCorrectWord.AutoSize = true;
            this.lblTPCorrectWord.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPCorrectWord.ForeColor = System.Drawing.Color.White;
            this.lblTPCorrectWord.Location = new System.Drawing.Point(489, 151);
            this.lblTPCorrectWord.Name = "lblTPCorrectWord";
            this.lblTPCorrectWord.Size = new System.Drawing.Size(135, 46);
            this.lblTPCorrectWord.TabIndex = 58;
            this.lblTPCorrectWord.Text = "word";
            // 
            // lblTPWordlbl
            // 
            this.lblTPWordlbl.AutoSize = true;
            this.lblTPWordlbl.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPWordlbl.ForeColor = System.Drawing.Color.White;
            this.lblTPWordlbl.Location = new System.Drawing.Point(346, 105);
            this.lblTPWordlbl.Name = "lblTPWordlbl";
            this.lblTPWordlbl.Size = new System.Drawing.Size(406, 46);
            this.lblTPWordlbl.TabIndex = 57;
            this.lblTPWordlbl.Text = "Correct word was:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Hangman.Properties.Resources.Hangman;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.ErrorImage = null;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(22, 62);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(380, 334);
            this.pictureBox8.TabIndex = 56;
            this.pictureBox8.TabStop = false;
            // 
            // btnTpResCont
            // 
            this.btnTpResCont.BackColor = System.Drawing.Color.Ivory;
            this.btnTpResCont.CausesValidation = false;
            this.btnTpResCont.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpResCont.Location = new System.Drawing.Point(386, 432);
            this.btnTpResCont.Name = "btnTpResCont";
            this.btnTpResCont.Size = new System.Drawing.Size(208, 50);
            this.btnTpResCont.TabIndex = 53;
            this.btnTpResCont.Text = "Continue";
            this.btnTpResCont.UseVisualStyleBackColor = false;
            this.btnTpResCont.Click += new System.EventHandler(this.btnTpResCont_Click);
            // 
            // btnTpResExit
            // 
            this.btnTpResExit.BackColor = System.Drawing.Color.Ivory;
            this.btnTpResExit.CausesValidation = false;
            this.btnTpResExit.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpResExit.Location = new System.Drawing.Point(215, 432);
            this.btnTpResExit.Name = "btnTpResExit";
            this.btnTpResExit.Size = new System.Drawing.Size(150, 50);
            this.btnTpResExit.TabIndex = 52;
            this.btnTpResExit.Text = "Exit";
            this.btnTpResExit.UseVisualStyleBackColor = false;
            this.btnTpResExit.Click += new System.EventHandler(this.btnTpResExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // tabHighScores
            // 
            this.tabHighScores.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabHighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHighScores.Controls.Add(this.cbScoresDificulty);
            this.tabHighScores.Controls.Add(this.lblHighScores);
            this.tabHighScores.Controls.Add(this.lblHighScoreTitle);
            this.tabHighScores.Controls.Add(this.btnHighScoreBack);
            this.tabHighScores.Location = new System.Drawing.Point(4, 22);
            this.tabHighScores.Name = "tabHighScores";
            this.tabHighScores.Padding = new System.Windows.Forms.Padding(3);
            this.tabHighScores.Size = new System.Drawing.Size(787, 544);
            this.tabHighScores.TabIndex = 3;
            this.tabHighScores.Text = "High Scores";
            this.tabHighScores.UseVisualStyleBackColor = true;
            // 
            // cbScoresDificulty
            // 
            this.cbScoresDificulty.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScoresDificulty.FormattingEnabled = true;
            this.cbScoresDificulty.Items.AddRange(new object[] {
            "Eazy",
            "Medium",
            "Hard"});
            this.cbScoresDificulty.Location = new System.Drawing.Point(497, 49);
            this.cbScoresDificulty.Name = "cbScoresDificulty";
            this.cbScoresDificulty.Size = new System.Drawing.Size(236, 52);
            this.cbScoresDificulty.TabIndex = 52;
            this.cbScoresDificulty.Text = "Eazy";
            this.cbScoresDificulty.SelectedIndexChanged += new System.EventHandler(this.cbScoresDificulty_SelectedIndexChanged);
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.ForeColor = System.Drawing.Color.White;
            this.lblHighScores.Location = new System.Drawing.Point(124, 144);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(247, 46);
            this.lblHighScores.TabIndex = 45;
            this.lblHighScores.Text = "1. Doozy 999";
            // 
            // lblHighScoreTitle
            // 
            this.lblHighScoreTitle.AutoSize = true;
            this.lblHighScoreTitle.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreTitle.ForeColor = System.Drawing.Color.White;
            this.lblHighScoreTitle.Location = new System.Drawing.Point(50, 32);
            this.lblHighScoreTitle.Name = "lblHighScoreTitle";
            this.lblHighScoreTitle.Size = new System.Drawing.Size(441, 79);
            this.lblHighScoreTitle.TabIndex = 44;
            this.lblHighScoreTitle.Text = "High Scores";
            // 
            // btnHighScoreBack
            // 
            this.btnHighScoreBack.BackColor = System.Drawing.Color.Ivory;
            this.btnHighScoreBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScoreBack.Location = new System.Drawing.Point(64, 445);
            this.btnHighScoreBack.Name = "btnHighScoreBack";
            this.btnHighScoreBack.Size = new System.Drawing.Size(300, 50);
            this.btnHighScoreBack.TabIndex = 2;
            this.btnHighScoreBack.Text = "Back";
            this.btnHighScoreBack.UseVisualStyleBackColor = false;
            this.btnHighScoreBack.Click += new System.EventHandler(this.btnHighScoreBack_Click);
            // 
            // tabHelp
            // 
            this.tabHelp.BackgroundImage = global::Hangman.Properties.Resources.board;
            this.tabHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHelp.Controls.Add(this.btmHelpBack);
            this.tabHelp.Controls.Add(this.lblHelp);
            this.tabHelp.Controls.Add(this.lblHelpTitle);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(787, 544);
            this.tabHelp.TabIndex = 4;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // btmHelpBack
            // 
            this.btmHelpBack.BackColor = System.Drawing.Color.Ivory;
            this.btmHelpBack.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmHelpBack.Location = new System.Drawing.Point(68, 451);
            this.btmHelpBack.Name = "btmHelpBack";
            this.btmHelpBack.Size = new System.Drawing.Size(300, 50);
            this.btmHelpBack.TabIndex = 44;
            this.btmHelpBack.Text = "Back";
            this.btmHelpBack.UseVisualStyleBackColor = false;
            this.btmHelpBack.Click += new System.EventHandler(this.btmHelpBack_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(24, 98);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(763, 396);
            this.lblHelp.TabIndex = 43;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.ForeColor = System.Drawing.Color.White;
            this.lblHelpTitle.Location = new System.Drawing.Point(282, 21);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(197, 79);
            this.lblHelpTitle.TabIndex = 42;
            this.lblHelpTitle.Text = "Help";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hangman_FormClosing);
            this.tabControlMenu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuHangman)).EndInit();
            this.tabSinglePlayer.ResumeLayout(false);
            this.tabControlSinglePlayer.ResumeLayout(false);
            this.tabPageSinglePlayerMenu.ResumeLayout(false);
            this.tabPageSinglePlayerMenu.PerformLayout();
            this.tabPageSinglePlayerGame.ResumeLayout(false);
            this.tabPageSinglePlayerGame.PerformLayout();
            this.pnlSPHangman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.pnlLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWood)).EndInit();
            this.tabPageSPResult.ResumeLayout(false);
            this.tabPageSPResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPHanged)).EndInit();
            this.tabTwoPlayers.ResumeLayout(false);
            this.tabTwoPlayers.PerformLayout();
            this.tabControlTwoPlayers.ResumeLayout(false);
            this.tabPageTPNames.ResumeLayout(false);
            this.tabPageTPNames.PerformLayout();
            this.tabPageTpWordSelect.ResumeLayout(false);
            this.tabPageTpWordSelect.PerformLayout();
            this.tabPageTPGame.ResumeLayout(false);
            this.tabPageTPGame.PerformLayout();
            this.pnlTPHangman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTPRightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPLeftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPRightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPLeftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPHead)).EndInit();
            this.pnlTPLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabPageTPResult.ResumeLayout(false);
            this.tabPageTPResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tabHighScores.ResumeLayout(false);
            this.tabHighScores.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnTwoPlayers;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabSinglePlayer;
        private System.Windows.Forms.TabPage tabTwoPlayers;
        private System.Windows.Forms.TabPage tabHighScores;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Button btnHighScoreBack;
        private System.Windows.Forms.PictureBox pbMenuHangman;
        private System.Windows.Forms.TabControl tabControlSinglePlayer;
        private System.Windows.Forms.TabPage tabPageSinglePlayerMenu;
        private System.Windows.Forms.RadioButton rbSPDif3;
        private System.Windows.Forms.RadioButton rbSPDif2;
        private System.Windows.Forms.RadioButton rbSPDif;
        private System.Windows.Forms.Label lblSPDif;
        private System.Windows.Forms.TextBox tbSPName;
        private System.Windows.Forms.Label lblSPName;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblSPCat;
        private System.Windows.Forms.Button btnSPBack;
        private System.Windows.Forms.Button btmSPPlay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tabPageSinglePlayerGame;
        private System.Windows.Forms.Button btnSPGameNew;
        private System.Windows.Forms.Button btnSPGameBack;
        private System.Windows.Forms.PictureBox pbWood;
        private System.Windows.Forms.TabPage tabPageSPResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblSPGuessWord;
        private System.Windows.Forms.Label lblSPREsScore;
        private System.Windows.Forms.Label lblSPRes2;
        private System.Windows.Forms.Button btnSPResNew;
        private System.Windows.Forms.Button btnSPResBack;
        private System.Windows.Forms.Label lblSPRes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lblHighScoreTitle;
        private System.Windows.Forms.PictureBox pbSPHanged;
        private System.Windows.Forms.Panel pnlLetters;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label lblCorrectTitle;
        private System.Windows.Forms.Label lblSPResCorrect;
        private System.Windows.Forms.ComboBox cbScoresDificulty;
        private System.Windows.Forms.Button btmHelpBack;
        private System.Windows.Forms.Panel pnlSPHangman;
        private System.Windows.Forms.PictureBox pbRightLeg;
        private System.Windows.Forms.PictureBox pbLeftLeg;
        private System.Windows.Forms.PictureBox pbRightArm;
        private System.Windows.Forms.PictureBox pbLeftArm;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.TabControl tabControlTwoPlayers;
        private System.Windows.Forms.TabPage tabPageTPNames;
        private System.Windows.Forms.Button btnTPNamesNext;
        private System.Windows.Forms.TextBox tbTPPlayer2Name;
        private System.Windows.Forms.TextBox tbTPPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Button btnTPBack;
        private System.Windows.Forms.TabPage tabPageTpWordSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTPWSPlay;
        private System.Windows.Forms.TextBox tbTPCurrentWord;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Button btnTPWSBack;
        private System.Windows.Forms.TabPage tabPageTPGame;
        private System.Windows.Forms.Label lblTPGuesingText;
        private System.Windows.Forms.Label lblTPGuessing;
        private System.Windows.Forms.Label lblTPScore2;
        private System.Windows.Forms.Label lblTPPlayer2;
        private System.Windows.Forms.Panel pnlTPHangman;
        private System.Windows.Forms.PictureBox pbTPRightLeg;
        private System.Windows.Forms.PictureBox pbTPLeftLeg;
        private System.Windows.Forms.PictureBox pbTPRightArm;
        private System.Windows.Forms.PictureBox pbTPLeftArm;
        private System.Windows.Forms.PictureBox pbTPBody;
        private System.Windows.Forms.PictureBox pbTPHead;
        private System.Windows.Forms.Panel pnlTPLetters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Label lblTPScore1;
        private System.Windows.Forms.Label lblTPPlayer1;
        private System.Windows.Forms.Label lblTPGameWord;
        private System.Windows.Forms.Button btnTPExit;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TabPage tabPageTPResult;
        private System.Windows.Forms.Label lblTPPlayer2ScoreRes;
        private System.Windows.Forms.Label lblTPPlayer2Res;
        private System.Windows.Forms.Label lblTPPlayer1ScoreRes;
        private System.Windows.Forms.Label lblTPPlayer1Res;
        private System.Windows.Forms.Label lblTPCorrectWord;
        private System.Windows.Forms.Label lblTPWordlbl;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnTpResCont;
        private System.Windows.Forms.Button btnTpResExit;
    }
}

