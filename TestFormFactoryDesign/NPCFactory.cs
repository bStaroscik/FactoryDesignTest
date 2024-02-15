using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormFactoryDesign
{
    public class NPCFactory
    {
        public INPC CreateNPC(string npcType)
        {
            int strength = 0;
            int dexterity = 0;
            int constitution = 0;
            int intelligence = 0;
            int wisdom = 0;
            int charisma = 0;


            Random rnd = new Random();

            for (int j = 0; j < 3; j++)
            {
                strength += Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                dexterity += Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                constitution += Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                intelligence += Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                wisdom += Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                charisma += Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20

            };

            switch (npcType.ToLower())
            {
                case "fighter":
                    return new Fighter(strength, dexterity, constitution, intelligence, wisdom, charisma);
                case "thief":
                    return new Thief(strength, dexterity, constitution, intelligence, wisdom, charisma);
                case "wizard":
                    return new Wizard(strength, dexterity, constitution, intelligence, wisdom, charisma);
                default:
                    throw new ArgumentException($"Invalid NPC type: {npcType}");

            }
        }
    }
}
