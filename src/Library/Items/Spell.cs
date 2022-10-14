namespace RoleplayGame
{
    public class Spell : IItem
    {
        private int attackValue;
        private int defenseValue;
        public string name {get;}

        public Spell(string name, int attack, int defense)
        {
            this.name = name;
            this.attackValue = attack;
            this.defenseValue = defense;
        }

        public int AttackValue 
        {
            get
            {
                return this.attackValue;
            }
        }
        public int DefenseValue 
        {
            get
            {
                return this.defenseValue;
            }
        }
    }
}