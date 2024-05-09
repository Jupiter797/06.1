using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2
{
    class IntClass
    {
        private int field1;
        private int field2;

        public IntClass(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }

        public void IntMethod()
        {
            Console.WriteLine($"Значення поля 1: {field1}");
            Console.WriteLine($"Значення поля 2: {field2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            IntClass value = new IntClass(10, 20);
            value.IntMethod();

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
