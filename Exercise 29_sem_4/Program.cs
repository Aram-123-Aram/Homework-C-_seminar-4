/* Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

// 1. Variant:
int[] array = new int[8];

int[] FullArray(int[] mas1)
{
    for (int i = 0; i < mas1.Length; i++) {mas1[i] = new Random().Next(0,100); }
    return mas1;
}

FullArray(array);
foreach(var item in array) {Console.Write($" {item},  "); }

/* 2. Variant-vozvrashaemaya fynktia
int[] array = new int[8];

int[] FullArray(int[] mas1)
{
    for (int i = 0; i < mas1.Length; i++) {mas1[i] = new Random().Next(0,100); }
    return mas1;
}
int[] ShowArray(int[] mas2)
{
    for(int i = 0; i < mas2.Length; i++) {Console.WriteLine($"{mas2[i]} "); }
    return mas2;
}
FullArray(array);
ShowArray(array);*/

/*3. Variant - nevozvrashaemaya funktia

int[] array = new int[8];

void FullArray(int[] mas1)
{
    for (int i = 0; i < mas1.Length; i++) {mas1[i] = new Random().Next(0,100); }
}
void ShowArray(int[] mas2)
{
    for(int i = 0; i < mas2.Length; i++) {Console.WriteLine($"{mas2[i]} "); }
}
FullArray(array);
ShowArray(array);*/


