// 62.Заполнить спирально массив 4 на 4

int[,] table = new int[3, 3];
//SpiralFill(table,0,0);
PrintArray(table);

int start=1;
for (int i=0;i<table.GetLength(1);i++)
    table[0,i] = start;
    start++;

for (int j=1;j<table.GetLength(0);j++)
    table[j,table.GetLength(1)-1] = start;
    start++;

for (int k=table.GetLength(1);k>=0;k--)
    table[table.GetLength(1)-1,k] = start;
    start++;

for (int l=0;l>=0;l--)
    table[l,0] = start;
    start++;


Console.WriteLine (table.GetLength);
/*void SpiralFill (int [,] array, int row, int col) //координаты строки и столбца
{
    int start = 0;
    if (row<array.GetLength(0) && col<array.GetLength(1))
   if (array[row,col]==0) 
    {
        array[row,col] = start+1;
        start++;
        SpiralFill(array,row,col+1);
        SpiralFill(array,row+1,col);
        SpiralFill(array,row,col-1);
        SpiralFill(array,row-1,col);
    }
}
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}