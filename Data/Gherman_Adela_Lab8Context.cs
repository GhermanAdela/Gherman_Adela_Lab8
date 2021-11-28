using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gherman_Adela_Lab8.Models;

namespace Gherman_Adela_Lab8.Data
{
    public class Gherman_Adela_Lab8Context : DbContext
    {
        public Gherman_Adela_Lab8Context (DbContextOptions<Gherman_Adela_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Gherman_Adela_Lab8.Models.Book> Book { get; set; }

        public DbSet<Gherman_Adela_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
