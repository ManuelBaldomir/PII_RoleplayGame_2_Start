using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDamage()
        {
            Archer legolas = new Archer("Legolas");
            legolas.Helmet = new Helmet();

            Knight boromir = new Knight("Boromir");
            boromir.Sword = new Sword();

            legolas.ReceiveAttack(boromir.AttackValue);
            Assert.AreEqual(98, legolas.Health);
        }

        [Test]
        public void TestCure()
        {
            Archer legolas = new Archer("Legolas");
            legolas.Helmet = new Helmet();

            Knight boromir = new Knight("Boromir");
            boromir.Sword = new Sword();

            legolas.ReceiveAttack(boromir.AttackValue);
            legolas.Cure();

            Assert.AreEqual(100, legolas.Health);
        }

        [Test]
        public void TestSpellUse()
        {
            Knight boromir = new Knight("Boromir");
            boromir.Shield = new Shield();
            boromir.Armor = new Armor();

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = new SpellsBook();
            gandalf.SpellsBook.Spells = new Spell[]{ new Spell("Firebolt", 10, 0) };

            boromir.ReceiveAttack(gandalf.AttackValue);
            Assert.AreEqual(29, boromir.Health);
        }
    }
}