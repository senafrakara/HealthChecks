using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthChecks.Models
{
    public class URL
    {
        [Key]
        [Column(TypeName ="varchar(150)")]
        public string _URL { get; set; }
        [Key]
        public int UserId { get; set; } //it indexed with Id which is pk of User tbl automatically
        public List<Email> Email_List { get; set; }
    }
}
