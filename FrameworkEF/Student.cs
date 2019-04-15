using System.Collections.Generic;

namespace FrameworkEF
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }

        //public virtual Address Address { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }

    }

}

