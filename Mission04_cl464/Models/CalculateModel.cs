using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_cl464.Models
{
    // Model establishing all the data types that will be used in the form
    // the validation requires the field to have values and to be an int within a range of 0-100
    public class CalculateModel
    {
        [Required]
        [Range(0,100)]
        public int assignment { get; set; }

        [Required]
        [Range(0, 100)]
        public int quiz { get; set; }

        [Required]
        [Range(0, 100)]
        public int project { get; set; }

        [Required]
        [Range(0, 100)]
        public int midterm { get; set; }

        [Required]
        [Range(0, 100)]
        public int final { get; set; }

        [Required]
        [Range(0, 100)]
        public int intex { get; set; }





    }
}
