using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class ColorsConsole
    {
        private Random _random = new Random();
        public void Clear()
        {
            Console.Clear();
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
        public void WriteLine(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(s);
        }
        public void WriteLineDamage(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
        }
        public void WriteLineHealing(string s)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
        }
        public void WriteLineDeath(string s)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
        }
        public void WriteLineDash(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
        }
        public void WriteLineEnemy(string s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
        }
        public void WriteLineOptions(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
        }
        public void WriteLineVictory(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(s);
        }


        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
        public void Write(string s)
        {
            Console.Write(s);
        }
    }
}