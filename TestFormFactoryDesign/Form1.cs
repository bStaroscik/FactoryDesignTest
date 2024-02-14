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

            npccmb.Items.AddRange(npcClass);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedClass = npccmb.SelectedItem.ToString();

            NPCFactory factory = new NPCFactory();

            // Create a npc character
            INPC npc = factory.CreateNPC(selectedClass);
            txtOutput.Text = npc.Create();

            // Try creating an invalid vehicle type
            //try
            //{
            //    IVehicle invalidVehicle = factory.CreateVehicle("bike");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            int strength = 0;
            int dexterity = 0;
            int constitution = 0;
            int intelligence = 0;
            int wisdom = 0;
            int charisma = 0;


            Random rnd = new Random();

            for (int j = 0; j < 3; j++)
            {
                strength = strength + Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                dexterity = dexterity + Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                constitution = constitution + Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                intelligence = intelligence + Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                wisdom = wisdom + Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20
                charisma = charisma + Convert.ToInt32(rnd.Next(1, 7)); // returns random integers >= 10 and < 20

            }

            strengthtxt.Text = strength.ToString();
            dextxt.Text = dexterity.ToString();
            contxt.Text = constitution.ToString();
            inttxt.Text = intelligence.ToString();
            wistxt.Text = wisdom.ToString();
            chartxt.Text = charisma.ToString();


        }
    }

}