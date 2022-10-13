using System;
namespace Library.Items{
    public class SpellBook : Item{
        public int SpellQuantity {get; set; }
        public SpellBook (string name, int damage, int defense, int spellQuantity = 0) : base (name, damage, defense)
        {
            this.SpellQuantity = spellQuantity;
        }
    }
}
