/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
void Task34 ()
{
int [] array = new int[8];
FillArray(array, 100, 999);
PrintArray(array);
CountEvenNumbers(array);

}
void CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    Console.WriteLine();
    Console.WriteLine("Кол-во четных чисел в массиве равно " + count);
}
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
Task34();