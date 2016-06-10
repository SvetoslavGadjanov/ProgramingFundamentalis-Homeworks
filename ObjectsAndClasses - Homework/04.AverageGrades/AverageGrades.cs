using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AvarageGrade
    {
        get
        {
            return Grades.Average();
        }
    }

    public static Student ReadStudent()
    {
        var tokens = Console.ReadLine().Split(' ').ToList();
        string name = tokens[0];
        tokens.RemoveAt(0);
        var grades = tokens.Select(Double.Parse).ToList();
        Student st = new Student() { Name = name, Grades = grades };
        return st;
    }
    public override string ToString()
    {
        return String.Format("{0} -> {1:f2}", this.Name, this.AvarageGrade);
    }

}


class AverageGrades
{
    static void Main(string[] args)
    {
        int inputLines = Int32.Parse(Console.ReadLine());
        List<Student> allStudenst = new List<Student>();
         
        for (int i = 0; i < inputLines; i++)
        {
            Student currentStudent = Student.ReadStudent();
            allStudenst.Add(currentStudent);
        }



        var toPrint = allStudenst.Where(g => g.AvarageGrade >= 5.00).OrderBy(t => t.Name).ThenBy(s => -s.AvarageGrade).ToList();
        foreach (var student in toPrint)
        {
            Console.WriteLine(student);
        }

    }
}

