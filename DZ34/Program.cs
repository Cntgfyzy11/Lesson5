// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] InitArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(100,1000);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = InitArray(n);
Print(array);
int count =0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    count++;
    {
        Console.Write($"Из {array.Length} чисел, {count} четные");
        break;
    }
}
