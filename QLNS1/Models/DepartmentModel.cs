using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS1.Models
{
    public class DepartmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; } // Represents SQL datetime
        public string UserCreate { get; set; }
        public DateTime DateLastUpdate { get; set; } // Represents SQL datetime
        public string UserLastUpdate { get; set; }
    }
}
