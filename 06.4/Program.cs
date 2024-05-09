using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._4
{
    class Number
    {
        private int field1;
        private int field2;

        public Number()
        {
            field1 = 0;
            field2 = 0;
        }

        public Number(int singleValue)
        {
            field1 = singleValue;
            field2 = singleValue;
        }

        public Number(int value1, int value2)
        {
            field1 = value1;
            field2 = value2;
        }

        public void PrintValues()
        {
            Console.WriteLine($"Field1: {field1}, Field2: {field2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Number result1 = new Number();
            Console.WriteLine("Конструктор без аргументів:");
            result1.PrintValues();

            Number result2 = new Number(10);
            Console.WriteLine("Конструктор з одним аргументом:");
            result2.PrintValues();

            Number result3 = new Number(20, 30);
            Console.WriteLine("Конструктор з двома аргументами:");
            result3.PrintValues();

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
