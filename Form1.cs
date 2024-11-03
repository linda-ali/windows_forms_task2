using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        private Image[] images;
        private int currentIndex = 1;

        public Form1()
        {
            InitializeComponent();


            images = new Image[]
            {
             Image.FromFile(@"C:\Users\Shahin Lap\source\repos\Visual Programming\task2\images\pic1.jpeg"),
             Image.FromFile(@"C:\Users\Shahin Lap\source\repos\Visual Programming\task2\images\pic2.jpeg"),
             Image.FromFile(@"C:\Users\Shahin Lap\source\repos\Visual Programming\task2\images\pic3.jpeg"),
             Image.FromFile(@"C:\Users\Shahin Lap\source\repos\Visual Programming\task2\images\pic4.jpeg")
            };

            if (images.Length > 0)
                pictureBox.Image = images[currentIndex];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (images.Length == 0) return;
            currentIndex = (currentIndex + 1) % images.Length;
            pictureBox.Image = images[currentIndex];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (images.Length == 0) return;
            currentIndex = (currentIndex - 1 + images.Length) % images.Length;
            pictureBox.Image = images[currentIndex];
        }
    }
}
