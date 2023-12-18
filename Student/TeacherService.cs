namespace Student;

public class TeacherService
{
    public static void AddTeacher(string teachertname, string teacherfamily, string teachercourse)
    {
        List<Teacher> allteachersinfo = new List<Teacher>();
        List<Lesson> lessons = new List<Lesson>();
        var teacher = allteachersinfo.Where(t => t.TeacherName == teachertname && t.TeacherFamily == teacherfamily).FirstOrDefault();
        var lesson = lessons.Where(t => t.Course == teachercourse).FirstOrDefault();
        if (teacher == null && lesson == null)
        {
            allteachersinfo.Add(new Teacher() { TeacherName = teachertname, TeacherFamily = teacherfamily });
            lessons.Add(new Lesson() { Course = teachercourse });
            foreach (var i in allteachersinfo)
            {
                Console.WriteLine("Name:" + i.TeacherName + " " + "Family:" + i.TeacherFamily);
            }
            foreach (var i in lessons)
            {
                Console.WriteLine("Lesson:" + i.Course);
            }
        }
    }

    public static void GetAllTeacher(string name, string lesson)
    {
        List<Teacher> allteachersinfo = new List<Teacher>();
        List<Lesson> lessons = new List<Lesson>();
        var getteacher = allteachersinfo.OrderBy(s => s.TeacherName == name).ToList();
        var getlesson = lessons.OrderBy(l => l.Course == lesson).ToList();

        foreach (var i in getteacher)
        {
            Console.WriteLine("Name: " + i.TeacherName + " Family: " + i.TeacherFamily);
        }

        foreach (var i in getlesson)
        {
            Console.WriteLine("Score: " + i.Course);
        }
    }

    public static void DeleteTeacher(string teachername)
    {
        List<Teacher> allteachersinfo = new List<Teacher>();
        var selecteditem = allteachersinfo.Where(s => s.TeacherName == teachername).FirstOrDefault();
        if (selecteditem == null)
        {
            Console.WriteLine("Not Found!");
        }

        else if (selecteditem != null)
        {
            allteachersinfo.Remove(selecteditem);
        }
    }

    public static void EditTeacher(string teachername)
    {
        List<Teacher> allteachersinfo = new List<Teacher>();
        List<Lesson> lessons = new List<Lesson>();
        var teacheredit = allteachersinfo.Where(t => t.TeacherName == teachername).FirstOrDefault();
        if (teacheredit == null)
        {
            Console.WriteLine("Not Found");
        }
        else
        {
            Console.WriteLine("Enter Your Teacher Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Family:");
            var family = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Lesson:");
            var course = Console.ReadLine();
            var te = new Teacher();
            var le = new Lesson();
            te.TeacherName = name;
            te.TeacherFamily = family;
            le.Course = course;
        }
        Console.WriteLine("Teacher Edited");
    }
}