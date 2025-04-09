using System.Diagnostics;

public static class Program
{
    static List<Student> students = new();
    static List<Teacher> teachers = new();
    static List<Discipline> disciplines = new();

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool exit = false;

        while (!exit)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddTeacher();
                    break;
                case "3":
                    CreateDiscipline();
                    break;
                case "4":
                    AssignActivity();
                    break;
                case "5":
                    AssignStudentToDiscipline();
                    break;
                case "6":
                    exit = true;
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n1. Додати студента");
        Console.WriteLine("2. Додати викладача");
        Console.WriteLine("3. Створити дисципліну");
        Console.WriteLine("4. Призначити активність");
        Console.WriteLine("5. Додати студента до дисципліни");
        Console.WriteLine("6. Вийти");
        Console.Write("Ваш вибір: ");
    }

    static void AddStudent()
    {
        Console.Write("Ім'я студента: ");
        string name = Console.ReadLine();
        Console.Write("Курс (1-4): ");
        int course = int.Parse(Console.ReadLine());
        Console.Write("Чи є комп'ютер? (так/ні): ");
        bool hasComputer = Console.ReadLine().ToLower() == "так";

        students.Add(new Student(name, course, hasComputer));
        Console.WriteLine("Студент доданий!");
    }

    static void AddTeacher()
    {
        Console.Write("Ім'я викладача: ");
        string name = Console.ReadLine();
        teachers.Add(new Teacher(name));
        Console.WriteLine("Викладач доданий!");
    }

    static void CreateDiscipline()
    {
        Console.WriteLine("Оберіть дисципліну:");
        Console.WriteLine("1. Основи програмування\n2. ООП\n3. Алгоритми");
        string input = Console.ReadLine();
        DisciplineFactory factory = input switch
        {
            "1" => new ProgrammingBasicsFactory(),
            "2" => new OOPFactory(),
            "3" => new AlgorithmsFactory(),
            _ => null
        };

        if (factory != null)
        {
            var discipline = factory.CreateDiscipline();
            disciplines.Add(discipline);
            Console.WriteLine($"Створено дисципліну: {discipline.Name}");
        }
    }

    static void AssignActivity()
    {
        Console.WriteLine("Оберіть дисципліну:");
        for (int i = 0; i < disciplines.Count; i++)
            Console.WriteLine($"{i + 1}. {disciplines[i].Name}");

        int dIndex = int.Parse(Console.ReadLine()) - 1;
        var discipline = disciplines[dIndex];

        Console.WriteLine("Оберіть тип активності:");
        foreach (var type in Enum.GetValues(typeof(ActivityType)))
            Console.WriteLine($"{(int)type}. {type}");

        ActivityType activityType = (ActivityType)int.Parse(Console.ReadLine());

        Console.WriteLine("Оберіть викладача:");
        for (int i = 0; i < teachers.Count; i++)
            Console.WriteLine($"{i + 1}. {teachers[i].Name}");

        int tIndex = int.Parse(Console.ReadLine()) - 1;
        var teacher = teachers[tIndex];

        discipline.AddActivity(new Activity(activityType, teacher));
        Console.WriteLine("Активність додано!");
    }

    static void AssignStudentToDiscipline()
    {
        Console.WriteLine("Оберіть студента:");
        for (int i = 0; i < students.Count; i++)
            Console.WriteLine($"{i + 1}. {students[i].Name}");

        int sIndex = int.Parse(Console.ReadLine()) - 1;
        var student = students[sIndex];

        Console.WriteLine("Оберіть дисципліну:");
        for (int i = 0; i < disciplines.Count; i++)
            Console.WriteLine($"{i + 1}. {disciplines[i].Name}");

        int dIndex = int.Parse(Console.ReadLine()) - 1;
        var discipline = disciplines[dIndex];

        discipline.AddStudent(student);
    }
}