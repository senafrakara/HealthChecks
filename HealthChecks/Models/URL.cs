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
        public string Url { get; set; }
        [Key]
        public int UserId { get; set; } //it indexed with Id which is pk of User tbl automatically
        public int Time { get; set; }

        public ICollection<URL_EMAIL> URL_EMAIL_LIST { get; set; }

        
    }
}

