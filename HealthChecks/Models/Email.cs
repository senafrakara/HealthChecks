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
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public int UserId { get; set; } //User tablosu db de user şeklinde geçmiyor!!!
       // public string _URL { get; set; }
        public ICollection<URL_EMAIL> URL_EMAIL_LIST { get; set; }

    }
}

