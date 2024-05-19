using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertPamfiloiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        int ok1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ok1++;
            ok1 = ok1 % 2;
            if (ok1 == 0)
                pictureBox4.Visible = false;
            else
            {
                pictureBox4.Visible = true;
            }
        }
        int ok2 = 0; 
        private void button2_Click(object sender, EventArgs e)
        {
            ok2++;
            ok2 = ok2 % 2;
            if (ok2 == 0)
                pictureBox5.Visible = false;
            else
            {
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        int ok3 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            ok3++;
            ok3 = ok3 % 2;
            if (ok3 == 0)
                pictureBox6.Visible = false;
            else
            {
                pictureBox6.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
