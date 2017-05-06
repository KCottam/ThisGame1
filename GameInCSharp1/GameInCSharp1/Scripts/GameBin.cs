using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1
{
    class GameBin
    {
        public GameBin()
        {
            //<editor-fold desc="Tutorial Phase">
            Console.WriteLine(Dialogue.TutorialDialogueClass.TutorialDialogue[0]);
            Console.WriteLine(Dialogue.TutorialDialogue.Tut1);
            InputLine();
            Console.WriteLine(Dialogue.TutorialDialogueClass.TutorialDialogue[1]);
            InputLine();
            Console.Write(Dialogue.TutorialDialogueClass.TutorialDialogue[2]);
            Variables.PlayerVariables.HeroName = Console.ReadLine();
            Console.WriteLine(Dialogue.TutorialDialogueClass.TutorialDialogue[3], Variables.PlayerVariables.HeroName);
            Console.WriteLine(Dialogue.TutorialDialogueClass.TutorialDialogue[4]);


            Console.ReadLine(); //wait at end
            //</editor-fold>
        }

        private void InputLine()
        {
            Console.WriteLine("<Please press any key.>");
            Console.ReadKey();
        }
    }
}
