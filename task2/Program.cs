//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] RandomArrGen()
{
    int length = new Random().Next(1, 15);
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        System.Console.WriteLine(arr[i]);
    }
    return arr;

}

int Summary(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

int[] arr = RandomArrGen();
System.Console.WriteLine(Summary(arr));