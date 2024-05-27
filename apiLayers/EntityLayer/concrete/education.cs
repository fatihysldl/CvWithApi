using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class education
    {
        [Key]
        public int educationId { get; set; }

        /*Education*/

        [StringLength(60)]
        public string educationSchool { get; set; }

        [StringLength(400)]
        public string educationAdress { get; set; }

        [StringLength(100)]
        public string educationDepartment { get; set; }
        public string educationDescription { get; set; }
    }
}
