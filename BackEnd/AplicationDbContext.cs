using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd
{
    public class AplicationDbContext: DbContext
    {
        //constructor
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
    }
}
