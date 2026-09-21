using System;
using System.Globalization;


namespace TreinoC_Modulo4;

class funcionarios {
    public string Nome;
    public decimal Salario;

}

//class pessoas {


//    //Exercicio 1================================================================
//    public string Nome;
//    public int Idade;
//}

class Program {
    static void Main(string[] args) {

        funcionarios f1 = new funcionarios();
        funcionarios f2 = new funcionarios();

        Console.WriteLine("Dados do primeiro funcionario:");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        f1.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do segundo funcionario:");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        f2.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal media = (f1.Salario + f2.Salario) / 2m;
        Console.WriteLine($"Salario médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        //Exercicio 1====================================================================
        //pessoas p1 = new pessoas();
        //pessoas p2 = new pessoas();


        //Console.WriteLine("Dados da primeira pessoa:");
        //Console.Write("nome: ");
        //p1.Nome = Console.ReadLine();

        //Console.Write("Idade: ");
        //p1.Idade = int.Parse(Console.ReadLine());

        //Console.WriteLine("Dados da segunda pessoa:");
        //Console.Write("nome: ");
        //p2.Nome = Console.ReadLine();

        //Console.Write("Idade: ");
        //p2.Idade = int.Parse(Console.ReadLine());

        //if (p1.Idade > p2.Idade) {
        //    Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
        //}
        //else {
        //    Console.WriteLine("A pessoa mais velha é:" + p2.Nome);
        //}
    }
}