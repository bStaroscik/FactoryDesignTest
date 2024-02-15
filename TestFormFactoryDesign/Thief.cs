using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormFactoryDesign
{
    public class Thief : INPC 
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public Thief() { }

        public Thief(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }

        public int Strength() { return strength; }
        public int Dexterity() { return dexterity; }
        public int Constitution() { return constitution; }
        public int Intelligence() { return intelligence; }
        public int Wisdom() { return wisdom; }
        public int Charisma() { return charisma; }

        public string Create ()
        {
            string npcResponse;
            npcResponse = "Fighter Created";
            return npcResponse;
        }
    }
}
