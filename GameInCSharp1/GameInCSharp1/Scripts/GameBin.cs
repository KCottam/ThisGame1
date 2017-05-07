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
            Console.Clear();

            Console.WriteLine(Dialogue.TutorialDialogue.NameAsking);
            Console.Write(Dialogue.TutorialDialogue.NameAskingPrompt);
            Variables.PlayerVariables.HeroName = Console.ReadLine();
            Console.Clear();
            //Console.WriteLine();

            Console.WriteLine(Dialogue.TutorialDialogue.HelloName, Variables.PlayerVariables.HeroName);
            Console.WriteLine();

            Console.WriteLine(Dialogue.TutorialDialogue.ClassAsking); //class ask
            InputLine();
            Dialogue.TutorialDialogueClass.PlayerChooseClass();
            Console.WriteLine(Dialogue.TutorialDialogue.SmallTalk1, Variables.PlayerVariables.HeroClassName.ToLower());
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.TutorialDialogue.GameStart1);
            Console.WriteLine(Dialogue.TutorialDialogue.GameStart2);
            Console.WriteLine(Dialogue.TutorialDialogue.GameStart3);
            //InputLine();
            //Console.Clear();

            //</editor-fold>
        }

        private static void InputLine()
        {
            Console.WriteLine("<Please press enter.>");
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
