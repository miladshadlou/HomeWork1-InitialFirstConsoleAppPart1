string secretWord = "CSharp";
string guess="";
int counter = 0;
while (guess != secretWord)
{
    Console.Clear();
    Console.WriteLine("Finding secret word");
    Console.Write("Please guess the secret word: ");
    guess = Console.ReadLine();
    counter++;
    if (guess != secretWord)
    {
        Console.WriteLine("Wrong answer! Try again");
        Console.ReadKey();
    }       
}
Console.WriteLine($"congratulation you guess the secret word correctly");
Console.WriteLine($"You have tried {counter} times for guessing the word");

