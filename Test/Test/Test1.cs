// See https://aka.ms/new-console-template for more information


class Test1
{

    static void Main(string[] args)
    {
        int[] ints = { 3, 6, 7, 9 };
        Console.WriteLine(Sum(ints));
    }

    static int Sum(int[] ints)
    {
        int sum = 0;
        foreach (int i in ints)
        {
            sum += i;
        }
        return sum;
    }
}
