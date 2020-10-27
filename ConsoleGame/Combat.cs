using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Combat
    {

        public int Attack(int toHit, int defense, int maxDamage )
        {
            Random randy = new Random();
            if (randy.Next(1, 21) + toHit>=defense)
            {
                return randy.Next(1, (maxDamage+1));//1 added so reflect the actual MaxDamage
            }else
            {
                return 0; // If they miss they will return 0 damage 
            }
        }
    }
}
