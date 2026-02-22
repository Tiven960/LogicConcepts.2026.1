using Shared;
using System.Security.Cryptography.X509Certificates;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese ubicación de los caballos: ");
    answer = Console.ReadLine();

    int[,] tab = new int[8,8];
    int[,] pos = new int[64,2];
    int tope = 0;
    int n = answer.Length;
    int i = 0;
    
    while (i < n)
    {
        char currCol = answer[i];
        i++;
        char currFil = answer[i];
        i++;
        i++;
        tab[ef(currFil),ec(currCol)] = 1;
        pos[tope,0] = ef(currFil);
        pos[tope,1] = ec(currCol);
        tope++;

    }

    int fil, col;
    for (i = 0; i < tope; i++)
    {
        Console.Write("\nAnalizando Caballo en "
                          + efInv(pos[i,0])
                          + ecInv(pos[i, 1])
                          + " => ");

        //horse movements
        //top left
        fil = pos[i,0] - 2;
         col = pos[i,1] - 1;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil, col] == 1)
            {
                Console.Write(" Conflicto con "
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
            }
        }
        //up and right
        fil = pos[i,0] - 2;
         col = pos[i,1] + 1;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil, col] == 1)
            {
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
            }
        }
        //top left
        fil = pos[i,0] - 1;
         col = pos[i,1] - 2;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil, col] == 1)
            {
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
            }
        }
        //top right
        fil = pos[i,0] + 1;
         col = pos[i,1] - 2;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil, col] == 1)
            {
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
            }
        }
        //right up
        fil = pos[i,0] - 1;
         col = pos[i,1] + 2;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil, col] == 1)
            {
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
            }
        }
        //right down
        fil = pos[i,0] + 1;
         col = pos[i,1] + 2;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil,col] == 1)
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
        }
        //bottom right
        fil = pos[i,0] + 2;
         col = pos[i,1] - 1;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil,col] == 1)
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
        }
        //bottom left
        fil = pos[i,0] + 2;
         col = pos[i,1] + 1;
        if (fil >= 0 && fil <= 7 && col >= 0 && col <= 7)
        {
            if (tab[fil, col] == 1)
            {
                Console.Write(" Conflicto con "
                              
                              + efInv(fil)
                              + ecInv(col)
                              + "\t");
            }
        }
        Console.WriteLine();
    }


    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


int ef(char f)
{
    switch (f) { 
        case '8': return 0;
        case '7': return 7;
        case '6': return 6;
        case '5': return 5;
        case '4': return 4;
        case '3': return 3;
        case '2': return 2;
        default: return 1;
    }
    
}

char efInv(int f)
{
    switch (f)
    {
        case 0: return '8';
        case 7: return '7';
        case 6: return '6';
        case 5: return '5';
        case 4: return '4';
        case 3: return '3';
        case 2: return '2';
        default: return '1';
    }

}

char ecInv(int f)
{
    switch (f)
    {
        case 0: return 'A';
        case 1: return 'B';
        case 2: return 'C';
        case 3: return 'D';
        case 4: return 'E';
        case 5: return 'F';
        case 6: return 'G';
        default: return 'H';
    }

}

int ec(char f)
{
    switch (f)
    {
        case 'A': return 0;
        case 'B': return 1;
        case 'C': return 2;
        case 'D': return 3;
        case 'E': return 4;
        case 'F': return 5;
        case 'G': return 6;
        default: return 7;
    }

}
