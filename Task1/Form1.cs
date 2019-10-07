using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Task1
{
    public partial class Form1 : Form
    {
        int PosX;
        int PosY;
        GameEngine Engine;
        public Form1()
        {
            InitializeComponent();
        }

         
        private void Form1_Load(object sender, EventArgs e)
        {
           Engine = new GameEngine(20,4, textBox1, GroupMap);
        }

        private void StrtBtn1_Click(object sender, EventArgs e)
        {           
            Timer1.Enabled = true;
        }

        private void PSBtn1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Rndlbl1.Text = "Round: " + Engine.numRounds.ToString();
            Engine.GameLogic();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Map mp = new Map(40, 4, textBox1);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("Map Data", FileMode.Create, FileAccess.Write, FileShare.None);
                    using (fs)
                {
                    bf.Serialize(fs, mp); // saves the whole map class 
                    MessageBox.Show("file Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Recbtn_Click(object sender, EventArgs e)
        {
            Map mp = new Map(40, 4, textBox1);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("Map Data", FileMode.Create, FileAccess.Write, FileShare.None);
                    using (fs)
                {
                    mp = (Map)bf.Deserialize(fs); // recalls the saved map class and recalls it. 
                    mp.Display(GroupMap);
                    MessageBox.Show("file loaded");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PosX = Convert.ToInt32(txtboxX.Text); // converting the text boxs to ints
            PosY = Convert.ToInt32(txtboxY.Text);
            if (PosX == 0 && PosY == 0)
            {
                button1.Enabled = false;
            }
            else

            if (PosX > 0 && PosY > 0)
            {
                button1.Enabled = true;
                MessageBox.Show(" " + PosX + ";"+ " " + PosY);
                Map map = new Map(40, 4, textBox1);
                map.SetSize(PosX, PosY);
                map.Generate();
            }

        }
    }
}
