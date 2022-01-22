
float perimetro = 0;
float lado_poligono = 0;
int cant_lado = 0;

while (cant_lado == 0)
{
    Console.Write("Digite la cantidad de lado del poligono: ");
    cant_lado = Convert.ToInt32(Console.ReadLine());

    if (cant_lado < 3)
    {
        Console.WriteLine("Los poligono tiene como minimo 3 lados");
        cant_lado = 0;
    }
}
Console.Write("Digite el valor de lado del poligono: ");
lado_poligono = float.Parse(Console.ReadLine());


perimetro = lado_poligono * cant_lado;
Console.WriteLine($"El perimetro de poligono regular es: {perimetro}");