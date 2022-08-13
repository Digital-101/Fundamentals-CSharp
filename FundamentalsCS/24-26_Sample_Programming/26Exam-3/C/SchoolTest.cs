using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._26Exam_3.C
{
    class SchoolTest
    {
        static void ScTes()
        {
            //Create a few students
            Student studentPeter = new Student("Peter", "Lee");
            Student studentDigil = new Student("Digital", "One");
            Student studentMaria= new Student("Maria", "Steward");
            Student studentGeorge = new Student("George", "Redwood");

            //Create a group and add a few students to it
            Group groupEnglish = new Group("English Course");
            groupEnglish.Students.Add(studentPeter);
            groupEnglish.Students.Add(studentDigil);
            groupEnglish.Students.Add(studentMaria);
            groupEnglish.Students.Add(studentGeorge);

            //Another group
            Group groupJava = new Group("Java Programming course");
            groupJava.Students.Add(studentMaria);
            groupJava.Students.Add(studentPeter);
            //Create Teacher and assign few groups
            Teacher teacherNatasha = new Teacher("Natasha", "Walters");
            teacherNatasha.Groups.Add(groupEnglish);
            teacherNatasha.Groups.Add(groupJava);
            groupEnglish.Teacher = teacherNatasha;
            groupJava.Teacher = teacherNatasha;

            //Another Teacher
            Teacher teacherHarry = new Teacher("Harry", "Potter");
            Group groupHTML = new Group("HTML Course");
            groupHTML.Students.Add(studentDigil);
            groupHTML.Students.Add(studentMaria);
            groupHTML.Teacher = teacherHarry;
            teacherHarry.Groups.Add(groupHTML);

            //Create school with few students, groups and teachers
            School school = new School("Hillgrove Secondary School");
            school.Students.Add(studentPeter);
            school.Students.Add(studentMaria);
            school.Students.Add(studentGeorge);
            school.Groups.Add(groupEnglish);
            school.Groups.Add(groupHTML);
            school.Groups.Add(groupJava);
            school.Teachers.Add(teacherHarry);
            school.Teachers.Add(teacherNatasha);

            //Modify some of the groups, student and teachers
            groupEnglish.Name = "Advanced English";
            groupEnglish.Students.RemoveAt(0);
            studentPeter.LastName = "White";
            teacherNatasha.LastName = "Silver";

            //Print the school
            Console.WriteLine(school);
        }
    }
}
