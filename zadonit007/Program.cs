// Задание 7. В Указанном массиве вещественных чисел найдите разницу 
// между максимальным и минимальным элементом

    double[] CreateArray(int length)
    {
        return new double[length];
    }

    double[] array = CreateArray(10);

    double[] FillArray(double[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = new Random().NextDouble()*100;
        }
        return A;
    }
    array = FillArray(array);

    string PrintArray(double[] arr)
    {
        string res = string.Empty;
        for (int i = 0; i < arr.Length; i++)
            res += $"{arr[i]}   ";
        return res;
    }
    Console.WriteLine();
    Console.WriteLine(PrintArray(array));
    Console.WriteLine();

    double MinMaxDiff(double[] arr)
    {
        double min = arr[0];
        double max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
                min = arr[i];
            if (max < arr[i])
                max = arr[i];
        }
        Console.WriteLine($"Минимальное значение {min}");
        Console.WriteLine($"Максимальное значение {max}");
        return max - min;
    }
    double result = MinMaxDiff(array);
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом равна {result}");
    Console.WriteLine();