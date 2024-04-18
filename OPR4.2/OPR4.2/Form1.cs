using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text.RegularExpressions;

namespace OPR4._2
{
    public partial class Form1 : Form
    {
        List<Order> generedOrders = new List<Order>();
        List<Order> fileOrders = new List<Order>();

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                string debA = "";
                debA += rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString()
                    + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString();
                string depA = "";
                depA += rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString()
                    + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString();

                int s = rnd.Next(1, 1000000);

                generedOrders.Add(new Order(debA, depA, s));
            }

            listBox1.Items.Clear();


            for (int i = 0; i < generedOrders.Count; i++)
            {
                listBox1.Items.Add(generedOrders[i]);
            }

            using (StreamWriter writer = new StreamWriter("data.txt", false))
            {
                foreach (var o in generedOrders)
                {
                    writer.WriteLine(o.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                fileOrders.Clear();

                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] strs = reader.ReadLine().Split(' ');
                        fileOrders.Add(new Order(strs[1], strs[3], Convert.ToInt32(strs[4])));
                    }
                }


                for (int i = 0; i < fileOrders.Count; i++)
                {
                    listBox2.Items.Add(fileOrders[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            string key = textBox1.Text;
            bool found = false;

            foreach (Order o in fileOrders)
            {
                if(o.debitAcc == key)
                {
                    listBox3.Items.Add(o);
                    found = true;
                }
            }   
            if (!found)
                MessageBox.Show("Записи с таким счётом не найдено");
        }
    }

    class Order
    {
        public string debitAcc;
        public string depositAcc;
        public int summ;

        public Order(string debAcc, string depAcc, int s)
        {
            debitAcc = debAcc;
            depositAcc = depAcc;
            summ = s;
        }

        public override string ToString()
        {
            return string.Format($"С {debitAcc} на {depositAcc} {summ} руб");
        }
    }

}
