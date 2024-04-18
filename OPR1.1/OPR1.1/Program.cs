using System;

namespace program
{
    class Money
    {
        private int rubles;
        private int kopeks;

        public Money(int rubles, int kopeks)
        {
            this.rubles = rubles;
            this.kopeks = kopeks;
            FIX();
        }

        private void FIX()
        {
            if (kopeks >= 100)
            {
                rubles += kopeks / 100;
                kopeks %= 100;
            }
            else if (kopeks < 0)
            {
                rubles += (kopeks - 99) / 100;
                kopeks = 100 + (kopeks % 100);
            }
        }

        public void Add(int otherRubles, int otherKopeks)
        {
            rubles += otherRubles;
            kopeks += otherKopeks;
            FIX();
        }

        public void Subtract(int otherRubles, int otherKopeks)
        {
            rubles -= otherRubles;
            kopeks -= otherKopeks;
            FIX();
        }

        public void Multiply(double factor)
        {
            double totalKopeks = rubles * 100 + kopeks;
            totalKopeks *= factor;
            rubles = (int)(totalKopeks / 100);
            kopeks = (int)(totalKopeks % 100);
            FIX();
        }

        public void Divide(int divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return;
            }

            double totalKopeks = rubles * 100 + kopeks;
            totalKopeks /= divisor;
            rubles = (int)(totalKopeks / 100);
            kopeks = (int)(totalKopeks % 100);
            FIX();
        }

        public void Divide(double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return;
            }

            double totalKopeks = rubles * 100 + kopeks;
            totalKopeks /= divisor;
            rubles = (int)(totalKopeks / 100);
            kopeks = (int)(totalKopeks % 100);
            FIX();
        }

        public void Print()
        {
            Console.WriteLine($"На вашем счету: {rubles},{kopeks:D2}");
        }

        public void cout()
        {
            Console.WriteLine($"Теперь на вашем счету: {rubles},{kopeks:D2}");
        }

        public bool Compare(int otherRubles, int otherKopeks)
        {
            return rubles == otherRubles && kopeks == otherKopeks;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Здравствуйте, давайте получим информацию по вашему счету.");
                Console.Write("Количество рублей на счету: ");
                int rubles = Convert.ToInt32(Console.ReadLine());
                Console.Write("Количество копеек на счету: ");
                int kopeks = Convert.ToInt32(Console.ReadLine());

                Money m = new Money(rubles, kopeks);
                m.Print();

                Console.WriteLine("Действие со счетом: ");
                Console.WriteLine("1. Внести денег на счет");
                Console.WriteLine("2. Вывести деньги со счета");
                Console.WriteLine("3. Приумножить деньги на счет");
                Console.WriteLine("4. Разделить счет на целое число");
                Console.WriteLine("5. Разделить счет на дробное число");
                Console.WriteLine("6. Узнать текущий баланс");
                Console.WriteLine("7. Сравнить счет");
                Console.WriteLine("8. Выход");

                Console.Write("Ваш выбор: ");
                int user_input = Convert.ToInt32(Console.ReadLine());

                switch (user_input)
                {
                    case 1:
                        Console.Write("Количество рублей для внесения: ");
                        int addRubles = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Количество копеек для внесения: ");
                        int addKopeks = Convert.ToInt32(Console.ReadLine());
                        m.Add(addRubles, addKopeks);
                        m.cout();
                        break;
                    case 2:
                        Console.Write("Количество рублей для вывода: ");
                        int subRubles = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Количество копеек для вывода: ");
                        int subKopeks = Convert.ToInt32(Console.ReadLine());
                        m.Subtract(subRubles, subKopeks);
                        m.cout();
                        break;
                    case 3:
                        Console.Write("Множитель: ");
                        double multiplier = Convert.ToDouble(Console.ReadLine());
                        m.Multiply(multiplier);
                        m.cout();
                        break;
                    case 4:
                        Console.Write("Делитель: ");
                        int divisorInt = Convert.ToInt32(Console.ReadLine());
                        m.Divide(divisorInt);
                        m.cout();
                        break;
                    case 5:
                        Console.Write("Делитель: ");
                        double divisorDouble = Convert.ToDouble(Console.ReadLine());
                        m.Divide(divisorDouble);
                        m.cout();
                        break;
                    case 6:
                        m.Print();
                        break;
                    case 7:
                        Console.Write("Введите количество рублей для сравнения: ");
                        int compareRubles = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите количество копеек для сравнения: ");
                        int compareKopeks = Convert.ToInt32(Console.ReadLine());
                        if (m.Compare(compareRubles, compareKopeks))
                        {
                            Console.WriteLine("Счеты совпадают.");
                        }
                        else
                        {
                            Console.WriteLine("Счеты не совпадают.");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Программа завершена.");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода!!!");
                Main();
            }

        }
    }
}
