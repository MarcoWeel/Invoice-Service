using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvoiceService.Models;

namespace InvoiceService.Data
{
    public class InvoiceServiceContext : DbContext
    {
        public InvoiceServiceContext (DbContextOptions<InvoiceServiceContext> options)
            : base(options)
        {
        }

        public DbSet<InvoiceService.Models.Invoice> Invoice { get; set; } = default!;
    }
}
