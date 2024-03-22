using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static WindowsFormsApp1.Food;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int selected = 0;
        string[] mcsharebox =
{
                     "McShareBundle for 3",
                     "McShareBundle for 4",
                     "6pc Chicken McShareBox",
                     "8pc Chicken McShareBox",
                     "BFF ShakeShake & McFloat",
                };
        string[] burgers =
{
                     "Double Crispy Fish Fillet Sandwich",
                     "Crispy Fish Fillet Sandwich",
                     "Big Mac",
                     "Double Quarter Pounder with Cheese",
                     "Quarter Pounder with Cheese, Lettuce, and Tomatoes",
                     "Quarter Pounder with Cheese",
                    "Triple Cheeseburger",
                     "Double Cheeseburger",
                     "McChicken",
                     "Cheeseburger with Lettuce & Tomatoes",
                     "Cheeseburger",
                     "Crispy Chicken Sandwich with Lettuce & Tomatoes",
                    "Crispy Chicken Sandwich",
                     "Burger McDo with Lettuce & Tomatoes",
                     "Burger Mcdo",
                };
        string[] chickens =
        {
                     "1pc Chicken McDo Meal",
                     "2pc Chicken McDo Meal",
                     "1pc Spicy Chicken McDo Meal",
                     "2pc Spicy Chicken McDo Meal",
                     "McCrispy Chicken Fillet",
                     "McCrispy Chicken Fillet Ala King",
                     "6 Pc Chicken McNuggets",
                };
        string[] spaghettis =
        {
                     "Chicken Spaghetti",
                     "McSpaghetti Solo",
        };
        string[] ricebowls =
        {
                     "1pc Mushroom PepperSteak w/ Egg",
                     "2pc Mushroom PepperSteak w/ Egg",
                };
        string[] dessertsNdrinks =
{
                     "McFlurry w/ Oreo",
                     "Hot Fudge Sundae",
                     "Hot Caramel Sundae",
                     "Apple Pie",
                     "Coke McFloat",
                     "Coke",
                     "Coke Zero",
                    "Sprite",
                     "Orange Juice",
                     "Iced Tea",
                     "Apple Juice",
                };
        string[] mccafes =
{
                     "McCafe Premium Roast Coffee",
                     "McCafe Coffee Float",
                     "McCafe Icecd Coffee",
                     "McCafe Strawberry Oreo Frappe",
                     "Cappuccino",
                     "Espresso",
                     "Macchiato",
                    "Americano",
                     "Mochaccino",
                     "Cafe Latte",
                };
        string[] friesNextras =
{
                     "BFF Fries",
                     "Fries",
                     "Shake Shake Fries",
                };
        string[] happymeals =
{
                     "1pc Chicken Mcdo Happy Meal",
                     "4pc Chicken McNuggets Happy Meal",
                     "McSpaghetti Happy Meal",
                     "BurgerMcDo Happy Meal",
                };

        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            Methods.MatchParentWidth(panel1);
            Methods.MatchParentWidth(tableLayoutPanel1);
            flowLayoutPanel2.HorizontalScroll.Enabled = false;
            flowLayoutPanel2.HorizontalScroll.Visible = false;

            flowLayoutPanel1.VerticalScroll.Visible = false;

            PictureBox[] pictureBoxes = new PictureBox[4];

            /* Style.MatchParentWidth(panel2);
             Style.MatchParentWidth(panel3);
             Style.MatchParentWidth(panel4);
             Style.MatchParentWidth(panel5);
             Style.MatchParentWidth(panel6);*/
            string[] menus = { "McShareBox", "Burger", "Chicken","Spaghetti", "Rice Bowls", "Desserts & Drinks", "McCafe", "Fries & Extras", "Happy Meal", };
            for (int i = 0; i < menus.Length; i++)
            {
                int index = i;
                // Create a FlowLayoutPanel for each iteration
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.WrapContents = false; // Optional
                flowLayoutPanel.AutoSize = true;
                Methods.MatchParentWidth(flowLayoutPanel);

                // Create a PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu" + (i + 1) + ".jpg"));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                Methods.FlowMargin(pictureBox);
              //  pictureBox.BackColor = Color.Red;

                // Create a Label
                Label label = new Label();
                label.Text = menus[i]; // Unique label text for each iteration
                Methods.FlowMargin(label);
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                //label.BackColor = Color.Blue;

                //pictureBox.Click += (sender, e) => selectionClicked(index);
                //label.Click += (sender, e) => selectionClicked(index);

                // Add PictureBox and Label to FlowLayoutPanel
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(label);

                flowLayoutPanel.Click += (sender, e) => selectionClicked(index);
                Methods.InheritEvent(flowLayoutPanel, (sender, e) => selectionClicked(index));

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

            ///
            //flowLayoutPanel3.Margin = new Padding(10);
            flowLayoutPanel3.HorizontalScroll.Enabled = false;
            flowLayoutPanel3.HorizontalScroll.Visible = false;





        }
        private void LoadMenu(string[] menu)
        {
            int counter = 0;
            for (int i = 0; i < menu.Length; i++)
            {
                FlowLayoutPanel flowLayoutPanelB = new FlowLayoutPanel();
                flowLayoutPanelB.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanelB.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanelB.WrapContents = false; // Optional
                flowLayoutPanelB.AutoSize = true;
                Methods.MatchParentWidth(flowLayoutPanelB);
                //flowLayoutPanelB.BackColor = Color.Blue;
                for (int j = 0; j < 3; j++)
                {
                    if (counter < menu.Length)
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
                        //pictureBox.BackColor = Color.Red;

                        Label label = new Label();
                        label.Text = menu[counter]; // Unique label text for each iteration
                        counter++;
                        Methods.MatchParentWidth(label);                       
                        label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        label.AutoSize = false;
                        label.AutoEllipsis = true;
                        // label.BackColor = Color.Blue;

                        flowLayoutPanel.Controls.Add(pictureBox);
                        flowLayoutPanel.Controls.Add(label);
                        flowLayoutPanelB.Controls.Add(flowLayoutPanel);
                    }
                }
                flowLayoutPanel3.Controls.Add(flowLayoutPanelB);
            }
        }
        private void selectionClicked(int selection)
        {
            flowLayoutPanel3.Controls.Clear();
            switch (selection)
            {
                case 0:
                    LoadMenu(mcsharebox);
                    break;
                case 1:
                    LoadMenu(burgers);
                    break;
                case 2:
                    LoadMenu(chickens);
                    break;
                case 3:
                    LoadMenu(spaghettis);
                    break;
                case 4:
                    LoadMenu(ricebowls);
                    break;
                case 5:
                    LoadMenu(dessertsNdrinks);
                    break;
                case 6:
                    LoadMenu(mccafes);
                    break;
                case 7:
                    LoadMenu(friesNextras);
                    break;
                case 8:
                    LoadMenu(happymeals);
                    break;
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
