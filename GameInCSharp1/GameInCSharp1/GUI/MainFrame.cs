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

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            listPanel.Add(MainMenuPane);
            listPanel.Add(LoadGamePane);
            listPanel.Add(CharacterCreationPane);
            for (int i = 0; i < listPanel.Count; i++)
            {
                listPanel[i].Visible = false;
            }
            listPanel[0].Visible = true;
        }

        private void MainMenuLoadGameButton_Click(object sender, EventArgs e)
        {
            listPanel[1].Visible = true;
            listPanel[0].Visible = false;
        }

        private void ReturnToMainMenuButton_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = true;
            listPanel[1].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

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
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            listPanel[2].Visible = true;
            listPanel[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = true;
            listPanel[2].Visible = false;
        }

        private void listBox2_Leave(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {

            switch (listBox2.SelectedIndex)
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
            if (createACharacterStepToEnable == 2)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e) //create your hero button
        {

        }
    }
}
