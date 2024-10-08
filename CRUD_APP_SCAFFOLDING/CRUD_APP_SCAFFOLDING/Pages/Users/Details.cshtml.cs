﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_APP_SCAFFOLDING.Data.CRUD_APP_SCAFFOLDINGContext _context;

        public DetailsModel(CRUD_APP_SCAFFOLDING.Data.CRUD_APP_SCAFFOLDINGContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
