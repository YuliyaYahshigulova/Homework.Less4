Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int MethodSum(int N)
{
    int s = 0;
    while (N > 0)
    {
        s = s + N % 10;
        N = N / 10;
    }
    Console.WriteLine(s);
    return N;
}

N = MethodSum(N);