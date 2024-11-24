# Решение задачи

using System;

public class StringFilter
{
        public static string[] FilterShortStrings(string[] input)
    {
        // 1. Подсчет коротких строк:
        int shortStringCount = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                shortStringCount++;
            }
        }

* 2. Создание массива результата:
string[] result = new string[shortStringCount];

        // 3. Заполнение массива результата:
        int index = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

    public static string[] GetInputStrings()
    {
        Console.WriteLine("Введите строки, разделенные пробелами (для завершения введите пустую строку):");
        string line = Console.ReadLine();

        if (string.IsNullOrEmpty(line))
        {
            return new string[0]; // Возвращаем пустой массив, если пользователь ввел пустую строку
        }

        return line.Split(' ');
    }

    public static void Main(string[] args)
    {
        string[] inputArray = GetInputStrings();

        string[] filteredArray = FilterShortStrings(inputArray);

        Console.WriteLine("Исходный массив: [" + string.Join(", ", inputArray) + "]");
        Console.WriteLine("Отфильтрованный массив: [" + string.Join(", ", filteredArray) + "]");
    }
}



