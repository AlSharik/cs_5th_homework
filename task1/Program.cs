//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] RandomArrGen()
{
    int length = new Random().Next(1, 15);
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
//      System.Console.WriteLine(arr[i]);
    }
    return arr;

}
//Массив можно было бы выводить паралельно его заполняя и тогда на одну итерацию прохода по массиву было бы меньше, но я не думаю, что это существенно

void ArrShow( int[] array )
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
int CheckingEven( int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

int[] arr = RandomArrGen();
ArrShow(arr);
System.Console.WriteLine(CheckingEven(arr));