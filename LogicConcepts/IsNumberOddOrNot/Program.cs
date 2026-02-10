// See https://aka.ms/new-console-template for more information
var numberString = string.Empty;
do
{
    Console.WriteLine("Ingrese numero o la palabra 'salir' para salir: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "salir" )
    {
        continue;
    }

    var numberInt = 0;
    if(int.TryParse(numberString, out numberInt))
    {

        if (numberInt % 2 == 0)
        {
            Console.Write($"El numero {numberInt}, es par.");
        }
        else
        {
            Console.Write($"El numero {numberInt}, es impar.");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un numero estero.");
    }

} while (numberString!.ToLower() != "salir");
Console.WriteLine("Gamer Over.");

