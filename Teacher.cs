using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOOProgram
{
      public abstract class Teacher : Person
      {
            private ITeach TeachBehaviour;
            private int StaffID { get; set; }
            public override string GetOccupation()    
            {
                  return "Teacher";
            }

            public Teacher(int pStaffID, string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
            {

            }
            public override string Work()
            {
                  return TeachBehaviour.Teach();
            }
      }
}
