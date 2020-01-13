using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void TestMethod(int n); //1. 声明匿名函数的类型
namespace ConsoleApp1
{
    class TestNoNameMethod
    {

      //  匿名函数测试
       public static void testNiMingMethod()
        {
            TestMethod test = delegate (int n) { //2. 创建匿名函数
                Console.WriteLine("匿名函数测试 输入的是{0}", n);
            };
            test(5);//3. 调用匿名函数
        }
    }
}
