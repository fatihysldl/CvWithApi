using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class contact
    {
        [Key]
        public int contactId { get; set; }
        [StringLength(20)]
        public string name { get; set; }

        [StringLength(10)]
        public string surname { get; set; }

        [StringLength(200)]
        public string mail { get; set; }


        [StringLength(250)]
        public string adress { get; set; }   
        public int phoneNumber{ get; set; }
    }
}
