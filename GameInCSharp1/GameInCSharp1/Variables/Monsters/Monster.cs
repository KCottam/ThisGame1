using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Variables.Monsters
{
    class Monster
    {
        int monsterHealth;
        string monsterName;
        int monsterDamage;

        public Monster(string name, int damage, int health)
        {
            monsterName = name;
            monsterDamage = damage;
            monsterHealth = health;
        }

        void DoMonsterAttack()
        {

        }
    }
}
