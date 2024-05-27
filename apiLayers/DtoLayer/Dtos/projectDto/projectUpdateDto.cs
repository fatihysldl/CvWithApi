using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.projectDto
{
    public class projectUpdateDto
    {
        public int projectsId { get; set; }
        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(50, ErrorMessage = "please write less than 50 character")]
        public string projectsTitle { get; set; }
        [Required(ErrorMessage = "Please fill in the date field")]
        public string projectsDescription { get; set; }

        [StringLength(200, ErrorMessage = "please write less than 200 character")]
        public string projectsImage { get; set; }
    }
}
