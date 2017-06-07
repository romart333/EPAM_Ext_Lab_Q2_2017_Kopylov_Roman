﻿// Написать программу, которая определяет площадь прямоугольника со сторонами a и b.
// Если пользователь вводит некорректные значения (отрицательные, или 0), должно выдаваться сообщение об ошибке.
// Возможность ввода пользователем строки вида «абвгд», или нецелых чисел игнорировать.
namespace Task06
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool result = false;
            int param = 0;
            string bold = "Bold", italic = "Italic", underline = "Underline", none = "None";
            int bitParam = 0;
            while (true)//todo pn как пользователь программно выйдет из консоли? Он может бояться нажать на крестик.
            {
                
                Console.WriteLine("Параметры записи: ");
                if (bitParam == 0)
                {
                    Console.WriteLine(none);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}", 
						(bitParam & 1) > 0 ? bold + " " : string.Empty, 
						(bitParam & 2) > 0 ? italic + " " : string.Empty, 
						(bitParam & 4) > 0 ? underline : string.Empty);//toro pn такие длинные строки кода лучше разбивать на несколько. Строка должна влезать на стандартный экран (диагональ 15/17 дюймов)
                }

                Console.WriteLine("Введите: ");
                Console.WriteLine($"\t1: {bold}\n\t2: {italic}\n\t3: {underline}");
                while (true)
                {
                    result = int.TryParse(Console.ReadLine(), out param);
                    if (!result || param < 1 || param > 3)
                    {
                        Console.WriteLine("Неверный ввод.");
                        continue;
                    }

                    break;
                }

                bitParam = bitParam ^ (1 << (param - 1));
            }
        }
    }
}
