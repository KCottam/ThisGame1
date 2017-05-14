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
        string monsterName;
        int monsterHealth;
        int monsterDamage;
        bool BattleIsOver = false;
        int turn = 1;
        int playerSpecial = 1;
        Random damageModifier = new Random();
        public BattleSequence(string monsterNameIn, int monsterHealthIn, int monsterDamageIn)
        {
            //            File.Create("BattleQueue.txt");
            monsterName = monsterNameIn;
            monsterHealth = monsterHealthIn;
            monsterDamage = monsterDamageIn;

            Variables.Monsters.Monster monster = new Variables.Monsters.Monster(monsterName, monsterDamage, monsterHealth);
            Console.Clear();
            Console.WriteLine(BattleText.EngagedInCombat, monsterName);
            InputLine();

            do
            {
                Console.WriteLine("Attacking restores mana and uses stamina.");
                Console.WriteLine("Resting restores stamina.");
                Console.WriteLine("Healing restores health and uses mana.");
                Console.WriteLine();
                WriteBattleInfo();
                DoPlayerAttack();
                DoMonsterAttack();
                turn++;
            } while (BattleIsOver != true);
            if(Variables.PlayerVariables.HeroCurrentHealth <= 0)
            {
                Console.WriteLine("You have died.");
            } else
            {
                Console.WriteLine("You have won!");
            }
        }

        private void WriteBattleInfo()
        {
            //Console.WriteLine();
            Console.WriteLine(BattleText.yourHealth, Variables.PlayerVariables.HeroCurrentHealth,Variables.PlayerVariables.HeroMaxHealth);
            Console.WriteLine(BattleText.yourMana, Variables.PlayerVariables.HeroCurrentMana,Variables.PlayerVariables.HeroMaxMana);
            Console.WriteLine(BattleText.yourStamina, Variables.PlayerVariables.HeroCurrentStamina,Variables.PlayerVariables.HeroMaxStamina);
            Console.WriteLine();
            Console.WriteLine(BattleText.monsterHealth, monsterName, monsterHealth);
        }
        private void DoMonsterAttack()
        {
            
            int rnd = damageModifier.Next(-monsterDamage / 2, monsterDamage / 2);
            if (turn % 10 == 0)
            {
                monsterHealth += (monsterDamage+rnd) * 2;
                
                Console.WriteLine("{0} heals itself for {1} health!",monsterName,(monsterDamage+rnd)*2);
                InputLine();
                Console.Clear();
            }
            else if (turn % 3 == 0)
            {
                Variables.PlayerVariables.HeroCurrentHealth -= (monsterDamage+rnd) * 15/10;
                Console.WriteLine("{0} launches a special attack!", monsterName);
                Console.WriteLine("You take {0} damage!", (monsterDamage+rnd) * 15/10);
                InputLine();
                Console.Clear();
                if (Variables.PlayerVariables.HeroCurrentHealth <= 0)
                {
                    BattleIsOver = true;
                }
            }
            else if (turn % 1 == 0)
            {
                Variables.PlayerVariables.HeroCurrentHealth -= (monsterDamage+rnd);
                Console.WriteLine("You have been hit for {0} damage!", (monsterDamage+rnd));
                InputLine();
                Console.Clear();
                if (Variables.PlayerVariables.HeroCurrentHealth <= 0)
                {
                    BattleIsOver = true;
                }
            }

        }

        private void DoPlayerAttack()
        {
            Console.WriteLine(BattleText.DoAnAttack);
            Console.WriteLine(BattleText.attackLabel);
            Console.WriteLine(BattleText.restLabel);
            Console.WriteLine(BattleText.specialLabel);

            var playerAttacks = false;

            do
            {
                var playerChoice = Console.ReadLine();
                switch (playerChoice)
                {
                    case "1":
                        int rnd = damageModifier.Next(-Variables.PlayerVariables.HeroDamage / 2, Variables.PlayerVariables.HeroDamage / 2);
                        if (Variables.PlayerVariables.HeroCurrentStamina - 25 < 0)
                        {
                            Console.WriteLine("You are out of stamina!");
                            InputLine();
                            playerAttacks = true;

                        }
                        else
                        {
                            if (playerSpecial % 5 == 0)
                            {
                                Variables.PlayerVariables.HeroCurrentStamina -= 25;
                                monsterHealth -= (Variables.PlayerVariables.HeroDamage+rnd)*3;
                                if (monsterHealth <= 0)
                                {
                                    BattleIsOver = true;
                                }
                                Variables.PlayerVariables.HeroCurrentMana += 50;
                                Console.WriteLine("You did a special attack!");
                                Console.WriteLine("You hit {0} for {1} damage!", monsterName, (rnd+Variables.PlayerVariables.HeroDamage)*3);

                                if (Variables.PlayerVariables.HeroCurrentMana > Variables.PlayerVariables.HeroMaxMana)
                                {
                                    Variables.PlayerVariables.HeroCurrentMana = Variables.PlayerVariables.HeroMaxMana;
                                }
                                playerSpecial++;
                            }
                            else if (playerSpecial % 1 == 0)
                            {
                                Variables.PlayerVariables.HeroCurrentStamina -= 25;
                                monsterHealth -= (Variables.PlayerVariables.HeroDamage+rnd);
                                if (monsterHealth <= 0)
                                {
                                    BattleIsOver = true;
                                }
                                Variables.PlayerVariables.HeroCurrentMana += 50;
                                Console.WriteLine("You hit {0} for {1} damage!", monsterName, (Variables.PlayerVariables.HeroDamage+rnd));

                                if (Variables.PlayerVariables.HeroCurrentMana > Variables.PlayerVariables.HeroMaxMana)
                                {
                                    Variables.PlayerVariables.HeroCurrentMana = Variables.PlayerVariables.HeroMaxMana;
                                }
                                playerSpecial++;
                            }
                            playerAttacks = true;
                            InputLine();
                        }
                        break;

                    default:
                        Variables.PlayerVariables.HeroCurrentStamina += 50;
                        Console.WriteLine("You have gained 50 stamina!");
                        playerAttacks = true;
                        if (Variables.PlayerVariables.HeroCurrentStamina > Variables.PlayerVariables.HeroMaxStamina)
                        {
                            Variables.PlayerVariables.HeroCurrentStamina = Variables.PlayerVariables.HeroMaxStamina;
                        }
                        InputLine();
                        break;

                    case "3":
                        if (Variables.PlayerVariables.HeroCurrentMana - 25 < 0)
                        {
                            Console.WriteLine("You have no mana!");
                            InputLine();
                            playerAttacks = true;
                        }
                        else
                        {
                            Variables.PlayerVariables.HeroCurrentMana -= 25;
                            Variables.PlayerVariables.HeroCurrentHealth += 50;
                            Console.WriteLine("You have gained 50 health!");
                            if (Variables.PlayerVariables.HeroCurrentHealth > Variables.PlayerVariables.HeroMaxHealth)
                            {
                                Variables.PlayerVariables.HeroCurrentHealth = Variables.PlayerVariables.HeroMaxHealth;
                            }
                            InputLine();
                        }
                        playerAttacks = true;
                        break;

                }
            } while (playerAttacks != true);
        }
        private static void InputLine()
        {
            Console.WriteLine("<Please press enter.>");
            Console.ReadLine();
        }

        

    }
}
