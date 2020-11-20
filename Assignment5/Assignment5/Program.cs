using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File reading is stating");
            OtherWork1();
            OtherWork2();
            OtherWork3();
            ReadFile();
            AfterWork1();
            AfterWork2();
            Console.ReadKey();
        }
        public static void OtherWork1()
        {
            
           
                Console.WriteLine("Other work 1");
            
            
        }
        public static void OtherWork2()
        {
            Console.WriteLine("Other work 2");
        }
        public static void OtherWork3()
        {
            Console.WriteLine("Other work 3");
        }
        public static async void ReadFile()
        {
            int total;
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                StreamReader sr = new StreamReader(@"C:\Users\nedgr\Desktop\SampleText");
                total = (sr.ReadToEnd().Length);
                Console.WriteLine("File reading is completed\nTotal Lenght: " + total);
            });
            

        }
        public static async void AfterWork1()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("After work 1");
            });
            
        }
        public static async void AfterWork2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("After work 2");
            });
            
        }
    }
}
