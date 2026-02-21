using Shared;
using System.Security.Cryptography.X509Certificates;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese la viga: ");
    answer = Console.ReadLine();

    if (esValido(answer!))
    {
        if (!soportePeso(answer!))
        {
            Console.WriteLine("La viga soporta el peso!");
        }
        else
        {
            Console.WriteLine("La viga no soporta el peso!");
        }
    }
    else
    {
        Console.WriteLine("La viga esta mal construida!");
    }




            do
            {
                answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i, [N]o: ", options);
            } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

 bool esValido(string baseText)
{
    String viga = baseText.Substring(0, 1);
    if (baseText == "#" || baseText == "&" || baseText == "%")
    {
        return true;
    }

    int n = baseText.Length;
    int conCon = 0;
    for (int i = 0; i < n; i++)
    {
        String pieza = baseText.Substring(i, i + 1);
        if(!(pieza == "=" || pieza == "*")){
            return false;
        }

        if(pieza == "*")
        {
            conCon++;
        }
        else
        {
            conCon = 0;
        }

        if(conCon == 2)
        {
            return false;
        }   
    }

    return false;
}

bool soportePeso(string baseText)
{
    String viga = baseText.Substring(0, 1);

    int n = baseText.Length;
    int pesoTotal = 0;
    int pesoSegmento = 0;
    for (int i = 0; i < n; i++)
    {
        String pieza = baseText.Substring(i, i + 1);
        if (pieza == "=")
        {
            pesoSegmento++;
        }
        else
        {
            pesoTotal += pesoSegmento * 3;
            pesoSegmento = 0;
        }
    }
    pesoTotal += pesoSegmento;

    int pesoBase = 0;
    switch (baseText)
    {
        case "#":
            pesoBase = 10;
            break;
        case "&":
            pesoBase = 30;
            break;
        case "%":
            pesoBase = 90;
            break;
    }
    
      return pesoBase >= pesoTotal;
}






