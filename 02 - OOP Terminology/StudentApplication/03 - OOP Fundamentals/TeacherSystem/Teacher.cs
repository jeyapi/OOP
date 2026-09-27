class Teacher
{
    private string name;
    private string subject;
    private int yearsofexperience;

    public string Name
    {
        get { return name;}
        set { name = value;}
    }

// 04 - Encapsulation 
    public string Subject
    {
        get { return subject;}
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                subject = value;
            }
        }
    }

    public int YearsOfExperience
    {
        get { return yearsofexperience;}
        set
        {
            if (value >= 0)
            {
                yearsofexperience = value;
            }
        }
    }

    public Teacher(string name, string subject, int yearsofexperience)
    {
        Name = name;
        Subject = subject; 
        YearsOfExperience = yearsofexperience;
    }
    
    public void ShowProfile()
    {
        Console.WriteLine($"Teacher: {Name} - Subject: {Subject} - Years of Experience: {YearsOfExperience}");
    }
}