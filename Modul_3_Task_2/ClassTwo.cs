using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_3_Task_2
{
    public class ClassTwo
    {
        private int _result;

        public ClassTwo()
        {
            _result = 0;
        }

        public Func<int, bool> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            _result = powHandler.Invoke(x, y);

            return (x) => Result(x);
        }

        public bool Result(int x)
        {
            return _result % x == 0 ? true : false;
        }
    }
}
