using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormFactoryDesign
{
    public class Human : INPC
    {
        public string npcRace { get; set; }
        public string npcClass { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public Human() { }

        public Human(string npcClass, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.npcRace = "Human";
            this.npcClass = npcClass;
            this.strength = strength + 1;
            this.dexterity = dexterity + 1;
            this.constitution = constitution + 1;
            this.intelligence = intelligence + 1;
            this.wisdom = wisdom + 1;
            this.charisma = charisma + 1;
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
            npcResponse = "Human " + this.npcClass + " Created";
            return npcResponse;
        }


    }
}
