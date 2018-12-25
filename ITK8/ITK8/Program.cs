using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ITK8
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nomer = @"\b[A-Z]\w*\b";
            string pass_nom = @"Af ad 1s Aa3 df 3dd Aa34567_  _34567aA 1aAaAa_f 12_sas Az0_Az0_ AA_98aaa 1s1111";
            string nomer = @"\b(?=.*[0-9])(?=.*[_])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z_]{8}\b";  
            foreach (Match m in Regex.Matches(pass_nom, nomer))
                Console.WriteLine(m); //Regex.IsMatch(pass_nom, nomer)); 
        }
    }
}
/*
 11	«Хороший» пароль должен иметь длину в 8 символов, 
 содержать большие, маленькие буквы латинского алфавита,
 цифры, подчёркивание, причём должен быть включён хотя бы один
 символ из каждой группы. Найти количество «хороших» паролей в текстовом файле.
 */
