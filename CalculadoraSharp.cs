using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0.0;
            double n2 = 0.0;
            
            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Resultado: " + (n1 + n2));
        }
    }
}
