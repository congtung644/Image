using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slideshowImage_LuuCongTung
{
    public partial class Form1 : Form

    {
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        bool playing = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            string[] images = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
              
            if(counter > images.Length - 1)
            {
                counter = 0;
            }

        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();
        }
    }
}
