int Stepen(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}
int pow = Stepen(2, 10);
Console.WriteLine(pow);

