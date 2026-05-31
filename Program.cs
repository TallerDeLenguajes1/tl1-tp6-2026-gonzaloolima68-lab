using System;

double numero;

Console.WriteLine("Ingrese un numero");
while(!double.TryParse(Console.ReadLine(),out numero))
{
    Console.WriteLine("Numero invalido intenta nuevamente");
}
Console.WriteLine("Resultados");
Console.WriteLine("Valor Absoluto = "+ Math.Abs(numero));
Console.WriteLine("cuadrado = "+ Math.Pow(numero,2));
if (numero>=0)
{
    Console.WriteLine("raiz = "+ Math.Sqrt(numero));
}
else
{
    Console.WriteLine("No es posible calcular la raiz");
}
Console.WriteLine("Seno = "+ Math.Sin(numero));
Console.WriteLine("Coseno = "+ Math.Cos(numero));
Console.WriteLine("Entero = "+ (int)numero);

Console.WriteLine("Ingrese el primer numero");
double num1;
while(!double.TryParse(Console.ReadLine(),out num1))
{
    Console.WriteLine("Ingrese un numero valido");
}
Console.WriteLine("Ingrese el segundo numero");
double num2;
while(!double.TryParse(Console.ReadLine(),out num2))
{
    Console.WriteLine("Ingrese un numero valido");
}

Console.WriteLine("Maximo = "+ Math.Max(num1,num2));
Console.WriteLine("Minimo = "+ Math.Min(num1,num2));
