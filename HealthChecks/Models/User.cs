using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthChecks.Models
{
    public class User : IdentityUser
    {
        
        public int Id { get; set; } //how to override a key
        public List<URL> URL_List{ get; set; }

    }
}
