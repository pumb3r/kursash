using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trypazzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // for (int i = 1; i <= 9; i++)
            //{
            //    ((PictureBox)(Controls.Find("picture" + i, true)[0])).AllowDrop = true;
           // }
            this.picture1.AllowDrop = true; this.picture2.AllowDrop = true;
            this.picture3.AllowDrop = true; this.picture4.AllowDrop = true;
            this.picture5.AllowDrop = true; this.picture6.AllowDrop = true;
            this.picture7.AllowDrop = true; this.picture8.AllowDrop = true;
            this.picture9.AllowDrop = true; this.picture11.AllowDrop = true;
            this.picture22.AllowDrop = true; this.picture33.AllowDrop = true;
            this.picture44.AllowDrop = true; this.picture55.AllowDrop = true;
            this.picture66.AllowDrop = true; this.picture77.AllowDrop = true;
            this.picture88.AllowDrop = true; this.picture99.AllowDrop = true;





        }
        private void picture1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((PictureBox)sender, DragDropEffects.Move);
        }
        private void picture1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void picture1_DragDrop(object sender, DragEventArgs e)
        {
            //объект-приемник 
            PictureBox receiver = (PictureBox)sender;
            //объект-источник
            PictureBox source =
                    (PictureBox)e.Data.GetData((typeof(PictureBox)));
            //Temp - вспомогательная переменная для хранения изображения
            Image Temp = receiver.Image;
            //меняем картинки местами
            receiver.Image = source.Image;
            source.Image = Temp;
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }

        private void picture11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
