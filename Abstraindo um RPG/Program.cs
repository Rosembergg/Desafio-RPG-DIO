using System;
using Abstraindo_um_RPG.src.Entities;

namespace Abstraindo_um_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus",23,"Knight",47,12);
            Wizard wizard = new Wizard("Jennifer",21,"White Wizard",24,57);
            Wizard wizard1 = new Wizard("Moon", 19, "Blck Wizard", 18, 61);
            Ninja ninja = new Ninja("Nazaki",32,"Ninja",39,35);
            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack(5));
            Console.WriteLine(wizard1.Attack(8));
            Console.WriteLine(ninja.Attack(7));
        }
    }
}
