using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthChecks.Models
{
    public class Email
    {
        [Key]
        [Column(TypeName = "varchar(35)")]
        public string _EmailAddress { get; set; }
        public int UserId { get; set; } //User tablosu db de user şeklinde geçmiyor!!!
        public string URL { get; set; }
        public List<URL> URL_List { get; set; }

    }
}
