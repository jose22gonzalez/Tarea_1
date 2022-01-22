
int numero = 0;

Console.Write("Digite un numero: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"El numero {numero} es par");

}
else
{
    Console.WriteLine($"El numero {numero} es impar");
}