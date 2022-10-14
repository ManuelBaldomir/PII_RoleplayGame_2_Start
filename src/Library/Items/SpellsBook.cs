using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IItem
    {
        public Spell[] Spells { get; set; }

        private int attackValue = 0;
        private int defenseValue = 0;

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }
        public int DefenseValue 
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
        
        

        
    }
}