using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace ITK13
{
    class Program
    {
        
        #region zadanie1
       /*
        delegate void Message();
        static void Main(string[] args)
        {
            Console.WriteLine("1 - sin 2 - cos");
            Message mes;
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1: mes = Sin; mes();
                    break;
                case 2: mes = Cos; mes();
                    break;

            }
           // Console.WriteLine(0.2f-0.2f);
        }

        private static void Sin()
        {
            for (float i =-1; i <0;  )
            {       
                Console.WriteLine("x= {0,-25} "+"i = {1,-20}",$" {Math.Sin(i),1:f5}", $" {i,1:f1}");
                i += 0.2f;
            }
        }

        private static void Cos()
        {
            for (float i = -1.0f; i <= 0.0f; )
            {
                Console.WriteLine("x= {0,-25} " + "i = {1,-20}", $" {Math.Cos(i),1:f5}", $" {i,1:f1}");
                i += 0.2f;
            }
        }
        */
        #endregion
        
        //
        
        #region zadanie3
            
        class NewsEventArgs : EventArgs
        {
            public NewsEventArgs(string message, int type)
            {
                Message = message;
                Type = type;
            }
            public string Message { get; private set; }
            public int Type { get; private set; }
        }
      

        class Subscribe
        {
            int[] types_of_news = new int[2];

            public void Subcribe_User(News news, int type)
            {               
                news.NewsSend += News_NewsSend;
                types_of_news[0] = type;
            }

            public int Types_of_news
            {
                get
                {
                    return types_of_news[0];
                }
            }

        }

        class News
        {
            public event EventHandler<NewsEventArgs> NewsSend;

            public void SendMessage(Subscribe sub)
            {
                if (NewsSend != null)
                {
                    if (sub.Types_of_news == 1)
                    {
                        NewsSend(this, new NewsEventArgs(string.Format("Belarus was win an Olympics Games 2018"), sub.Types_of_news));
                    }
                    if (sub.Types_of_news == 2)
                    {
                        NewsSend(this, new NewsEventArgs(string.Format("C# 10.0 now is available"), sub.Types_of_news));                      
                    }
                }
                
            }
            
        }
        static void Main(string[] args)
        {

            News news = new News();
            News news1 = new News();
            Subscribe sub_1 = new Subscribe();
            Subscribe sub_2 = new Subscribe();
            sub_1.Subcribe_User(news,1);
            sub_2.Subcribe_User(news1,2);
            sub_2.Subcribe_User(news1, 1);

            news.SendMessage(sub_1);
            news.SendMessage(sub_2);
            //news.SendMessage(2,sub_2);
            //news.SendMessage(type);

        }

        private static void News_NewsSend(object sender, NewsEventArgs e)
        {
            if(e.Type == 1)
            Console.WriteLine("Your news= " + e.Message);
            if (e.Type == 2)
            Console.WriteLine("Your news= " + e.Message);
        }
        
        #endregion

        //


        #region Zadanie 4
        /*
    class ZadanieEventsArgs : EventArgs
    {
        public ZadanieEventsArgs(String result)
        {
            Result = result;
        }

        public string Result { get; private set; }
    }

    class Zadaniuz
    {
        public event EventHandler<ZadanieEventsArgs> SendAnswer;
        int amount;
        string answer = "";
        public void ChoosZadanie(int type)
        {

            if (SendAnswer != null)
            {
                if (type == 1)
                    zad1();
                if (type == 2)
                    zad2();
                SendAnswer(this, new ZadanieEventsArgs(string.Format(answer)));
            }
        }

        private void zad1()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Введите числа(5)");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != 4)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        amount++;
                    }
                }
                else
                {
                    if (numbers[numbers.Length - 2] < numbers[numbers.Length - 1])
                    {
                        amount++;
                    }
                }
            }

            if (amount == 5)
            {
                answer = "true";
            }
            else
            {
                answer = "false";
            }
        }

        private void zad2()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Введите числа(5)");
            int help = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    int temp = numbers[i];
                    numbers[help] = temp;
                    help++;
                }
            }
            for (int i = 0; i < help; i++)
            {
                answer += " " + numbers[i];
            }
        }
    }

    static void Main(string[] args)
    {
        Zadaniuz zadd = new Zadaniuz();
        zadd.SendAnswer += Zadd_SendAnswer;
        Console.WriteLine("Zad1 == 1 ;  zad2 == 2");

        int type = Int32.Parse(Console.ReadLine());
        if (type == 1)
            zadd.ChoosZadanie(1);
        if (type == 2)
            zadd.ChoosZadanie(2);
    }

    private static void Zadd_SendAnswer(object sender, ZadanieEventsArgs e)
    {
        Console.WriteLine("Answer = " + e.Result);
    }
    */
        #endregion

        //

        //class MyEvent
        //{

        //    [DllImport("user32.dll", SetLastError = true)]

        //    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        //    public void pressLeftMouse()
        //    {
        //        mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
        //        mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        //    }
        //}

        //[Flags]
        //public enum MouseEventFlags
        //{
        //    LEFTDOWN = 0x00000002,
        //    LEFTUP = 0x00000004,
        //    MIDDLEDOWN = 0x00000020,
        //    MIDDLEUP = 0x00000040,
        //    MOVE = 0x00000001,
        //    ABSOLUTE = 0x00008000,
        //    RIGHTDOWN = 0x00000008,
        //    RIGHTUP = 0x00000010
        //}

        //static void Main(string[] args)
        //{
        //    MyEvent Event = new MyEvent();
        //    ConsoleKeyInfo input;
        //    x:
        //    input = Console.ReadKey(true);

        //    if (input.Key == ConsoleKey.W)
        //    {
        //        Event.pressLeftMouse();
        //        goto x;
        //    }

        //}




    }
}
