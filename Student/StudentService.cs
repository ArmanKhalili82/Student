namespace Student;

public class StudentService
{
    public static void AddStudent(string studentname, string studentfamily, int studentscore)
    {
        List<Students> students = new List<Students>();
        var st = students.Where(s => s.Name == studentname && s.Family == studentfamily && s.Score == studentscore).FirstOrDefault();
        if (st == null)
        {
            students.Add(new Students() { Name = studentname, Family = studentfamily, Score = studentscore });
            foreach (var i in students)
            {
                Console.WriteLine("Name:" + i.Name + " " + "Family:" + i.Family + " " + "Score:" + i.Score);
            }
        }
    }

    public static void GetAllStudent(string name)
    {
        List<Students> students = new List<Students>();
        var getstudents = students.OrderBy(s => s.Name == name).ToList();

        foreach (var i in getstudents)
        {
            Console.WriteLine("Name: " + i.Name + " Family: " + i.Family + " Score: " + i.Score);
        }
    }

    public static void DeleteStudent(string studentname)
    {
        List<Students> students = new List<Students>();
        var selecteditem = students.Where(s => s.Name == studentname).FirstOrDefault();
        if (selecteditem == null)
        {
            Console.WriteLine("Not Found!");
        }

        else if (selecteditem != null)
        {
            students.Remove(selecteditem);
        }
    }

    public static void EditStudent(string studentname)
    {
        List<Students> students = new List<Students>();
        var studentedit = students.Where(s => s.Name == studentname).FirstOrDefault();
        if (studentname == null)
        {
            Console.WriteLine("Not Found");
        }

        else
        {
            Console.WriteLine("Enter Your Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Your Family:");
            var family = Console.ReadLine();
            Console.WriteLine("Enter Your Score:");
            int score = int.Parse(Console.ReadLine());
            var st = new Students();
            st.Name = name;
            st.Family = family;
            st.Score = score;
        }
        Console.WriteLine("Student Edited");
    }
}
