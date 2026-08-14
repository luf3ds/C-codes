using System;

using System;

public class ItemRPG
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int Estoque { get; private set; }
    public ItemRPG(string nome, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("ERRO: O nome do item não pode ser vazio.");
        }

        if (preco < 0)
        {
            throw new ArgumentException("ERRO: O preço não pode ser negativo.");
        }

        Nome = nome;
        Preco = preco;
        Estoque = 0;
    }
    public void Reabastecer(int quantidade)
    {
        if (quantidade <= 0)
        {
            Console.WriteLine($"> ERRO: Quantidade de reabastecimento deve ser positiva.");
            return;
        }
        Estoque += quantidade;
        Console.WriteLine($"> Reabastecendo {quantidade} unidades...");
        Console.WriteLine($" Estoque atual: {Estoque}");
        Console.WriteLine();
    }
    public void RealizarVenda(int quantidade)
    {
        if (quantidade <= 0)
        {
            Console.WriteLine("> ERRO: A quantidade de venda deve ser maior que zero.");
            return;
        }

        if (quantidade > Estoque)
        {
            Console.WriteLine($"> Tentando vender {quantidade} unidades... ");
            Console.WriteLine("ERRO: Estoque insuficiente.");
            Console.WriteLine();
            return;
        }

        Estoque -= quantidade;
        Console.WriteLine($"> Vendendo {quantidade} unidades... Venda realizada!");
        Console.WriteLine($"Estoque restante: { Estoque }");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- RPG SHOP ---");

        try
        {
            ItemRPG item = new ItemRPG("Espada Suprema", 1000.00m);
            Console.WriteLine($"Criando item '{item.Nome}'...");
            Console.WriteLine($"Sucesso! Preço: R$ {item.Preco:N2} - Estoque Inicial: {item.Estoque}"); 
            Console.WriteLine();

            item.Reabastecer(10);

            item.RealizarVenda(5);

            item.RealizarVenda(50);

            Console.WriteLine("--- ESTADO FINAL ---");
            Console.WriteLine($"Item: {item.Nome}");
            Console.WriteLine($"Preço: R$ {item.Preco:N2}");
            Console.WriteLine($"Estoque: {item.Estoque}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}