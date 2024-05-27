using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.contactDto
{
    public class contactAddDto
    {
        public int contactId { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(20, ErrorMessage = "please write less than 50 character")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(10, ErrorMessage = "please write less than 10 character")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(200, ErrorMessage = "please write less than 200 character")]
        public string mail { get; set; }


        [Required(ErrorMessage = "Please fill in the date field")]
        [StringLength(250, ErrorMessage = "please write less than 250 character")]
        public string adress { get; set; }
        public int phoneNumber { get; set; }
    }
}
