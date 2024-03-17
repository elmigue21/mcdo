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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            Style.MatchParentWidth(panel1);
            Style.MatchParentWidth(tableLayoutPanel1);
            flowLayoutPanel2.HorizontalScroll.Enabled = false;
            flowLayoutPanel2.HorizontalScroll.Visible = false;

            flowLayoutPanel1.VerticalScroll.Visible = false;

            PictureBox[] pictureBoxes = new PictureBox[4];

            /* Style.MatchParentWidth(panel2);
             Style.MatchParentWidth(panel3);
             Style.MatchParentWidth(panel4);
             Style.MatchParentWidth(panel5);
             Style.MatchParentWidth(panel6);*/
            string[] menus = { "McShareBox", "Burger", "Chicken", "Spaghetti", "Rice Bowls", "Desserts & Drinks", "McCafe", "Fries & Extras", "Happy Meal", };
            for (int i = 0; i < 9; i++)
            {
                // Create a FlowLayoutPanel for each iteration
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.WrapContents = false; // Optional
                flowLayoutPanel.AutoSize = true;
                Style.MatchParentWidth(flowLayoutPanel);

                // Create a PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu" + (i + 1) + ".jpg"));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                Style.MatchParentWidth(pictureBox);

                // Create a Label
                Label label = new Label();
                label.Text = menus[i]; // Unique label text for each iteration
                Style.MatchParentWidth(label);
                label.TextAlign = ContentAlignment.MiddleCenter;


                // Add PictureBox and Label to FlowLayoutPanel
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(label);

                // Add FlowLayoutPanel to the parent FlowLayoutPanel (flowLayoutPanel2)
                flowLayoutPanel2.Controls.Add(flowLayoutPanel);
            }

            //////////////////////////////////ads/////////////
            int currentIndex = 0;

            panel1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            currentIndex++;


            Timer timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += (sender, e) =>
            {
                panel1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
                currentIndex = (currentIndex + 1) % 4;
            };
            timer.Start();
            //////////////////////////////////////////////////////////////////
            string[] BurgerNames =
            {
                     "Double Crispy Fish Fillet Sandwich",
                     "Crispy Fish Fillet Sandwich",
                     "Big Mac",
                     "Double Quarter Pounder with Cheese",
                     "Quarter Pounder with Cheese, Lettuce, and Tomatoes",
                     "Quarter Pounder with Cheese",
                    "Triple Cheeseburger",
                     "Double Cheeseburger",
                     "McChicken", "burger9",
                     "Cheeseburger with Lettuce & Tomatoes",
                     "Cheeseburger", 
                     "Crispy Chicken Sandwich with Lettuce & Tomatoes", 
                    "Crispy Chicken Sandwich",
                     "Burger McDo with Lettuce & Tomatoes", 
                     "Burger Mcdo", 
                };

            ///
            //flowLayoutPanel3.Margin = new Padding(10);
            flowLayoutPanel3.HorizontalScroll.Enabled = false;
            flowLayoutPanel3.HorizontalScroll.Visible = false;

            int counter = 0;

            for (int i = 0; i < BurgerNames.Length; i++)
            {
                FlowLayoutPanel flowLayoutPanelB = new FlowLayoutPanel();
                flowLayoutPanelB.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanelB.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanelB.WrapContents = false; // Optional
                flowLayoutPanelB.AutoSize = true;
                Style.MatchParentWidth(flowLayoutPanelB);
                //flowLayoutPanelB.BackColor = Color.Blue;
                for (int j = 0; j <3; j++)
                {
                    if (counter < BurgerNames.Length)
                    {
                        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                        flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                        flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                        flowLayoutPanel.WrapContents = false; // Optional
                        flowLayoutPanel.AutoSize = true;

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu" + (/*i + */1) + ".jpg"));
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 125;
                        pictureBox.Height = 125;
                        // pictureBox.BackColor = Color.Red;
                        pictureBox.Margin = new Padding(20);

                        Label label = new Label();
                        label.Text = BurgerNames[counter]; // Unique label text for each iteration
                        counter++;
                        Style.MatchParentWidth(label);
                        label.TextAlign = ContentAlignment.MiddleCenter;

                        flowLayoutPanel.Controls.Add(pictureBox);
                        flowLayoutPanel.Controls.Add(label);
                        flowLayoutPanelB.Controls.Add(flowLayoutPanel);
                    }
                }
                flowLayoutPanel3.Controls.Add(flowLayoutPanelB);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
