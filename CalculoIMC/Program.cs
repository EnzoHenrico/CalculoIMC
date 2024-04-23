float weight = 0, height = 0;
double imc = 0;
string result = "";
char sex;

Console.WriteLine("Calculo de IMC.");

do
{
    Console.Write("Digite a sua altura em centímetros: ");
    height = float.Parse(Console.ReadLine());
    
    if (height <= 0)
    {
        Console.WriteLine("\nAltura deve ser maior que 0, tente novamente.\n");
    }
} while (height <= 0);

do
{
    Console.Write("Digite o seu peso em Kg: ");
    weight = float.Parse(Console.ReadLine());
    
    if (weight <= 0)
    {
        Console.WriteLine("\nPeso deve ser maior que 0, tente novamente.\n");
    }
 } while (weight <= 0);

do
{
    Console.Write("Qual seu sexo biológico? ('H' para homem / 'M' para mulher): ");
    sex = char.Parse(Console.ReadLine());

    if (sex != 'H' && sex != 'M')
    {
        Console.WriteLine("\nOpção inválida, tente novamente.\n");
    }

} while (sex != 'H' && sex != 'M');


/*
    Tabela de IMC base para os resultados:

    Menor que 18,5 	Baixo peso
    De 18,5 a 24,9 	Peso normal
    De 25 a 29,9 	Sobrepeso
    De 30 a 34,9 	Obesidade grau I
    De 35 a 39.9 	Obesidade grau II
    Igual ou maior que 40 	Obesidade grau III

    fonte: https://www.tuasaude.com/imc/
 
 */

imc = weight / Math.Pow(height / 100, 2);
if (sex == 'H')
{
    switch (imc)
    {
        case < 18.5:
            result = "Abaixo do peso.";
            break;
        case < 25:
            result = "No peso ideal";
            break;
        case < 30:
            result = "Em sobrepeso";
            break;
        case < 35:
            result = "Obesidade grau I";
            break;
        case < 40:
            result = "Obesidade grau II";
            break;
        default:
            result = "Obesidade grau III";
            break;
    }
}
else
{
    switch (imc)
    {
        case < 18.5:
            result = "Abaixo do peso.";
            break;
        case < 25:
            result = "No peso ideal";
            break;
        case < 30:
            result = "Em sobrepeso";
            break;
        case < 35:
            result = "Obesidade grau I";
            break;
        case < 40:
            result = "Obesidade grau II";
            break;
        default:
            result = "Obesidade grau III";
            break;
    }
}

Console.WriteLine($"\n-> O cálculo do IMC é {imc:0.00} e aponta: {result}\n"); 

// Interação final
Console.ReadKey();