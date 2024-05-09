using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._3
{
    class CharPair
    {
        private char field1;
        private char field2;

        public void AssignValues()
        {
            field1 = 'A';
            field2 = 'B';
        }

        public void AssignValues(char singleValue)
        {
            field1 = singleValue;
            field2 = singleValue;
        }

        public void AssignValues(char value1, char value2)
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

            CharPair pair = new CharPair();

            pair.AssignValues();
            Console.WriteLine("Виклик без аргументів : ");
            pair.PrintValues();

            pair.AssignValues('X');
            Console.WriteLine("Виклик з аргументом X : ");
            pair.PrintValues();

            pair.AssignValues('Y', 'Z');
            Console.WriteLine("Виклик з аргументами Y та Z : ");
            pair.PrintValues();

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
