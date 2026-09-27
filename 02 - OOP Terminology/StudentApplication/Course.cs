class Course
{
    public string Name;
    public static int TotalCourses = 0;

    public Course(string name)
    {
        Name = name;
        TotalCourses++;
    }

    public static void ShowCourse()
    {
        Console.WriteLine($"Total Courses: {TotalCourses}");
    }
}