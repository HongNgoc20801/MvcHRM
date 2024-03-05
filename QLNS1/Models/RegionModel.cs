using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS1.Models
{
    public class RegionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegionID { get; set; }

        public string RegionName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; } // Represents SQL datetime
        public string UserCreate { get; set; }
        public DateTime DateLastUpdate { get; set; } // Represents SQL datetime
        public string UserLastUpdate { get; set; }
    }
}
