using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEF
{
   public class Classes
    {
        //class_id, class_name, teacher_id
        public int id { get; set; }
        public string class_name { get; set; }
        public int teacher_id { get; set; }

        public virtual Teachers Teacher { get; set; }

        public int TeacherId { get; set; }

        // public virtual ICollection<Student> Students { get; set; }
    }
}
