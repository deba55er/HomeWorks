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
    public class IndexModel : PageModel
    {
        private readonly HomeWork2_EFCoreWithRazorPages.Data.SchoolContext _context;

        public IndexModel(HomeWork2_EFCoreWithRazorPages.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
