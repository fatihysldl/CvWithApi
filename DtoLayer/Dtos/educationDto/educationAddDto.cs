using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.educationDto
{
    public class educationAddDto
    {   
        public int educationId { get; set; }
    
        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(60, ErrorMessage = "please write less than 60 character")]
        public string educationSchool { get; set; }
        
        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(400, ErrorMessage = "please write less than 400 character")]
        public string educationAdress { get; set; }
        
        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(100, ErrorMessage = "please write less than 100 character")]
        public string educationDepartment { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        public string educationDescription { get; set; }
    }
}
