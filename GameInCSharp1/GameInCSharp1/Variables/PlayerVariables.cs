using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Variables
{
    class PlayerVariables
    {
        public static string HeroName;
        public static int HeroMaxHealth;
        public static int HeroCurrentHealth;
        public static int HeroMaxStamina;
        public static int HeroCurrentStamina;
        public static int HeroMaxMana;
        public static int HeroCurrentMana;
        public static int HeroExperience;
        public enum HeroClass
        {
            Warrior,
            Mage,
            Thief
        }
    }
}
