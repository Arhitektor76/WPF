using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpWeek2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Marital_status { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public bool Hi_education { get; set; }
        public bool PC_skills { get; set; }
        public bool Language_skills { get; set; }
        public bool Inform_technologies { get; set; }

        public void Write(BinaryWriter bw)
        {
            bw.Write(FirstName);
            bw.Write(LastName);
            bw.Write(Patronymic);
            bw.Write(Marital_status);
            bw.Write(Age);
            bw.Write(Address);
            bw.Write(Email);

            bw.Write(Hi_education);
            bw.Write(PC_skills);
            bw.Write(Language_skills);
            bw.Write(Inform_technologies);
        }
        public static Student Read(BinaryReader br)
        {
            Student st = new Student();
            st.FirstName = br.ReadString();
            st.LastName = br.ReadString();
            st.Patronymic = br.ReadString();
            st.Marital_status = br.ReadString();
            st.Age = br.ReadString();
            st.Address = br.ReadString();
            st.Email = br.ReadString();

            st.Hi_education = br.ReadBoolean();
            st.PC_skills = br.ReadBoolean();
            st.Language_skills = br.ReadBoolean();
            st.Inform_technologies = br.ReadBoolean();
            return st;
        }
    }
}
