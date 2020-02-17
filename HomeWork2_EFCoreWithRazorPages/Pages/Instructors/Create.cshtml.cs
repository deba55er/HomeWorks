﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HomeWork2_EFCoreWithRazorPages.Data;
using HomeWork2_EFCoreWithRazorPages.Models;

namespace HomeWork2_EFCoreWithRazorPages.Pages.Instructors
{
    public class CreateModel : PageModel
    {
        private readonly HomeWork2_EFCoreWithRazorPages.Data.SchoolContext _context;

        public CreateModel(HomeWork2_EFCoreWithRazorPages.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Instructor Instructor { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Instructors.Add(Instructor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
