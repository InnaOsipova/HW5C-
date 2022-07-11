//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray ()
{
    int[] arrayRand = new int [20];
    for (int i = 0; i < 20; i++)
    {
        arrayRand [i] = new Random().Next(100, 1000);
    }
    return arrayRand;

}

int Сoucounting (int[] arr)
{
   int cou = 0;
   for (int i = 0; i < 20; i++)
   {
     Console.Write (arr[i]+", ");
     if ((arr[i] % 2) == 0)  cou++;
   }
   Console.WriteLine();
   return cou;
}

int[] array = RandomArray();
int count = Сoucounting(array);

Console.WriteLine($"Количество четных чисел массива = {count}");
