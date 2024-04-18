using System;

namespace Program
{
    class Goods
    {
        private string name;
        private DateTime purchaseDate;
        private double price;
        private int quantity;
        private string invoiceNumber;


        public Goods(string name, DateTime purchaseDate, double price, int quantity, string invoiceNumber)
        {
            this.name = name;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.quantity = quantity;
            this.invoiceNumber = invoiceNumber;
        }


        public void ChangePrice(double newPrice)
        {
            price = newPrice;
        }


        public void IncreaseQuantity(int amount)
        {
            quantity += amount;
        }


        public void DecreaseQuantity(int amount)
        {
            if (amount <= quantity)
            {
                quantity -= amount;
            }
            else
            {
                Console.WriteLine("Ошибка: невозможно уменьшить количество товара больше, чем есть на складе.");
            }
        }


        public double CalculateTotalPrice()
        {
            return price * quantity;
        }


        public void DisplayTotalPrice()
        {
            Console.WriteLine($"Общая стоимость товара \"{name}\": {CalculateTotalPrice()}");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите название товара: ");
                string name = Console.ReadLine();

                Console.Write("Введите дату покупки товара: ");
                DateTime purchaseDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Введите цену товара: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Введите количество товара: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Введите номер счета: ");
                string invoiceNumber = Console.ReadLine();

                Goods product = new Goods(name, purchaseDate, price, quantity, invoiceNumber);

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Изменить цену товара");
                Console.WriteLine("2. Увеличить количество товара");
                Console.WriteLine("3. Уменьшить количество товара");
                Console.Write("Ваш выбор: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите новую цену товара: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        product.ChangePrice(newPrice);
                        break;
                    case 2:
                        Console.Write("Введите количество товара: ");
                        int increaseAmount = int.Parse(Console.ReadLine());
                        product.IncreaseQuantity(increaseAmount);
                        break;
                    case 3:
                        Console.Write("Введите количество товара: ");
                        int decreaseAmount = int.Parse(Console.ReadLine());
                        product.DecreaseQuantity(decreaseAmount);
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }


                product.DisplayTotalPrice();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода!!!");
                Main();
            }

        }
    }
}
