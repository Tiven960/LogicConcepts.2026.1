// See https://aka.ms/new-console-template for more information


do
{
    Console.WriteLine("Ingrese 3 numeros diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero: ");
    var c = ConsoleExtension.GetInt("Ingrese tercer numero: ");

    if (a > b && a > c)
    {
        if(b>c)
        {
            Console.WriteLine($"El mayor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el medio es {b}, el menor es {a}");
        }
    }
    
    
} while (true);
