using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace YoucodeReserv.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Etudiants> Etudiants { get; set; }
        public DbSet<TypeReservation> TypeReservations { get; set; }
        public DbSet<Resrvation> Resrvations { get; set; }
    }

}
