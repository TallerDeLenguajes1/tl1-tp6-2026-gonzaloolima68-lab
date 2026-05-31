using System;
using System.Security.AccessControl;

char continuar;

do
{
    Console.WriteLine("Ingrese la operacion a realizar");
    Console.WriteLine("1-sumar");
    Console.WriteLine("2-restar");
    Console.WriteLine("3-multiplicar");
    Console.WriteLine("4-restar");
    Console.WriteLine("5-terminar");

    Console.WriteLine("Ingrese el primer numero");
    double num1;
    while(!double.TryParse(Console.ReadLine(),out num1))
    {
        Console.WriteLine("Numero invalido intente nuevamente");
    }
    Console.WriteLine("Ingrese el segundo numero");
    double num2;
    while(!double.TryParse(Console.ReadLine(),out num2))
    {
        Console.WriteLine("Numero invalido intente nuevamente");
    }
    
    continuar=Convert.ToChar(Console.ReadLine().ToLower());
} while (continuar == 's');

