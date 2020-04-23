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
            PictureBox source =(PictureBox)e.Data.GetData((typeof(PictureBox)));
            //Temp - вспомогательная переменная для хранения изображения
            Image Temp = receiver.Image;
            //меняем картинки местами
            receiver.Image = source.Image;
            source.Image = Temp;
        }
        private void picture1_Click(object sender, EventArgs e)
        {

        }

        private void picture11_Click(object sender, EventArgs e)
        {

        }      
        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void перемешатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Bitmap> resources = new List<Bitmap>();
            resources.Add(Properties.Resources.cut1);
            resources.Add(Properties.Resources.cut2);
            resources.Add(Properties.Resources.cut3);
            resources.Add(Properties.Resources.cut4);
            resources.Add(Properties.Resources.cut5);
            resources.Add(Properties.Resources.cut6);
            resources.Add(Properties.Resources.cut7);
            resources.Add(Properties.Resources.cut8);
            resources.Add(Properties.Resources.cut9);

            resources = resources.OrderBy(a => Guid.NewGuid()).ToList();

            for (int i = 0; i < resources.Count; i++)
            {
                picture1.Image = resources[0];
                picture2.Image = resources[1];
                picture3.Image = resources[2];
                picture4.Image = resources[3];
                picture5.Image = resources[4];
                picture6.Image = resources[5];
                picture7.Image = resources[6];
                picture8.Image = resources[7];
                picture9.Image = resources[8];
            }


        }
        private void показатьОригиналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            support supwindow = new support();
            supwindow.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //початкове перемішуваненя при відкритті
            //List<Bitmap> resources = new List<Bitmap>();
          //  resources.Add(Properties.Resources.image_part_001);
           // resources.Add(Properties.Resources.image_part_002);
           // resources.Add(Properties.Resources.image_part_003);
          //  resources.Add(Properties.Resources.image_part_004);
          //  resources.Add(Properties.Resources.image_part_005);
          //  resources.Add(Properties.Resources.image_part_006);
          //  resources.Add(Properties.Resources.image_part_007);
         //   resources.Add(Properties.Resources.image_part_008);
         //   resources.Add(Properties.Resources.image_part_009);

          ////  resources = resources.OrderBy(a => Guid.NewGuid()).ToList();

          //  for (int i = 0; i < resources.Count; i++)
          // / {
           //     picture3.Image = resources[2];
         //       picture5.Image = resources[4];
         //       picture6.Image = resources[5];
         //       picture7.Image = resources[6];
         ////       picture8.Image = resources[7];
             //   picture9.Image = resources[8];
          //////  }
            //https://stackoverflow.com/questions/39309076/loop-multiple-images-through-multiple-pictureboxes?noredirect=1&lq=1 взято отсюда
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Bitmap> resources = new List<Bitmap>();
            resources.Add(Properties.Resources.image_part_001);
            resources.Add(Properties.Resources.image_part_002);
            resources.Add(Properties.Resources.image_part_003);
            resources.Add(Properties.Resources.image_part_004);
            resources.Add(Properties.Resources.image_part_005);
            resources.Add(Properties.Resources.image_part_006);
            resources.Add(Properties.Resources.image_part_007);
            resources.Add(Properties.Resources.image_part_008);
            resources.Add(Properties.Resources.image_part_009);

            resources = resources.OrderBy(a => Guid.NewGuid()).ToList();

            for (int i = 0; i < resources.Count; i++)
            {
                picture1.Image = resources[0];
                picture2.Image = resources[1];
                picture3.Image = resources[2];
                picture4.Image = resources[3];
                picture5.Image = resources[4];
                picture6.Image = resources[5];
                picture7.Image = resources[6];
                picture8.Image = resources[7];
                picture9.Image = resources[8];
            }
        }
    }
}
