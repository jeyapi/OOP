class Student
{
    public string Name;
    public int Age;
      
    public static int TotalStudents = 0;
    public static void ShowMessage()
    {
        Console.WriteLine("Welcome to the student system!");
    }


    public Student(string name, int age)
    {
        Name = name;
        Age = age; 
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Student: {Name} - Age: {Age}");
    }

    public int GetYearsToGraduate()
    {
        return 4;
    }

    public void CelebrateBirthday(int years)
    {
        Age += years;
        Console.WriteLine($"Happy Birthday {Name}! You are now {Age}.");
    }
}