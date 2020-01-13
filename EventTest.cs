
namespace ConsoleApp1
{
    using System;

    public class EventTest
    {
        private int age = 3;

        //申明事件触发类型
        public delegate void AgeChangeTypeEvent();

        //定义事件触发器
        public event AgeChangeTypeEvent AgeChangeEvent;

        protected virtual void OnAgeChanged()
        {
            if (AgeChangeEvent != null)
            {
                AgeChangeEvent(); /* 最终触发事件 */
            }
            else
            {
                Console.WriteLine("事件没有被触发 ==== AgeChangeEvent 没有被注册");
                Console.ReadKey(); /* 回车继续 */
            }
        }


        public EventTest()
        { }


        public void SetValue(int value)
        {
            if (age != value)
            {
                Console.WriteLine("{0} ，{1}准备触发事件", age, value);
                age = value;
                OnAgeChanged();//准备触发事件
            }
            else
            {
                Console.WriteLine("{0} ，{1} 和上次的数据一样 不准备触发事件", age, value);
                Console.ReadKey(); /* 回车继续 */
            }
        }
    }


    /*******事件触发后的执行类****/

    public class SubscribEvent
    {
        public void printf()
        {
            Console.WriteLine("事件被触发了 ==== 执行完毕");
            Console.ReadKey(); /* 回车继续 */
        }
    }

    public class TestEvent
    {
        public static void Main1()
        {
            EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
            SubscribEvent subscribEvent = new SubscribEvent(); /* 实例化对象 */

            /* 注册 */
            e.AgeChangeEvent += new EventTest.AgeChangeTypeEvent(subscribEvent.printf);

            e.SetValue(3);
            e.SetValue(11);
        }
    }
}
