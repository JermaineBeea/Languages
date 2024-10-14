using System;
using System.Windows.Forms;

namespace MoveIcon
{
    public partial class Form1 : Form
    {
        private int moveStep = 10; // Number of pixels to move the icon

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Allow form to capture key presses
            this.KeyDown += new KeyEventHandler(OnKeyDown); // Handle key presses
        }

        // Method to handle key press events
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Check which arrow key is pressed and move the PictureBox accordingly
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= moveStep; // Move left
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += moveStep; // Move right
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= moveStep; // Move up
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += moveStep; // Move down
            }
        }

        // Additional form setup
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial position of the PictureBox if needed
            pictureBox1.Location = new System.Drawing.Point(100, 100);
        }
    }
}

