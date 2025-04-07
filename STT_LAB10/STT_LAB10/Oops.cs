// Task 4: Object-Oriented Programming
class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int Marks { get; set; }

    public Student(string name, int id, int marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        if (Marks >= 75) return "B";
        if (Marks >= 60) return "C";
        return "D";
    }

    public virtual void Display()
    {
        Console.WriteLine($"Student: {Name}, ID: {ID}, Marks: {Marks}, Grade: {GetGrade()}");
    }
}

class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, int id, int marks, string hostel) : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostel;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Hostel: {Hostel_Name_IITGN}");
    }

    static void Main3()
    {
        StudentIITGN student = new StudentIITGN("Chirag Patel",22110183, 95, "Emieat");
        student.Display();
    }
}