﻿Console.Clear();
Console.Write("Введите номер дня недели: ");
int digit = Convert.ToInt16(Console.ReadLine());
if (digit >= 1 && digit <= 7)
{
    if (digit == 6 || digit == 7)
        Console.WriteLine($"Да, день недели с номером {digit} является выходным");
    else
        Console.WriteLine($"Нет, день недели с номером {digit} не является выходным");
}
else
    Console.WriteLine($"Дня недели с номером {digit} не существует");