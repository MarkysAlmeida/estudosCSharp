using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Square p = new Square();

            Console.WriteLine("Entre a largura e Altura do retângulo");
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("AREA = " + p.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + p.Perimentro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + p.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Aperte um botão para sair");
            Console.ReadLine();
            
        }
    }//endProgram
}