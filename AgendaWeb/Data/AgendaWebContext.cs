using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgendaWeb.Models;

namespace AgendaWeb.Data
{
    public class AgendaWebContext : DbContext
    {
        public AgendaWebContext (DbContextOptions<AgendaWebContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaWeb.Models.Contato> Contato { get; set; }
    }
}
