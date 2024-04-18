namespace OPR4._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            listBox3 = new ListBox();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 384);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(403, 32);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(385, 384);
            listBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 2;
            label1.Text = "Добавлено в файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 9);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 3;
            label2.Text = "Загружено из файла";
            // 
            // button1
            // 
            button1.Location = new Point(12, 422);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 4;
            button1.Text = "Сгенерировать записи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(201, 422);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 5;
            button2.Text = "Загрузить записи из файла";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 426);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 6;
            label3.Text = "Поиск по счёту:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(551, 423);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(794, 32);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(385, 384);
            listBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(794, 9);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 9;
            label4.Text = "Найденные записи";
            // 
            // button3
            // 
            button3.Location = new Point(682, 422);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Найти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 461);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(listBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox3;
        private Label label4;
        private Button button3;
    }
}
