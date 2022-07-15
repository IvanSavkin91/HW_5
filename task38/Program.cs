/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
void Task38()
{
Random random = new Random ();
double[] array = new double[10];
for (int i = 0; i < array.Length; i++ )
    {
    array[i] = Math.Round(random.NextDouble(), 4);
    }
    Console.WriteLine("Вывод массива ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]> max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine();
    Console.WriteLine ($"Максимальное число : {max} ;  Минимальное число : {min}");
    Console.WriteLine();
    Console.WriteLine ("Их разность равна: " + (max - min));
}
Task38();