using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AuthDemo.Models
{

    public class LO
    {

        [Key]
        public int ID { get; set; }
       [Required]
        public String LOID { get; set; }
        public int Lmarks { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Module")]
        public string ModuleId { get; set; }
        public Module Module { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }
        public string p3 { get; set; }
        public string p4 { get; set; }
        public string p5 { get; set; }
        public string p6 { get; set; }
        public string p7 { get; set; }
        public string p8 { get; set; }
        public string p9 { get; set; }
        public string p10 { get; set; }
        public string p11 { get; set; }

        public string p12 { get; set; }


        
    }

}

