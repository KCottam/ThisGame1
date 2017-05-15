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
            this.MainMenuLoadGameButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadGamePane = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ReturnToMainMenuButton = new System.Windows.Forms.Button();
            this.LoadSelectedGameButton = new System.Windows.Forms.Button();
            this.CharacterCreationPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AboutClass = new System.Windows.Forms.TabControl();
            this.InformationTab = new System.Windows.Forms.TabPage();
            this.AboutTabText = new System.Windows.Forms.RichTextBox();
            this.SkillsTab = new System.Windows.Forms.TabPage();
            this.UnlockableSkillsTabText = new System.Windows.Forms.RichTextBox();
            this.AttributesTab = new System.Windows.Forms.TabPage();
            this.AttributesTabText = new System.Windows.Forms.RichTextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DialoguePane = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainMenuPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoadGamePane.SuspendLayout();
            this.CharacterCreationPane.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AboutClass.SuspendLayout();
            this.InformationTab.SuspendLayout();
            this.SkillsTab.SuspendLayout();
            this.AttributesTab.SuspendLayout();
            this.DialoguePane.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuPane
            // 
            this.MainMenuPane.Controls.Add(this.ExitGameButton);
            this.MainMenuPane.Controls.Add(this.MainMenuLoadGameButton);
            this.MainMenuPane.Controls.Add(this.StartGameButton);
            this.MainMenuPane.Controls.Add(this.pictureBox1);
            this.MainMenuPane.Location = new System.Drawing.Point(2, 1);
            this.MainMenuPane.Name = "MainMenuPane";
            this.MainMenuPane.Size = new System.Drawing.Size(400, 300);
            this.MainMenuPane.TabIndex = 0;
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitGameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitGameButton.Location = new System.Drawing.Point(0, 231);
            this.ExitGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(400, 23);
            this.ExitGameButton.TabIndex = 1;
            this.ExitGameButton.Text = "Exit Game";
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // MainMenuLoadGameButton
            // 
            this.MainMenuLoadGameButton.BackColor = System.Drawing.Color.PaleGreen;
            this.MainMenuLoadGameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainMenuLoadGameButton.Location = new System.Drawing.Point(0, 254);
            this.MainMenuLoadGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.MainMenuLoadGameButton.Name = "MainMenuLoadGameButton";
            this.MainMenuLoadGameButton.Size = new System.Drawing.Size(400, 23);
            this.MainMenuLoadGameButton.TabIndex = 2;
            this.MainMenuLoadGameButton.Text = "Load Game";
            this.MainMenuLoadGameButton.UseVisualStyleBackColor = false;
            this.MainMenuLoadGameButton.Click += new System.EventHandler(this.MainMenuLoadGameButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StartGameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartGameButton.Location = new System.Drawing.Point(0, 277);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(400, 23);
            this.StartGameButton.TabIndex = 3;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(400, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadGamePane
            // 
            this.LoadGamePane.Controls.Add(this.listBox1);
            this.LoadGamePane.Controls.Add(this.ReturnToMainMenuButton);
            this.LoadGamePane.Controls.Add(this.LoadSelectedGameButton);
            this.LoadGamePane.Location = new System.Drawing.Point(2, 307);
            this.LoadGamePane.Name = "LoadGamePane";
            this.LoadGamePane.Size = new System.Drawing.Size(400, 300);
            this.LoadGamePane.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 238);
            this.listBox1.TabIndex = 4;
            // 
            // ReturnToMainMenuButton
            // 
            this.ReturnToMainMenuButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ReturnToMainMenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnToMainMenuButton.Location = new System.Drawing.Point(0, 254);
            this.ReturnToMainMenuButton.Name = "ReturnToMainMenuButton";
            this.ReturnToMainMenuButton.Size = new System.Drawing.Size(400, 23);
            this.ReturnToMainMenuButton.TabIndex = 3;
            this.ReturnToMainMenuButton.Text = "Return to Main Menu";
            this.ReturnToMainMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMainMenuButton.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // LoadSelectedGameButton
            // 
            this.LoadSelectedGameButton.BackColor = System.Drawing.Color.PaleGreen;
            this.LoadSelectedGameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadSelectedGameButton.Location = new System.Drawing.Point(0, 277);
            this.LoadSelectedGameButton.Name = "LoadSelectedGameButton";
            this.LoadSelectedGameButton.Size = new System.Drawing.Size(400, 23);
            this.LoadSelectedGameButton.TabIndex = 2;
            this.LoadSelectedGameButton.Text = "Load Selected Game";
            this.LoadSelectedGameButton.UseVisualStyleBackColor = false;
            // 
            // CharacterCreationPane
            // 
            this.CharacterCreationPane.Controls.Add(this.panel1);
            this.CharacterCreationPane.Controls.Add(this.NameInput);
            this.CharacterCreationPane.Controls.Add(this.button2);
            this.CharacterCreationPane.Controls.Add(this.label1);
            this.CharacterCreationPane.Controls.Add(this.button1);
            this.CharacterCreationPane.Location = new System.Drawing.Point(2, 613);
            this.CharacterCreationPane.Name = "CharacterCreationPane";
            this.CharacterCreationPane.Size = new System.Drawing.Size(400, 300);
            this.CharacterCreationPane.TabIndex = 0;
            this.CharacterCreationPane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CharacterCreationPane_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 213);
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
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AboutClass);
            this.splitContainer1.Size = new System.Drawing.Size(396, 209);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Thief"});
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 209);
            this.listBox2.TabIndex = 1;
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
            this.listBox2.Leave += new System.EventHandler(this.listBox2_Leave);
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
            this.AboutClass.Size = new System.Drawing.Size(240, 209);
            this.AboutClass.TabIndex = 0;
            // 
            // InformationTab
            // 
            this.InformationTab.Controls.Add(this.AboutTabText);
            this.InformationTab.Location = new System.Drawing.Point(4, 22);
            this.InformationTab.Name = "InformationTab";
            this.InformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.InformationTab.Size = new System.Drawing.Size(232, 183);
            this.InformationTab.TabIndex = 0;
            this.InformationTab.Text = "About";
            this.InformationTab.UseVisualStyleBackColor = true;
            // 
            // AboutTabText
            // 
            this.AboutTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTabText.Location = new System.Drawing.Point(3, 3);
            this.AboutTabText.Name = "AboutTabText";
            this.AboutTabText.Size = new System.Drawing.Size(226, 177);
            this.AboutTabText.TabIndex = 0;
            this.AboutTabText.Text = "";
            // 
            // SkillsTab
            // 
            this.SkillsTab.Controls.Add(this.UnlockableSkillsTabText);
            this.SkillsTab.Location = new System.Drawing.Point(4, 22);
            this.SkillsTab.Name = "SkillsTab";
            this.SkillsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SkillsTab.Size = new System.Drawing.Size(144, 162);
            this.SkillsTab.TabIndex = 1;
            this.SkillsTab.Text = "Unlockable Skills";
            this.SkillsTab.UseVisualStyleBackColor = true;
            // 
            // UnlockableSkillsTabText
            // 
            this.UnlockableSkillsTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnlockableSkillsTabText.Location = new System.Drawing.Point(3, 3);
            this.UnlockableSkillsTabText.Name = "UnlockableSkillsTabText";
            this.UnlockableSkillsTabText.Size = new System.Drawing.Size(138, 156);
            this.UnlockableSkillsTabText.TabIndex = 0;
            this.UnlockableSkillsTabText.Text = "";
            // 
            // AttributesTab
            // 
            this.AttributesTab.Controls.Add(this.AttributesTabText);
            this.AttributesTab.Location = new System.Drawing.Point(4, 22);
            this.AttributesTab.Name = "AttributesTab";
            this.AttributesTab.Size = new System.Drawing.Size(144, 162);
            this.AttributesTab.TabIndex = 2;
            this.AttributesTab.Text = "Attributes";
            this.AttributesTab.UseVisualStyleBackColor = true;
            // 
            // AttributesTabText
            // 
            this.AttributesTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesTabText.Location = new System.Drawing.Point(0, 0);
            this.AttributesTabText.Name = "AttributesTabText";
            this.AttributesTabText.Size = new System.Drawing.Size(144, 162);
            this.AttributesTabText.TabIndex = 0;
            this.AttributesTabText.Text = "";
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.Location = new System.Drawing.Point(248, 4);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(149, 20);
            this.NameInput.TabIndex = 5;
            this.NameInput.Text = "<Hero Name>";
            this.NameInput.Enter += new System.EventHandler(this.NameInput_Enter);
            this.NameInput.Leave += new System.EventHandler(this.NameInput_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(0, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Your Hero";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter a name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DialoguePane
            // 
            this.DialoguePane.Controls.Add(this.pictureBox2);
            this.DialoguePane.Controls.Add(this.panel3);
            this.DialoguePane.Controls.Add(this.menuStrip1);
            this.DialoguePane.Controls.Add(this.button3);
            this.DialoguePane.Location = new System.Drawing.Point(408, 1);
            this.DialoguePane.Name = "DialoguePane";
            this.DialoguePane.Size = new System.Drawing.Size(400, 300);
            this.DialoguePane.TabIndex = 0;
            this.DialoguePane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CharacterCreationPane_MouseMove);
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
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 57);
            this.panel3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(0, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Continue Game";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 196);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1028);
            this.Controls.Add(this.DialoguePane);
            this.Controls.Add(this.CharacterCreationPane);
            this.Controls.Add(this.LoadGamePane);
            this.Controls.Add(this.MainMenuPane);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MainMenuPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoadGamePane.ResumeLayout(false);
            this.CharacterCreationPane.ResumeLayout(false);
            this.CharacterCreationPane.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AboutClass.ResumeLayout(false);
            this.InformationTab.ResumeLayout(false);
            this.SkillsTab.ResumeLayout(false);
            this.AttributesTab.ResumeLayout(false);
            this.DialoguePane.ResumeLayout(false);
            this.DialoguePane.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPane;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button MainMenuLoadGameButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LoadGamePane;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ReturnToMainMenuButton;
        private System.Windows.Forms.Button LoadSelectedGameButton;
        private System.Windows.Forms.Panel CharacterCreationPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabControl AboutClass;
        private System.Windows.Forms.TabPage InformationTab;
        private System.Windows.Forms.RichTextBox AboutTabText;
        private System.Windows.Forms.TabPage SkillsTab;
        private System.Windows.Forms.RichTextBox UnlockableSkillsTabText;
        private System.Windows.Forms.TabPage AttributesTab;
        private System.Windows.Forms.RichTextBox AttributesTabText;
        private System.Windows.Forms.Panel DialoguePane;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipConversationToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}