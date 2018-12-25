using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
/*• название пункта назначения рейса; 
• номер рейса; • тип самолета.*/
namespace laba10
{
   public class Program
    {
        [Serializable]
       public struct AER0FL0T:IComparable<AER0FL0T>
        {
            public string pynkt;
            public int number_reis;
            public string type_air;

            public int CompareTo(AER0FL0T other)
            {
                if (this.number_reis > other.number_reis) return 1;
                if (this.number_reis < other.number_reis) return -1;
                return 0;
            }
        };

        static void Main(string[] args)
        {
            
            Console.WriteLine("ВВедите кол-во рейсов");
            int kolvo = Int32.Parse(Console.ReadLine());
            AER0FL0T[] aer = new AER0FL0T[kolvo];
            try
            {
                Console.WriteLine("ВВедите данные о рейсе(Пункт назначения, номер рейса, тип самолета)");
                for (int i = 0; i < aer.Length; i++)
                {
                    aer[i].pynkt = Console.ReadLine();

                    aer[i].number_reis = Int32.Parse(Console.ReadLine());
                  
                  
                    aer[i].type_air = Console.ReadLine();
                }
                Array.Sort(aer);
                var a = aer.OrderBy(x => x.number_reis);
                    for (int i = 0; i < aer.Length; i++)
                    {
                        for (int j = 0; j < aer.Length - 1; j++)
                        {
                            if (aer[j].number_reis > aer[j+1].number_reis)
                            {
                                int temp = aer[j].number_reis;
                            aer[j].number_reis = aer[j+1].number_reis;
                            aer[j+1].number_reis = temp;
                            }
                        }
                    }
                for (int i = 0; i < aer.Length; i++)
                {
                    Console.WriteLine("Пункт назначения по номеру рейса {0} =  {2} Тип Самолета = {1}", aer[i].number_reis, aer[i].type_air, aer[i].pynkt);
                }
                #region ITK 9
                //Console.WriteLine("ВВедите интересующий номер рейса");
                //int interested_number_reis = Int32.Parse(Console.ReadLine());
                //for (int i = 0; i < aer.Length; i++)
                //{
                //    if (aer[i].number_reis == interested_number_reis)
                //    {
                //        Console.WriteLine("Пункт назначения {0} =  {2} Тип Самолета = {1}", i + 1, aer[i].type_air, aer[i].pynkt);
                //    }
                //    else
                //        Console.WriteLine("Рейс не найден");
                //}
                #endregion
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }

            #region ITK12 Binary
            /*
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("AEROFLOT.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, aer);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("AEROFLOT.dat", FileMode.OpenOrCreate))
            {
                AER0FL0T[] newAER0FL0T = (AER0FL0T[])formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                int number_reis = 1;
                foreach (AER0FL0T p in newAER0FL0T)
                {
                    Console.WriteLine("Пункт назначения {0} =  {2} Тип Самолета = {1}", number_reis, p.type_air, p.pynkt);
                    number_reis++;
                }
                
            }
            */
            #endregion ITK12

            

            #region ITK12 XML

            XmlSerializer formatter = new XmlSerializer(typeof(AER0FL0T[]));

            using (FileStream fs = new FileStream("AER0FL0T.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, aer);
            }

            using (FileStream fs = new FileStream("AER0FL0T.xml", FileMode.OpenOrCreate))
            {
                AER0FL0T[] newAER0FL0T = (AER0FL0T[])formatter.Deserialize(fs);
                int number_reis = 1;
                foreach (AER0FL0T p in newAER0FL0T)
                {
                    Console.WriteLine("Пункт назначения {0} =  {2} Тип Самолета = {1}", number_reis, p.type_air, p.pynkt);
                    number_reis++;
                }
            }

            #endregion


        }



    }
}
