const int maxgrades = 5;
List<double> grades = new List<double>();
while (grades.Count < maxgrades)
{
    Console.WriteLine($"Enter grade:");
    if (!double.TryParse(Console.ReadLine(), out double grade))
    {
        Console.WriteLine("Invalid input.");
    } 
    else
    {
        grades.Add(grade);
    }
}

Console.WriteLine($"Max grade: {grades.Max()}" );
Console.WriteLine($"Min grade: {grades.Min()}");
Console.WriteLine($"Average grade: {grades.Average()}");
