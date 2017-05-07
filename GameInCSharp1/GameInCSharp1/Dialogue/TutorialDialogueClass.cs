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
            string playerClassChooser;
            switchloop:
            {
                Console.Clear();
                Console.WriteLine(ClassInfo.PickAClass.ClassInfo);
                Console.WriteLine(ClassInfo.PickAClass.ClassWarrior);
                Console.WriteLine(ClassInfo.PickAClass.ClassMage);
                Console.WriteLine(ClassInfo.PickAClass.ClassThief);
                Console.Write(ClassInfo.PickAClass.EnterANumber);
                playerClassChooser = Console.ReadLine();
                Console.WriteLine();
                switch (playerClassChooser)
                {
                    case "1":
                        warrior:
                        Console.Clear();
                        Console.WriteLine(ClassInfo.WarriorAbout.WarriorInfo);
                        Console.WriteLine(ClassInfo.WarriorAbout.WarriorInfo2);
                        Console.WriteLine(ClassInfo.WarriorAbout.WarriorHealthInfo);
                        Console.WriteLine(ClassInfo.WarriorAbout.WarriorStaminaInfo);
                        Console.WriteLine(ClassInfo.WarriorAbout.WarriorManaInfo);
                        Console.WriteLine();
                        if (AreYouSure(Variables.PlayerVariables.HeroClass.Warrior))
                        {
                            Variables.PlayerVariables.HeroMaxHealth = 150;
                            Variables.PlayerVariables.HeroMaxStamina = 100;
                            Variables.PlayerVariables.HeroMaxMana = 50;

                            Variables.PlayerVariables.HeroCurrentHealth = 150;
                            Variables.PlayerVariables.HeroCurrentStamina = 100;
                            Variables.PlayerVariables.HeroCurrentMana = 50;

                            Variables.PlayerVariables.HeroExperience = 0;
                            Variables.PlayerVariables.HeroClassName = "WARRIOR";
                            break;
                        } //setting stats
                        else { goto warrior; }
                        
                    case "2":
                        mage:
                        Console.Clear();
                        Console.WriteLine(ClassInfo.MageAbout.MageInfo);
                        Console.WriteLine(ClassInfo.MageAbout.MageHealthInfo);
                        Console.WriteLine(ClassInfo.MageAbout.MageStaminaInfo);
                        Console.WriteLine(ClassInfo.MageAbout.MageManaInfo);
                        Console.WriteLine();
                        if (AreYouSure(Variables.PlayerVariables.HeroClass.Mage))
                        {
                            Variables.PlayerVariables.HeroMaxHealth = 75;
                            Variables.PlayerVariables.HeroMaxStamina = 50;
                            Variables.PlayerVariables.HeroMaxMana = 175;

                            Variables.PlayerVariables.HeroCurrentHealth = 75;
                            Variables.PlayerVariables.HeroCurrentStamina = 50;
                            Variables.PlayerVariables.HeroCurrentMana = 175;

                            Variables.PlayerVariables.HeroExperience = 0;
                            Variables.PlayerVariables.HeroClassName = "MAGE";
                            break;
                        } //setting stats
                        else { goto mage; }
                        
                    case "3":
                        thief:
                        Console.Clear();
                        Console.WriteLine(ClassInfo.ThiefAbout.ThiefInfo);
                        Console.WriteLine(ClassInfo.ThiefAbout.ThiefHealthInfo);
                        Console.WriteLine(ClassInfo.ThiefAbout.ThiefStaminaInfo);
                        Console.WriteLine(ClassInfo.ThiefAbout.ThiefManaInfo);
                        Console.WriteLine();
                        if (AreYouSure(Variables.PlayerVariables.HeroClass.Thief))
                        {
                            Variables.PlayerVariables.HeroMaxHealth = 100;
                            Variables.PlayerVariables.HeroMaxStamina = 100;
                            Variables.PlayerVariables.HeroMaxMana = 100;

                            Variables.PlayerVariables.HeroCurrentHealth = 100;
                            Variables.PlayerVariables.HeroCurrentStamina = 100;
                            Variables.PlayerVariables.HeroCurrentMana = 100;

                            Variables.PlayerVariables.HeroExperience = 0;
                            Variables.PlayerVariables.HeroClassName = "THIEF";
                            break;
                        } //setting stats
                        else { goto thief; }
                        
                    default:
                        Console.Clear();
                        Console.WriteLine(ClassInfo.PickAClass.Default);
                        Console.WriteLine();
                        goto switchloop;
                }//end switch
            }//end switch loop
        }//end playerChooseClass()

        private static bool AreYouSure(Variables.PlayerVariables.HeroClass hero)
        {
        //switchloop:
            {
                Console.WriteLine("Are you sure you want to be {0}?",hero);
                Console.WriteLine("<Please type 'YES' or 'NO'>");
                string YesOrNo = null;
                YesOrNo = Console.ReadLine().ToUpper();
                switch(YesOrNo)
                {
                    case "YES":
                        Console.Clear();
                        //Console.WriteLine();
                        Console.WriteLine("You are now a {0}", hero);
                        //Console.WriteLine();
                        return true;
                    case "NO":
                        Console.Clear();
                        //Console.WriteLine();
                        PlayerChooseClass();
                        Console.WriteLine();
                        return false;
                    default:
                        //Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("That is not a valid answer.");
                        Console.WriteLine();
                        return false;
                }// end switch
            }//end switch loop
        }// end AreYouSure()


    }// end class
}
