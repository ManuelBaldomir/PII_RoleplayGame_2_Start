using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell("Fireball", 80, 0) };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Console.WriteLine($"Gimli has hp {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with attack {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has hp {gimli.Health}");

            gimli.Cure();
            Console.WriteLine("Gimli se cura");

            Console.WriteLine($"Gimli has hp {gimli.Health}");
        }
    }
}
