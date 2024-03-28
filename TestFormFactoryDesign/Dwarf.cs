namespace TestFormFactoryDesign
{
    public class Dwarf : INPC
    {
        public string npcRace;
        public string npcClass { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public Dwarf() { }

        public Dwarf(string npcClass, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.npcRace = "Dwarf";
            this.npcClass = npcClass;
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution + 2;
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
            npcResponse = "Dwarven " + this.npcClass + " Created";
            return npcResponse;
        }


    }
}