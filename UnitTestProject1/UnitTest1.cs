using System;
using ConsoleGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Combat Attack = new Combat();

            int Damage = Attack.Attack(3, 10, 5);

            Console.WriteLine(Damage);
            Console.WriteLine(Attack.Attack(3, 30, 5));
            Console.WriteLine(Attack.Attack(3, 10, 5));
            Console.WriteLine(Attack.Attack(3, 10, 5));
            Console.WriteLine(Attack.Attack(3, 10, 5));
        }
    }
}
