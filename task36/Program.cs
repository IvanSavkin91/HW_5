/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
void Task36()
{
int [] array = new int[8];
FillArray(array, 0, 100);
PrintArray(array);

void FillArray (int [] array, int startNumber = 0, int endNumber= 1)
{
    endNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        {
        array [i] = random.Next(startNumber, endNumber);
        }
}
void PrintArray (int[] array)
    {
        Console.WriteLine("Вывод массива ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов, стоящих на нечётных индексах равна " + sum );
    }
Task36();