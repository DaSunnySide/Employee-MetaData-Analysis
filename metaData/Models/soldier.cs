using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace metaData.Models
{
    public class Soldier
    {
        [Required]
        public int soldierId { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [Required]
        public int ETS { get; set; }
        public int BASD { get; set; }
        public string POB { get; set; }
        public string maritalStatus { get; set; }
        List<Soldier> currentLeaders = new List<Soldier>();
        List<Soldier> currentSuboordinates = new List<Soldier>();
    }
}