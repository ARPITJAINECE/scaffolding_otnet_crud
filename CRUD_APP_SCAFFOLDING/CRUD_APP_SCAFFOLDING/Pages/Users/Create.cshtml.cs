using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_APP_SCAFFOLDING.Data;
using CRUD_APP_SCAFFOLDING.Model;

namespace CRUD_APP_SCAFFOLDING.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly CRUD_APP_SCAFFOLDING.Data.CRUD_APP_SCAFFOLDINGContext _context;

        public CreateModel(CRUD_APP_SCAFFOLDING.Data.CRUD_APP_SCAFFOLDINGContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
