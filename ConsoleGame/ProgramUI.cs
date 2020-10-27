using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class ProgramUI
    {
        private Dash _dash = new Dash(20, 5);
        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tower Of DEATH!\n" +
                "created by Orange Okapi");
            Console.ReadKey();
            Room1();
        }
        public void Room1()
        {
            Console.Clear();
            Console.WriteLine("You enter the first floor of the Tower and come across a Bandit. What do you do? Select a type by pressing the cooresponding number.");
            Console.WriteLine("1. Attack 2. Talk 3. Run");
            string response = Console.ReadLine();
            while (true)
            {
                switch (response)
                {
                    case "1":
                        Fight1();
                        break;
                    case "2":
                        Console.WriteLine("Bandit: I'd rather fight!");
                        Console.ReadKey();
                        Fight1();
                        break;
                    case "3":
                        Console.WriteLine("The bandit hits your from behind for 3 damage!");
                        _dash.CurrentHealth = _dash.CurrentHealth - 3;
                        Console.ReadKey();
                        Fight1();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please chose an option below!");
                        Console.WriteLine("1. Attack 2. Talk 3. Run");
                        response = Console.ReadLine();
                        break;
                }
            }
        }
        public void Room2()
        {
            Console.Clear();
            Console.WriteLine("After defeating the Bandit, you run into the Bandit Leader! He looks at you dead in the eyes, waiting for you to make the first move. How will you approach him? Select a type by pressing the cooresponding number.");
            Console.WriteLine("1. Attack 2. Run");
            string response = Console.ReadLine();
            while (true)
            {
                switch (response)
                {
                    case "1":
                        Fight2();
                        break;
                    case "2":
                        Console.WriteLine("The Bandit Leader hits you from behind for 3 damage!");
                        _dash.CurrentHealth = _dash.CurrentHealth - 3;
                        Console.ReadKey();
                        Fight2();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please chose an option below!");
                        Console.WriteLine("1. Attack 3. Run");
                        response = Console.ReadLine();
                        break;
                }
            }
        }
        public void Room3()
        {
            Console.Clear();
            Console.WriteLine("After defeating the Bandit Leader, you start to wonder if what you came here for is even worth it. You catch your breath for a moment, only to walk into the next room to find an Ogre! He stands feet above you, looking down upon you as if you are nothing. How will you approach it? Select a type by pressing the cooresponding number.");
            Console.WriteLine("1. Attack 2. Run");
            string response = Console.ReadLine();
            while (true)
            {
                switch (response)
                {
                    case "1":
                        Fight3();
                        break;
                    case "2":
                        Console.WriteLine("The Ogre hits you from behind for 3 damage!");
                        _dash.CurrentHealth = _dash.CurrentHealth - 3;
                        Console.ReadKey();
                        Fight3();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please chose an option below!");
                        Console.WriteLine("1. Attack 2. Run");
                        response = Console.ReadLine();
                        break;
                }
            }
        }
        public void Fight1()
        {
            Combat combat = new Combat();
            Bandits _bandits = new Bandits();
            int enemyHP = _bandits.MaxHealth;
            Console.WriteLine($"You have entered combat with the Bandit");
            string input;
            int damage;
            while (_dash.CurrentHealth >= 0 && enemyHP >= 0)
            {
                Console.WriteLine("Choose what to do!");
                Console.WriteLine($"1. Attack 2. Heal for (5), you have {_dash.HpPot}");
                input = Console.ReadLine();
                if (input == "1")
                {
                    damage = combat.Attack(_dash.ToHit, _bandits.Defense, _dash.MaxDamage);
                    Console.WriteLine($"You have dealt {damage}\n");
                    enemyHP = enemyHP - damage;
                    Console.WriteLine($"Bandit HP{enemyHP}\n");
                }
                else if (input == "2")
                {
                    Healing();
                }
                else
                {
                    Console.WriteLine("Not a valid input, you lose your turn.");
                }
                if (enemyHP >= 0)
                {
                    Console.WriteLine("The bandit attacks!");
                    damage = combat.Attack(_bandits.ToHit, _dash.Defense, _bandits.MaxDamage);
                    Console.WriteLine($"Bandits have dealt {damage}\n");
                    _dash.CurrentHealth = _dash.CurrentHealth - damage;
                    Console.WriteLine($"Dash HP{_dash.CurrentHealth}\n");
                }

            }
            if (_dash.CurrentHealth <= 0)
            {
                Console.Clear();
                Console.WriteLine("Dash has died and his story is over!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                _dash.CurrentHealth = _dash.CurrentHealth;
                Console.WriteLine($"You defeted the bandit!/n Dash's current hp is:{_dash.CurrentHealth}\n press any key to continue to the next room.");
                Console.ReadKey();
                Room2();
            }

        }
        public void Fight2()
        {
            Combat combat = new Combat();
            BanditLeader _banditLeader = new BanditLeader();
            int enemyHP = _banditLeader.MaxHealth;
            Console.WriteLine($"You have entered combat with the Bandit Leader");
            string input;
            int damage;
            while (_dash.CurrentHealth >= 0 && enemyHP >= 0)
            {
                Console.WriteLine("Choose what to do!");
                Console.WriteLine($"1. Attack 2. Heal for (5), you have {_dash.HpPot}");
                input = Console.ReadLine();
                if (input == "1")
                {
                    damage = combat.Attack(_dash.ToHit, _banditLeader.Defense, _dash.MaxDamage);
                    Console.WriteLine($"You have dealt {damage}\n");
                    enemyHP = enemyHP - damage;
                    Console.WriteLine($"Bandit Leader HP{enemyHP}\n");
                }
                else if (input == "2")
                {
                    Healing();
                }
                else
                {
                    Console.WriteLine("Not a valid input, you lose your turn.");
                }
                if (enemyHP >= 0)
                {
                    Console.WriteLine("The Bandit Leader attacks!");
                    damage = combat.Attack(_banditLeader.ToHit, _dash.Defense, _banditLeader.MaxDamage);
                    Console.WriteLine($"Bandit Leader has dealt {damage}\n");
                    _dash.CurrentHealth = _dash.CurrentHealth - damage;
                    Console.WriteLine($"Dash HP{_dash.CurrentHealth}\n");
                }
            }
            if (_dash.CurrentHealth <= 0)
            {
                Console.Clear();
                Console.WriteLine("Dash has died and his story is over!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                _dash.CurrentHealth = _dash.CurrentHealth;
                Console.WriteLine($"You defeted the Bandit Leader!/n Dash's current hp is:{_dash.CurrentHealth}\n press any key to continue to the next room.");
                Console.ReadKey();
                Room2();
            }
        }
        public void Fight3()
        {
            Combat combat = new Combat();
            Ogres _ogres = new Ogres();
            int enemyHP = _ogres.MaxHealth;
            Console.WriteLine($"You have entered combat with the");
            string input;
            int damage;
            while (_dash.CurrentHealth >= 0 && enemyHP >= 0)
            {
                Console.WriteLine("Choose what to do!");
                Console.WriteLine($"1. Attack 2. Heal for (5), you have {_dash.HpPot}");
                input = Console.ReadLine();
                if (input == "1")
                {
                    damage = combat.Attack(_dash.ToHit, _ogres.Defense, _dash.MaxDamage);
                    Console.WriteLine($"You have dealt {damage}\n");
                    enemyHP = enemyHP - damage;
                    Console.WriteLine($"Bandit Leader HP{enemyHP}\n");
                }
                else if (input == "2")
                {
                    Healing();
                }
                else
                {
                    Console.WriteLine("Not a valid input, you lose your turn.");
                }
                if (enemyHP >= 0)
                {
                    Console.WriteLine("The Orge attacks!");
                    damage = combat.Attack(_ogres.ToHit, _dash.Defense, _ogres.MaxDamage);
                    Console.WriteLine($"The Ogre has dealt {damage}\n");
                    _dash.CurrentHealth = _dash.CurrentHealth - damage;
                    Console.WriteLine($"Dash HP{_dash.CurrentHealth}\n");
                }
            }
            if (_dash.CurrentHealth <= 0)
            {
                Console.Clear();
                Console.WriteLine("Dash has died and his story is over!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Congratulations! You defeted the Mighty Orge!/n Dash saved the princess!");
                Console.ReadKey();
            }
        }
        public void Healing()
        {
            int potAmount = 5;
            if (_dash.CurrentHealth == _dash.MaxHealth && _dash.HpPot > 0)
            {
                Console.WriteLine("You're already at full health! You lose your turn");
            }
            else if (_dash.CurrentHealth > _dash.MaxHealth - 4 && _dash.HpPot > 0)
            {
                _dash.HpPot -= 1;
                _dash.CurrentHealth = _dash.MaxHealth;
                Console.WriteLine($"You overhealed! HP set to 20.");

            }
            else if (_dash.HpPot <= 0)
            {
                Console.WriteLine("You're out of Health Pots! You lose your turn");
            }
            else
            {
                _dash.HpPot -= 1;
                _dash.CurrentHealth += potAmount;
                Console.WriteLine($"You healed to {_dash.CurrentHealth}.");
            }
        }
    }
}