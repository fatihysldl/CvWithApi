using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.aboutDto
{
    public class aboutListDto
    {
        public int aboutId { get; set; }
        public string aboutHeader { get; set; }
        public string aboutSubTitle { get; set; }
        public string aboutDescription { get; set; }
        public string aboutSocialMedia { get; set; }
    }
}
