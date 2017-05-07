using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Variables.Monsters
{
    class Goblin : BaseMonster
    {
        protected new string MonsterName { get; set; }
        protected new int MonsterMaxHealth { get; set; }
        protected new int MonsterCurrentHealth { get; set; }
       Goblin(string name="Goblin", int health=25)
        {
            MonsterName = name;
            MonsterMaxHealth = health;
            MonsterCurrentHealth = health;
        }

        protected override void AddAttackToQueue(object Target, object Attack)
        {
            
        }

        protected override void Announce()
        {

        }

        protected override void Attack()
        {
            
        }

        protected override void CheckForDeath()
        {
            if (MonsterCurrentHealth == 0)
            {

            }
        }

        protected override void SpecialAttack1()
        {
            
        }

    }
}
