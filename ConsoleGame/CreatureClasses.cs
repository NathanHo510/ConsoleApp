using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Dash : ICreatures
    {
        public string Name => "Dash";
        public int ToHit => 3;
        public int MaxDamage => 9;
        public int Defense => 15;
        public int MaxHealth => 20;
        public int CurrentHealth { get; set; }
        public int HpPot { get; set; }
        //public int Levels { get; set; }
        //public int Exp { get; set; } // 1   2|300 3|900 4|2700 5|6500 6|14000 7|23000 8|34000 9|48000 10|64000
        //public string Weapon { get; set; }
        //public string Armor { get; set; }
        //Potential Special Attack
        public Dash(int currentHealth, int hPPot)
        {
            CurrentHealth = currentHealth;
            HpPot = hPPot;
        }
    }
    public class Bandits : ICreatures //Challenge rating = 1/8
    {
        public string Name { get; set; }
        public int ToHit => 3;
        //Remember max number in random is 1-7 vvvv
        public int MaxDamage => 3;
        public int Defense => 12;
        public int MaxHealth => 11;
        public int CurrentHealth { get { return MaxHealth; } set { } }
    }
    public class BanditLeader : ICreatures //Challenge rating = 1
    {
        public string Name => "Dane";
        public int ToHit => 3;
        public int MaxDamage => 4;
        public int Defense => 13;
        public int MaxHealth => 25;
        public int CurrentHealth => MaxHealth;
    }
    public class Ogres : ICreatures //Challenge rating = 2.5
    {
        public string Name { get; set; }
        public int ToHit => 4;
        public int MaxDamage => 5;
        public int Defense => 11;
        public int MaxHealth => 35;
        public int CurrentHealth => MaxHealth;
    }
}
//    public class OgreWarLord : ICreatures //Challenge rating = 10
//        //Has a high pitch voice 
//    {
//        public string Name => "Logar The O-gar ";
//        public int ToHit => 10;
//        public int MaxDamage => 36;
//        public int Defense => 18;
//        public int MaxHealth => 133;
//        public int CurrentHealth => MaxHealth;
//        public int Exp => 5900;
//    }
//    public class Knight : ICreatures //Challenge rating = 3
//    {
//        //A damsel in distress, turns out to be a boss fight if you try to rob her. :)
//        public string Name => "Elizabeth";
//        public int ToHit => 7;
//        public int MaxDamage => 15;
//        public int Defense => 18;
//        public int MaxHealth => 50;
//        public int CurrentHealth => MaxHealth;
//        public int Exp => 700;
//    }
//    public class FinalDragon : ICreatures //Challenge rating = 17
//    {
//        public string Name => "Blaze";
//        public int ToHit => 14;
//        public int MaxDamage => 40;
//        public int Defense => 19;
//        public int MaxHealth => 256;
//        public int CurrentHealth => MaxHealth;
//        //Potential Special Attack
//        public int Exp => 18000;
//    }
//}
