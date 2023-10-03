using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class about
    {
        [Key]
        public int aboutId { get; set; }

        [StringLength(50)]
        public string aboutHeader { get; set; }

        [StringLength(150)]
        public string aboutSubTitle { get; set; }
        public string aboutDescription { get; set; }

        [StringLength(400)]
        public string aboutSocialMedia { get; set; }
    }
}
