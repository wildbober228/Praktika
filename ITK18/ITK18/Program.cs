using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Вариант 4
В одномерном массиве, состоящем из п вещественных элементов, вычислить: 
1) сумму элементов массива с нечетными номерами;
2) сумму элементов массива, расположенных между первым и последним отри-цательными элементами. 
3) Сжать массив, удалив из него все элементы, модуль которых не превышает единицу.
4) Освободившиеся в конце массива элементы заполнить нулями.
 
*/
namespace ITK18
{
    class Program
    {
        private static IEnumerable<int> result;

        static void Main(string[] args)
        {
          

            int length;
            Console.WriteLine("ВВедите размерность массива");
            length = Int32.Parse(Console.ReadLine());
            int[] mas = new int[length];

            Console.WriteLine("ВВедите массив");
            for (int i = 0; i < length; i++)
            {
                mas[i] = Int32.Parse(Console.ReadLine());
            }

            #region Zadanie1
            var selectedMas_1 = from massive in mas 
                                where massive%2!=0
                                
                                select massive;
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Сумма нечетных чисел массива");
            Console.WriteLine(selectedMas_1.Sum());
            #endregion
            Console.WriteLine("-----------------");
            Console.WriteLine("Zadanie 2");
            Random rnd = new Random();
            int[] array = Enumerable.Range(0, 20).Select(rand=> rnd.Next(-3, 11)).ToArray();
            Console.WriteLine(string.Join(" ", array));
            var result = array.SkipWhile(x => x >= 0).Skip(1).Reverse().SkipWhile(x => x >= 0).Skip(1).ToArray();
            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine(result.Sum());
          
            Console.WriteLine("-----------------");
            Console.WriteLine("Zadanie 3");
                       var result_3 = from massive in mas
                                where Math.Abs(massive) <=1

                                select massive;
            foreach (int s in result_3)
            {
                Console.WriteLine(" "+s);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Zadanie 4");

            int new_length = mas.Length-result_3.Count();
            Console.WriteLine("new_length" + new_length);

            Queue<int> q = new Queue<int>();
            //q = (Queue<int>)result_3;
            for (int i = 0; i < new_length; i++)
            {
                q.Enqueue(0);
              
            }
            Console.WriteLine();
            Console.Write(string.Join(" ", q));
            Console.Write(" ");
            Console.Write(string.Join(" ", result_3));

        }
    }
}
