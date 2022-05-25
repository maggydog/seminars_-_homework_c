// 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Числа выбираются случайно, при этом проверяется, что такого числа еще не было. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int x = InputNumbers("Зададим трехмерную матрицу. Введите первое измерение: ");
int y = InputNumbers("Введите второе измерение: ");
int z = InputNumbers("Введите третье измерение: ");
int[,,] cubeTable = new int[x, y, z];

int InputNumbers(string b)
{
    int a;
    Console.Write(b);
    while (!int.TryParse(Console.ReadLine(), out a) || a <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
    return a;
}

void FillAndPrintTable(int[,,] array)
{
    bool isItDuplicate = false;
    int randomNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {

                while (!isItDuplicate)
                {
                    randomNumber = new Random().Next(10, 100);
                    isItDuplicate = NotDuplicateRandom(array, randomNumber);
                }
                array[i, j, k] = randomNumber;
                Console.WriteLine($"Элемент [{i},{j},{k}] = {array[i, j, k]}");
                isItDuplicate = false;
            }
}

bool NotDuplicateRandom(int[,,] array, int randomNum)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (randomNum == array[i, j, k]) return false;
    return true;
}

FillAndPrintTable(cubeTable);