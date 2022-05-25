// See https://aka.ms/new-console-template for more information


int [,] first = new int [3,3];

void PrintTable (int [,] table)
{
    for (int i=0; i < table.GetLength(0); i++)
    {
        for (int j=0; j < table.GetLength(1);j++)
        {
        
            Console.Write($"-{table[i,j]}- ");
        }
    Console.WriteLine ();
    }

}
void PrintStringTable (string [,] table, string name)
{
    Console.WriteLine(name);
    for (int i=0; i < table.GetLength(0); i++)
    {
        for (int j=0; j < table.GetLength(1);j++)
        {
        
            Console.Write($"-{table[i,j]}- ");
        }
    Console.WriteLine ();
    }

}

void FillTable (int [,] table, int start)
{
    for (int i=0; i < table.GetLength(0); i++)
    {
        for (int j=0; j < table.GetLength(1);j++)
        {
            table[i,j]=start;
            start++;

        }
    }

}

void PrintImage (int [,] table)
{
    for (int i=0; i < table.GetLength(0); i++)
    {
        for (int j=0; j < table.GetLength(1);j++)
        {
                if (table[i,j]==0) Console.Write($" ");
                else Console.Write("*");
        }
    Console.WriteLine ();
    }

}


void DrawImage (int [,] table)
{
    for (int i=0; i < table.GetLength(0); i++)
    {
        for (int j=0; j < table.GetLength(1);j++)
        {
            table[i,j]=int.Parse(Console.ReadLine());
        }
    }

}





string[,] second = new string [3,3];

void HandFilling (string [,] table)
{
    for (int row=0; row<table.GetLength(0);row++)
    {
        for (int column=0; column<table.GetLength(1);column++)
        {
            Console.Write($"Заполните ячейку [{row},{column}]): ");
            table[row,column]=Console.ReadLine();
        }
    }
}

HandFilling(second);
PrintStringTable(second,"таблица");