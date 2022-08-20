// Задача 34: Задайте массив, заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] IntRandomArrayFromToSize(int LeftBorder, int RightBorder, int Length) {
    int[] arr = new int[Length];
    Random rand = new Random();
    for (int i=0; i<Length; i++) {arr[i] = rand.Next(LeftBorder,RightBorder);}
    return arr;}
Console.Write("Введите кол-во элементов массива трехзначных чисел: ");
int Number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Number];
int sum=0;
array = IntRandomArrayFromToSize(100,1000,Number);
Console.WriteLine($"[{string.Join(", ",array)}]");
for (int i=0; i<Number;i++) {if (array[i]%2==0) {sum++;}}
if (sum>0) {Console.WriteLine($"Кол-во четных элементов массива : {sum}");}
else {Console.WriteLine("Нет четных элементов массива.");}