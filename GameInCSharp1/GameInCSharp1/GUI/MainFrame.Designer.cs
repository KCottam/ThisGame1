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
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // MainMenuPane
            // 
            this.MainMenuPane.Controls.Add(this.ExitGameButton);
            this.MainMenuPane.Controls.Add(this.MainMenuLoadGameButton);
            this.MainMenuPane.Controls.Add(this.StartGameButton);
            this.MainMenuPane.Controls.Add(this.pictureBox1);
            this.MainMenuPane.Location = new System.Drawing.Point(2, 12);
            this.MainMenuPane.Name = "MainMenuPane";
            this.MainMenuPane.Size = new System.Drawing.Size(268, 289);
            this.MainMenuPane.TabIndex = 0;
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitGameButton.Location = new System.Drawing.Point(4, 258);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(261, 23);
            this.ExitGameButton.TabIndex = 3;
            this.ExitGameButton.Text = "Exit Game";
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // MainMenuLoadGameButton
            // 
            this.MainMenuLoadGameButton.BackColor = System.Drawing.Color.PaleGreen;
            this.MainMenuLoadGameButton.Location = new System.Drawing.Point(4, 229);
            this.MainMenuLoadGameButton.Name = "MainMenuLoadGameButton";
            this.MainMenuLoadGameButton.Size = new System.Drawing.Size(261, 23);
            this.MainMenuLoadGameButton.TabIndex = 2;
            this.MainMenuLoadGameButton.Text = "Load Game";
            this.MainMenuLoadGameButton.UseVisualStyleBackColor = false;
            this.MainMenuLoadGameButton.Click += new System.EventHandler(this.MainMenuLoadGameButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StartGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartGameButton.Location = new System.Drawing.Point(4, 200);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(261, 23);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadGamePane
            // 
            this.LoadGamePane.Controls.Add(this.listBox1);
            this.LoadGamePane.Controls.Add(this.ReturnToMainMenuButton);
            this.LoadGamePane.Controls.Add(this.LoadSelectedGameButton);
            this.LoadGamePane.Location = new System.Drawing.Point(2, 12);
            this.LoadGamePane.Name = "LoadGamePane";
            this.LoadGamePane.Size = new System.Drawing.Size(268, 289);
            this.LoadGamePane.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 212);
            this.listBox1.TabIndex = 4;
            // 
            // ReturnToMainMenuButton
            // 
            this.ReturnToMainMenuButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ReturnToMainMenuButton.Location = new System.Drawing.Point(4, 258);
            this.ReturnToMainMenuButton.Name = "ReturnToMainMenuButton";
            this.ReturnToMainMenuButton.Size = new System.Drawing.Size(261, 23);
            this.ReturnToMainMenuButton.TabIndex = 3;
            this.ReturnToMainMenuButton.Text = "Return to Main Menu";
            this.ReturnToMainMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMainMenuButton.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // LoadSelectedGameButton
            // 
            this.LoadSelectedGameButton.BackColor = System.Drawing.Color.PaleGreen;
            this.LoadSelectedGameButton.Location = new System.Drawing.Point(4, 229);
            this.LoadSelectedGameButton.Name = "LoadSelectedGameButton";
            this.LoadSelectedGameButton.Size = new System.Drawing.Size(261, 23);
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
            this.CharacterCreationPane.Location = new System.Drawing.Point(2, 12);
            this.CharacterCreationPane.Name = "CharacterCreationPane";
            this.CharacterCreationPane.Size = new System.Drawing.Size(268, 289);
            this.CharacterCreationPane.TabIndex = 0;
            this.CharacterCreationPane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CharacterCreationPane_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 192);
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AboutClass);
            this.splitContainer1.Size = new System.Drawing.Size(254, 188);
            this.splitContainer1.SplitterDistance = 98;
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
            this.listBox2.Location = new System.Drawing.Point(0, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(98, 175);
            this.listBox2.TabIndex = 1;
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
            this.listBox2.Leave += new System.EventHandler(this.listBox2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose a class:";
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
            this.AboutClass.Size = new System.Drawing.Size(152, 188);
            this.AboutClass.TabIndex = 0;
            // 
            // InformationTab
            // 
            this.InformationTab.Controls.Add(this.AboutTabText);
            this.InformationTab.Location = new System.Drawing.Point(4, 22);
            this.InformationTab.Name = "InformationTab";
            this.InformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.InformationTab.Size = new System.Drawing.Size(144, 162);
            this.InformationTab.TabIndex = 0;
            this.InformationTab.Text = "About";
            this.InformationTab.UseVisualStyleBackColor = true;
            // 
            // AboutTabText
            // 
            this.AboutTabText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTabText.Location = new System.Drawing.Point(3, 3);
            this.AboutTabText.Name = "AboutTabText";
            this.AboutTabText.Size = new System.Drawing.Size(138, 156);
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
            this.NameInput.Location = new System.Drawing.Point(116, 4);
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
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(4, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Your Hero";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter a name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(4, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 313);
            this.Controls.Add(this.CharacterCreationPane);
            this.Controls.Add(this.LoadGamePane);
            this.Controls.Add(this.MainMenuPane);
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
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AboutClass.ResumeLayout(false);
            this.InformationTab.ResumeLayout(false);
            this.SkillsTab.ResumeLayout(false);
            this.AttributesTab.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl AboutClass;
        private System.Windows.Forms.TabPage InformationTab;
        private System.Windows.Forms.RichTextBox AboutTabText;
        private System.Windows.Forms.TabPage SkillsTab;
        private System.Windows.Forms.RichTextBox UnlockableSkillsTabText;
        private System.Windows.Forms.TabPage AttributesTab;
        private System.Windows.Forms.RichTextBox AttributesTabText;
    }
}