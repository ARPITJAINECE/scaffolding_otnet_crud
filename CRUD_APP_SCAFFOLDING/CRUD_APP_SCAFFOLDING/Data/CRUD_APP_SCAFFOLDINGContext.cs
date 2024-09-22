using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_APP_SCAFFOLDING.Model;

namespace CRUD_APP_SCAFFOLDING.Data
{
    public class CRUD_APP_SCAFFOLDINGContext : DbContext
    {
        public CRUD_APP_SCAFFOLDINGContext (DbContextOptions<CRUD_APP_SCAFFOLDINGContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_APP_SCAFFOLDING.Model.User> User { get; set; } = default!;
    }
}
