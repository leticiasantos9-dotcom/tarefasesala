double pesoEmKg;
double alturaEmMetros;
double imc;

Console.WriteLine("Digite o peso:");
pesoEmKg = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a atltura:");
alturaEmMetros = Convert.ToDouble(Console.ReadLine());

if (alturaEmMetros == 0)
{
    Console.WriteLine("Altura deve ser maior que zero");
    return;
}
double alturaAoQuadrado = alturaEmMetros * alturaEmMetros;

imc = pesoEmKg / alturaAoQuadrado;

double imcFormatado = Math.Round(imc, 2);

Console.WriteLine($"O Seu IMC calculado é: {imcFormatado}");

if ( imcFormatado < = 29.9
    {
    Console.WriteLine("Magro");
}
else
{
    Console.WriteLine("Obesidade");
}