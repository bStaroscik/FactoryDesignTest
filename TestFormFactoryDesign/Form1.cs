using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormFactoryDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] npcClass = { "Fighter", "Thief", "Wizard" };
            string[] npcRace = { "Human", "Elf", "Dwarf", "Tiefling" };

            npccmb.Items.AddRange(npcClass);
            npcRacecmb.Items.AddRange(npcRace);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedClass = npccmb.SelectedItem.ToString();
            string selectedRace = npcRacecmb.SelectedItem.ToString();

            NPCFactory factory = new NPCFactory();

            // Create a npc character
            INPC npc = factory.CreateNPC(selectedClass, selectedRace);
            txtOutput.Text = npc.Create();

            strengthtxt.Text = npc.Strength().ToString();
            dextxt.Text = npc.Dexterity().ToString();
            contxt.Text = npc.Constitution().ToString();
            inttxt.Text = npc.Intelligence().ToString();
            wistxt.Text = npc.Wisdom().ToString();
            chartxt.Text = npc.Charisma().ToString();


        }
    }

}