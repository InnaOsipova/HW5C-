//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] RandomArray ()
{
    double[] arrayRand = new double [20];
    for (int i = 0; i < 20; i++)
    {
        arrayRand [i] = Convert.ToDouble(new Random ().Next (-100, 101)/10.0);
        Console.Write (arrayRand[i]+"  ");
    }
    Console.WriteLine();
    return arrayRand;

}

double Сoucounting (double [] arr)
{
   double min = arr[0];
   double max = arr[0];
   for (int i = 0 ; i < 20; i++)
   {
      if (arr[i] > max) 
      {
        max = arr[i];
        Console.WriteLine($" макс = {arr[i]}");
      }
      else if (arr[i] < min) 
      {
        min = arr[i];
        Console.WriteLine($" мин = {arr[i]}");
      }
   }

   double difference = max - min;
   return difference;
}

double[] array = RandomArray();
double diff = Сoucounting(array);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");
