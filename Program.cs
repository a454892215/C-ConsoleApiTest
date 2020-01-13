using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /* 我的第一个 C# 程序 */
            // Console.WriteLine("Hello World!");
            //  test();
            //  Program2.testNiMingMethod();
            // TestDelegate.Main5();
            // TestIndexer.Main6();
            TestEvent.Main1();
            Console.ReadKey();
         
        }

      //   [Obsolete("Don't use OldMethod, use NewMethod instead")]
        static void test()
        {
            Console.WriteLine("Hello World222");
        }
    }
}
