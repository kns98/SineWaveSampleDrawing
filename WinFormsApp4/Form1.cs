using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawSineWave();
        }

        private void DrawSineWave()
        {
            // Get the width and height of the picture box
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Create a new bitmap with the same width and height as the picture box
            Bitmap bmp = new Bitmap(width, height);

            // Use the Graphics class to draw on the bitmap
            Graphics g = Graphics.FromImage(bmp);

            const int num_waves = 5;
            // Loop through each x value from 0 to the width of the picture box
            for (int x = 0; x < width; x++)
            {
                // Calculate the y value of the sine wave using the sine function
                float y = (float)(height / 2 + height / 4 * Math.Sin(x * num_waves * Math.PI / width));
             
                for (int i = (int)y; i < height / 2; i++)
                {
                    bmp.SetPixel(x, i, Color.RebeccaPurple);
                }
                for (int i = (int)y; i > height / 2; i--)
                {
                    bmp.SetPixel(x, i, Color.RosyBrown);
                }
              
            }

            // Set the image of the picture box to the bitmap
            this.pictureBox1.Image = bmp;
        }
    }
}