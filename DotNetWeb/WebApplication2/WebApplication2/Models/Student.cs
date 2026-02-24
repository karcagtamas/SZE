using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Student
    {
        [DisplayName("Id")]
        public long Id { get; set; }

        [DisplayName("Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "The name is required")]
        public string Name { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        [Range(18, 120, ErrorMessage = "The age has to be between 18 and 120")]
        public int Age { get; set; }

        [DisplayName("Birth Date")]
        [UIHint("BirthDate")]
        public DateTime BirthDate { get; set; }
    }
}
