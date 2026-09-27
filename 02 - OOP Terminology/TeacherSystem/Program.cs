// 01 - Create a class
Teacher teacher1 = new Teacher("Dr. Smith", "Physics", 10);
Console.WriteLine($"Teacher: {teacher1.Name} - Subject: {teacher1.Subject} - Years of Experience: {teacher1.YearsOfExperience}");
Teacher teacher2 = new Teacher("Dr. Johnson", "Mathematics", 15);
Console.WriteLine($"Teacher: {teacher2.Name} - Subject: {teacher2.Subject} - Years of Experience: {teacher2.YearsOfExperience}");

// 02 - Add a method
teacher1.ShowProfile();
teacher2.ShowProfile();

// 03 - Use a list 
List<Teacher> teachers = new List<Teacher>();
teachers.Add(new Teacher("Dr. Smith", "Physics", 10));
teachers.Add(new Teacher("Dr. Johnson", "Mathematics", 15));

foreach (Teacher teacher in teachers)
{
    teacher.ShowProfile();
}

// 05 - Final challenge 
while(true)
{
    Console.WriteLine("1. Add Teacher");
    Console.WriteLine("2. Show Teachers");
    Console.WriteLine("3. Count how many teachers exist");
    Console.WriteLine("4.Show the average years of experience");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter teacher's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter teacher's subject: ");
            string subject = Console.ReadLine();
            Console.Write("Enter teacher's years of experience: ");
            int yearsOfExperience = int.Parse(Console.ReadLine());

            Teacher newTeacher = new Teacher(name, subject, yearsOfExperience);
            teachers.Add(newTeacher);
            Console.WriteLine("Teacher added successfully!");
            break;

        case 2:
            Console.WriteLine("List of Teachers:");
            foreach (Teacher teacher in teachers)
            {
                teacher.ShowProfile();
            }
            break;
        
        case 3:
            Console.WriteLine($"Total number of teachers: {teachers.Count}");
            break;
        
        case 4: 
            if (teachers.Count > 0)
            {
                double averageExperience = teachers.Average(t => t.YearsOfExperience);
                Console.WriteLine($"Average years of experience: {averageExperience}");
            }
            else
            {
                Console.WriteLine("No teachers available to calculate average experience.");
            }
            break;
        
        case 5:
            Console.WriteLine("Exiting the program.");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }       
}