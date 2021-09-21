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
    public class MessageDeleteModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 _context;

        public MessageDeleteModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 context)
        {
            _context = context;
        }

        [BindProperty]
        public ChatMessage ChatMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChatMessage = await _context.Message.FirstOrDefaultAsync(m => m.Id == id);

            if (ChatMessage == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChatMessage = await _context.Message.FindAsync(id);

            if (ChatMessage != null)
            {
                _context.Message.Remove(ChatMessage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/MessageHub");
        }
    }
}
