using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCSharp1.Variables.Monsters
{
    abstract class BaseMonster
    {
        protected string MonsterName { get; set; }
        protected int MonsterMaxHealth { get; set; }
        protected int MonsterCurrentHealth { get; set; }
        abstract protected void Announce();
        abstract protected void AddAttackToQueue(object Target, object Attack);
        abstract protected void CheckForDeath();
        abstract protected void Attack();
        abstract protected void SpecialAttack1();
    }
}
