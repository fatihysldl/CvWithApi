using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class project
    {
        [Key]
        public int projectsId { get; set; }
        [StringLength(50)]
        public string projectsTitle { get; set; }
        public string projectsDescription { get; set; }
        [StringLength(200)]
        public string projectsImage { get; set; }
    }
}
