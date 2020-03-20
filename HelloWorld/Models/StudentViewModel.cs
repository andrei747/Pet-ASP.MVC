using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class StudentViewModel
    {
        public int id { get; set; }
       // [DisplayName("sdsd")]
        [MinLength(2, ErrorMessage = "name is to short")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsnewlyEnrolled { get; set; }

        public DateTime DateOfBirth { get; set; }




    }
}
