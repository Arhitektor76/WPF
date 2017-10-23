using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace WpWeek2
{
    class StudentList : IEnumerable, IEnumerator
    {
        public List<Student> Stud_List { get; set; }
        int position = -1;
        public StudentList()
        {
            Stud_List = new List<Student>();
        }

        public void Write(BinaryWriter bw)
        {
            foreach (Student st in Stud_List)
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

        public IEnumerator GetEnumerator()
        {
            return Stud_List.GetEnumerator();
        }
        public bool MoveNext()
        {
            position++;
            return (position < Stud_List.Count());
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return Stud_List[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
