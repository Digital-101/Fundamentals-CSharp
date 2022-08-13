using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._26Exam_3.C
{
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }

        public Group(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public override string ToString()
        {
            StringBuilder groupAsString = new StringBuilder();
            groupAsString.AppendLine("Group Name: " + this.Name);
            groupAsString.Append("Students in the group: " + string.Join(", ", this.Students.Select(s=>s.Name)));

            if (this.Teacher != null)
            {
                groupAsString.Append("\nGroup Teacher: " + this.Teacher.Name);
            }

            return groupAsString.ToString();
        }
    }
}
