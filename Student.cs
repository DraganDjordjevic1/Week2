using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOOProgram
{
      class Student : Person
      {
            public string StudentID { get; set; }

            public Student(string pFname, string pLname, string pGender, string pStudentID) : base(pFname, pLname, pGender)
            {

            }
            public override string Work()
            {
                  return "Study, Drink Coffee, Party, Sleep, Repeat";
            }

      }
}
