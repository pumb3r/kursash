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
        }
           

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void загрузказображення_Click(object sender, EventArgs e)
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

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            // Width of this PictureBox is 300
            // Height of this PictureBox is 300

            //    Vertical Grid lines should be:
            // 1. x = 100, y = 0 -> x = 100, y = 300 
            // 2. x = 200, y = 0 -> x = 200, y = 300 

            e.Graphics.DrawLine(new Pen(Color.LightGray), new Point(100, 0), new Point(100, 300));
            e.Graphics.DrawLine(new Pen(Color.LightGray), new Point(200, 0), new Point(200, 300));

            //    Horizontal Grid lines should be:
            // 1. x = 0, y = 100 -> x = 300, y = 100 
            // 2. x = 0, y = 200 -> x = 300, y = 200 

            e.Graphics.DrawLine(new Pen(Color.LightGray), new Point(0, 100), new Point(300, 100));
            e.Graphics.DrawLine(new Pen(Color.LightGray), new Point(0, 200), new Point(300, 200));
        }

        private void picture1box_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
