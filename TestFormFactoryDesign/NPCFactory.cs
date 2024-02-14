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
            switch (npcType.ToLower())
            {
                case "fighter":
                    return new Fighter();
                case "thief":
                    return new Thief();
                case "wizard":
                    return new Wizard();
                default:
                    throw new ArgumentException($"Invalid NPC type: {npcType}");

            }
        }
    }
}
