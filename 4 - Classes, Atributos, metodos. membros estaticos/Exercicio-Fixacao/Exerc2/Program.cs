using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: $");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: $");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f.ToString());
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");

            f.AumentarSalario(Porcentagem: double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)); 
            // Salario + Porcentagem | Ex. 6000.00 + 10 % = 6600.00

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + f.ToString());
            //$6600.00 - 1000.00 = $5600

            Console.WriteLine();
            Console.WriteLine("Aperte um botão para encerrar o programa");
            Console.ReadLine();
        }
    }//End Program
}