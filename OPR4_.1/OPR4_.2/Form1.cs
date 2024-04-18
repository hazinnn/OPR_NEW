using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OPR4._2
{
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    public partial class Form1 : Form
    {
        List<ZNAK> generatedZNAKs = new List<ZNAK>();
        List<ZNAK> fileZNAKs = new List<ZNAK>();

        Random rnd = new Random();
        ListBox listBox1;
        ListBox listBox2;
        ListBox listBox3;
        Label label1;
        Label label2;
        Label label3;
        TextBox textBox1;
        Button button1;
        Button button2;
        Button button3;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 24);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 289);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(324, 24);
            listBox2.Margin = new Padding(2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(292, 289);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(642, 24);
            listBox3.Margin = new Padding(2);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(283, 289);
            listBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Добавлено в файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Загружено из файла";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 5;
            label3.Text = "Найденные записи";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(929, 24);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(929, 51);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(121, 22);
            button1.TabIndex = 7;
            button1.Text = "Сгенерировать записи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(929, 77);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(121, 22);
            button2.TabIndex = 8;
            button2.Text = "Загрузить записи из файла";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(929, 103);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(121, 22);
            button3.TabIndex = 9;
            button3.Text = "Найти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 338);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                string name = GenerateRandomName();
                string zodiacSign = GenerateRandomZodiacSign();
                DateTime birthDate = GenerateRandomBirthDate();

                generatedZNAKs.Add(new ZNAK(name, zodiacSign, birthDate));
            }

            listBox1.Items.Clear();

            foreach (var z in generatedZNAKs.OrderBy(z => z.Name))
            {
                listBox1.Items.Add(z);
            }

            using (StreamWriter writer = new StreamWriter("data.txt", false))
            {
                foreach (var z in generatedZNAKs)
                {
                    writer.WriteLine(z.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                fileZNAKs.Clear();

                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');
                        if (fields.Length == 3)
                        {
                            fileZNAKs.Add(new ZNAK(fields[0], fields[1], DateTime.Parse(fields[2])));
                        }
                    }
                }

                foreach (var z in fileZNAKs.OrderBy(z => z.Name))
                {
                    listBox2.Items.Add(z);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            string sign = textBox1.Text;
            bool found = false;

            foreach (ZNAK z in fileZNAKs)
            {
                if (z.ZodiacSign == sign)
                {
                    listBox3.Items.Add(z);
                    found = true;
                }
            }

            if (!found)
                MessageBox.Show($"Люди, родившиеся под знаком '{sign}', не найдены");
        }
        private string GenerateRandomName()
        {
            string[] names = { "Александр", "Иван", "Екатерина", "Ольга", "Павел", "Сергей", "Наталья", "Анна", "Дмитрий", "Мария" };
            string[] surnames = { "Иванов", "Петров", "Смирнов", "Васильев", "Козлов", "Лебедева", "Морозова", "Никитина", "Федоров", "Алексеев" };

            return $"{names[rnd.Next(names.Length)]} {surnames[rnd.Next(surnames.Length)]}";
        }

        private string GenerateRandomZodiacSign()
        {
            string[] signs = { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };
            return signs[rnd.Next(signs.Length)];
        }

        private DateTime GenerateRandomBirthDate()
        {
            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class ZNAK
    {
        public string Name;
        public string ZodiacSign;
        public DateTime BirthDate;

        public ZNAK(string name, string sign, DateTime birthDate)
        {
            Name = name;
            ZodiacSign = sign;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} - {ZodiacSign} ({BirthDate.ToShortDateString()})";
        }

    }
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}