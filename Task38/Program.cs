// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Глядя на пример, осмелюсь предположить, что все же имелись ввиду натуральные числа...

int[] GetRandArr(int lenght, int begin, int end)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(begin, end + 1);
    }
    return result;
}

int[] array = GetRandArr(333, 1, 9999);
Console.WriteLine($"{String.Join(", ", array)}");
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}
Console.WriteLine($"Разница меж максимальным и минимальным элементом массива: {max - min}");