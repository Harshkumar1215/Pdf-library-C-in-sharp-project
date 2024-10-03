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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            home.BackColor = Color.LightSteelBlue;
            computer.BackColor = Color.LightSteelBlue;
            math.BackColor = Color.LightSteelBlue;
            top.BackColor = Color.Silver;
            biology.BackColor = Color.LightSteelBlue;
            chymistry.BackColor = Color.LightSteelBlue;
            physic.BackColor = Color.LightSteelBlue;
            Form3 f = new Form3();
            f.Show();
            Hide();
   
        }

        private void computer_Click(object sender, EventArgs e)
        {
            home.BackColor = Color.LightSteelBlue;       
            math.BackColor = Color.LightSteelBlue;
            
            biology.BackColor = Color.LightSteelBlue;
            chymistry.BackColor = Color.LightSteelBlue;
            physic.BackColor = Color.LightSteelBlue;
            computer.BackColor = Color.Pink;

            top.BackColor = Color.Pink;


            Form4 f = new Form4();


            f.TopLevel = false;


            area.Controls.Clear();


            area.Controls.Add(f);


            f.Size = area.Size;
            f.Location = new Point(0, 0);


            f.Show();
            
        }

        private void math_Click_1(object sender, EventArgs e)
        {
            home.BackColor = Color.LightSteelBlue;
            computer.BackColor = Color.LightSteelBlue;
           
            biology.BackColor = Color.LightSteelBlue;
            chymistry.BackColor = Color.LightSteelBlue;
            physic.BackColor = Color.LightSteelBlue;
            math.BackColor = Color.Pink;
            top.BackColor = Color.Pink;


            Form5 f = new Form5();


            f.TopLevel = false;


            area.Controls.Clear();


            area.Controls.Add(f);


            f.Size = area.Size;
            f.Location = new Point(0, 0);


            f.Show();
        }

        private void biology_Click(object sender, EventArgs e)
        {
            home.BackColor = Color.LightSteelBlue;
            computer.BackColor = Color.LightSteelBlue;
            math.BackColor = Color.LightSteelBlue;
            
            
            chymistry.BackColor = Color.LightSteelBlue;
            physic.BackColor = Color.LightSteelBlue;
            top.BackColor = Color.Pink;
            biology.BackColor = Color.Pink;
            Form6 f = new Form6();


            f.TopLevel = false;


            area.Controls.Clear();


            area.Controls.Add(f);


            f.Size = area.Size;
            f.Location = new Point(0, 0);


            f.Show();
        }

        private void chymistry_Click(object sender, EventArgs e)
        {

            home.BackColor = Color.LightSteelBlue;
            computer.BackColor = Color.LightSteelBlue;
            math.BackColor = Color.LightSteelBlue;

            biology.BackColor = Color.LightSteelBlue;
           
            physic.BackColor = Color.LightSteelBlue;
            top.BackColor = Color.Pink;
            biology.BackColor = Color.LightSteelBlue;
            chymistry.BackColor = Color.Pink;
            Form7 f = new Form7();


            f.TopLevel = false;


            area.Controls.Clear();


            area.Controls.Add(f);


            f.Size = area.Size;
            f.Location = new Point(0, 0);


            f.Show();
        }

        private void physic_Click(object sender, EventArgs e)
        {
            home.BackColor = Color.LightSteelBlue;
            computer.BackColor = Color.LightSteelBlue;
            math.BackColor = Color.LightSteelBlue;
            
            biology.BackColor = Color.LightSteelBlue;
            chymistry.BackColor = Color.LightSteelBlue;
            
            top.BackColor = Color.Pink;
            
            physic.BackColor = Color.Pink;

            Form8 f = new Form8();


            f.TopLevel = false;


            area.Controls.Clear();


            area.Controls.Add(f);


            f.Size = area.Size;
            f.Location = new Point(0, 0);


            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form9 F = new Form9();
            F.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form10 F = new Form10();
            F.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void area_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form11 F = new Form11();
            F.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Form12 F = new Form12();
            F.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Form13 F = new Form13();
            F.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form14 F = new Form14();
            F.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form15 F = new Form15();
            F.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form16 F = new Form16();
            F.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form17 F = new Form17();
            F.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form18 F = new Form18();
            F.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Form19 F = new Form19();
            F.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Form20 F = new Form20();
            F.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Form21 F = new Form21();
            F.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Form22 F = new Form22();
            F.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form23 F = new Form23();
            F.Show();
        }
    }
}
