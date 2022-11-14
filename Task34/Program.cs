// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandArr(int lenght, int begin, int end)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(begin, end + 1);
    }
    return result;
}

int[] array = GetRandArr(333, 100, 999);
Console.WriteLine($"{String.Join(", ", array)}");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");