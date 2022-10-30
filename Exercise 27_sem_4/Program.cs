/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  452 -> 11
                                                                                  82 -> 10
                                                                                  9012 -> 12 */
Console.Write("Enter any number: n= ");
int.TryParse(Console.ReadLine()!, out int n);

Console.Write($"The summa of numbers n equals: -----{n} -> {Funct_sum(n)}");

int Funct_sum(int n)
{
    int temp = n;
    int Sum_numbers = 0;
    while(temp != 0)
    {Sum_numbers =Sum_numbers + temp%10; temp = temp/10;}
    return Sum_numbers;

}
Funct_sum(n);