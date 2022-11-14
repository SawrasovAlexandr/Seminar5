// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetRandArr(int lenght, int begin, int end)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(begin, end + 1);
    }
    return result;
}
// Условие не соответствует примеру. На семинаре с преподавателем определились, 
// что будем делать, как в примере, т.е. искать сумму элементов с нечетными индексами
int[] array = GetRandArr(333, -999, 999);
Console.WriteLine($"{String.Join(", ", array)}");
int sum = 0;
for (int i = 1; i < array.Length; i += 2) // что бы найти сумму элементов, стоящих на нечётных позициях i должна стартовать с 0.
{
    sum += array[i];
}
Console.WriteLine($"Сумма элементов, с нечетными индексами: {sum}");