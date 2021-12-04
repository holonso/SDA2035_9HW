using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_9HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");

            Console.Write("Введите целое число. X = ");
            int a = 0;
            int b = 0;
            a = NumInput();
            Console.Write("Введите целое число. Y = ");
            b = NumInput();
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("   1 - сложение");
            Console.WriteLine("   2 - вычитание");
            Console.WriteLine("   3 - произведение");
            Console.WriteLine("   4 - частное");
            Console.Write("Ваш выбор: ");
            int oper = Convert.ToInt32(Console.ReadLine());
            int Result = 0;

            switch (oper)
            {
                case 1:
                    Result = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, Result);
                    break;
                case 2:
                    Result = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, Result);
                    break;
                case 3:
                    Result = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, Result);
                    break;
                case 4:
                    Result = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, Result);
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером");
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        private static int NumInput()
        {
            int num;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ошибка! Попробуйте снова ввести число: ");
                }
            }
            return num;
        }
    }
}
