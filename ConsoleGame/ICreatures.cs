using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public interface ICreatures
    {
        // Name ToHit/BonusHit DamageRoll/Multiplier Health
        string Name { get; }
        int ToHit { get; }
        int MaxDamage { get;  }
        int Defense { get; }
        int MaxHealth { get; }
        int CurrentHealth { get; }

    }
}
