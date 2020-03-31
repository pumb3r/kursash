namespace puzzle
{
    partial class Puzzle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picture1box = new System.Windows.Forms.PictureBox();
            this.picture2box = new System.Windows.Forms.PictureBox();
            this.загрузказображення = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2box)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(518, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 270);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // picture1box
            // 
            this.picture1box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture1box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture1box.Location = new System.Drawing.Point(28, 111);
            this.picture1box.Name = "picture1box";
            this.picture1box.Size = new System.Drawing.Size(270, 270);
            this.picture1box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1box.TabIndex = 0;
            this.picture1box.TabStop = false;
            this.picture1box.Click += new System.EventHandler(this.pictureBox3_Click);
            this.picture1box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture1box_MouseDown);
            // 
            // picture2box
            // 
            this.picture2box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture2box.Location = new System.Drawing.Point(518, 111);
            this.picture2box.Name = "picture2box";
            this.picture2box.Size = new System.Drawing.Size(270, 270);
            this.picture2box.TabIndex = 0;
            this.picture2box.TabStop = false;
            this.picture2box.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // загрузказображення
            // 
            this.загрузказображення.Location = new System.Drawing.Point(106, 51);
            this.загрузказображення.Name = "загрузказображення";
            this.загрузказображення.Size = new System.Drawing.Size(75, 23);
            this.загрузказображення.TabIndex = 1;
            this.загрузказображення.Text = "Вибрать картинку";
            this.загрузказображення.UseVisualStyleBackColor = true;
            this.загрузказображення.Click += new System.EventHandler(this.загрузказображення_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.загрузказображення);
            this.Controls.Add(this.picture2box);
            this.Controls.Add(this.picture1box);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puzzle";
            this.Text = "Puzzle";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Puzzle_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Puzzle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picture1box;
        private System.Windows.Forms.PictureBox picture2box;
        private System.Windows.Forms.Button загрузказображення;
        private System.Windows.Forms.Button button2;
    }
}

