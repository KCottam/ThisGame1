using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Dialogue
{
    class TutorialDialogueClass
    {
        public static string[] TutorialDialogue =
        {
            "<Unknown> Hello. Welcome to the world of Narnia.", //0
            "<Unknown> May I have your name?", //1
            "<Unknown> Enter your name: ", //write //2
            "<Unknown> Hello, {0}", //+heroName //3
            "<Edna> I am Edna. A witch. What are you?", //4
            "<Edna> A {0}, huh? Fascinating. I have never seen one in my long life.", //+heroClass //5
            "<Edna> Come with me, wont you? I did save your life, afterall.", //6
            "And now we need to save something else...", //7
            "The World." //8
        };
        public static string[] PickAClass =
        {
            "Please pick a class by pressing one of the following numbers.", //0
            "1) Warrior", //1
            "2) Mage", //2
            "3) Thief", //3
            "This is not a valid class. Please pick a valid class.", //default //4
        };
        public static string[] WarriorInfo =
        {
            "The warrior is strong, able to withstand numerous injuries. ", //1
            "He is also hard-hitting, but lacks on the magical spectrum of the world.", //2
            "His max health is 150, the highest of all of the classes.", //3
            "His max stamina is 100.", //4
            "His max mana is a mere 50." //5
        };
        public static string[] MageInfo =
        {
            "The mage is weak, but makes up for it based on his many damaging abilities.", //1
            "His max health is 75.", //2
            "His max stamina is 50.", //3
            "His max mana is 175." //4
        };
        public static string[] ThiefInfo =
        {
            "The thief is wellrounded.", //1
            "His max health is 100.", //2
            "His max stamina is 100.", //3
            "His max mana is 100." //4
        };
    }
}
