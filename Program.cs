using System;
string ingresado;
Console.WriteLine("Ingrese un numero");
ingresado=Console.ReadLine();


if(int.TryParse(ingresado,out int num))
{
    int num2=num;
    int invertido=0;
    if (num > 0)
    {
        while (num != 0)
        {
            int digito=num%10;
            invertido=invertido*10+digito;
            num=num/10;
        }
        Console.WriteLine("el numero ingresado es "+num2);
        Console.WriteLine("el numero invertido es "+invertido);
    }
    else
    {
        Console.WriteLine("El numero ingresado debe ser mayor a cero");
    }
}
else
{
    Console.WriteLine("No se ingreso un numero valido" );
}

