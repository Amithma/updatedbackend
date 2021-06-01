using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Models
{
    public class Module
    {   
        [Key]
        [Required]
        public String ModuleId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Credits { get; set; }
        [Required]
        public String type { get; set; }
        [Required]
        public String State { get; set; }

        public string s1 { get; set; }
        public string s2 { get; set; }
        public string s3 { get; set; }
        public string s4 { get; set; }
        public string s5 { get; set; }
        public string s6 { get; set; }
        public string s7 { get; set; }
        public string s8 { get; set; }
        public string s9 { get; set; }
        public string s10 { get; set; }
        public string s11 { get; set; }
        public string s12 { get; set; }

        public ICollection<LO> LOs { get; set; }

        public ICollection<AsComponent> AsComponents { get; set;}
    }
}
