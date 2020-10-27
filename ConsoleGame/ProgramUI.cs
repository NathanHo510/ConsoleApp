using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class ProgramUI
    {
        private ColorsConsole _console;
        public ProgramUI(ColorsConsole console)
        {
            _console = console;
        }
        private Dash _dash = new Dash(20, 5);
        public void Welcome()
        {
            _console.Clear();

            _console.WriteLine("Welcome to the Tower Of DEATH!");
            _console.WriteLine("created by Orange Okapi");
            _console.ReadKey();
            Room1();
        }
        public void Room1()
        {
            _console.Clear();
            _console.WriteLine("You enter the first floor of the Tower and come across a Bandit.\n" + "What do you do? Select a type by pressing the cooresponding number.");
            _console.WriteLineOptions("1. Attack\n2. Talk\n3. Run");
            string response = _console.ReadLine();
            while (true)
            {
                switch (response)
                {
                    case "1":
                        Fight1();
                        break;
                    case "2":
                        _console.WriteLine("Bandit: I'd rather fight!");
                        _console.ReadKey();
                        Fight1();
                        break;
                    case "3":
                        _console.WriteLineDamage("The bandit hits your from behind for 3 damage!");
                        _dash.CurrentHealth = _dash.CurrentHealth - 3;
                        _console.ReadKey();
                        Fight1();
                        break;
                    default:
                        _console.WriteLine("Invalid input, please chose an option below!");
                        _console.WriteLineOptions("1. Attack\n2. Talk\n3. Run");
                        response = _console.ReadLine();
                        break;
                }
            }
        }
        public void Room2()
        {
            _console.Clear();
            _console.WriteLine("After defeating the Bandit, you run into the Bandit Leader!\n" + " He looks at you dead in the eyes, waiting for you to make the first move.\n" + " How will you approach him? Select a type by pressing the cooresponding number.");
            _console.WriteLineOptions("1. Attack\n2. Run");
            string response = _console.ReadLine();
            while (true)
            {
                switch (response)
                {
                    case "1":
                        Fight2();
                        break;
                    case "2":
                        _console.WriteLineDamage("The Bandit Leader hits you from behind for 3 damage!");
                        _dash.CurrentHealth = _dash.CurrentHealth - 3;
                        _console.ReadKey();
                        Fight2();
                        break;
                    default:
                        _console.WriteLine("Invalid input, please chose an option below!");
                        _console.WriteLineOptions("1. Attack\n2. Run");
                        response = _console.ReadLine();
                        break;
                }
            }
        }
        public void Room3()
        {
            _console.Clear();
            _console.WriteLine("After defeating the Bandit Leader, you start to wonder if what you came here for is even worth it.\n" + "You catch your breath for a moment, only to walk into the next room to find an Ogre! He stands feet above you, looking down upon you as if you are nothing.\n" + "How will you approach it? Select a type by pressing the cooresponding number.");
            _console.WriteLineOptions("1. Attack\n2. Run");
            string response = _console.ReadLine();
            while (true)
            {
                switch (response)
                {
                    case "1":
                        Fight3();
                        break;
                    case "2":
                        _console.WriteLineDamage("The Ogre hits you from behind for 3 damage!");
                        _dash.CurrentHealth = _dash.CurrentHealth - 3;
                        _console.ReadKey();
                        Fight3();
                        break;
                    default:
                        _console.WriteLine("Invalid input, please chose an option below!");
                        _console.WriteLineOptions("1. Attack\n2. Run");
                        response = _console.ReadLine();
                        break;
                }
            }
        }
        public void Fight1()
        {
            Combat combat = new Combat();
            Bandits _bandits = new Bandits();
            int enemyHP = _bandits.MaxHealth;
            _console.WriteLine($"You have entered combat with the Bandit");
            string input;
            int damage;
            while (_dash.CurrentHealth >= 0 && enemyHP >= 0)
            {
                _console.WriteLine("Choose what to do!");
                _console.WriteLineOptions($"1. Attack \n2. Heal for (5), you have {_dash.HpPot}");
                input = _console.ReadLine();
                if (input == "1")
                {
                    damage = combat.Attack(_dash.ToHit, _bandits.Defense, _dash.MaxDamage);
                    _console.WriteLineDamage($"You have dealt {damage}\n");
                    enemyHP = enemyHP - damage;
                    _console.WriteLineEnemy($"Bandit HP{enemyHP}\n");
                }
                else if (input == "2")
                {
                    Healing();
                }
                else
                {
                    _console.WriteLine("Not a valid input, you lose your turn.");
                }
                if (enemyHP >= 0)
                {
                    _console.WriteLine("The bandit attacks!");
                    damage = combat.Attack(_bandits.ToHit, _dash.Defense, _bandits.MaxDamage);
                    _console.WriteLineDamage($"Bandits have dealt {damage}\n");
                    _dash.CurrentHealth = _dash.CurrentHealth - damage;
                    _console.WriteLineDash($"Dash HP{_dash.CurrentHealth}\n");
                }

            }
            if (_dash.CurrentHealth <= 0)
            {
                Death();
            }
            else
            {
                _console.Clear();
                _dash.CurrentHealth = _dash.CurrentHealth;
                _console.WriteLine($"You defeted the bandit! Dash's current hp is:{_dash.CurrentHealth}\n press any key to continue to the next room.");
                _console.ReadKey();
                Room2();
            }

        }
        public void Fight2()
        {
            Combat combat = new Combat();
            BanditLeader _banditLeader = new BanditLeader();
            int enemyHP = _banditLeader.MaxHealth;
            _console.WriteLine($"You have entered combat with the Bandit Leader");
            string input;
            int damage;
            while (_dash.CurrentHealth >= 0 && enemyHP >= 0)
            {
                _console.WriteLine("Choose what to do!");
                _console.WriteLineOptions($"1. Attack \n2. Heal for (5), you have {_dash.HpPot}");
                input = _console.ReadLine();
                if (input == "1")
                {
                    damage = combat.Attack(_dash.ToHit, _banditLeader.Defense, _dash.MaxDamage);
                    _console.WriteLineDamage($"You have dealt {damage}\n");
                    enemyHP = enemyHP - damage;
                    _console.WriteLineEnemy($"Bandit Leader HP{enemyHP}\n");
                }
                else if (input == "2")
                {
                    Healing();
                }
                else
                {
                    _console.WriteLine("Not a valid input, you lose your turn.");
                }
                if (enemyHP >= 0)
                {
                    _console.WriteLine("The Bandit Leader attacks!");
                    damage = combat.Attack(_banditLeader.ToHit, _dash.Defense, _banditLeader.MaxDamage);
                    _console.WriteLineDamage($"Bandit Leader has dealt {damage}\n");
                    _dash.CurrentHealth = _dash.CurrentHealth - damage;
                    _console.WriteLineDash($"Dash HP{_dash.CurrentHealth}\n");
                }
            }
            if (_dash.CurrentHealth <= 0)
            {
                Death();
            }
            else
            {
                _console.Clear();
                _dash.CurrentHealth = _dash.CurrentHealth;
                _console.WriteLine($"You defeted the Bandit Leader! Dash's current hp is:{_dash.CurrentHealth}\n press any key to continue to the next room.");
                _console.ReadKey();
                Room3();
            }
        }
        public void Fight3()
        {
            Combat combat = new Combat();
            Ogres _ogres = new Ogres();
            int enemyHP = _ogres.MaxHealth;
            _console.WriteLine($"You have entered combat with the Ogre");
            string input;
            int damage;
            while (_dash.CurrentHealth >= 0 && enemyHP >= 0)
            {
                _console.WriteLine("Choose what to do!");
                _console.WriteLineOptions($"1. Attack \n2. Heal for (5), you have {_dash.HpPot}");
                input = _console.ReadLine();
                if (input == "1")
                {
                    damage = combat.Attack(_dash.ToHit, _ogres.Defense, _dash.MaxDamage);
                    _console.WriteLineDamage($"You have dealt {damage}\n");
                    enemyHP = enemyHP - damage;
                    _console.WriteLineEnemy($"Ogre's HP{enemyHP}\n");
                }
                else if (input == "2")
                {
                    Healing();
                }
                else
                {
                    _console.WriteLine("Not a valid input, you lose your turn.");
                }
                if (enemyHP >= 0)
                {
                    _console.WriteLine("The Orge attacks!");
                    damage = combat.Attack(_ogres.ToHit, _dash.Defense, _ogres.MaxDamage);
                    _console.WriteLineDamage($"The Ogre has dealt {damage}\n");
                    _dash.CurrentHealth = _dash.CurrentHealth - damage;
                    _console.WriteLineDash($"Dash HP{_dash.CurrentHealth}\n");
                }
            }
            if (_dash.CurrentHealth <= 0)
            {
                Death();
            }
            else
            {
                _console.Clear();
                _console.WriteLineVictory($"Congratulations! You defeted the Mighty Orge!\n Dash saved the princess!");
                _console.ReadKey();
            }
        }
        public void Death()
        {
            _console.Clear();
            _console.WriteLineDeath("Dash has died and his story is over!");
            _console.ReadKey();
        }
        public void Healing()
        {
            int potAmount = 5;
            if (_dash.CurrentHealth == _dash.MaxHealth && _dash.HpPot > 0)
            {
                _console.WriteLineHealing("You're already at full health! You lose your turn");
            }
            else if (_dash.CurrentHealth > _dash.MaxHealth - 4 && _dash.HpPot > 0)
            {
                _dash.HpPot -= 1;
                _dash.CurrentHealth = _dash.MaxHealth;
                _console.WriteLineHealing($"You overhealed! HP set to 20.");

            }
            else if (_dash.HpPot <= 0)
            {
                _console.WriteLineHealing("You're out of Health Pots! You lose your turn");
            }
            else
            {
                _dash.HpPot -= 1;
                _dash.CurrentHealth += potAmount;
                _console.WriteLineHealing($"You healed to {_dash.CurrentHealth}.");
            }
        }
    }
}