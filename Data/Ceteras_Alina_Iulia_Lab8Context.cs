using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ceteras_Alina_Iulia_Lab8.Models;

namespace Ceteras_Alina_Iulia_Lab8.Data
{
    public class Ceteras_Alina_Iulia_Lab8Context : DbContext
    {
        public Ceteras_Alina_Iulia_Lab8Context (DbContextOptions<Ceteras_Alina_Iulia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ceteras_Alina_Iulia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ceteras_Alina_Iulia_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ceteras_Alina_Iulia_Lab8.Models.Category> Category { get; set; }
    }
}
