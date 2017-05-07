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
            Console.WriteLine(Dialogue.TutorialDialogue.HelloMessage);
            InputLine();
            Console.WriteLine(Dialogue.TutorialDialogue.NameAsking);

            Console.Write(Dialogue.TutorialDialogue.NameAskingPrompt);
            Variables.PlayerVariables.HeroName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(Dialogue.TutorialDialogue.HelloName, Variables.PlayerVariables.HeroName);
            Console.WriteLine(Dialogue.TutorialDialogue.ClassAsking);
            Dialogue.TutorialDialogueClass.PlayerChooseClass();

            Console.ReadLine(); //wait at end
            //</editor-fold>
        }

        private static void InputLine()
        {
            Console.WriteLine("<Please press any key.>");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
