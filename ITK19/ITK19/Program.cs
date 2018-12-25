using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Вариант 4 
В одномерном массиве, состоящем из я вещественных элементов, вычислить: 
• сумму элементов массива с нечетными номерами; 
• сумму элементов массива, расположенных между первым и последним отрицательными элементами. 
Сжать массив, удалив из него все элементы, модуль которых не превышает единицу. Освободившиеся в конце массива элементы заполнить нулями. 
*/
namespace ITK19
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                const int size = 7;
                int* mass = stackalloc int[size];
                int* p = mass;
                int sum = 0;

                for (int i = 0; i < size; i++)
                {
                    p[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < size; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += p[i];
                    }
                }
                Console.WriteLine("Zadanie 1");
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("-----------------");
                Console.WriteLine("Zadanie 2");
                int numMaxFirst = 0, count = 0, summ = 0;
                for (int i = 0; i < size; i++)
                {
                    if (p[i] < 0)
                    {
                        numMaxFirst = i;
                        break;
                    }
                }

                for (int i = size; i >= 0; --i)
                {
                    if (p[i] < 0)
                    {
                        if (i == numMaxFirst)
                        {
                            Console.WriteLine("none positive element: 0");
                        }
                        else
                        {
                            for (int j = numMaxFirst; j < i; j++)
                                summ += p[j];
                            Console.WriteLine("summ between otrizatl element:  " + summ);
                        }
                        break;
                    }

                }

                Console.WriteLine("-----------");
                Console.WriteLine("Zadanie 3");


                int help = 0;
                for (int i = 0; i < size; i++)
                {
                    if (Math.Abs(p[i]) <= 1)
                    {

                        help++;
                    }
                }
                Console.WriteLine("Size = "+help);
                int* mass_2 = stackalloc int[help];
                int he = 0;
                for (int i = 0; i < size; i++)
                {
                    if (Math.Abs(p[i]) <= 1)
                    {
                        mass_2[he] = p[i];
                        he++;
                    }

                }
                int new_size = size - help;

                for (int i = size; i > new_size; i--)
                {
                    mass_2[i] = 0;
                }

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(mass_2[i]);
                }
            }
        }
    }
}
