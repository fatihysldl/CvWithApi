using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class header
    {
        [Key]
        public int headerId { get; set; }

        [StringLength(60)]
        public string headerDescription1 { get; set; }

        [StringLength(60)]
        public string headerDescription2 { get; set; }
        public string image { get; set; }
    }
}
