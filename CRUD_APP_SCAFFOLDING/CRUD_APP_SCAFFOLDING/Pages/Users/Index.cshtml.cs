using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_APP_SCAFFOLDING.Data;
using CRUD_APP_SCAFFOLDING.Model;

namespace CRUD_APP_SCAFFOLDING.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_APP_SCAFFOLDING.Data.CRUD_APP_SCAFFOLDINGContext _context;

        public IndexModel(CRUD_APP_SCAFFOLDING.Data.CRUD_APP_SCAFFOLDINGContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
