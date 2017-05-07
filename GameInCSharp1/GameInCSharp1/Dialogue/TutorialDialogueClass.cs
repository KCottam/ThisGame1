using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Dialogue
{
    class TutorialDialogueClass
    {
        public static void PlayerChooseClass()
        {
            var isClassChosen = false;

            do
            {
                var result = 0;
                var playerClassChoosen = DisplayChooseClass();

                switch (playerClassChoosen)
                {
                    case "1":
                        result = VerifyWarriorClass();
                        break;

                    case "2":
                        result = VerifyMageClass();
                        break;

                    case "3":
                        result = VerifyThiefClass();
                        break;

                    default:
                        if (result == -1)
                        {
                            Console.Clear();
                            Console.WriteLine(ClassInfo.PickAClass.Default);
                            Console.WriteLine();
                        }
                        break;
                }

                isClassChosen = result == 1 ? true : false;
            } while (isClassChosen == false);
        }

        private static int VerifyThiefClass()
        {
            int result;
            DisplayThiefInformation();
            result = AreYouSure(Variables.PlayerVariables.HeroClass.Thief);
            if (result == 1)
            {
                SetThiefClass();
            }

            return result;
        }

        private static int VerifyMageClass()
        {
            int result;
            DisplayMageInformation();
            result = AreYouSure(Variables.PlayerVariables.HeroClass.Mage);
            if (result == 1)
            {
                SetMageClass();
            }

            return result;
        }

        private static int VerifyWarriorClass()
        {
            int result;
            DisplayWarriorInformation();
            result = AreYouSure(Variables.PlayerVariables.HeroClass.Warrior);
            if (result == 1)
            {
                SetWarriorClass();
            }

            return result;
        }

        private static void SetThiefClass()
        {
            Variables.PlayerVariables.HeroMaxHealth = 100;
            Variables.PlayerVariables.HeroMaxStamina = 100;
            Variables.PlayerVariables.HeroMaxMana = 100;

            Variables.PlayerVariables.HeroCurrentHealth = 100;
            Variables.PlayerVariables.HeroCurrentStamina = 100;
            Variables.PlayerVariables.HeroCurrentMana = 100;

            Variables.PlayerVariables.HeroExperience = 0;
            Variables.PlayerVariables.HeroClassName = "THIEF";
        }

        private static void DisplayThiefInformation()
        {
            Console.Clear();
            Console.WriteLine(ClassInfo.ThiefAbout.ThiefInfo);
            Console.WriteLine(ClassInfo.ThiefAbout.ThiefHealthInfo);
            Console.WriteLine(ClassInfo.ThiefAbout.ThiefStaminaInfo);
            Console.WriteLine(ClassInfo.ThiefAbout.ThiefManaInfo);
            Console.WriteLine();
        }

        private static void SetMageClass()
        {
            Variables.PlayerVariables.HeroMaxHealth = 75;
            Variables.PlayerVariables.HeroMaxStamina = 50;
            Variables.PlayerVariables.HeroMaxMana = 175;

            Variables.PlayerVariables.HeroCurrentHealth = 75;
            Variables.PlayerVariables.HeroCurrentStamina = 50;
            Variables.PlayerVariables.HeroCurrentMana = 175;

            Variables.PlayerVariables.HeroExperience = 0;
            Variables.PlayerVariables.HeroClassName = "MAGE";
        }

        private static void DisplayMageInformation()
        {
            Console.Clear();
            Console.WriteLine(ClassInfo.MageAbout.MageInfo);
            Console.WriteLine(ClassInfo.MageAbout.MageHealthInfo);
            Console.WriteLine(ClassInfo.MageAbout.MageStaminaInfo);
            Console.WriteLine(ClassInfo.MageAbout.MageManaInfo);
            Console.WriteLine();
        }

        private static void SetWarriorClass()
        {
            Variables.PlayerVariables.HeroMaxHealth = 150;
            Variables.PlayerVariables.HeroMaxStamina = 100;
            Variables.PlayerVariables.HeroMaxMana = 50;

            Variables.PlayerVariables.HeroCurrentHealth = 150;
            Variables.PlayerVariables.HeroCurrentStamina = 100;
            Variables.PlayerVariables.HeroCurrentMana = 50;

            Variables.PlayerVariables.HeroExperience = 0;
            Variables.PlayerVariables.HeroClassName = "WARRIOR";
        }

        private static void DisplayWarriorInformation()
        {
            Console.Clear();
            Console.WriteLine(ClassInfo.WarriorAbout.WarriorInfo);
            Console.WriteLine(ClassInfo.WarriorAbout.WarriorInfo2);
            Console.WriteLine(ClassInfo.WarriorAbout.WarriorHealthInfo);
            Console.WriteLine(ClassInfo.WarriorAbout.WarriorStaminaInfo);
            Console.WriteLine(ClassInfo.WarriorAbout.WarriorManaInfo);
            Console.WriteLine();
        }

        private static string DisplayChooseClass()
        {
            Console.Clear();
            Console.WriteLine(ClassInfo.PickAClass.ClassInfo);
            Console.WriteLine(ClassInfo.PickAClass.ClassWarrior);
            Console.WriteLine(ClassInfo.PickAClass.ClassMage);
            Console.WriteLine(ClassInfo.PickAClass.ClassThief);
            Console.Write(ClassInfo.PickAClass.EnterANumber);

            var playerClassChooser = Console.ReadLine();
            Console.WriteLine();

            return playerClassChooser;
        }

        private static int AreYouSure(Variables.PlayerVariables.HeroClass hero)
        {
            Console.WriteLine("Are you sure you want to be {0}?", hero);
            Console.WriteLine("<Please type 'YES' or 'NO'>");

            var result = -1;
            do
            {
                var YesOrNo = Console.ReadLine().ToUpper();
                switch (YesOrNo)
                {
                    case "YES":
                    case "Y":
                        Console.Clear();
                        Console.WriteLine("You are now a {0}", hero);
                        result = 1;
                        break;

                    case "NO":
                    case "N":
                        Console.Clear();
                        Console.WriteLine();
                        result = 0;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("That is not a valid answer.");
                        Console.WriteLine();
                        result = - 1;
                        break;
                }
            } while (result == -1);

            return result;
        }
    }
}
