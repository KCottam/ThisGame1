namespace GameInCSharp1.GUI
{
    partial class MainFrame
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
            if (disposing && (components != null))
            {
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
            this.MainMenuPane = new System.Windows.Forms.Panel();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.BtnMainMenuLoadGame = new System.Windows.Forms.Button();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.LoadGamePane = new System.Windows.Forms.Panel();
            this.ReturnToMainMenuButton = new System.Windows.Forms.Button();
            this.BtnLoadSelectedGame = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CharacterCreationPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBxClassNames = new System.Windows.Forms.ListBox();
            this.AboutClass = new System.Windows.Forms.TabControl();
            this.InformationTab = new System.Windows.Forms.TabPage();
            this.AboutTabText = new System.Windows.Forms.RichTextBox();
            this.SkillsTab = new System.Windows.Forms.TabPage();
            this.UnlockableSkillsTabText = new System.Windows.Forms.RichTextBox();
            this.AttributesTab = new System.Windows.Forms.TabPage();
            this.AttributesTabText = new System.Windows.Forms.RichTextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.btnCreateYourHero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DialoguePane = new System.Windows.Forms.Panel();
            this.btnContinueDialogue = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.RTxtBoxDialoguePane = new System.Windows.Forms.RichTextBox();
            this.picDialogue = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addMonsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLoutEnemyGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCombatAttack = new System.Windows.Forms.Button();
            this.MainMenuPane.SuspendLayout();
            this.LoadGamePane.SuspendLayout();
            this.CharacterCreationPane.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AboutClass.SuspendLayout();
            this.InformationTab.SuspendLayout();
            this.SkillsTab.SuspendLayout();
            this.AttributesTab.SuspendLayout();
            this.DialoguePane.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDialogue)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPane
            // 
            this.MainMenuPane.Controls.Add(this.picMainMenu);
            this.MainMenuPane.Controls.Add(this.ExitGameButton);
            this.MainMenuPane.Controls.Add(this.BtnMainMenuLoadGame);
            this.MainMenuPane.Controls.Add(this.BtnStartGame);
            this.MainMenuPane.Location = new System.Drawing.Point(2, 1);
            this.MainMenuPane.Name = "MainMenuPane";
            this.MainMenuPane.Size = new System.Drawing.Size(400, 303);
            this.MainMenuPane.TabIndex = 0;
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitGameButton.Location = new System.Drawing.Point(0, 280);
            this.ExitGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(402, 23);
            this.ExitGameButton.TabIndex = 1;
            this.ExitGameButton.Text = "Exit Game";
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // BtnMainMenuLoadGame
            // 
            this.BtnMainMenuLoadGame.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnMainMenuLoadGame.Location = new System.Drawing.Point(0, 256);
            this.BtnMainMenuLoadGame.Margin = new System.Windows.Forms.Padding(5);
            this.BtnMainMenuLoadGame.Name = "BtnMainMenuLoadGame";
            this.BtnMainMenuLoadGame.Size = new System.Drawing.Size(400, 23);
            this.BtnMainMenuLoadGame.TabIndex = 2;
            this.BtnMainMenuLoadGame.Text = "Load Game";
            this.BtnMainMenuLoadGame.UseVisualStyleBackColor = false;
            this.BtnMainMenuLoadGame.Click += new System.EventHandler(this.MainMenuLoadGameButton_Click);
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnStartGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnStartGame.Location = new System.Drawing.Point(0, 232);
            this.BtnStartGame.Margin = new System.Windows.Forms.Padding(5);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(400, 23);
            this.BtnStartGame.TabIndex = 3;
            this.BtnStartGame.Text = "Start Game";
            this.BtnStartGame.UseVisualStyleBackColor = false;
            this.BtnStartGame.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // LoadGamePane
            // 
            this.LoadGamePane.Controls.Add(this.ReturnToMainMenuButton);
            this.LoadGamePane.Controls.Add(this.BtnLoadSelectedGame);
            this.LoadGamePane.Controls.Add(this.listBox1);
            this.LoadGamePane.Location = new System.Drawing.Point(2, 307);
            this.LoadGamePane.Name = "LoadGamePane";
            this.LoadGamePane.Size = new System.Drawing.Size(400, 300);
            this.LoadGamePane.TabIndex = 0;
            // 
            // ReturnToMainMenuButton
            // 
            this.ReturnToMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnToMainMenuButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ReturnToMainMenuButton.Location = new System.Drawing.Point(0, 277);
            this.ReturnToMainMenuButton.Name = "ReturnToMainMenuButton";
            this.ReturnToMainMenuButton.Size = new System.Drawing.Size(400, 23);
            this.ReturnToMainMenuButton.TabIndex = 3;
            this.ReturnToMainMenuButton.Text = "Return to Main Menu";
            this.ReturnToMainMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMainMenuButton.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // BtnLoadSelectedGame
            // 
            this.BtnLoadSelectedGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadSelectedGame.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnLoadSelectedGame.Location = new System.Drawing.Point(0, 257);
            this.BtnLoadSelectedGame.Name = "BtnLoadSelectedGame";
            this.BtnLoadSelectedGame.Size = new System.Drawing.Size(400, 23);
            this.BtnLoadSelectedGame.TabIndex = 2;
            this.BtnLoadSelectedGame.Text = "Load Selected Game";
            this.BtnLoadSelectedGame.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 264);
            this.listBox1.TabIndex = 4;
            // 
            // CharacterCreationPane
            // 
            this.CharacterCreationPane.Controls.Add(this.panel1);
            this.CharacterCreationPane.Controls.Add(this.NameInput);
            this.CharacterCreationPane.Controls.Add(this.btnCreateYourHero);
            this.CharacterCreationPane.Controls.Add(this.label1);
            this.CharacterCreationPane.Controls.Add(this.button1);
            this.CharacterCreationPane.Location = new System.Drawing.Point(2, 613);
            this.CharacterCreationPane.Name = "CharacterCreationPane";
            this.CharacterCreationPane.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterCreationPane.Size = new System.Drawing.Size(400, 300);
            this.CharacterCreationPane.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 213);
            this.panel1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AboutClass);
            this.splitContainer1.Size = new System.Drawing.Size(390, 209);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBxClassNames);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Selection";
            // 
            // LBxClassNames
            // 
            this.LBxClassNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBxClassNames.FormattingEnabled = true;
            this.LBxClassNames.Items.AddRange(new object[] {
            "Warrior",
            "Thief",
            "Mage"});
            this.LBxClassNames.Location = new System.Drawing.Point(3, 16);
            this.LBxClassNames.Name = "LBxClassNames";
            this.LBxClassNames.Size = new System.Drawing.Size(137, 184);
            this.LBxClassNames.TabIndex = 1;
            this.LBxClassNames.Leave += new System.EventHandler(this.listBox2_Leave);
            // 
            // AboutClass
            // 
            this.AboutClass.Controls.Add(this.InformationTab);
            this.AboutClass.Controls.Add(this.SkillsTab);
            this.AboutClass.Controls.Add(this.AttributesTab);
            this.AboutClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutClass.Location = new System.Drawing.Point(0, 0);
            this.AboutClass.Name = "AboutClass";
            this.AboutClass.SelectedIndex = 0;
            this.AboutClass.Size = new System.Drawing.Size(237, 209);
            this.AboutClass.TabIndex = 0;
            // 
            // InformationTab
            // 
            this.InformationTab.Controls.Add(this.AboutTabText);
            this.InformationTab.Location = new System.Drawing.Point(4, 22);
            this.InformationTab.Name = "InformationTab";
            this.InformationTab.Size = new System.Drawing.Size(229, 183);
            this.InformationTab.TabIndex = 0;
            this.InformationTab.Text = "About";
            this.InformationTab.UseVisualStyleBackColor = true;
            // 
            // AboutTabText
            // 
            this.AboutTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTabText.Location = new System.Drawing.Point(0, 0);
            this.AboutTabText.Name = "AboutTabText";
            this.AboutTabText.Size = new System.Drawing.Size(229, 183);
            this.AboutTabText.TabIndex = 0;
            this.AboutTabText.Text = "";
            // 
            // SkillsTab
            // 
            this.SkillsTab.Controls.Add(this.UnlockableSkillsTabText);
            this.SkillsTab.Location = new System.Drawing.Point(4, 22);
            this.SkillsTab.Name = "SkillsTab";
            this.SkillsTab.Size = new System.Drawing.Size(229, 183);
            this.SkillsTab.TabIndex = 1;
            this.SkillsTab.Text = "Unlockable Skills";
            this.SkillsTab.UseVisualStyleBackColor = true;
            // 
            // UnlockableSkillsTabText
            // 
            this.UnlockableSkillsTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnlockableSkillsTabText.Location = new System.Drawing.Point(0, 0);
            this.UnlockableSkillsTabText.Name = "UnlockableSkillsTabText";
            this.UnlockableSkillsTabText.Size = new System.Drawing.Size(229, 183);
            this.UnlockableSkillsTabText.TabIndex = 0;
            this.UnlockableSkillsTabText.Text = "";
            // 
            // AttributesTab
            // 
            this.AttributesTab.Controls.Add(this.AttributesTabText);
            this.AttributesTab.Location = new System.Drawing.Point(4, 22);
            this.AttributesTab.Name = "AttributesTab";
            this.AttributesTab.Size = new System.Drawing.Size(229, 183);
            this.AttributesTab.TabIndex = 2;
            this.AttributesTab.Text = "Attributes";
            this.AttributesTab.UseVisualStyleBackColor = true;
            // 
            // AttributesTabText
            // 
            this.AttributesTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesTabText.Location = new System.Drawing.Point(0, 0);
            this.AttributesTabText.Name = "AttributesTabText";
            this.AttributesTabText.Size = new System.Drawing.Size(229, 183);
            this.AttributesTabText.TabIndex = 0;
            this.AttributesTabText.Text = "";
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.Location = new System.Drawing.Point(115, 13);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(282, 20);
            this.NameInput.TabIndex = 5;
            this.NameInput.Text = "<Hero Name>";
            this.NameInput.Enter += new System.EventHandler(this.NameInput_Enter);
            this.NameInput.Leave += new System.EventHandler(this.NameInput_Leave);
            // 
            // btnCreateYourHero
            // 
            this.btnCreateYourHero.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCreateYourHero.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateYourHero.Enabled = false;
            this.btnCreateYourHero.Location = new System.Drawing.Point(3, 251);
            this.btnCreateYourHero.Name = "btnCreateYourHero";
            this.btnCreateYourHero.Size = new System.Drawing.Size(394, 23);
            this.btnCreateYourHero.TabIndex = 2;
            this.btnCreateYourHero.Text = "Create Your Hero";
            this.btnCreateYourHero.UseVisualStyleBackColor = false;
            this.btnCreateYourHero.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter a name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // DialoguePane
            // 
            this.DialoguePane.Controls.Add(this.btnContinueDialogue);
            this.DialoguePane.Controls.Add(this.picDialogue);
            this.DialoguePane.Controls.Add(this.RTxtBoxDialoguePane);
            this.DialoguePane.Controls.Add(this.menuStrip1);
            this.DialoguePane.Location = new System.Drawing.Point(408, 1);
            this.DialoguePane.Name = "DialoguePane";
            this.DialoguePane.Size = new System.Drawing.Size(400, 300);
            this.DialoguePane.TabIndex = 0;
            this.DialoguePane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CharacterCreationPane_MouseMove);
            // 
            // btnContinueDialogue
            // 
            this.btnContinueDialogue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnContinueDialogue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinueDialogue.Location = new System.Drawing.Point(0, 280);
            this.btnContinueDialogue.Name = "btnContinueDialogue";
            this.btnContinueDialogue.Size = new System.Drawing.Size(400, 23);
            this.btnContinueDialogue.TabIndex = 1;
            this.btnContinueDialogue.Text = "Continue";
            this.btnContinueDialogue.UseVisualStyleBackColor = false;
            this.btnContinueDialogue.Click += new System.EventHandler(this.btnContinueDialogue_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skipConversationToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // skipConversationToolStripMenuItem
            // 
            this.skipConversationToolStripMenuItem.Name = "skipConversationToolStripMenuItem";
            this.skipConversationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.skipConversationToolStripMenuItem.Text = "Skip Conversation";
            // 
            // picMainMenu
            // 
            this.picMainMenu.BackColor = System.Drawing.Color.Black;
            this.picMainMenu.Location = new System.Drawing.Point(0, 0);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(400, 232);
            this.picMainMenu.TabIndex = 4;
            this.picMainMenu.TabStop = false;
            // 
            // RTxtBoxDialoguePane
            // 
            this.RTxtBoxDialoguePane.Location = new System.Drawing.Point(0, 207);
            this.RTxtBoxDialoguePane.Name = "RTxtBoxDialoguePane";
            this.RTxtBoxDialoguePane.Size = new System.Drawing.Size(400, 72);
            this.RTxtBoxDialoguePane.TabIndex = 2;
            this.RTxtBoxDialoguePane.Text = "";
            // 
            // picDialogue
            // 
            this.picDialogue.BackColor = System.Drawing.Color.Black;
            this.picDialogue.Location = new System.Drawing.Point(0, 24);
            this.picDialogue.Name = "picDialogue";
            this.picDialogue.Size = new System.Drawing.Size(400, 184);
            this.picDialogue.TabIndex = 1;
            this.picDialogue.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCombatAttack);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.flowLoutEnemyGroup);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Location = new System.Drawing.Point(408, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 300);
            this.panel2.TabIndex = 0;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CharacterCreationPane_MouseMove);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(400, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMonsterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Debug";
            // 
            // addMonsterToolStripMenuItem
            // 
            this.addMonsterToolStripMenuItem.Name = "addMonsterToolStripMenuItem";
            this.addMonsterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMonsterToolStripMenuItem.Text = "Add Monster";
            // 
            // flowLoutEnemyGroup
            // 
            this.flowLoutEnemyGroup.Location = new System.Drawing.Point(0, 25);
            this.flowLoutEnemyGroup.Name = "flowLoutEnemyGroup";
            this.flowLoutEnemyGroup.Size = new System.Drawing.Size(400, 42);
            this.flowLoutEnemyGroup.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 91);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnCombatAttack
            // 
            this.btnCombatAttack.Location = new System.Drawing.Point(283, 212);
            this.btnCombatAttack.Name = "btnCombatAttack";
            this.btnCombatAttack.Size = new System.Drawing.Size(48, 23);
            this.btnCombatAttack.TabIndex = 3;
            this.btnCombatAttack.Text = "Attack";
            this.btnCombatAttack.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1072, 1028);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DialoguePane);
            this.Controls.Add(this.CharacterCreationPane);
            this.Controls.Add(this.LoadGamePane);
            this.Controls.Add(this.MainMenuPane);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MainMenuPane.ResumeLayout(false);
            this.LoadGamePane.ResumeLayout(false);
            this.CharacterCreationPane.ResumeLayout(false);
            this.CharacterCreationPane.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.AboutClass.ResumeLayout(false);
            this.InformationTab.ResumeLayout(false);
            this.SkillsTab.ResumeLayout(false);
            this.AttributesTab.ResumeLayout(false);
            this.DialoguePane.ResumeLayout(false);
            this.DialoguePane.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDialogue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPane;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button BtnMainMenuLoadGame;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Panel LoadGamePane;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ReturnToMainMenuButton;
        private System.Windows.Forms.Button BtnLoadSelectedGame;
        private System.Windows.Forms.Panel CharacterCreationPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button btnCreateYourHero;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox LBxClassNames;
        private System.Windows.Forms.TabControl AboutClass;
        private System.Windows.Forms.TabPage InformationTab;
        private System.Windows.Forms.RichTextBox AboutTabText;
        private System.Windows.Forms.TabPage SkillsTab;
        private System.Windows.Forms.RichTextBox UnlockableSkillsTabText;
        private System.Windows.Forms.TabPage AttributesTab;
        private System.Windows.Forms.RichTextBox AttributesTabText;
        private System.Windows.Forms.Panel DialoguePane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipConversationToolStripMenuItem;
        private System.Windows.Forms.Button btnContinueDialogue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.PictureBox picDialogue;
        private System.Windows.Forms.RichTextBox RTxtBoxDialoguePane;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMonsterToolStripMenuItem;
        private System.Windows.Forms.Button btnCombatAttack;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLoutEnemyGroup;
    }
}