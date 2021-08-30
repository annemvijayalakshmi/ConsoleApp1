using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();

            Console.WriteLine("Enter your name");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.WriteLine(" Press any key to continue...");
            Console.Read();


        }
        static async void Method1()
        {
            await Task.Delay(70000);
            Console.WriteLine("Download Completed. (file1)");
        }
        static async void Method2()
        {
            await Task.Delay(70000);
            Console.WriteLine("Download Completed. (file2)");
        }
    }
}
