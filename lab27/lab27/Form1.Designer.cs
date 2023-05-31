namespace lab27
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Atributes_txt = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateCat = new System.Windows.Forms.Button();
            this.CreateFile = new System.Windows.Forms.Button();
            this.CopyFile = new System.Windows.Forms.Button();
            this.CopyFile2 = new System.Windows.Forms.Button();
            this.CopyCat2 = new System.Windows.Forms.Button();
            this.CopyCat = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(408, 185);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Відобразити\r\nпапки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Властивості\r\nдиску/папки/файлу\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Фільтрування файлів";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Атрибути файлу або папки:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Відкрити текстовий файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "Відкрити зображення";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 42);
            this.button6.TabIndex = 7;
            this.button6.Text = "Атрибути безпеки";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Atributes_txt
            // 
            this.Atributes_txt.AutoSize = true;
            this.Atributes_txt.Location = new System.Drawing.Point(206, 321);
            this.Atributes_txt.Name = "Atributes_txt";
            this.Atributes_txt.Size = new System.Drawing.Size(0, 16);
            this.Atributes_txt.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(435, 36);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(232, 22);
            this.Name_txt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Назва файлу або папки:";
            // 
            // CreateCat
            // 
            this.CreateCat.Location = new System.Drawing.Point(435, 64);
            this.CreateCat.Name = "CreateCat";
            this.CreateCat.Size = new System.Drawing.Size(113, 42);
            this.CreateCat.TabIndex = 11;
            this.CreateCat.Text = "Створити каталог";
            this.CreateCat.UseVisualStyleBackColor = true;
            this.CreateCat.Click += new System.EventHandler(this.CreateCat_Click);
            // 
            // CreateFile
            // 
            this.CreateFile.Location = new System.Drawing.Point(554, 64);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(113, 42);
            this.CreateFile.TabIndex = 12;
            this.CreateFile.Text = "Створити файл";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // CopyFile
            // 
            this.CopyFile.Location = new System.Drawing.Point(605, 112);
            this.CopyFile.Name = "CopyFile";
            this.CopyFile.Size = new System.Drawing.Size(146, 46);
            this.CopyFile.TabIndex = 13;
            this.CopyFile.Text = "Вибрати файл для копіювання";
            this.CopyFile.UseVisualStyleBackColor = true;
            this.CopyFile.Click += new System.EventHandler(this.CopyFile_Click);
            // 
            // CopyFile2
            // 
            this.CopyFile2.Location = new System.Drawing.Point(605, 164);
            this.CopyFile2.Name = "CopyFile2";
            this.CopyFile2.Size = new System.Drawing.Size(146, 33);
            this.CopyFile2.TabIndex = 14;
            this.CopyFile2.Text = "Скопіювати файл";
            this.CopyFile2.UseVisualStyleBackColor = true;
            this.CopyFile2.Click += new System.EventHandler(this.CopyFile2_Click);
            // 
            // CopyCat2
            // 
            this.CopyCat2.Location = new System.Drawing.Point(435, 164);
            this.CopyCat2.Name = "CopyCat2";
            this.CopyCat2.Size = new System.Drawing.Size(164, 33);
            this.CopyCat2.TabIndex = 15;
            this.CopyCat2.Text = "Скопіювати каталог";
            this.CopyCat2.UseVisualStyleBackColor = true;
            this.CopyCat2.Click += new System.EventHandler(this.CopyCat2_Click);
            // 
            // CopyCat
            // 
            this.CopyCat.Location = new System.Drawing.Point(435, 112);
            this.CopyCat.Name = "CopyCat";
            this.CopyCat.Size = new System.Drawing.Size(164, 46);
            this.CopyCat.TabIndex = 16;
            this.CopyCat.Text = "Вибрати каталог для копіювання";
            this.CopyCat.UseVisualStyleBackColor = true;
            this.CopyCat.Click += new System.EventHandler(this.CopyCat_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(435, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 42);
            this.button7.TabIndex = 20;
            this.button7.Text = "Вибрати каталог для переміщення";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(435, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 42);
            this.button8.TabIndex = 19;
            this.button8.Text = "Перемістити каталог";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(605, 260);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 42);
            this.button9.TabIndex = 18;
            this.button9.Text = "Перемістити файл файл";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(605, 212);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 42);
            this.button10.TabIndex = 17;
            this.button10.Text = "Вибрати файл для переміщення";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(435, 308);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(164, 29);
            this.button11.TabIndex = 21;
            this.button11.Text = "Видалити каталог";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(605, 308);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(146, 29);
            this.button12.TabIndex = 22;
            this.button12.Text = "Видалити файл";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 555);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.CopyCat);
            this.Controls.Add(this.CopyCat2);
            this.Controls.Add(this.CopyFile2);
            this.Controls.Add(this.CopyFile);
            this.Controls.Add(this.CreateFile);
            this.Controls.Add(this.CreateCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Atributes_txt);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label Atributes_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateCat;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Button CopyFile;
        private System.Windows.Forms.Button CopyFile2;
        private System.Windows.Forms.Button CopyCat2;
        private System.Windows.Forms.Button CopyCat;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

