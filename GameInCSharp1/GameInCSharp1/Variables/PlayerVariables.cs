using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Variables
{
    class PlayerVariables
    {
        public static string HeroName { get; set; }
        public static int HeroMaxHealth { get; set; }
        public static int HeroCurrentHealth { get; set; }
        public static int HeroMaxStamina { get; set; }
        public static int HeroCurrentStamina { get; set; }
        public static int HeroMaxMana { get; set; }
        public static int HeroCurrentMana { get; set; }
        public static int HeroExperience { get; set; }
        public static string HeroClassName { get; set; }
        public enum HeroClass
        {
            Warrior,
            Mage,
            Thief
        } 
    }
}
