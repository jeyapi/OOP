
// 02 - Variables, Data Types, Input and Constants

Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("How many tasks do you want to complete today? ");
int taskGoal = int.Parse(Console.ReadLine());

Console.Write("How many hours do you have available? ");
double availableHours = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Your goal is {taskGoal} tasks.");
Console.WriteLine($"You have {availableHours} hours available. ");

Console.Write("What is your age ? ");
int studentage = int.Parse(Console.ReadLine());

Console.Write("What is the name of your course ? ");
string coursename = Console.ReadLine();

Console.Write("Do you know C# ? (true/false) ");
bool knowscsharp = bool.Parse(Console.ReadLine());

const int maxtasksperday = 10;

Console.WriteLine();
Console.WriteLine($"Your age is {studentage}.");
Console.WriteLine($"Your course name is {coursename}.");
Console.WriteLine($"Do you know C# ? {knowscsharp}. ");
Console.WriteLine($"The maximum number of tasks allowed per day is {maxtasksperday}. ");

// 03 - Conditions: if, else and switch

Console.Write("How many tasks have you completed today? ");
int completedTasks = int.Parse(Console.ReadLine());

if (completedTasks == 0)
{
    Console.WriteLine("Time to get started!");
}
else if (completedTasks < 3)
{
    Console.WriteLine("Good start. Keep going!");
}
else
{
    Console.WriteLine("Great progress!");
}

Console.WriteLine();
Console.WriteLine("1. Add task");
Console.WriteLine("2. View tasks");
Console.WriteLine("3. Complete task");
Console.WriteLine("4. Remove task");
Console.WriteLine("0. Exit");


Console.Write("Choose an option: ");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("Adding a task...");
        break;
    
    case 2:
        Console.WriteLine("Showing tasks...");
        break;
    
    case 3:
        Console.WriteLine("Completing a task...");
        break;
    
    case 4:
        Console.WriteLine("Removing a task...");
        break;

    case 0:
        Console.WriteLine("Goodbye!");
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}

// 04 - Loops and lists

List<string> tasks = new List<string>();
const int MaxTasks = 10;
tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");

Console.WriteLine($"Number of tasks: {tasks.Count}");

foreach (string task in tasks)
{
    Console.WriteLine(task);
}

for (int i = 0; i < tasks.Count; i++)
{
    Console.WriteLine($"{i + 1}. {tasks[i]}");
}

Console.Write("Enter a new task: ");
string newTask = Console.ReadLine();

tasks.Add(newTask);

Console.WriteLine("Task added.");

bool running = true;

while (running)
{
    ShowMenu();
    int menuOption = int.Parse(Console.ReadLine());

    switch (menuOption)
    {
        case 1:
            AddTask(tasks);
            break;
        
        case 2:
            ShowTasks(tasks);
            break;
        
        case 3:
            RemoveTask(tasks);
            break;
        
        case 4: 
            Showtaskcount(tasks);
            break;

        case 0:
            running = false;
            break;
        
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}


// 05 - Methods and Refactoring

void ShowTitle()
{
    Console.WriteLine();
    Console.WriteLine("Student Task Manager");
    Console.WriteLine("====================");
}

ShowTitle();

void ShowMessage(string message)
{
    Console.WriteLine($"[INFO] {message}");
}

ShowMessage("Application started.");
ShowMessage("Task added.");

int GetTaskCount(List<string> tasks)
{
    return tasks.Count;
}

int count = GetTaskCount(tasks);
Console.WriteLine($"You currently have {count} tasks.");

void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("4. Show task count");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
}

void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i+1}. {tasks[i]}");
    }
}

void AddTask(List<string> tasks)
{
    if (tasks.Count >= MaxTasks)
    {
        Console.WriteLine("Maximum number of tasks reached.");
    }
    else
    {
        Console.Write("Enter task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        ShowMessage("Task added.");
    }
}

void RemoveTask(List<string> tasks)
{
    ShowTasks(tasks);
    Console.Write("Task to remove: ");
    int taskIndex = int.Parse(Console.ReadLine()) - 1;
    tasks.RemoveAt(taskIndex);
    ShowMessage("Task removed.");
}

void Showtaskcount(List<string> tasks)
{
    if (GetTaskCount(tasks)<=1)
    {
        Console.WriteLine($"You currently have {GetTaskCount(tasks)} task.");
    }
    else
    {
        Console.WriteLine($"You currently have {GetTaskCount(tasks)} tasks.");
    }
    Console.WriteLine($"Maximum allowed: {MaxTasks}");
    Console.WriteLine($"Remaining capacity: {MaxTasks - GetTaskCount(tasks)}");
}



// 06 - Enums, Constants and Final Integration

TaskPriority priority = TaskPriority.High;
Console.WriteLine(priority);

switch (priority)
{
    case TaskPriority.Low:
        Console.WriteLine("This task can wait.");
        break;
    
    case TaskPriority.Medium:
        Console.WriteLine("Try to finish this task today.");
        break;
    
    case TaskPriority.High:
        Console.WriteLine("Prioritize this task.");
        break;
}    


enum TaskPriority
{
    Low,
    Medium,
    High
}


