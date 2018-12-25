using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ITK7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ВВедите номер паспорта");
          //  for (; ; )
            {
                // string pass_nom = @"ab1234567 AB1234567, MP12345678 MP987654 MC1234567";//Console.ReadLine();
                // string nomer = @"\b(?i)(AB|BM|HB|KH||MP|MC|KB|PP){2}\d{7}\b";

                string pass_nom = @"Af ad 1s Aa3 df 3dd dssddewe";
                string nomer = @"\b[A-Z]\w*\b";
                    foreach (Match m in Regex.Matches(pass_nom, nomer))
                    Console.WriteLine(m); //Regex.IsMatch(pass_nom, nomer)); 
            }
        }
    }
}
