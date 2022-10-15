// Задание 5. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int [10];
int summa = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + ", ");
    if (i % 2 != 0)
    {
        summa = summa + array[i];
    }
}
Console.WriteLine($" cуммa чисел одномерного массива стоящих на нечетной позиции = {summa}");

