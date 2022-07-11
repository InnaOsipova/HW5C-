//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray ()
{
    int[] arrayRand = new int [20];
    for (int i = 0; i < 20; i++)
    {
        arrayRand [i] = new Random().Next(100, 1000);
        Console.Write (arrayRand[i]+", ");
    }
    Console.WriteLine();
    return arrayRand;

}

int Сoucounting (int[] arr)
{
   int sum = 0;
   for (int i = 1; i < 20; i = i+2)
   {
      sum = sum + arr[i];
   }
   
   return sum;
}

int[] array = RandomArray();
int summa = Сoucounting(array);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {summa}");
