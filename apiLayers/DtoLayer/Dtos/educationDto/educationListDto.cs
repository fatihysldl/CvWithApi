using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.educationDto
{
    public class educationListDto
    {
        public int educationId { get; set; }
        public string educationSchool { get; set; }
        public string educationAdress { get; set; }
        public string educationDepartment { get; set; }
        public string educationDescription { get; set; }
    }
}
