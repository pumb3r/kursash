using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class Puzzle : Form
    {
        public Puzzle()
        {
            InitializeComponent();
            picture1box.MouseDown += picture1box_MouseDown;
            pictureBox2.AllowDrop = true;
            pictureBox2.DragEnter += pictureBox2_DragEnter;
            pictureBox2.DragDrop += pictureBox2_DragDrop;
        //https://stackoverflow.com/questions/16004682/c-sharp-drag-and-drop-from-one-picture-box-into-another
        }
           

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }
        

        private void picture1box_MouseDown(object sender, MouseEventArgs e)
        {
            var img = picture1box.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                picture1box.Image = null;
            }
        }

        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox2.Image = bmp;
        }

        private void загрузитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFd = new OpenFileDialog();
            // формат картинки
            oFd.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.)|*.BMP;*.JPG;*.PNG|All files(*.*)|*.*";//Image Files(*.BMP;*.JPG;*.PNG;*.) вибор формата файла ,*.BMP;*.JPG;*.PNG це файли які нам підходять і можна вибрати
                                                                                                  // *- це назва файлу 


            if (oFd.ShowDialog() == DialogResult.OK)// тут наступний крок якщо нажали ок и вибрали картинку 
            {
                try// ми загружаэм картинку в пикчер бокс
                {
                    picture1box.Image = new Bitmap(oFd.FileName);
                }
                catch// якщо у нас буде якась помилка
                {
                    MessageBox.Show("Не возможно открить файл", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
