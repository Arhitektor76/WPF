using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpWeek2
{
    class StudentList
    {
        public List<Student> Stud_List;
        public StudentList()
        {
            Stud_List = new List<Student>();
        }

        public void Write(BinaryWriter bw)
        {
            foreach(Student st in Stud_List)
            {
                st.Write(bw);
            }
        }
        public static StudentList Read(BinaryReader br)
        {
            StudentList sl = new StudentList();
            while (br.PeekChar() > -1)
            {
                sl.Stud_List.Add(Student.Read(br));
            }
            return sl;
        }
    }
}
