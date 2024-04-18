using System;
using System.Windows.Forms;

namespace PurchaseCalculator
{
    public partial class MainForm : Form
    {
        private TextBox notebookPriceTextBox;
        private TextBox notebookQuantityTextBox;
        private TextBox pencilPriceTextBox;
        private TextBox pencilQuantityTextBox;
        private Button calculateButton;
        private Label totalCostLabel;
        private Label notebookPriceLabel;
        private Label notebookQuantityLabel;
        private Label pencilPriceLabel;
        private Label pencilQuantityLabel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.notebookPriceLabel = new System.Windows.Forms.Label();
            this.notebookQuantityLabel = new System.Windows.Forms.Label();
            this.pencilPriceLabel = new System.Windows.Forms.Label();
            this.pencilQuantityLabel = new System.Windows.Forms.Label();
            this.notebookPriceTextBox = new System.Windows.Forms.TextBox();
            this.notebookQuantityTextBox = new System.Windows.Forms.TextBox();
            this.pencilPriceTextBox = new System.Windows.Forms.TextBox();
            this.pencilQuantityTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notebookPriceLabel
            // 
            this.notebookPriceLabel.AutoSize = true;
            this.notebookPriceLabel.Location = new System.Drawing.Point(30, 10);
            this.notebookPriceLabel.Name = "notebookPriceLabel";
            this.notebookPriceLabel.Size = new System.Drawing.Size(79, 13);
            this.notebookPriceLabel.TabIndex = 0;
            this.notebookPriceLabel.Text = "Цена тетради:";
            // 
            // notebookQuantityLabel
            // 
            this.notebookQuantityLabel.AutoSize = true;
            this.notebookQuantityLabel.Location = new System.Drawing.Point(150, 10);
            this.notebookQuantityLabel.Name = "notebookQuantityLabel";
            this.notebookQuantityLabel.Size = new System.Drawing.Size(118, 13);
            this.notebookQuantityLabel.TabIndex = 1;
            this.notebookQuantityLabel.Text = "Количество тетрадей:";
            // 
            // pencilPriceLabel
            // 
            this.pencilPriceLabel.AutoSize = true;
            this.pencilPriceLabel.Location = new System.Drawing.Point(30, 60);
            this.pencilPriceLabel.Name = "pencilPriceLabel";
            this.pencilPriceLabel.Size = new System.Drawing.Size(95, 13);
            this.pencilPriceLabel.TabIndex = 2;
            this.pencilPriceLabel.Text = "Цена карандаша:";
            // 
            // pencilQuantityLabel
            // 
            this.pencilQuantityLabel.AutoSize = true;
            this.pencilQuantityLabel.Location = new System.Drawing.Point(150, 60);
            this.pencilQuantityLabel.Name = "pencilQuantityLabel";
            this.pencilQuantityLabel.Size = new System.Drawing.Size(134, 13);
            this.pencilQuantityLabel.TabIndex = 3;
            this.pencilQuantityLabel.Text = "Количество карандашей:";
            // 
            // notebookPriceTextBox
            // 
            this.notebookPriceTextBox.Location = new System.Drawing.Point(30, 30);
            this.notebookPriceTextBox.Name = "notebookPriceTextBox";
            this.notebookPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.notebookPriceTextBox.TabIndex = 0;
            // 
            // notebookQuantityTextBox
            // 
            this.notebookQuantityTextBox.Location = new System.Drawing.Point(150, 30);
            this.notebookQuantityTextBox.Name = "notebookQuantityTextBox";
            this.notebookQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.notebookQuantityTextBox.TabIndex = 1;
            // 
            // pencilPriceTextBox
            // 
            this.pencilPriceTextBox.Location = new System.Drawing.Point(30, 80);
            this.pencilPriceTextBox.Name = "pencilPriceTextBox";
            this.pencilPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.pencilPriceTextBox.TabIndex = 2;
            // 
            // pencilQuantityTextBox
            // 
            this.pencilQuantityTextBox.Location = new System.Drawing.Point(150, 80);
            this.pencilQuantityTextBox.Name = "pencilQuantityTextBox";
            this.pencilQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.pencilQuantityTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(30, 110);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(220, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(30, 140);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(0, 13);
            this.totalCostLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.notebookPriceLabel);
            this.Controls.Add(this.notebookQuantityLabel);
            this.Controls.Add(this.pencilPriceLabel);
            this.Controls.Add(this.pencilQuantityLabel);
            this.Controls.Add(this.notebookPriceTextBox);
            this.Controls.Add(this.notebookQuantityTextBox);
            this.Controls.Add(this.pencilPriceTextBox);
            this.Controls.Add(this.pencilQuantityTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCostLabel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                double notebookPrice = Convert.ToDouble(notebookPriceTextBox.Text);
                int notebookQuantity = Convert.ToInt32(notebookQuantityTextBox.Text);
                double pencilPrice = Convert.ToDouble(pencilPriceTextBox.Text);
                int pencilQuantity = Convert.ToInt32(pencilQuantityTextBox.Text);


                double totalCost = (notebookPrice * notebookQuantity) + (pencilPrice * pencilQuantity);


                totalCostLabel.Text = $"Общая стоимость покупки: {totalCost:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
