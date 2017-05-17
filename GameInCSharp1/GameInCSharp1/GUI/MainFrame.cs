using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInCSharp1.GUI
{
    public partial class MainFrame : Form
    {
        int createACharacterStepToEnable = 0;

        List<Panel> listPanel = new List<Panel>();
        bool clicked = false;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            listPanel.Add(MainMenuPane);
            listPanel.Add(LoadGamePane);
            listPanel.Add(CharacterCreationPane);
            listPanel.Add(DialoguePane);
            for (int i = 0; i < listPanel.Count; i++)
            {
                listPanel[i].Visible = false;
                listPanel[i].Location = new Point(0, 0);
            }
            this.Size = new Size(width: 400, height: 340);
            listPanel[0].Visible = true;
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuLoadGameButton_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void ReturnToMainMenuButton_Click(object sender, EventArgs e)
        {
            ShowPanel(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }                       //none

        #region nameInput
        private void NameInput_Enter(object sender, EventArgs e)
        {
            if (NameInput.Text == "<Hero Name>")
            {
                NameInput.Text = "";
            }
        }

        private void NameInput_Leave(object sender, EventArgs e)
        {
            if (NameInput.Text == "")
            {
                NameInput.Text = "<Hero Name>";
                if (createACharacterStepToEnable > 0)
                {
                    createACharacterStepToEnable--;
                }
            }
            else
            {
                createACharacterStepToEnable++;
            }
            checkIfCharacterCreated();
        }
        #endregion

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            ShowPanel(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(0);
        }                                 //unused

        private void listBox2_Leave(object sender, EventArgs e)
        {
            checkIfCharacterCreated();
        }                 

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {

            switch (LBxClassNames.SelectedIndex)
            {
                case 0: //warior
                    AboutTabText.Text = "hoi. I am warriu!";
                    UnlockableSkillsTabText.Text = "I kan wof!";
                    AttributesTabText.Text = "I am MIGHTY DOGGO!";

                    break;
                case 1: //mage
                    AboutTabText.Text = "hoi. I am magi!";
                    UnlockableSkillsTabText.Text = "I kan wof with mana!";
                    AttributesTabText.Text = "I am MAGIKAL DOGGO!";
                    break;
                case 2: //thief
                    AboutTabText.Text = "hoi. I am thief!";
                    UnlockableSkillsTabText.Text = "I kan huf!";
                    AttributesTabText.Text = "I am QUIET DOGGO!";
                    break;
            }
            if (clicked == false)
            {
                createACharacterStepToEnable++;
                clicked = true;
            }
        }

        private void CharacterCreationPane_MouseMove(object sender, MouseEventArgs e)
        {
            

        }                         //none

        private void checkIfCharacterCreated()
        {
            if (createACharacterStepToEnable == 2)
            {
                btnCreateYourHero.Enabled = true;
            }
            else
            {
                btnCreateYourHero.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) //create your hero button
        {
            RTxtBoxDialoguePane.AppendText("Hello, Hero. My name is Edna. I am here to help you save the world.");
            ShowPanel(3);
        }

        private void ShowPanel(int index)
        {
            for (int i = 0; i < listPanel.Count; i++)
            {
                listPanel[i].Visible = false;
                listPanel[i].Location = new Point(0, 0);
            }
            listPanel[index].Visible = true;
        }

        private void btnContinueDialogue_Click(object sender, EventArgs e)
        {
            int step = 0;
            switch (step)
            {
                case 0:
                    step++;
                    RTxtBoxDialoguePane.AppendText("\n"+"We must leave this place!");
                    break;
                default:
                    step=0;
                    RTxtBoxDialoguePane.Text = "";
                    break;
            }
        }
    }
}
