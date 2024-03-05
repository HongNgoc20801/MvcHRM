using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS1.Models
{
    public class NationModel

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NationID { get; set; }

        public string NationName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; } // Represents SQL datetime
        public string UserCreate { get; set; }
        public DateTime DateLastUpdate { get; set; } // Represents SQL datetime
        public string UserLastUpdate { get; set; }
    }
}
