int n = 0;
do
{
    Console.Clear();
    Console.Write("Please Enter A Positive integer n: ");
    //n = int.Parse(Console.ReadLine());
    if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
    {
        Console.Write("The input is incorrect please try again");
    }
    else
    {
        int Total = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                Total += i;
            }
        }
        Console.WriteLine($"The Total of odd numbers is: {Total}");
    }
    Console.ReadKey();
}while (n < 1);