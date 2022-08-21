// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] IntRandomArrayFromToSize(int LeftBorder, int RightBorder, int Length){
    
    double[] arr = new double[Length];
    Random rand = new Random();
    for (int i=0; i<Length; i++) 
    {
        arr[i] = (rand.Next(LeftBorder,RightBorder-1)*100+rand.Next(0,101));
        arr[i] = arr[i]/100;}
        
    return arr;}
  
Console.Write("Введите кол-во элементов массива : ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите левую (целочисленную) границу массива : ");
int LeftBorder1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую (целочисленную) границу массива : ");
int RightBorder1 = Convert.ToInt32(Console.ReadLine());
if ((Number>0)&&(LeftBorder1<RightBorder1))
{
    double[] array = new double[Number];
    array = IntRandomArrayFromToSize(LeftBorder1,RightBorder1,Number);
    Console.WriteLine($"[{string.Join("; ",array)}]");
    double max = array[0];
    double min = array[0];    
    for (int i=0; i<Number;i++) {
        if (array[i]>max) {max = array[i];}
        if (array[i]<min) {min = array[i];}
    }
       Console.WriteLine($"Разница между MAX и MIN элементами = {Math.Round((max-min)*100)/100}");}

else {Console.WriteLine("Введены некорректные данные");}