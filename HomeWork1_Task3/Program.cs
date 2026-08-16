Console.WriteLine("guess a secret number between 1 to 10 (you have only 5 chance) ");
int secretNumber = 7;
int Result = 0;
int counter = 0;
while (Result != secretNumber && counter < 5 )
{
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"guess number{i}: ");
        Result = int.Parse(Console.ReadLine());
        counter++;
        if (Result == secretNumber)
        {
            Console.Write($"Congragulation you guess right number");
            break;
        }                    
    }    
}
if (Result != secretNumber )
Console.WriteLine($"your chance is over, Right answer is: {secretNumber} ");

