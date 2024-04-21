using System.Diagnostics.CodeAnalysis;

float weight = 0, height = 0;
double imc = 0;
string sex = string.Empty, result = string.Empty;

Console.WriteLine("Calculo de IMC.");

do
{
    Console.Write("Digite a sua altura em centímetros: ");
    height = float.Parse(Console.ReadLine());
    
    if (height <= 0)
    {
        Console.WriteLine("\nAltura deve ser positiva, tente novamente.\n");
    }
} while (height <= 0);

do
{
    Console.Write("Digite o seu peso em Kg: ");
    weight = float.Parse(Console.ReadLine());
    
    if (weight <= 0)
    {
        Console.WriteLine("\nPesp deve ser positivo, tente novamente.\n");
    }
 } while (weight <= 0);

do
{
    Console.Write("Qual seu sexo biológico? ('H' para homem / 'M' para mulher): ");
    sex = Console.ReadLine();

    if (!sex.Equals("H") && !sex.Equals("M"))
    {
        Console.WriteLine("\nOpção inválida, tente novamente.\n");
    }

} while (!sex.Equals("H") && !sex.Equals("M"));


/*
    Tabela de IMC base para os resultados:

    Menor que 18,5 	Baixo peso
    De 18,5 a 24,9 	Peso normal
    De 25 a 29,9 	Sobrepeso
    De 30 a 34,9 	Obesidade grau I
    De 35 a 39.9 	Obesidade grau II
    Igual ou maior que 40 	Obesidade grau III
 
 */

imc = weight / Math.Pow(height / 100, 2);

if (imc < 18.5)
{
    result = "Abaixo do peso.";
}
else if (imc < 25)
{
    result = "No peso ideal";
}
else if (imc < 30)
{
    result = "Em sobrepeso";
}
else if (imc < 35)
{
    result = "Obesidade grau I";
}
else if (imc < 40)
{
    result = "Obesidade grau II";
}
else
{
    result = "Obesidade grau III";
}

Console.WriteLine($"\n-> O cálculo do IMC é {imc:0.00} e aponta: {result}\n"); 

// Interação final
Console.ReadKey();