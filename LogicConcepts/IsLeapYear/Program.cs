// See https://aka.ms/new-console-template for more information

using Shared;

do
{
    var CurrentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese año: ");

    if(year == CurrentYear)
    {
        message = "es";
    }else if(year > CurrentYear)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }

    if (year % 4 == 0)
    {
        //puede ser bisiesto
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año {year}, Si {message} bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {year}, No {message} bisiesto.");
            }
        }
        else
        {
            Console.WriteLine($"El año {year}, Si {message} bisiesto.");
        }
    }
    else
    {
        Console.WriteLine($"El año {year}, No {message} bisiesto.");
    }
    
} while (true);
