﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        

        public static Form1 instance;
        public Form1()
        {
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            Style.CenterSub(panel1);
            Style.CenterSub(panel2);
            Style.RoundBorders(panel2, 20);
            Style.RoundBorders(panel4, 20);
            Style.MatchParentWidth(label1);
            Style.MatchParentWidth(label2);

        }
        private void panel2_Click(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void panel2_Click(object sender, PaintEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
