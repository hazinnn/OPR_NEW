using System;
using System.Windows.Forms;

namespace SumCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                int n = (int)numericUpDown1.Value;
                long sum = 0;

                if (formulaRadioButton.Checked)
                {

                    sum = n * (n + 1) * (2 * n + 1) / 6;
                }
                else if (loopRadioButton.Checked)
                {

                    for (int i = 1; i <= n; i++)
                    {
                        sum += i * i;
                    }
                }

                resultLabel.Text = $"Сумма: {sum}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка ввода: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.formulaRadioButton = new System.Windows.Forms.RadioButton();
            this.loopRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();




            this.numericUpDown1.Location = new System.Drawing.Point(30, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;




            this.calculateButton.Location = new System.Drawing.Point(30, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);




            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(30, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 2;





            this.formulaRadioButton.AutoSize = true;
            this.formulaRadioButton.Location = new System.Drawing.Point(10, 20);
            this.formulaRadioButton.Name = "formulaRadioButton";
            this.formulaRadioButton.Size = new System.Drawing.Size(87, 17);
            this.formulaRadioButton.TabIndex = 3;
            this.formulaRadioButton.TabStop = true;
            this.formulaRadioButton.Text = "По формуле";
            this.formulaRadioButton.UseVisualStyleBackColor = true;




            this.loopRadioButton.AutoSize = true;
            this.loopRadioButton.Location = new System.Drawing.Point(10, 50);
            this.loopRadioButton.Name = "loopRadioButton";
            this.loopRadioButton.Size = new System.Drawing.Size(135, 17);
            this.loopRadioButton.TabIndex = 4;
            this.loopRadioButton.TabStop = true;
            this.loopRadioButton.Text = "Суммированием циклом";
            this.loopRadioButton.UseVisualStyleBackColor = true;



            this.groupBox1.Controls.Add(this.loopRadioButton);
            this.groupBox1.Controls.Add(this.formulaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(180, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ расчета";



            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "MainForm";
            this.Text = "Sum Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton formulaRadioButton;
        private System.Windows.Forms.RadioButton loopRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
