// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] RandomArray(int a, int b)
{
    Random ran = new Random();
    double[,] array = new double[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i,j] = ran.NextDouble();
        }
    }
    return array;
}

Console.WriteLine("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(RandomArray(a,b));

