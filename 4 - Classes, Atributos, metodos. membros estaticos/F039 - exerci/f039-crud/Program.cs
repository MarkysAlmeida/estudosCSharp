using System;
using System.Globalization;

namespace Curso;
public class Produto {
    public string nome;
    public double preco;
    public int quantidade;
}
class CRUDProgram {
    static void Main(string[] args) {

        Produto nome = new Produto();
        Produto preco = new Produto();
        Produto quantidade = new Produto();
        Produto addProduto = new Produto();
        Produto removeProduto = new Produto();

        Console.WriteLine("Entre os dados do produto");
        Console.Write("Nome: ");
        nome.nome = Console.ReadLine();
        Console.Write("Preço: ");
        preco.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        quantidade.quantidade = int.Parse(Console.ReadLine());

        double somaproduto = preco.preco * quantidade.quantidade;
        Console.WriteLine("Dados do Produto: " + nome.nome + ", $" + preco.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + quantidade.quantidade + " unidades, Total: " + somaproduto.ToString("F2", CultureInfo.InvariantCulture));


        //Segunda parte - Adicionar estoque
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        addProduto.quantidade = int.Parse(Console.ReadLine());
        quantidade.quantidade = quantidade.quantidade + addProduto.quantidade;
        somaproduto = preco.preco * quantidade.quantidade;

        Console.WriteLine("Dados do Produto: " + nome.nome + ", $" + preco.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + quantidade.quantidade + " unidades, Total: " + somaproduto.ToString("F2", CultureInfo.InvariantCulture));

        //Terceira parte - remover Estoque
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        removeProduto.quantidade = int.Parse(Console.ReadLine());
        quantidade.quantidade = quantidade.quantidade - removeProduto.quantidade;
        somaproduto = preco.preco * quantidade.quantidade;

        Console.WriteLine("Dados do Produto: " + nome.nome + ", $" + preco.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + quantidade.quantidade + " unidades, Total: " + somaproduto.ToString("F2", CultureInfo.InvariantCulture));


    }//end static
}

