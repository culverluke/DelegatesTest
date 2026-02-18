

Console.WriteLine("Pick an operation");
Console.WriteLine("[1] - Is number even");
Console.WriteLine("[2] - Is number positive");
Console.WriteLine("[3] - is number a multiple of Ten");

int choice = 0;


int.TryParse(Console.ReadLine(), out choice);
int input = 0;

switch (choice)
{
    case 1:
        Sieve evenSieve = new Sieve(IsEven);

        do
        {
            int.TryParse(Console.ReadLine(), out input);

            Console.WriteLine(evenSieve.IsGood(input));
        
        } while (true);

    break;

    case 2:
        Sieve positiveSieve = new Sieve(IsPositive);

        do
        {
            int.TryParse(Console.ReadLine(), out input);

            Console.WriteLine(positiveSieve.IsGood(input));

        } while (true);
    break;

    case 3:
        Sieve tenSieve = new Sieve(MultipleOfTen);

        do
        {
            int.TryParse(Console.ReadLine(), out input);

            Console.WriteLine(tenSieve.IsGood(input));

        } while (true);
    break;

    default:
        Console.WriteLine("Pick a option from the menu.");
        break;
}



bool IsEven(int number)
{
    if(number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool IsPositive(int number)
{
    if(number >= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool MultipleOfTen(int number)
{
    if(number % 10 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}



public class Sieve(Func<int, bool> operation)
{


    public Func<int, bool> DelegateOperation { get; set; } = operation;

    public bool IsGood(int number)
    {
        bool result = false;

        result = DelegateOperation(number);

        return result;
    }

}