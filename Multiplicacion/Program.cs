using System;
using System.Threading;

namespace Multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("--- I'm a Multiplication Calculator! ---");
            Console.WriteLine("-------------------------------------------\n");

            Console.WriteLine("Enter two numerical values:");
            Console.Write("- X:");
            if(!int.TryParse(Console.ReadLine(), out int x)) {
                Console.WriteLine("That's not a numerical value. Insert the value again.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.Write("- Y:");
            if (!int.TryParse(Console.ReadLine(), out int y)) {
                Console.WriteLine("That's not a numerical value. Insert the value again.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.WriteLine($"\n- Result: {Calculator.Multiply(x,y)}");
            Console.WriteLine("Thanks for using this program! :D");
        }
    }
}

//parametro out: se utiliza para pasar los argumentos a los metodos como tipo de referencia.