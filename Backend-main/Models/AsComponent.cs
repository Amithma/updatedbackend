﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Models
{
    public class AsComponent
    {   
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AsID { get; set; }
        [Required]
        public string Ascomponent { get; set; }
        [Required]
        public string LOID { get; set; }

        [ForeignKey("POID")]
        public string POID { get; set; }
        public int Marks { get; set; }
        public string LD { get; set; }
        public string Type { get; set; }
        public int lid { get; set; }
        [ForeignKey("Module")]
        public string ModuleId { get; set; }
        public Module Module { get; set; }


    }
}
