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
            AssignPlayerClass();

            Console.WriteLine("DEBUG SKIP");
            InputLine();
            ReturningToTownBeforeFight();

            Scripts.Battle.BattleSequence battle = new Scripts.Battle.BattleSequence("Goblin Boss",500,15);
            InputLine();
        }

        private static void ReturningToTownBeforeFight()
        {
            Console.WriteLine(Dialogue.ReturningToTownDialogue.ReturnHome);
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.ReturningToTownDialogue.HealYourself);
            InputLine();
            Console.Clear();

            Console.WriteLine("You have been healed!"); //to be replaced with text from staying in home.
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.ReturningToTownDialogue.CommenceTravel);
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.ReturningToTownDialogue.SettingDescription);
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.ReturningToTownDialogue.SoundNotification);
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.ReturningToTownDialogue.GoblinsAppear);
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.ReturningToTownDialogue.EdnaGoblinExclamation);
            InputLine();
            Console.Clear();
        }

        private static void AssignPlayerClass()
        {
            Console.WriteLine(Dialogue.TutorialDialogue.HelloMessage);
            InputLine();
            Console.Clear();

            do
            {
                Console.WriteLine(Dialogue.TutorialDialogue.NameAsking);

                Console.Write(Dialogue.TutorialDialogue.NameAskingPrompt);

                Variables.PlayerVariables.HeroName = Console.ReadLine();
                Console.Clear();

            } while (Variables.PlayerVariables.HeroName == "");

            Console.WriteLine(Dialogue.TutorialDialogue.HelloName, Variables.PlayerVariables.HeroName);
            Console.WriteLine();

            Console.WriteLine(Dialogue.TutorialDialogue.ClassAsking);
            InputLine();

            Dialogue.TutorialDialogueClass.PlayerChooseClass();
            Console.WriteLine(Dialogue.TutorialDialogue.SmallTalk1, Variables.PlayerVariables.HeroClassName.ToLower());
            InputLine();
            Console.Clear();

            Console.WriteLine(Dialogue.TutorialDialogue.GameStart1);
            Console.WriteLine(Dialogue.TutorialDialogue.GameStart2);
            Console.WriteLine(Dialogue.TutorialDialogue.GameStart3);

            Console.WriteLine();
            InputLine();
            Console.Clear();
        }

        private static void InputLine()
        {
            Console.WriteLine("<Please press enter.>");
            Console.ReadLine();
        }
    }
}
