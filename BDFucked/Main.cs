using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFucked
{
    public partial class Main : Form
    {
        private Mem MemLib = new Mem();
        public int[] CharacterValue = { 50000, 90000, 120000, 140000, 150000, 155000, 157250, 2147483647 };
        public int[] CharacterValue2 = { 1, 2, 3, 4, 5, 6, 7, 2147483647 };
        private int gameProcId;

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            gameProcId = MemLib.getProcIDFromName("BlackDesert64");
            if (gameProcId > 0)
            {
                //Console.WriteLine("Process ID: " + gameProcId.ToString());
                this.Text += " | " + gameProcId.ToString();
                MemLib.OpenProcess(gameProcId);
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Kuda
            if (checkBox1.Checked)
            {
                //Speed
                MemLib.writeMemory("base+0x3CF6D78,8908", "int", (int.Parse(textBox4.Text) * 10000).ToString());
            }
            if (checkBox2.Checked)
            {
                //Accelerate
                MemLib.writeMemory("base+0x3CF6D78,8904", "int", (int.Parse(textBox1.Text) * 10000).ToString());
            }
            if (checkBox3.Checked)
            {
                //Turn
                MemLib.writeMemory("base+0x3CF6D78,8912", "int", (int.Parse(textBox2.Text) * 10000).ToString());
            }
            if (checkBox4.Checked)
            {
                //Break
                MemLib.writeMemory("base+0x3CF6D78,8916", "int", (int.Parse(textBox3.Text) * 10000).ToString());
            }

            //Character
            if(checkBox7.Checked)
            {
                //Attack Speed
                MemLib.writeMemory("base+0x329E900,3068", "int", CharacterValue[comboBox1.SelectedIndex].ToString());
            }

            if (checkBox8.Checked)
            {
                //Casting Speed
                MemLib.writeMemory("base+0x329E900,3072", "int", CharacterValue[comboBox2.SelectedIndex].ToString());
            }

            if (checkBox9.Checked)
            {
                //Move Speed
                MemLib.writeMemory("base+0x329E900,3064", "int", CharacterValue[comboBox3.SelectedIndex].ToString());
            }

            if (checkBox10.Checked)
            {
                //Critical Hit
                MemLib.writeMemory("base+0x329E900,18760", "int", CharacterValue2[comboBox4.SelectedIndex].ToString());
            }

            if (checkBox11.Checked)
            {
                //Fishing
                MemLib.writeMemory("base+0x329E900,18776", "int", CharacterValue2[comboBox5.SelectedIndex].ToString());
            }

            if (checkBox12.Checked)
            {
                //Gathering
                MemLib.writeMemory("base+0x329E900,18784", "int", CharacterValue2[comboBox6.SelectedIndex].ToString());
            }

            if (checkBox13.Checked)
            {
                //Luck
                MemLib.writeMemory("base+0x329E900,18768", "int", CharacterValue2[comboBox7.SelectedIndex].ToString());
            }

            if (checkBox5.Checked)
            {
                //Alchemy
                MemLib.writeMemory("base+0x329E900,4252", "int", ((comboBox8.SelectedIndex + 1) * 50000).ToString());
            }

            if (checkBox6.Checked)
            {
                //Cooking
                MemLib.writeMemory("base+0x329E900,4256", "int", ((comboBox9.SelectedIndex + 1) * 50000).ToString());
            }

            //Resistence
            if (checkBox16.Checked)
            {
                //Knockdown/Bound
                MemLib.writeMemory("base+0x329E900,4236", "int", (int.Parse(textBox8.Text) * 10000).ToString());
            }
            if (checkBox17.Checked)
            {
                //Stun/Stiffness/Freezing
                MemLib.writeMemory("base+0x329E900,4240", "int", (int.Parse(textBox5.Text) * 10000).ToString());
            }
            if (checkBox14.Checked)
            {
                //Knockback/Floating
                MemLib.writeMemory("base+0x329E900,4244", "int", (int.Parse(textBox6.Text) * 10000).ToString());
            }
            if (checkBox15.Checked)
            {
                //Grapple
                MemLib.writeMemory("base+0x329E900,4248", "int", (int.Parse(textBox7.Text) * 10000).ToString());
            }

        }
    }
}
