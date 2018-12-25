using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK12
{
    class Program
    {
        #region zad_1

        
        
        static int fib(int n)
        {
            return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }

        static void Main(string[] args)
        {

            int n = 10;
            //  string fib = "фффф0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711аываы";

            
            Random rnd = new Random();
            Console.WriteLine("Записанный массив:");
            using (BinaryWriter BW = new BinaryWriter(File.Open(@"d:\mas.bin", FileMode.Create)))
            {
                for (int i = 0; i < n; i++)
                {
                    int a = fib(i);
                    BW.Write(a);
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine("\nПрочитанный массив:");
            using (BinaryReader BR = new BinaryReader(File.Open(@"d:\mas.bin", FileMode.Open))) 
            {
                List<int> list = new List<int>();
                List<int> list_true = new List<int>();
                while (BR.BaseStream.Position != BR.BaseStream.Length)
                {
                    Console.WriteLine(("POS= "+ (BR.BaseStream.Position + 4) /4));
                    string help = ((BR.BaseStream.Position + 4) / 4).ToString();

                    int a = Int32.Parse(help);
                    if (a%3 == 0)
                    list.Add(BR.ReadInt32());
                    else
                    list_true.Add(BR.ReadInt32());
                }
                Console.WriteLine(string.Join(" ", list_true));
            }
            Console.ReadLine();
        }
      

        

        #endregion


        #region zad_2
        
    //static void Main(string[] args)
    //{
    //    string path = @"C:\ITK12\data.txt";
    //    Console.WriteLine();
    //    Console.WriteLine("******считываем построчно********");
    //    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
    //    {
    //        string line="";
    //        string line_text = "";
    //        int max = line.Length;
    //        while ((line = sr.ReadLine()) != null)
    //        {                
    //            if (max < line.Length)
    //            {
    //                max = line.Length;
    //                line_text = line;
    //            }
    //        }
    //        Console.WriteLine(line_text +" "+ line_text.Length);
    //    }


    //}
    
        #endregion


        //static void AddCatalog(string name, string path)
        //{
        //   // string path = @"C:\SomeDir";
            
        //    DirectoryInfo dirInfo = new DirectoryInfo(path);
        //    if (!dirInfo.Exists)
        //    {
        //        dirInfo.Create();
        //    }
        //    dirInfo.CreateSubdirectory(name);
        //} 

        //static void AddText(string path, string text)
        //{

        //    using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
        //    {
        //        // преобразуем строку в байты
        //        byte[] array = System.Text.Encoding.Default.GetBytes(text);
        //        // запись массива байтов в файл
        //        fstream.Write(array, 0, array.Length);
              
        //        fstream.Close();
        //    }

        //}

        //static string GetText(string path)
        //{
        //    string text_to_out="";
        //    using (FileStream fstream = File.OpenRead(path))
        //    {
        //        // преобразуем строку в байты
        //        byte[] array = new byte[fstream.Length];
        //        // считываем данные
        //        fstream.Read(array, 0, array.Length);
        //        // декодируем байты в строку
        //        string textFromFile = System.Text.Encoding.Default.GetString(array);
             
        //        text_to_out = textFromFile;
        //    }
        //    return text_to_out;

        //}

        //static void Copy(string path, string newPath)
        //{
            
        //    FileInfo fileInf = new FileInfo(path);
        //    if (fileInf.Exists)
        //    {
        //        fileInf.CopyTo(newPath, true);
               
        //    }
        //}

        //static void Transfer(string path, string newPath)
        //{
            
        //    FileInfo fileInf = new FileInfo(path);
        //    if (fileInf.Exists)
        //    {
        //        fileInf.MoveTo(newPath);
               
        //    }
        //}

        //static void GetInfo(string path)
        //{
           
        //    FileInfo fileInf = new FileInfo(path);
        //    if (fileInf.Exists)
        //    {
        //        Console.WriteLine("Имя файла: {0}", fileInf.Name);
        //        Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
        //        Console.WriteLine("Размер: {0}", fileInf.Length);
        //        Console.WriteLine(" ");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    string temp = "C:/temp"; //k1 and k2

        //    AddCatalog("k1",temp);
        //    AddCatalog("k2", temp);

           

        //    AddText("C:\\temp/t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
        //    AddText("C:\\temp/t2.txt", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
        //   string s1= GetText("C:\\temp/t1.txt");
        //   string s2 = GetText("C:\\temp/t2.txt");
        //   AddText("C:\\temp/k2/t3.txt", s1+" "+s2);

        //    GetInfo("C:\\temp/t1.txt");
        //    GetInfo("C:\\temp/t2.txt");
        //    GetInfo("C:\\temp/k2/t3.txt");
        //    Transfer("C:\\temp/t2.txt", "C:\\temp/k2/t2.txt");
        //    Copy("C:\\temp/t1.txt", "C:\\temp/k2/t1.txt");
        //    System.IO.Directory.Move(@"C:/temp/k2", @"C:/temp/all");
        //    Directory.Delete(@"C:/temp/k1", true);
        //    DirectoryInfo dirInfo = new DirectoryInfo(@"C:/temp/all");
        //    Console.WriteLine("Имя папки: {0}", dirInfo.Name);
        //    Console.WriteLine("Время создания: {0}", dirInfo.CreationTime);
        //    foreach (FileInfo f in dirInfo.GetFiles())
        //    {
        //        Console.WriteLine("Имя файла: {0}", f.Name);
        //    }
           
        //    Console.WriteLine(" ");




        //}
    }
}
//FileInfo File_1 = new FileInfo("D:\\temp/k1/t1.txt");
//File_1.Create();



//FileInfo File_2 = new FileInfo("D:\\temp/k2/t2.txt");
//File_2.Create();
//File_2.OpenWrite();