﻿void SpiraleArray(int[,] array)
{
    int iSize = array.GetLength(0);
    int jSize = array.GetLength(1);

    int count = 0, i = 0, j = -1;
    bool goRight = true, goDown = false, goLeft = false, goUp = false;

    int rightBorder = array.GetLength(1);
    int bottomBorder = array.GetLength(0);
    int leftBorder = -1;
    int topBorder = -1;

    bool flag = false;

    do
    {
        if (goRight)
        {
            j++;

            if (j == rightBorder)
            {
                j--;
                goRight = false;
                goDown = true;
                topBorder++;
            }
        }

        if (goDown)
        {
            i++;

            if (i == bottomBorder)
            {
                i--;
                goDown = false;
                goLeft = true;
                rightBorder--;
            }
        }

        if (goLeft)
        {
            j--;

            if (j == leftBorder)
            {
                j++;
                goLeft = false;
                goUp = true;
                bottomBorder--;
            }
        }

        if (goUp)
        {
            i--;

            if (i == topBorder)
            {
                i++;
                goUp = false;
                goRight = true;
                leftBorder++;

                continue;  // для завершения "круга", новый круг должен начаться в сторону goRight, как самый первый раз
            }
        }

        count++;
        array[i, j] = count;

    } while (count < iSize * jSize);
}


int EnterDataNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("D2") + " ");

        Console.WriteLine();
    }
}


Console.Clear();
int sizeArrayRows = EnterDataNumber("Введите количество строк массива: ");
int sizeArrayCols = EnterDataNumber("Введите количество столбцов массива: ");


int[,] myArray = new int[sizeArrayRows, sizeArrayCols];


SpiraleArray(myArray);
PrintArray(myArray);