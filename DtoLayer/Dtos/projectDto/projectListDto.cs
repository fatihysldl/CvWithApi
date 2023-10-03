using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.projectDto
{
    public class projectListDto
    {
        public int projectsId { get; set; }
        public string projectsTitle { get; set; }
        public string projectsDescription { get; set; }
        public string projectsImage { get; set; }
    }
}
