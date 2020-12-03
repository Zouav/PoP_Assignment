using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_Assignment_BORDAS_Alexandre
{
    class Person
    {
        //VARIABLES

        public string firstName;
        public string lastName;


        //CONSTRUCTOR

        public Person( string fName, string lName)
        {
            if (fName.All(Char.IsLetter) == true)
            {
                this.firstName = fName;
            }
            else
            {
                Console.WriteLine("ERROR : First name of person cannot contain digits");
            }

            if (lName.All(Char.IsLetter) == true)
            {
                this.lastName = lName;
            }
            else
            {
                Console.WriteLine("ERROR : Last name of person cannot contain digits");
            }
        }
    }
}
