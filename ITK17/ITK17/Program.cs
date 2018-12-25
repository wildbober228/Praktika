using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ITK17
{
    public class Program
    {

        #region Zadanie1
        /*
        static void Main(string[] args)
        {
            string s1 = "112345";

            string s2 = "543211";

            Stack<int> s1_stack = new Stack<int>();
            Stack<int> s2_stack = new Stack<int>();

            int check = 0;

            int ss1=0, ss2=0;
            for (int i = 0; i < s1.Length; i++)
            {
                s1_stack.Push(s1[i]);
              
            }
            Console.WriteLine("---------");
            for (int i = s1.Length-1; i >=0; i--)
            {
                s2_stack.Push(s2[i]);
                
            }
            if(s1.Length == s2.Length)
            for (int i=0; i < s1.Length;i++)
            {
                    ss1 = s1_stack.Pop();
                    ss2 = s2_stack.Pop();
                    if(ss1 == ss2)
                    {
                        check++;
                    }
            }
            if(check == s1.Length)
            Console.WriteLine("Строка s2 обратна строке s1");
            else
            Console.WriteLine("Строка s2 не обратна строке s1");

        }
        */
        #endregion

        #region Zadanie2
        /*
        static void Main(string[] args)
        {
            string path = @"C:\ITK17\itk17_2.txt";
            Queue<int> numbers_plus = new Queue<int>();
            int plus = 0;
            int minus = 0;
            Queue<int> numbers_minus = new Queue<int>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if(Int32.Parse(line) >= 0)
                    {
                        numbers_plus.Enqueue(Int32.Parse(line));
                        plus++;
                        Console.WriteLine(Int32.Parse(line));
                    }
                    if (Int32.Parse(line) < 0)
                    {
                        numbers_minus.Enqueue(Int32.Parse(line));
                        minus++;
                        Console.WriteLine(Int32.Parse(line));
                    }

                }
            }
            Console.WriteLine("-----------");
            for (int i = 0; i < plus; i++)
            {
               Console.Write(numbers_plus.Dequeue()+" ");
            }
            for (int i = 0; i < minus; i++)
            {
                Console.Write(numbers_minus.Dequeue() + " ");
            }
        }

        */
        #endregion

        #region Zadanie3
        /*
                [Serializable]
                public class Cars : IComparer<Cars>
                {
                    public string Marka { get; set; }
                    public int NumberOfCar { get; set; }
                    public string Sname { get; set; }
                    public int DateOfBuy { get; set; }
                    public int Probeg { get; set; }

                    public Cars(){}

                    public Cars(string marka,int numbercar, string sname, int databuy,int probeg)
                    {
                        Marka = marka;
                        NumberOfCar = numbercar;
                        Sname = sname;
                        DateOfBuy = databuy;
                        Probeg = probeg;
                    }

                    public int CompareTo(object obj)
                    {
                        Cars car = obj as Cars;

                        if (car != null)
                            return this.Probeg.CompareTo(car.Probeg);
                        else
                            throw new Exception("Невозможно сравнить два объекта");
                    }

                    public int Compare(Cars x, Cars y)
                    {
                        if (x.Probeg > y.Probeg)
                        {
                            return -1;
                        }
                        else if (x.Probeg < y.Probeg)
                            return 1;
                        else
                            return 0;
                    }
                }

                static void Main(string[] args)
                {
                    #region Inicialize
                    //Cars car_1 = new Cars("BMW",777,"Sidorenko",2005,45000);
                    //Cars car_2 = new Cars("Audi", 123, "Bezmen", 2018, 450000);
                    //Cars car_3 = new Cars("Жигуль", 125, "Blinov", 2017, 100000);
                    //Cars[] cars = new Cars[] { car_1, car_2, car_3 };
                    #endregion
                    Cars car_1 = new Cars();
                    Cars car_2 = new Cars();
                    Cars car_3 = new Cars();

                    XmlSerializer formatter = new XmlSerializer(typeof(Cars[]));
                    #region Serialize
                    //using (FileStream fs = new FileStream("input.xml", FileMode.OpenOrCreate))
                    //{
                    //    formatter.Serialize(fs, cars);
                    //}
                    #endregion

                    using (FileStream fs = new FileStream("input.xml", FileMode.OpenOrCreate))
                    {
                        Cars[] car = (Cars[])formatter.Deserialize(fs);

                        //foreach(Cars car in newcars)        
                        //Console.WriteLine("Marka: {0}  Номер Машины: {1}  Фамилия: {2} Дата покупки: {3} Пробег: {4}", car[0].Marka, car[0].NumberOfCar,car[0].Sname,car[0].DateOfBuy,car[0].Probeg);
                         car_1 = new Cars(car[0].Marka, car[0].NumberOfCar, car[0].Sname, car[0].DateOfBuy, car[0].Probeg);
                         car_2 = new Cars(car[1].Marka, car[1].NumberOfCar, car[1].Sname, car[1].DateOfBuy, car[1].Probeg);
                         car_3 = new Cars(car[2].Marka, car[2].NumberOfCar, car[2].Sname, car[2].DateOfBuy, car[2].Probeg);
                    }

                    Cars[] cars = new Cars[] { car_1, car_2, car_3 };

                    Array.Sort(cars, new Cars());

                    Cars[] carsToSerial = new Cars[3];
                    int help = 0;
                    foreach (Cars car in cars)
                    {
                        if (car.DateOfBuy > 2015)
                        {
                            Console.WriteLine("Marka: {0}  Номер Машины: {1}  Фамилия: {2} Дата покупки: {3} Пробег: {4}", car.Marka, car.NumberOfCar, car.Sname, car.DateOfBuy, car.Probeg);
                            carsToSerial[help] = car;
                            help++;
                        }
                    }
                    using (FileStream fs = new FileStream("output.xml", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, carsToSerial);
                    }
                }
                */
        #endregion

        #region Zadanie 4 
        static void Main(string[] args)
        {
            Hashtable catalog = new Hashtable();
            string nameDisk =  "";
            string nameMusic = "";
            string nameOwner = "";
            Console.WriteLine("Catalog was been created");
            flag:
            WriteInfo();
            int action = Int32.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine(" Введите Имя ");
                    Console.Write(" Диска ");
                    Console.WriteLine(" ");
                    nameDisk = Console.ReadLine();
                    AddDisk(catalog, nameDisk);
                    break;
                case 2:
                    Console.WriteLine(" Введите Имя ");
                    Console.Write(" Клипа ");
                    nameMusic= Console.ReadLine();
                    Console.Write(" Диска(куда вы хотите записать музыку) ");
                    nameDisk = Console.ReadLine();
                    Console.Write(" Музыкального Испольнителя ");
                    Console.WriteLine(" ");
                    nameOwner = Console.ReadLine();
                    AddMusic(catalog,nameMusic,nameDisk, nameOwner);
                    break;
                case 3:
                    Console.WriteLine(" Введите Имя ");
                    Console.Write(" Диска(который вы хотите удалить) ");
                    Console.WriteLine(" ");
                    nameDisk = Console.ReadLine();
                    DeleteDisk(catalog, nameDisk);
                    break;
                case 4:
                    Console.WriteLine(" Введите Имя ");
                    Console.Write(" Клипа(который вы хотите удалить) ");
                    nameMusic = Console.ReadLine();
                    Console.Write(" Диска(откуда вы хотите удалить) ");
                    Console.WriteLine(" ");
                    nameDisk = Console.ReadLine();
                    DeleteMusic(catalog,nameMusic,nameDisk);
                    break;
                case 5:
                    Console.WriteLine( "Введите Имя ");
                    Console.Write( "Диска(который вы хотите просмотреть) ");
                    Console.WriteLine(" ");
                    nameDisk = Console.ReadLine();
                    SearchDick(catalog,nameDisk);
                    break;
                case 6:
                    Console.WriteLine(" Введите Имя ");
                    Console.WriteLine(" По которому вы хотите найти треки ");
                    Console.WriteLine(" ");
                    nameOwner = Console.ReadLine();
                    SearchFromCatalog(catalog, nameOwner);
                    break;
                case 7:
                    Console.WriteLine( "Каталог Открыт" );
                    Console.WriteLine(" ");
                    LookCatalog(catalog);
                    break;
            }
            goto flag;
        }


        static void WriteInfo()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" 1 - AddDick &  2 - AddMusic to Disk ");
            Console.WriteLine(" 3 - DeleteDick &  4 - DeleteMusic from Disk ");
            Console.WriteLine(" 5 - SearchDick &  6 - Search Catalog ");
            Console.WriteLine(" 7 - Look All Catalog ");
            Console.WriteLine(" ");
        }

        static void AddDisk(Hashtable catal,string NameDisk_Key)
        {
            Hashtable Disk_H = new Hashtable();

            catal.Add(NameDisk_Key, Disk_H);
            Console.WriteLine("Диск "+ NameDisk_Key + " Успещно создан");
        }
        static void DeleteDisk(Hashtable catal, string NameDisk_Key)
        {
            catal.Remove(NameDisk_Key);
            Console.WriteLine("Диск " + NameDisk_Key + " Успещно удален");
        }

        static void SearchDick(Hashtable catal, string NameDisk_Key)
        {
            Hashtable disk_h = (Hashtable)catal[NameDisk_Key];
            ICollection keys = disk_h.Keys;
            foreach (string s in keys)
                Console.WriteLine("Содержимое диска " +" Трек "+ s + " : "+" Испольнителя "+ disk_h[s]);
        }

        static void AddMusic(Hashtable catal, string NameMusic_Key, string NameDisk_Key,  string NameOfOwner)
        {
            Hashtable disk_h = (Hashtable)catal[NameDisk_Key];

            disk_h.Add(NameMusic_Key, NameOfOwner);
            Console.WriteLine("Музыка " + NameMusic_Key +" Испольнителя "+NameOfOwner+" Успещно Добавдена в Диск "+ NameDisk_Key);
        }
        static void DeleteMusic(Hashtable catal, string NameMusic_Key, string NameDisk_Key)
        {
            Hashtable disk_h = (Hashtable)catal[NameDisk_Key];
         
            Console.WriteLine("Музыка " + NameMusic_Key + " Испольнителя " + disk_h[NameMusic_Key] + " Успещно Удалена с Диска " + NameDisk_Key);
            disk_h.Remove(NameMusic_Key);
        }

        static void LookCatalog(Hashtable catal)
        {
            ICollection keys = catal.Keys;
            foreach (string s in keys)
                Console.WriteLine("Содержимое каталога "+" Диск " + s);
        }

        static void SearchFromCatalog(Hashtable catal, string owner)
        {
            ICollection keys = catal.Keys;
            Hashtable[] disks = new Hashtable[keys.Count];

            int help = 0;
            //Console.WriteLine(keys.Count);
            foreach (string s in keys)
            {
                //Console.WriteLine(s + ": " + catal[s]);
                disks[help] = (Hashtable)catal[s];
                help++;
            }
            ICollection[] keys_d = new ICollection[help];
            for (int i = 0; i < disks.Length; i++)
            {
                keys_d[i] = disks[i].Keys;
                foreach (string s in keys_d[i])
                {
                    if(owner == disks[i][s].ToString())
                    Console.WriteLine(" По исполнителю "+ disks[i][s]+" найден трек "+ s);
                }
            }
        }

        #endregion
    }
}
