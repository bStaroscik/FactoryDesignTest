using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormFactoryDesign
{
    public class Elf : INPC
    {
        public string npcRace;
        public string npcClass { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public Elf() { }

        public Elf(string npcClass, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.npcRace = "Elf";
            this.npcClass = npcClass;
            this.strength = strength;
            this.dexterity = dexterity + 2;
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

        public string Create()
        {
            string npcResponse;
            npcResponse = "Elven " + this.npcClass + " Created";
            return npcResponse;
        }


    }
}
