using System;

delegate int NumberChanger(int n);

namespace ConsoleApp1
{
    //委托测试
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

       public static void Main5()
        {
            // 委托给AddNum
            NumberChanger nc1 = new NumberChanger(AddNum);
            // 委托给MultNum
            NumberChanger nc2 = new NumberChanger(MultNum);

            // 使用委托对象调用方法
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
