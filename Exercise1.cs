using System;


public enum Department
{
    ComputerScience,
    ElectricalEngineering,
    MechanicalEngineering,
    CivilEngineering
}

public class Person
{
    private string name;

    public Person()
    {
        name = null;
    }

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    private string regNo;
    private int age;
    private Department program;

    public Student() : base()
    {
        regNo = null;
        age = 0;
        program = Department.ComputerScience; // Default program
    }

    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Department Program
    {
        get { return program; }
        set { program = value; }
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Registration Number: " + RegNo);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Program: " + Program);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Zohaib Siddique", "233517", 20, Department.ComputerScience);
        Student student2 = new Student("Shumail Majid", "233763", 21, Department.ElectricalEngineering);

        student1.DisplayStudentInfo();
        Console.WriteLine();
        student2.DisplayStudentInfo();
    }
}

