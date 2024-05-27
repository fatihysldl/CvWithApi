using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.experienceDto
{
    public class experienceUpdateDto
    {
        public int experienceId { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        public string experienceDates { get; set; }

        [Required(ErrorMessage = "Please fill in the field of experience position")]
        [StringLength(50, ErrorMessage = "please write less than 50 character")]
        public string experiencePosition { get; set; }

        [Required(ErrorMessage = "Please fill in the field of experience adress")]
        [StringLength(400, ErrorMessage = "please write less than 400 character")]
        public string experienceAdress { get; set; }

        [Required(ErrorMessage = "Please fill in the field of experience description")]
        public string experienceDescription { get; set; }
    }
}

