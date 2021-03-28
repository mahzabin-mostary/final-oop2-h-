using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentcourse
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private string course;

        public Course cour
        {
            get { return cour; }
            set { cour = value; }
        }
        public Student()
        {
        }
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Cgpa: " + cgpa);
        }
        public void ShowDepartmentDetails()
        {
            ShowInfo();
            cour.ShowInfo();
        }
        public void addcourse()
        {
            if (Student < course = 5)
            {
                Console.WriteLine(" it is maximum size")
                else
                {
                    Console.WriteLine("invalid")
                }
                public void addstudent()
                {
                    if ( course< Student=30 )
                    {
                        Console.WriteLine(" it is maximum size")
                else
                        {
                            Console.WriteLine("invalid")
                }
                    }
    
    static void Main(string[] args)
    {
        Student s1 = new Student("Tanvir", "13245", 2.5f);
        Student s2 = new Student("Sabbir", "13246", 3.5f);
        Student s3 = new Student("Rahim", "13246", 3.5f);

       Course d1 = new Course("Computer Science", "CS");
        Course d2 = new Course("Electrical Engineering", "EEE");

        s1.cour = d1;
        d1.AddStudent(s1, s2, s3);

        s2.cour = d1;
        s3.cour= d2;
        d2.AddStudent(s3);
        s1.ShowDepartmentDetails();
        s3.ShowDepartmentDetails();
        Console.WriteLine("*********");
        d1.Name = "Computer Science and Engineering";
        d1.Id = "CSE";
        s2.ShowDepartmentDetails();
        Console.WriteLine("*********");
        d2.PrintStudents();
        s3.Name = "Abdur Rahim";
        d2.PrintStudents();


    }
}
