using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFlibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                warning.Visible = true;
                warning1.Visible = true;
            }

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                warning.Visible = true;
                warning1.Visible = true;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                warning.Visible = true;
                warning1.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            warning.Visible = false;
            warning1.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
