/* Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B:  3, 5 -> 243 (3⁵)
                                           2, 4 -> 16        */

/* 1. Variant - Возврашаемая функция

Console.Write("Enter the first number A= ");
int.TryParse(Console.ReadLine()!, out int A);
Console.Write("Enter the second number B= ");
int.TryParse(Console.ReadLine()!, out int B);

double Funct_AstpB(int a, int b)
{
    double AstpB = Math.Pow(a, b);
    return AstpB;
}
double result = Funct_AstpB(A, B);
Console.Write($"The result equals: result= {result}");*/


/*2. Variant - Возврашаемая функция

Console.Write("Enter the first number A= ");
int.TryParse(Console.ReadLine()!, out int A);
Console.Write("Enter the second number B= ");
int.TryParse(Console.ReadLine()!, out int B);

double Funct_AstpB(int a, int b)
{
    double AstpB = Math.Pow(a, b);
    Console.Write($"The result equals: result= {AstpB}");
    return AstpB;
}
Funct_AstpB(A, B);*/

/*3. Variant - Невозврашаемая функция

Console.Write("Enter the first number A= ");
int.TryParse(Console.ReadLine()!, out int A);
Console.Write("Enter the second number B= ");
int.TryParse(Console.ReadLine()!, out int B);

void Funct_AstpB(int a, int b)
{
    double AstpB = Math.Pow(a, b);
Console.Write($"The result equals: result= {AstpB}");
}
Funct_AstpB(A,B); */

/*4. Variant - Возвращаемая функция
Console.Write("Enter the first number A= ");
int.TryParse(Console.ReadLine()!, out int A);
Console.Write("Enter the second number B= ");
int.TryParse(Console.ReadLine()!, out int B);

double Funct_AstpB(int a, int b) // 3^4=3*3*3*3
{      int AstpB = 1;
    for(int i = 1; i <= b; i++) {AstpB = AstpB*a; }
    return AstpB;
}
double result = Funct_AstpB(A, B);
Console.Write($"The result equals: result= {result}");*/

//5. Variant - Невозвращаемая функция
Console.Write("Enter the first number A= ");
int.TryParse(Console.ReadLine()!, out int A);
Console.Write("Enter the second number B= ");
int.TryParse(Console.ReadLine()!, out int B);

void Funct_AstpB(int a, int b) // 3^4=3*3*3*3
{      int AstpB = 1;
    for(int i = 1; i <= b; i++) {AstpB = AstpB*a; }
    Console.Write($"The result equals: {a}, {b}, -> {AstpB}");
}
Funct_AstpB(A, B);









