// Andrew Nilsson
//09-07-2022
//Mini Challenge #2 - Add 2 Numbers
//This is a console project that will add 2 numbers
//Peer Review by: Lerissa Lazar 
//The project ran very smoothly, without any errors. Great!


Console.Clear();
bool play = true;


while (play)
{
    int num1 = 0, num2 = 0;
    bool valid1 = false, valid2 = false;

    Console.Write("Enter first number: ");

    while (!valid1)
    {
        valid1 = Int32.TryParse(Console.ReadLine(), out num1);

        if (!valid1)
        {
            Console.WriteLine("Invalid number. Try again.");
        }
    }

    //int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second number: ");

    while (!valid2)
    {
        valid2 = Int32.TryParse(Console.ReadLine(), out num2);

        if (!valid2)
        {
            Console.WriteLine("Invalid number. Try again.");
        }
    }

    //int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Your sum is: " + (num1 + num2));

    bool playValid = true;
    
    while (playValid)
    {
        Console.WriteLine("Enter yes if you would like to add more numbers. Enter no to exit.");
        string input = Console.ReadLine();
        input = input.ToLower();

        if (input == "yes")
        {
            playValid = false;
        }
        else if (input == "no")
        {
            Console.WriteLine("Have a good day.");
            playValid = false;
            play = false;
        }
        else
        {
            Console.WriteLine("INVALID ANSWER");
        }
    }
}