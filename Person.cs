using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOOProgram
{
      public abstract class Person
      {
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string Gender { get; set; }

            public string GetGender()
            {
                  return Gender;
            }

            public virtual string GetOccupation()
            {
                  return "Unemployed";
            }

            public abstract string Work();

            public Person(string pFname, string pLname, string pGender)
            {
                  if (Gender == "F" || Gender == "M")
                  {

                  }
                  else
                  {
                        Console.WriteLine("Invalid Gender Passed to Person Constructor");
                  }
            }

            public Person(string pGender)
            {
                  if (Gender == "F")
                  {
                        Fname = "Jane";
                        Lname = "Doe";
                  }
                  if (Gender == "M")
                  {
                        Fname = "John";
                        Lname = "Doe";
                  }
                  else
                  {
                        Console.WriteLine("Invalid Gender Passed to Person Constructor");
                  }
            }

      }
}
