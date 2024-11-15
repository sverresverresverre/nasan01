// if(6 >= 3)
// {
//     Console.WriteLine("Hello, World!");
// }

// Console.WriteLine("Write your name.");
// string username = Console.ReadLine();

// Console.WriteLine("Type in the password.");
// string password = Console.ReadLine();
// if(username == "kalleanka" && password == "12345")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
// }

// for (int i = 0; i < 32; i ++)
// {
//     Console.WriteLine("Hello, world");
// }

// while (true)
// {
//     Console.WriteLine("Type in the password.");
//     string password = Console.ReadLine();

//     if(password == "12345")
//     {
//         Console.WriteLine("Welcome!");
//         break;
//     }
//     else
//     {
//         Console.ReadLine();
//     }
// }

// for (int i = 0; i < 5; i ++)
// {
//     Console.WriteLine("Write a number");
//     string number = Console.ReadLine();
//     int five;
//     bool lyckad = int.TryParse(number, out five);
    
//     if (five > 5)
//     {
//         Console.WriteLine("Högre än 5!");
//         break;
//     }

//     if (lyckad == false)
//     {
//         Console.WriteLine("Not a number...");
//     }
// }

Console.WriteLine("Shabobba's number guessing game!!!!");
Console.WriteLine("(Hint, it is between 1-20)");

while (true)
{
    string number = Console.ReadLine();
    int result;
    bool lyckad = int.TryParse(number, out result);

    if (result == 3)
    {
        Console.WriteLine("Well done!!! You guessed 3 which is correct.");
        break;
    }
    if (result < 3 && lyckad == true)
    {
        Console.WriteLine("A little bit more...");
    }
    if (result > 3 && lyckad == true)
    {
        Console.WriteLine("Nahhh... a little bit less.");
    }
    if (lyckad == false)
    {
        Console.WriteLine("That is not an integer... Try again.");
    }
}

Console.ReadLine();