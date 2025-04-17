﻿namespace _029_student
{
    class Student
    {
        private string name;
        private int age;
        private string major;

        // Setter, Getter 불필요

        // 생성자 : 리턴값이 없고 이름이 클래스와 같은 메소드

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("이름 : {0}\n나이 : {1}\n전공 : {2}", name, age, major);
            Console.WriteLine($"이름 : {name}\n나이 : {age}\n전공 : {major}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Random r= new Random();
            Student s = new Student("엄예준",21,"의료it공학");
            s.DisplayInfo();
        }
    }
}
