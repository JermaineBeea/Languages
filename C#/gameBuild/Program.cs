using System;
using System.Windows.Forms;
using System.Drawing;

namespace MoveIconExample
{
    public partial class Form1 : Form
    {
        private PictureBox icon;
        private int step = 10; // Step size for movement

        public Form1()
        {
            InitializeComponent();
            InitializeIcon();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown); // KeyDown event for moving the icon
        }

        private void InitializeIcon()
        {
            // Create a PictureBox for the icon
            icon = new PictureBox();
            icon.Size = new Size(50, 50);
            icon.Location = new Point(100, 100);
            icon.BackColor = Color.Red; // You can use an image here instead of a color

            this.Controls.Add(icon);
        }

        // Event handler for key presses
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    MoveIcon(0, -step);
                    break;
                case Keys.Down:
                    MoveIcon(0, step);
                    break;
                case Keys.Left:
                    MoveIcon(-step, 0);
                    break;
                case Keys.Right:
                    MoveIcon(step, 0);
                    break;
            }
        }

        // Method to move the icon
        private void MoveIcon(int dx, int dy)
        {
            int newX = icon.Location.X + dx;
            int newY = icon.Location.Y + dy;

            // Keep the icon within the bounds of the form
            if (newX >= 0 && newX + icon.Width <= this.ClientSize.Width)
            {
                icon.Location = new Point(newX, icon.Location.Y);
            }

            if (newY >= 0 && newY + icon.Height <= this.ClientSize.Height)
            {
                icon.Location = new Point(icon.Location.X, newY);
            }
        }
    }
}
