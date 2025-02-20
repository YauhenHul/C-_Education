﻿int SummNaturalElements (int numberM, int numberN, int sum = 0)
{	
	if (numberM == numberN)
		return sum += numberN;
	else 
		return sum += numberM + SummNaturalElements(numberM + 1, numberN, sum);
}


Console.Clear();


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int summaryFromMtoN = SummNaturalElements(numberM, numberN);


int sum = 0;
for (int i = numberM; i <= numberN; i++)
	sum += i;

Console.WriteLine($"\nСумма от {numberM} до {numberN} через рекурсию: " + summaryFromMtoN);
Console.WriteLine($"Сумма от {numberM} до {numberN} через цикл: " + sum);