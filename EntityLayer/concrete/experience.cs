using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class experience
    {
        [Key]   
        public int experienceId { get; set; }
        public string experienceDates { get; set; }

        [StringLength(50)]
        public string experiencePosition { get; set; }

        [StringLength(400)]
        public string experienceAdress { get; set; }
        public string experienceDescription { get; set; }
    }
}
