using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiMSAP.Models;

namespace apiMSAP.Data
{
    public class apiMSAPContext : DbContext
    {
        public apiMSAPContext (DbContextOptions<apiMSAPContext> options)
            : base(options)
        {
        }

        public DbSet<apiMSAP.Models.Post> Post { get; set; }
    }
}
