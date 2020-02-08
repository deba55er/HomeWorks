﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeWork2_EFCoreWithRazorPages.Data;
using HomeWork2_EFCoreWithRazorPages.Models;

namespace HomeWork2_EFCoreWithRazorPages
{
    public class DetailsModel : PageModel
    {
        private readonly HomeWork2_EFCoreWithRazorPages.Data.SchoolContext _context;

        public DetailsModel(HomeWork2_EFCoreWithRazorPages.Data.SchoolContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}