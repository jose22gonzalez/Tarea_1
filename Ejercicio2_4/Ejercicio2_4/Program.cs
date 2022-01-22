double centrigado = 0;
double fahrenheit = 0;

Console.Write("Digite la cantidad de Celsiud: ");
centrigado =  Convert.ToDouble(Console.ReadLine());

fahrenheit = (9 / 5) * centrigado + 32;

Console.WriteLine($"Fahrenheit: {fahrenheit}");
