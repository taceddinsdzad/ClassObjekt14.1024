namespace CLasObject
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student("Taceddin", "Esedzade", "BP217", 65);
            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;


        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = Point >= 65;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Surname:{Surname} Group:{Group} Point:{Point} Is Graduated:{IsGraduated}");
        }
        public void CheckGraduation()
        {
            if (IsGraduated)
            {
                Console.WriteLine($"{Name} :Mezun olub");
            }
            else
            {
                Console.WriteLine($"{Name} Mezun olmayib.");
            }
        }
        public void GetDiplomDegree()
        {

            if (Point >= 65 && Point <= 80)
            {
                Console.WriteLine("adi diplom.");
            }
            else if (Point > 80 && Point <= 90)
            {
                Console.WriteLine("sheref diplomu.");
            }
            else if (Point > 90 && Point <= 100)
            {
                Console.WriteLine("yuksek sheref diplomu.");
            }
            else Console.WriteLine("mezun olmayib");
        }
    }


}


