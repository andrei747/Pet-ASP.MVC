using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class PetViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Race { get; set; }
        [Required]
        [Range(0,30)]
        public double Age { get; set; }





    }
}
