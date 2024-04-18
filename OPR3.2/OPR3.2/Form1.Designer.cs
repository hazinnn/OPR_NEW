namespace SumCalculator
{
    partial class MainForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.formulaRadioButton = new System.Windows.Forms.RadioButton();
            this.loopRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(30, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(30, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(30, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 2;
            // 
            // formulaRadioButton
            // 
            this.formulaRadioButton.AutoSize = true;
            this.formulaRadioButton.Location = new System.Drawing.Point(10, 20);
            this.formulaRadioButton.Name = "formulaRadioButton";
            this.formulaRadioButton.Size = new System.Drawing.Size(87, 17);
            this.formulaRadioButton.TabIndex = 3;
            this.formulaRadioButton.TabStop = true;
            this.formulaRadioButton.Text = "По формуле";
            this.formulaRadioButton.UseVisualStyleBackColor = true;
            // 
            // loopRadioButton
            // 
            this.loopRadioButton.AutoSize = true;
            this.loopRadioButton.Location = new System.Drawing.Point(10, 50);
            this.loopRadioButton.Name = "loopRadioButton";
            this.loopRadioButton.Size = new System.Drawing.Size(150, 17);
            this.loopRadioButton.TabIndex = 4;
            this.loopRadioButton.TabStop = true;
            this.loopRadioButton.Text = "Суммированием циклом";
            this.loopRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loopRadioButton);
            this.groupBox1.Controls.Add(this.formulaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(180, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ расчета";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "MainForm";
            this.Text = "Sum Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

