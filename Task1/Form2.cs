using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form2 : Form
    {
        int PosX;
        int PosY;
        public Form2()
        {
            InitializeComponent();
        }

        private void SetSizeBtn_Click(object sender, EventArgs e)
        {
            PosX = Convert.ToInt32(textBox1.Text); // converting the text boxs to ints
            PosY = Convert.ToInt32(textBox2.Text);

            if (PosX == 0)
            {
                SetSizeBtn.Enabled = false;
            }
            if (PosY == 0)
            {
                SetSizeBtn.Enabled = false;
            }

            if (PosX > 0 && PosY > 0)
            {
                SetSizeBtn.Enabled = true;
                MessageBox.Show(" " + PosX + " " + PosY);
            }

            Form1 frm1 = new Form1();
            Map mp = new Map(40, 4, textBox1);
            mp.SetSize(PosX, PosY); // sends the value to maps 

            Form2 frm2 = new Form2();
            frm1.Show();
            frm2.Close();
        }
    }
}
