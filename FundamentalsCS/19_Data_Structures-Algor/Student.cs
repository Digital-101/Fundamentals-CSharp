using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._19_Data_Structures_Algor
{
    //Write a program printing all courses and the students, who have joined 
    //them, ordered by last name, and then by first name(if the last names match).
    public class Student : IComparable<Student>
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int CompareTo(Student student)
        {
            int result = lastName.CompareTo(student.lastName);
            if (result == 0)
            {
                result = firstName.CompareTo(student.firstName);
            }
            return result;
        }

        public override string ToString()
        {
            return firstName + " " + lastName; ;
        }

        static void ReadFile()
        {
            // Read the file and build the hash-table of courses
            Dictionary<string, List<Student>> courses = new Dictionary<string, List<Student>>();
            StreamReader reader = new StreamReader("Students.txt");
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string firstName = entry[0].Trim();
                    string lastName = entry[1].Trim();
                    string course = entry[2].Trim();
                    List<Student> students;
                    if (!courses.TryGetValue(course, out students))
                    {
                        //New course -> create a list of students for it
                        students = new List<Student>();
                        courses.Add(course, students);
                    }
                    Student student = new Student(firstName, lastName);
                    students.Add(student);
                }
            }

            //Print the courses and their students
            foreach (string course in courses.Keys)
            {
                Console.WriteLine("Course "+course+":");
                List<Student> students = courses[course];
                students.Sort();
                foreach (Student student in students)
                {
                    Console.WriteLine("\t{0}", student);
                }
            }

            //Output:
                    //Course C#:
                    // Chris Jones
                    // Peter Jones
                    // Mia Smith
                    // Mia Wilson
            //Course PHP:
                    // Mia Smith
            //Course Java:
                    // Chris Jones
                    // Sophia Wilson
        }
       
    }
}
