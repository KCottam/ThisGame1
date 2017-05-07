using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GameInCSharp1.Scripts.Battle
{
    class BattleSequence
    {
        public BattleSequence()
        {
            string str = "Some text";
            File.Create("BattleQueue.txt");

            Console.WriteLine("<Please press enter.>");
            Console.ReadLine();
        }

/*
         ~BattleSequence()
        {
            File.Delete(@"BattleQueue.txt");
        } */
    }
}
