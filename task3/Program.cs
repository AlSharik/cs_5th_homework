//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


// В условиях сказанно о вещественных числах поэтому все через double

double[] RandomArrGen()
{
    double max = - 10000;
    double min = 100000;
    int length = new Random().Next(1, 15);
    double[] arr = new double[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().NextDouble()*2000-1000;
        //Random rnd = new Random();
        //arr[i] = rnd.Next(-1000,1000)+rnd.NextDouble();
        System.Console.WriteLine(arr[i]);
        if(max < arr[i]) max = arr[i];
        if(min > arr[i]) min = arr[i];
    }
    System.Console.WriteLine($"Разница равна {max - min}");
    return arr;

}
double[] arr = RandomArrGen();
