using System;

namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите два числа");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество чисел в массиве:");
            int n = int.Parse(Console.ReadLine()); 
            int[] array= new int[n];
            Console.WriteLine("Введите числа:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine().ToString());
            }
            Console.WriteLine("Выберите действие 1.Правило суммы 2.Правило произведения 3.Размещение с повторениями 4.Размещение без повторений " +
               "5. Сочетание с повторениями 6. Сочетание без повторений 7.Перестановка с повторениями 8.Перестановка без повторении(для первого числа)");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Combinatorics.Cw("1.Правило суммы", Combinatorics.CombSumm(num1, num2));
                    break;
                case 2:
                    Combinatorics.Cw("2.Правило произведения", Combinatorics.CombMult(num1, num2));
                    break;
                case 3:
                    Combinatorics.Cw("3.Размещение с повторениями", Combinatorics.CombPow(num1, num2));
                    break;
                case 4:
                    Combinatorics.Cw("4.Размещение без повторений", Combinatorics.CombParPermNoRep(num1, num2));
                    break;
                case 5:
                    Combinatorics.Cw("5. Сочетание с повторениями", Combinatorics.CombCombinationRep(num1, num2));
                    break;
                case 6:
                    Combinatorics.Cw("6. Сочетание без повторений", Combinatorics.CombCombinationNoRep(num1, num2));
                    break;
                case 7:
                    Combinatorics.Cw("7.Перестановка с повторениями", Combinatorics.CombPermRep(num1, array));
                    break;
                case 8:
                    Combinatorics.Cw("8.Перестановка без повторении(для первого числа)", Combinatorics.Fact(num1));
                    break;
                default:
                    break;
            }

        }

        class Combinatorics
        {
            static public void Cw(string name, double res)
            {
                Console.WriteLine(name + ". Ответ: " + res);
            }
            static public double Fact(double n)
            {
                double res = 1;
                for (int i = 1; i < n + 1; i++)
                {
                    res *= i;
                }
                return res;
            }

            static public double CombSumm(double a, double b)
            {
                return a + b;
            }

            static public double CombMult(double a, double b)
            {
                return a * b;
            }

            static public double CombPow(double n, double m)
            {
                double res = n;
                for (int i = 0; i < m; i++)
                {
                    res *= n;
                }
                return res;
            }

            static public double CombParPermNoRep(double n, double m)
            {
                return Fact(n) / Fact(m);
            }
            static public double CombCombinationRep(double n, double m)
            {
                return (Fact((n + m - 1)) / Fact((n - 1)) / Fact(m));
            }

            static public double CombPermRep(double num, int[] array)
            {
                double factor = 1;
                double res = 1;
                Array.Sort(array);
                for (int i = 1; i < array[0] + 1; i++)
                {
                    factor *= i;
                    if (i>=1 && i<= array[0] + 1)
                    {
                        res *= factor;
                    }
                }
                return Fact(num) / res;
            }

            static public double CombCombinationNoRep(double n, double m)
            {
                return (Fact(n) / (Fact(m) * Fact(n - m)));
            }


        }
    }
}
