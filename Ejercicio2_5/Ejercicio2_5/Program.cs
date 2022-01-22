

double dolares = 0;
double euro = 0.88;
double dolar_euro = 0;

Console.Write("Digite la cantidad en dolar: ");
dolares = Convert.ToDouble(Console.ReadLine());

dolar_euro = dolares * euro;

Console.WriteLine("Euro: " + dolar_euro);