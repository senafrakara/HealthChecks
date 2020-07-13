using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace HealthChecks.Models
{
    public class URL_EMAIL
    {

        public  string URL { get; set; } //fk and pk 

        public string Email { get; set; } //fk and pk

        public Url Url { get; set; }

        public Email _Email { get; set; }

    }
}
