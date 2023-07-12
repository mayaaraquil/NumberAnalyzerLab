Console.WriteLine("Hello there! welcome to decision maker ");
{
    int num = 0;
    Console.WriteLine("Enter a number between from 1-100");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine("{0} is even", num);
    }
    else
    {
        Console.WriteLine("{0} is odd", num);
    }
    Console.ReadLine();
}




