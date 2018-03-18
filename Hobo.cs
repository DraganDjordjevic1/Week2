using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOOProgram
{
      class Hobo : Person
      {
            public Hobo(string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
            {

            }

            public Hobo(string pGender) : base(pGender)
            {

            }

            public override string Work()
            {
                  return "Find A Place To Sleep";

            }
      }
}



