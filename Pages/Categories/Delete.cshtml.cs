﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ceteras_Alina_Iulia_Lab8.Data;
using Ceteras_Alina_Iulia_Lab8.Models;

namespace Ceteras_Alina_Iulia_Lab8.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Ceteras_Alina_Iulia_Lab8.Data.Ceteras_Alina_Iulia_Lab8Context _context;

        public DeleteModel(Ceteras_Alina_Iulia_Lab8.Data.Ceteras_Alina_Iulia_Lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
