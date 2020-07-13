using System;
using System.Collections.Generic;
using System.Text;
using HealthChecks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthChecks.Data
{
    public class ApplicationDbContext : IdentityDbContext<User> //by the way, the User model which isnot created by application side, can be used for all User operations. 
        //the User model is inherited from IdentityUser
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
    }
}
