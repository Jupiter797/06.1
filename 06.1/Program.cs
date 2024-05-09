using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1
{
    class Symbols
    {
        private char symbol;

        public Symbols(char symbol)
        {
            this.symbol = symbol;
        }

        public int GetCharCode()
        {
            return Convert.ToInt32(symbol);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть символ : ");
            char enteredСharacter = Convert.ToChar(Console.ReadLine());

            Symbols symbol = new Symbols(enteredСharacter);
            Console.WriteLine($"Символ : {enteredСharacter}");
            Console.WriteLine($"Код символу : {symbol.GetCharCode()}");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
