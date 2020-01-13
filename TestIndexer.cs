using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //索引器测试
    class TestIndexer
    {
        private string[] Namelist;


        public TestIndexer(int size)
        {
            Namelist = new string[size];

            for (int i = 0; i < size; i++)
                this[i] = "Index:"+i;//索引器赋值
        }
        //索引器声明
        public string this[int index] 
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= Namelist.Length)
                {
                    tmp = Namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= Namelist.Length - 1)
                {
                    Namelist[index] = value;
                }
            }
        }

       public static void Main6()
        {
            TestIndexer names = new TestIndexer(5);
          
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(names[i]);//迭代对象的所有索引
            }
            Console.ReadKey();
        }
    }
}
