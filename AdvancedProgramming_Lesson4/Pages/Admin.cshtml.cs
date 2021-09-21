using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Models;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class AdminModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 _context;

        public AdminModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 context)
        {
            _context = context;
        }

        public IList<AspNetUsers> AspNetUsers { get;set; }

        public async Task OnGetAsync()
        {
            AspNetUsers = await _context.AspNetUsers.ToListAsync();
        }
    }
}
