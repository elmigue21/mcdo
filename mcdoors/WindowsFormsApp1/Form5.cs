using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public partial class Form5 : Form
    {

        public string ReturnValue { get; private set; }

        class ProductData
        {
            public string ImagePath { get; set; }
            public decimal[] Prices { get; set; }
            public string[] Sizes { get; set; }
        }

        public Form5()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            Methods.ShowAds(panel1);
            Methods.MatchParentWidth(panel2);
            pictureBox1.BackColor = Color.Red;
            customization1.BackColor = Color.Blue;
            customization2.BackColor = Color.Blue;
            customization3.BackColor = Color.Blue;
            dropdown1.BackColor = Color.Green;
            dropdown2.BackColor = Color.Green;
            dropdown3.BackColor = Color.Green;


            /* PictureBox pictureBox = new PictureBox();
             pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu1" + ".jpg"));
             pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
             pictureBox.Width = 100;
             pictureBox.Height = 100;
             Methods.FlowMargin(pictureBox);

             dropdown2.Controls.Add(pictureBox);
            */
            var attributesBurger1 = new Dictionary<string, string[]>
            {
                { "Size", new string[] { "Small", "Medium" } },
                { "Toppings", new string[] { "Lettuce", "Tomato" } }
            };

            // Example: Attributes for Burger 2
            var attributesBurger2 = new Dictionary<string, string[]>
            {
                { "Size", new string[] { "Medium", "Large" } },
                { "Toppings", new string[] { "Onion", "Pickles" } }
            };



        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            ReturnValue = "asdasdasdasd";
            this.Close(); // Close the pop-up form
        }

        private void customization1_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu1" + ".jpg"));
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            Methods.FlowMargin(pictureBox);

            dropdown1.Controls.Add(pictureBox);
        }
        private void customization2_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu1" + ".jpg"));
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            Methods.FlowMargin(pictureBox);

            dropdown2.Controls.Add(pictureBox);
        }
        private void customization3_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu1" + ".jpg"));
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            Methods.FlowMargin(pictureBox);

            dropdown3.Controls.Add(pictureBox);
        }



        private void customization1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
