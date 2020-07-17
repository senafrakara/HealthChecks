using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace HealthChecks.Models
{
    public class URL_EMAIL
    {

        public string Url { get; set; } //fk and pk 
        public URL URL { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } //fk and pk
        public Email Email { get; set; }

    }
}



