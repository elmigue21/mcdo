using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public static Form2 instance;
        public Form2()
        {
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Style.CenterSub(panel1);
            Style.CenterSub(panel2);
            Style.RoundBorders(panel2, 20);
            Style.RoundBorders(panel3, 20);
            Style.MatchParentWidth(label1);
            Style.MatchParentWidth(label2);

        }
        private void panel2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
