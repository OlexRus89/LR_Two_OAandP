using System;
using System.IO;

namespace LR_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            bool console = true;
            while (console)
            {
                // Вариант 27
                Console.WriteLine("Для изменения данных файл input.txt находится в @/LR_Two/LR_Two/bin/Debug/netcoreapp3.1");
                Console.WriteLine("Для просмотра результатов данных файла output.txt находится в @/LR_Two/LR_Two/bin/Debug/netcoreapp3.1");
                Console.WriteLine();
                TextWriter save_out = Console.Out;
                TextReader save_in = Console.In;
                var new_out = new StreamWriter(@"output.txt");
                var new_in = new StreamReader(@"input.txt");
                Console.SetOut(new_out);
                Console.SetIn(new_in);
                double a, b, c, d, e;
                double s, k;
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = Convert.ToDouble(Console.ReadLine());
                e = Convert.ToDouble(Console.ReadLine());
                if ((b<0)||(e<0))
                {
                    Console.WriteLine("ERROR");
                }
                else if (b+a-e<0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    s = (a / Math.Sqrt(b + a - e)) + ((c + Math.Sqrt(b + a - e)) / (Math.Sqrt(e)));
                    Console.WriteLine(String.Format("Ответ для S: {0:0.000}", s));
                }
                if (e-a<0)
                {
                    Console.WriteLine("ERROR");
                }
                else if (c-4*b<0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    k = (Math.Sqrt(e - a)) / (Math.Sqrt(c - 4 * b) - e);
                    Console.WriteLine(String.Format("Ответ для K: {0:0.000}", k));
                }
                Console.SetOut(save_out); new_out.Close();
                Console.SetIn(save_in); new_in.Close();

                Console.Write("Хотите выйти из консоли? (y/n): ");
                char yn = Convert.ToChar(Console.ReadLine());
                if (yn =='y')
                {
                    console = false;
                    break;
                }
                else if (yn == 'n')
                {
                    console = true;
                }
            }
        }
    }
}
