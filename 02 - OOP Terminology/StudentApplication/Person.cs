class Person
{
    private string name;
    private int age;

    public string Name
    {
        get {return name;}
        set { name = value;}
    }

    public int Age
    {
        get {return age;}
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

}