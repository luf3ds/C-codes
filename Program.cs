using System;

string nome;
string opcao;
double descontoINSS = 0;
double descontoIRRF = 0;
double salarioBruto;

do
{
    Console.Clear();
    Console.WriteLine("=== FOLHA DE PAGAMENTO ===");
    Console.WriteLine();

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite seu salario bruto: ");
    salarioBruto = double.Parse(Console.ReadLine());


    salarioBruto = ValidarSalario(salarioBruto);
    descontoINSS = calcDescontoINSS(salarioBruto);
    descontoIRRF = calcDescontoIRRF(salarioBruto);


    Console.WriteLine();

    ExibirFolha(nome, salarioBruto, descontoINSS, descontoIRRF);

    Console.WriteLine();
    Console.WriteLine($"Folha de {nome} processada com sucesso!");
    Console.WriteLine();
    Console.WriteLine("[S] para novo cálculo | [N] para sair");
    opcao = Console.ReadLine().ToUpper();

} while (opcao == "S");

Console.WriteLine("Programa encerrado. Até logo!");

static double ValidarSalario(double salario)
{
    while (salario <= 0)
    {
        Console.Write("Salario inválido, digite novamente: ");
        salario = double.Parse(Console.ReadLine());
    }
    return salario; // Retorna o valor lido para a variável 'salarioBruto'
}

static double calcDescontoINSS(double salario)
{
    if (salario > 3900) return salario * 0.14;
    if (salario >= 3000) return salario * 0.12; // Ajustei a faixa para fazer sentido lógico
    if (salario >= 2500) return salario * 0.09;
    if (salario >= 1300) return salario * 0.075;
    return 0;
}

static double calcDescontoIRRF(double salario)
{
    if (salario > 1900) return salario * 0.075;
    return 0;
}

static void ExibirFolha(string nome, double bruto, double inss, double irrf)
{
    double liquido = bruto - inss - irrf; // Cálculo aqui dentro para não precisar de variável global
    Console.WriteLine("==========================");
    Console.WriteLine($"FOLHA: {nome}");
    Console.WriteLine($"Salário Bruto: {bruto:C}");
    Console.WriteLine($"Desconto INSS: {inss:C}");
    Console.WriteLine($"Desconto IRRF: {irrf:C}");
    Console.WriteLine("==========================");
    Console.WriteLine($"Salario Liquido: {liquido:C}");
}