﻿int EnterDataNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void FillRandomDoubleArray(double[,] array, int leftRange, int rightRange)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 3); // округлим до 3 знаков
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
}


Console.Clear();


const int leftRangeRandom = -10;
const int rightRangeRandom = 10;


int sizeM = EnterDataNumber("Введите количество строк m: ");
int sizeN = EnterDataNumber("Введите количество столбцов n: ");


double[,] myArray = new double[sizeM, sizeN];


FillRandomDoubleArray(
        array: myArray,
        leftRange: leftRangeRandom,
        rightRange: rightRangeRandom
        );
PrintArray(myArray);