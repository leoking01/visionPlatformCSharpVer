using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "all Files type|*.*|Jpg Files(*.jpg)|*.jpg|Bmp Files(*.bmp)|*.bmp|png Files(*.png)|*.png";
            // ofdlg.Filter = "Bmp Files(*.bmp)|*.bmp|Gif Files（*.gif)| *.gif|Jpg Files(*.jpg)|*.jpg";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(ofdlg.FileName);
                pictureBox1.Image = image;
            }
 


            //OpenFileDialog openfile = new OpenFileDialog();
            //if (openfile.ShowDialog() == DialogResult.OK &&
            //    (openFileDialog1.FileName != ""))
            //{
            //    picturebox1.ImageLocation = openfile.FileName;
            //    textbox.Text = openfile.FileName;
            //}
            //openfile.Dispose();


        }
    }
}
