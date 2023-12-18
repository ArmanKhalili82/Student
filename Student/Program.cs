using Student;

while (true)
{
    List<Students> students = new List<Students>();
    List<Teacher> allteachersinfo = new List<Teacher>();
    List<Lesson> lessons = new List<Lesson>();

    Console.WriteLine("Enter Your Command:");
    var command = Console.ReadLine();

    if (command == "Add")
    {
        Console.WriteLine("Add Teacher Or Student:");
        var select = Console.ReadLine();

        if (select == "Student")
        {
            Console.WriteLine("Enter Your Student Name:");
            var studentname = Console.ReadLine();
            Console.WriteLine("Enter Your Student Family:");
            var studentfamily = Console.ReadLine();
            Console.WriteLine("Enter Your Student Score:");
            int studentscore = int.Parse(Console.ReadLine());
            StudentService.AddStudent(studentname, studentfamily, studentscore);
        }

        else if (select == "Teacher")
        {
            Console.WriteLine("Enter Your Teacher Name:");
            var teachertname = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Family:");
            var teacherfamily = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Course:");
            var teachercourse = Console.ReadLine();
            TeacherService.AddTeacher(teachertname, teacherfamily, teachercourse);
            }
        }
    

    else if (command == "GetAll")
    {
        Console.WriteLine("Get All Teacher Or Student:");
        var select = Console.ReadLine();

        if (select == "Student")
        {
            Console.WriteLine("Enter Your Student Name:");
            var name = Console.ReadLine();
            StudentService.GetAllStudent(name);
        }

        else if (select == "Teacher")
        {
            Console.WriteLine("Enter Your Teacher Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Lesson");
            var lesson = Console.ReadLine();
            TeacherService.GetAllTeacher(name, lesson);
        }
    }

    else if (command == "Delete")
    {
        Console.WriteLine("Delete Teacher Or Student:");
        var select = Console.ReadLine();

        if (select == "Student")
        {
            Console.WriteLine("Enter Your Student Name:");
            var studentname = Console.ReadLine();
            StudentService.DeleteStudent(studentname);
        }

        else if (select == "Teacher")
        {
            Console.WriteLine("Enter Your Teacher Name:");
            var teachername = Console.ReadLine();
            TeacherService.DeleteTeacher(teachername);
        }

    else if (command == "Edit")
        {
            {
                Console.WriteLine("Edit Student Or Teacher");
                var editeditems = Console.ReadLine();

                if (editeditems == "Student")
                {
                    Console.WriteLine("Enter Your Student Name:");
                    var studentname = Console.ReadLine();
                    StudentService.EditStudent(studentname);
                }

                else if (editeditems == "Teacher")
                {
                    Console.WriteLine("Enter Your Teacher Name:");
                    var teachername = Console.ReadLine();
                    TeacherService.EditTeacher(teachername);
                }
            }
        }
    }
        
}