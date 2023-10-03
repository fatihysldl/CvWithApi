using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.aboutDto
{
    public class aboutAddDto
    {
        public int aboutId { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(50, ErrorMessage = "please write less than 50 character")]
        public string aboutHeader { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(150, ErrorMessage = "please write less than 150 character")]
        public string aboutSubTitle { get; set; }
        public string aboutDescription { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(400, ErrorMessage = "please write less than 400 character")]
        public string aboutSocialMedia { get; set; }
    }
}
