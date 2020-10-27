using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {

        static void Main(string[] args)
        {
            ColorsConsole console = new ColorsConsole();           //RegularConsole console = new RegularConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Welcome();

            // Name ToHit/BonusHit DamageRoll/Multiplier Health
            //hero dash = new hero("dash", 3, 15);
            //bandit keith = new bandit("bandit keith", 1, 5);
            //bandit ben = new bandit("bandit ben", 2, 8);
            //knight leeroy = new knight("knight leeroy", 3, 12);
            //knight seth = new knight("knight seth", 5, 15);
            //dragon bluedrag = new dragon("blue dragon", 7, 20, 2);
            //dragon reddrag = new dragon("red dragon", 8, 20, 3);
            //dragon blackdrag = new dragon("black dragon", 10, 25, 4);

            //story.beforebandits();
            //battle.withbandit(dash, keith);
            //battle.withbandit(dash, ben);
            //dash.levelup();

            //story.beforeknights();
            //battle.withknight(dash, leeroy);
            //battle.withknight(dash, seth);
            //dash.levelup();

            //story.beforedragons();
            //battle.withdragon(dash, bluedrag);
            //battle.withdragon(dash, reddrag);
            //battle.withdragon(dash, blackdrag);
            //story.theend();


        }
    }
}
