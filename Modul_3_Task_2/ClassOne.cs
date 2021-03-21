using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_3_Task_2
{
    public class ClassOne
    {
        public event Action<bool> ShowHandler;

        public int Pow(int x, int y) => x * y;

        public void PrintResult(bool value)
        {
            if (ShowHandler != null)
            {
                ShowHandler.Invoke(value);
            }
        }
    }
}
