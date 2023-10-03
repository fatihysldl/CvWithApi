using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.contactDto
{
    public class contactListDto
    {
        public int contactId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string adress { get; set; }
        public int phoneNumber { get; set; }
    }
}
