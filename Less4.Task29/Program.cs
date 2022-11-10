// Console.Write("Введите положительное целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 201);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.WriteLine(col[pos]);
    }
}
FillArray(array);
PrintArray(array);






// Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.
