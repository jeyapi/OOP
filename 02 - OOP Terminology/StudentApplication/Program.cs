// 01 - Introduction to Classes
Student student1 = new Student();
student1.Name = "Ana";
student1.Age = 20;
student1.Career = "Computer Science";

Console.WriteLine($"Student : {student1.Name}");
Console.WriteLine($"Age: {student1.Age}");
Console.WriteLine($"Career: {student1.Career}");

Student student2 = new Student();
student2.Name = "Carlos";
student2.Age = 22;
student2.Career = "Mathematics";

Console.WriteLine($"Student : {student2.Name}");
Console.WriteLine($"Age: {student2.Age}");
Console.WriteLine($"Career: {student2.Career}");

Course course1 = new Course();
course1.name = "OOP";
course1.credits = 5;
course1.teacher = "Prof Prieto";

Console.WriteLine($"Course: {course1.name}");
Console.WriteLine($"Credits: {course1.credits}");
Console.WriteLine($"Teacher: {course1.teacher}");

// 02 - Objects, Fields and State

Console.WriteLine($"{student1.Name} is {student1.Age} years old.");
Console.WriteLine($"{student2.Name} is {student2.Age} years old.");

List<Student> students = new List<Student>();
students.Add(student1);
students.Add(student2);

foreach (Student student in students)
{
    Console.WriteLine($"{student.Name} - {student.Career}");
}

Book book_1984 = new Book();
book_1984.Title = "1984";
book_1984.Author = "George Orwell";
book_1984.Pages = 328;

Book book_hobbit = new Book();
book_hobbit.Title = "The Hobbit";
book_hobbit.Author = "J.R.R. Tolkien";
book_hobbit.Pages = 310;

Book book_harryPotter = new Book();
book_harryPotter.Title = "Harry Potter and the Sorcerer's Stone";
book_harryPotter.Author = "J.K. Rowling";
book_harryPotter.Pages = 309;

List <Book> books = new List<Book>();
books.Add(book_1984);
books.Add(book_hobbit); 
books.Add(book_harryPotter);

foreach (Book book in books)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Pages: {book.Pages}");
}

// 03 - Constructors
Student student = new Student("Ana", 20, "Computer Science");
Console.WriteLine($"{student.Name} - {student.Career}");

Product product = new Product("PC", 900.00, 10);
Product product1 = new Product("Mouse", 10.00, 15);
Console.WriteLine($"{product.Name} - {product.Price}");
Console.WriteLine($"{product1.Name} - {product1.Price}");

// 04 - Methods and Behavior
Student student = new Student("Ana", 20);
student.PrintSummary();

int years = student.GetYearsToGraduate();
Console.WriteLine($"Years to graduate: {years}");

student.CelebrateBirthday(1);

BankAccount account = new BankAccount("Pablo", 1000.0);
account.Deposit(500.0);
account.ShowBalance();
account.Withdraw(200.0);
account.ShowBalance();

// 05 - Properties and Encapsulation 

Student student = new Student();
student.Name = "Ana";
student.Age = 20;

Console.WriteLine($"{student.Name} is {student.Age}");

// 06 - Static Members
Student student1 = new Student("Ana");
Student student2 = new Student("Luis");

Console.WriteLine(Student.TotalStudents);

Student.ShowMessage();

// 07 - Lists of Objects 

List<Student> students = new List<Student>();
students.Add(new Student("Ana", 20));
students.Add(new Student("Luis", 22));
students.Add(new Student("Carlos", 21));

foreach (Student student in students)
{
    if (student.Age >= 21)
    {
        Console.WriteLine($"Adult student: {student.Name}");
    }
}

List<Course> courses = new List<Course>();
courses.Add(new Course("Mathematics"));
courses.Add(new Course("Physics"));
courses.Add(new Course("Chemistry"));
foreach (Course course in courses)
{
    Console.WriteLine($"Course: {course.Name}");
}