using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Models;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class MessageCreateModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 _context;

        public MessageCreateModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ChatMessage ChatMessage { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Message.Add(ChatMessage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./MessageHub");
        }
    }
}
