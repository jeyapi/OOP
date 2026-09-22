void rolldice()
{
    Random rand = new Random();
    while(true)
    {
        int dicehuman = rand.Next(1,7);
        int dicecomputer = rand.Next(1,7);
        Console.WriteLine($"Human : {dicehuman}");
        Console.WriteLine($"Computer : {dicecomputer}");
        if (dicehuman > dicecomputer)
        {
            Console.WriteLine("Human wins");
            break;
        }
        else if (dicehuman < dicecomputer)
        {
            Console.WriteLine("Computer wins");
            break;
        }
        else
        {
            Console.WriteLine("It is a tie, rolling again");
        }
    }
}

rolldice();
