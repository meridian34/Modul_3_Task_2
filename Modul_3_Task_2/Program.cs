using System;

namespace Modul_3_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = new ClassOne();
            var two = new ClassTwo();
            one.ShowHandler = new Program().Show;
            one.ShowHandler(two.Calc(one.Pow, 1, 2).Invoke(2));
            Console.ReadKey();
        }

        public void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
