using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGame
{

    class Program {
        static void Main (string [] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Welcome to the C# Console Dungeon! In this game, you will choose a class and attempt to eliminate as many monsters as possible in the dungeon. Pease select an option:");
                Console.WriteLine("1) New Game \n" + "2) Exit Game");
                string playInput = Console.ReadLine();
                Character newChar = new Character();
                switch (playInput)
                {
                    case "1":
                    CharacterCreate.createCharacter(newChar);
                    running = true;
                    break;
                    case "2":
                    Console.WriteLine("Thank you for playing! Press enter to exit");
                    Console.ReadLine();
                    running = false;
                    return;
                    default:
                    Console.WriteLine("I'm sorry. It seems you did not enter a valid option. Press enter to continue to Character Creation.");
                    Console.ReadLine();
                    CharacterCreate.createCharacter(newChar);
                    running = true;
                    break;
                }
                Console.WriteLine($"Well done {newChar.Name}! You have chosen to be a {newChar.charClass}! Prepare for your adventure to begin! Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Monster monster = new Monster ();
                monsterHealth health = new monsterHealth();
                Damage damage = new Damage();
                int totalMonsterKills = 0;
                do 
                {
                    string randomMonster = monster.chooseRandomMonster();
                    int randommonsterHealth = health.randomHealth();
                    Console.Clear();
                    Console.WriteLine($"While traversing through the dungeon you encounter a {randomMonster} with {randommonsterHealth} HP. You get to attack first! Press 1 to attack it or 2 to flee to the next monster. ");
                    string attackIt = Console.ReadLine();
                    if (attackIt =="1")
                    {
                        do 
                        {
                            int randomDamageDone = damage.randomDamage();
                            randommonsterHealth = randommonsterHealth - newChar.Damage;
                            newChar.Health = newChar.Health - randomDamageDone;
                            Console.WriteLine($"{newChar.charAttack}{randomMonster} for {newChar.Damage} damage. It hits you for {randomDamageDone} damage.  It now has {randommonsterHealth} health remaining. Press enter to continue.");
                            Console.ReadLine();
                            if (randommonsterHealth <= 0 && newChar.Health >= 0)
                            {
                            totalMonsterKills = totalMonsterKills + 1;
                            Console.WriteLine($"You eliminated the {randomMonster}! You have now eliminated {totalMonsterKills} monsters and have {newChar.Health} HP remaining! Press enter to continue through the dungeon.");
                            Console.ReadLine();
                            }

                        } while (randommonsterHealth > 0 && newChar.Health > 0);
                        if (totalMonsterKills % 5 == 0)
                        {
                            newChar.Health = newChar.Health + 100;
                            Console.Clear();
                            Console.WriteLine("You pause and rest for a few minutes and regain 100 life points. Press enter to continue on to the next room.");
                            Console.ReadLine();
                        }
                    }
                    else if(attackIt == "2")
                    {
                        Console.WriteLine("You run away from the monster! Press enter to continue. ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("I'm not sure what you are trying to do. Press enter to continue to a new monster. ");
                        Console.ReadLine();
                    }
                } while (newChar.Health > 0);
                int finalScore = totalMonsterKills * 100;
                Console.Clear();
                Console.WriteLine($"Oh no you have fallen in battle. Game Over! You eliminated {totalMonsterKills} monsters! Your final score was {finalScore}.");
                Console.WriteLine("------------THE END------------");
                Console.WriteLine("COPYRIGHT 2022 EILERS ALBACETE LLC.");
                Console.WriteLine("Press enter to return to the Main Menu.");
                Console.ReadLine();
            }
        }
    }
    public class CharacterCreate
    {
        public static void createCharacter(Character newChar)
        {
            Console.Clear();
            Console.WriteLine("Please choose a character name: ");
            newChar.Name = Console.ReadLine();

            Console.WriteLine($"Welcome {newChar.Name}!\n" + "There are three classes: Warrior, Mage, and Rogue. Warriors have high health and low damage. Mages have high damage and low health. Rogues have medium health and medium damage.\n" + "Please choose your character class (Enter 1-3): ");
            Console.WriteLine("1) Warrior");
            Console.WriteLine("2) Mage");
            Console.WriteLine("3) Rogue");
            string charClass = Console.ReadLine();
            switch (charClass)
            {
                case "1":
                newChar.charClass = "Warrior";
                break;
                case "2":
                newChar.charClass = "Mage";
                break;
                case "3":
                newChar.charClass = "Rogue";
                break;
                default:
                Console.WriteLine("I'm sorry. It seems you did not enter a valid option. Please try again. Press enter to return to Character Creation.");
                Console.ReadLine();
                CharacterCreate.createCharacter(newChar);
                break;
            }
            Character.classOption(newChar);


        }
    }
    public class Character
    {
        public string Name;
        public int Health;
        public int Damage;
        public string charClass;
        public string charAttack;
        
        public static void classOption(Character newChar)
        {
             switch (newChar.charClass)
             {
                 case "Warrior":
                 newChar.Health = 400;
                 newChar.Damage = 200;
                 newChar.charAttack = "You swing your sword at the ";
                 break;
                 case "Mage":
                 newChar.Health = 200;
                 newChar.Damage = 400;
                 newChar.charAttack = "You cast a fireball at the ";
                 break;
                 case "Rogue":
                 newChar.Health = 300;
                 newChar.Damage = 300;
                 newChar.charAttack = "You swing your daggers at the ";
                 break;
             }
        }
       
    }
    public class Monster 
    {
        public int monsterHealth;

        Random _random = new Random();
        public string chooseRandomMonster()
        {
                string[] monsterType = new string[] {"Zombie", "Baby Zombie", "Wolf", "Angry Chicken", "Deerbra", "Raptor", "Wyvern", "Centaur", "Elemental", "Lizardman","Dragon"};
                int randomNumber = _random.Next(0, monsterType.Length);
                string randomType = monsterType.ElementAt(randomNumber);
                // Console.WriteLine(randomType);
                return randomType;
        }
    }
    public class Damage
    {
        Random dmg = new Random();
        public int randomDamage()
        {
            int [] monsterDmg = new int[] {5, 10, 15, 20, 30};
            int randomdmgNumber = dmg.Next(0, monsterDmg.Length);
            int damageDone = monsterDmg.ElementAt(randomdmgNumber);
            return damageDone;
        }
    }
    public class monsterHealth
    {
        Random health = new Random();
        public int randomHealth()
        {
            int [] monsterHP = new int[] {200, 400, 600, 800, 1000};
            int totalHP = health.Next(0, monsterHP.Length);
            int monsterHealth = monsterHP.ElementAt(totalHP);
            return monsterHealth;
        }
    }
}