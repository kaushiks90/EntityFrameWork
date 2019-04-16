using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEF
{
   public class Address
    {     
        //[ForeignKey("Student")]
        public int AddressId { get; set; }
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }   
        
        public virtual Student Student { get; set; }
       
    }
}
