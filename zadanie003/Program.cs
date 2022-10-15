// Задание 3. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] array = new int [size];
int index = 0;
int countChet = 0;
int countNechet = 0;

while (index < size)
{
    array[index] = new Random().Next(99, 1000);
    index++;
}
Console.WriteLine("Ваш массив ");
Console.WriteLine();
index = 0;
while(index < size)
{
    Console.WriteLine($"{array[index]}");
    index++;
}
Console.WriteLine();
index = 0;

while (index < size)
{
    if (array[index] % 2 == 0)
    countChet = countChet + 1;
    else
    countNechet = countNechet + 1;
    index++;
}
Console.WriteLine();
Console.WriteLine($"Четных чисел {countChet} , нечетных чисел {countNechet}");
Console.WriteLine();