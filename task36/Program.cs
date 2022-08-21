// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] IntRandomArrayFromToSize(int LeftBorder, int RightBorder, int Length) {
    int[] arr = new int[Length];
    Random rand = new Random();
    for (int i=0; i<Length; i++) {arr[i] = rand.Next(LeftBorder,RightBorder);}
    return arr;}
Console.Write("Введите кол-во элементов массива : ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите левую границу массива : ");
int LeftBorder1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу массива : ");
int RightBorder1 = Convert.ToInt32(Console.ReadLine())+1;
if ((Number>0)&&(LeftBorder1<=RightBorder1)){
    int[] array = new int[Number];
    int sum=0;
    array = IntRandomArrayFromToSize(LeftBorder1,RightBorder1,Number);
    Console.WriteLine($"[{string.Join(", ",array)}]");
    for (int i=0; i<Number;i++) {sum=sum+array[i];i++;}
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях : {sum}");}
else {Console.WriteLine("Введены некорректные данные");}