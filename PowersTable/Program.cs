//Powers Table

Console.WriteLine("Welcome to Powers Table");
static int GetCubed(int x)
{
    return (x * x * x);
}
static int GetSquare(int y)
{
    return (y * y);
}

Console.WriteLine("Learn squares and cubes!");

while (true)
{
    Console.WriteLine("Please enter an integer.");
    int choice = int.Parse(Console.ReadLine());

    if (choice <= 0)
    {
        Console.WriteLine("Please enter a vakid number! The program will restart!");
        continue;
    }

    if (choice > 1290)
    {
        Console.WriteLine("Sorry, the number is too large, please choose a number less than or equal to 1,290");
        continue;
    }

    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "======", "======", "======"));
    //Console.WriteLine("Number" + "\t" "Squared" + "\t" + "Cubed");
    //Console.WriteLine("======" + "\t" "======" + "\t" + "======");

    for (int i = 1; i <= choice; i++)
    {
        //Console.WriteLine(i + "\t" GetSquare(i) + "\t" + GetCubed(i) + "\tn");
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, GetSquare(i), GetCubed(i)));
    }

    Console.WriteLine("Would you like to restart? Enter YES or Y to continue, or enter any key to exit");
    string restart = Console.ReadLine().ToUpper();

    if (restart == "Y" || restart == "YES")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Thanks for playing! You may exit now!");
        break;
    }
}