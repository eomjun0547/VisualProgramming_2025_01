namespace _031_Student2
{
    internal class Program
    {
        class Student
        {
            private string name; int age; string major;

            public Student(string name, int age, string major)
            {
                this.name = name;
                this.age = age;
                this.major = major;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"이름 : {name}\n나이 : {age}\n전공 : {major}");
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("엄예준", 21, "의료it공학");
            s.DisplayInfo();
        }
    }
}
