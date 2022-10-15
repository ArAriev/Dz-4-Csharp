// Задание 6. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введи число элементов в массиве: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];
for (int i = 0; i < A; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array[i]} ");
    Console.WriteLine();
}
Console.WriteLine("Произведение первого и последнего элемента, второго и предпоследнего и т.д.  ");

int couple = 0;
for (int i = 0; i < A/2; i++)
{
    couple = array[i] * array[A-(i+1)];
    
    Console.Write($"{couple} , ");
}