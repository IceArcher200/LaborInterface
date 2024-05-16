using Labor.MyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInterface.Classes
{
    internal class ReaderFullName : User
    {
        string fullName;
        public ReaderFullName(string lastName, string firstName, string middleName)
        {
            fullName = lastName + " " + firstName + " " + middleName;
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
    }
}
