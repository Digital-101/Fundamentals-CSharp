using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._26Exam_3.C
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Group> Groups { get; set; }

        public Teacher(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Groups = new List<Group>();
        }

        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public override string ToString()
        {
            StringBuilder teacherAsString = new StringBuilder();
            teacherAsString.AppendLine("Teacher Name: " + this.Name);
            teacherAsString.Append("Groups of this teacher: " + string.Join(", ", this.Groups.Select(g => g.Name)));

            return teacherAsString.ToString(); 
        }
    }
}
