using System;

class ArrayOperations
{
    // Метод сортировки массива по возрастанию
    public static int[] SortAscending(int[] array)
    {
        Array.Sort(array); // Сортировка массива по возрастанию
        return array;
    }

    // Метод сортировки массива по убыванию
    public static int[] SortDescending(int[] array)
    {
        Array.Sort(array); // Сначала сортируем по возрастанию
        Array.Reverse(array); // Затем разворачиваем для получения убывания
        return array;
    }

    // Метод объединения двух массивов
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        Array.Copy(array1, mergedArray, array1.Length); // Копируем первый массив
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length); // Копируем второй массив
        return mergedArray;
    }

    // Тестирование методов
    static void Main()
    {
        int[] array1 = { 5, 2, 8, 1 };
        int[] array2 = { 9, 3, 4 };

        Console.WriteLine("Исходный массив 1: " + string.Join(", ", array1));
        Console.WriteLine("Исходный массив 2: " + string.Join(", ", array2));

        // Сортировка по возрастанию
        int[] sortedAscending = SortAscending((int[])array1.Clone());
        Console.WriteLine("Сортировка по возрастанию: " + string.Join(", ", sortedAscending));

        // Сортировка по убыванию
        int[] sortedDescending = SortDescending((int[])array1.Clone());
        Console.WriteLine("Сортировка по убыванию: " + string.Join(", ", sortedDescending));

        // Объединение массивов
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединение массивов: " + string.Join(", ", mergedArray));
    }
}
