using System.Diagnostics;
using System.Text;
using Labaratorna_2;

class Program
{
   
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;


        Console.WriteLine("Вітаємо в системі моделювання дисциплін університету!");

            Console.Write("Введіть ім'я викладача: ");
            string lecturerName = Console.ReadLine();
            Lecturer lecturer = new Lecturer(lecturerName);

            Console.Write("Введіть курс групи: ");
            int course = int.Parse(Console.ReadLine());
            StudentGroup group = new StudentGroup(course);

            bool addingStudents = true;
            while (addingStudents)
            {
                Console.Write("Введіть прізвище студента (або 'стоп' для завершення): ");
                string studentName = Console.ReadLine();
                if (studentName.ToLower() == "стоп") break;

                Console.Write("Чи має студент комп'ютер? (так/ні): ");
                bool hasComputer = Console.ReadLine().ToLower() == "так";

                group.AddStudent(new Student(studentName, hasComputer));
            }

            Console.WriteLine("Доступні дисципліни:");
            Console.WriteLine("1. Основи Програмування");
            Console.WriteLine("2. ООП");

            Console.Write("Виберіть дисципліну (1 або 2): ");
            int disciplineChoice = int.Parse(Console.ReadLine());
            Discipline selectedDiscipline = disciplineChoice == 1 ? new ProgrammingFundamentals() : new ObjectOrientedProgramming();

            selectedDiscipline.AddLecturer(lecturer);

            if (group.CanStudyDiscipline(selectedDiscipline))
            {
                Console.WriteLine("Група може вивчати цю дисципліну!");
            }
            else
            {
                Console.WriteLine("Група не може вивчати цю дисципліну.");
            }

            Console.WriteLine("Програма завершена!");
        }
    }



    


