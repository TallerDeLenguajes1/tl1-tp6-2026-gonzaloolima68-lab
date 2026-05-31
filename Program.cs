using System;
using System.Security.AccessControl;

char continuar;

do
{
    Console.WriteLine("Ingrese la operacion a realizar");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");

    int opcion;
    bool ok=int.TryParse(Console.ReadLine(),out opcion);

    if (!ok || opcion<1 || opcion >4)
    {
        Console.WriteLine("opcion invalida");
    }
    else
    {
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
        
        double resultado;

        switch (opcion)
        {
            case 1:
                resultado=num1+num2;
                Console.WriteLine(num1 +" + "+num2+" = "+resultado);
            break;
            case 2:
                resultado=num1-num2;
                Console.WriteLine(num1 +" - "+num2+" = "+resultado);
            break;
            case 3:
                resultado=num1*num2;
                Console.WriteLine(num1 +" * "+num2+" = "+resultado);
            break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("No es posible realizar la division");
                }
                else
                {
                    resultado=num1/num2;
                    Console.WriteLine(num1 +" / "+num2+" = "+resultado);
                }
                
            break;
        }
    }


    Console.WriteLine("Desea realizar otra operacion s=si");
    continuar=Convert.ToChar(Console.ReadLine().ToLower());
} while (continuar == 's');

