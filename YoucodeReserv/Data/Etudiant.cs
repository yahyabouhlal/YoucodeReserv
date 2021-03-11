using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoucodeReserv.Data
{
    public class Etudiants : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProMotion { get; set; }
        public int RestCount { get; set; }
    }
}
