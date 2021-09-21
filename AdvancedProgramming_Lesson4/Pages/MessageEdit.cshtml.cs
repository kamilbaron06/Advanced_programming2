using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Models;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class MessageEditModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 _context;

        public MessageEditModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext2 context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ChatMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChatMessageExists(ChatMessage.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/MessageHub");
        }

        private bool ChatMessageExists(string id)
        {
            return _context.Message.Any(e => e.Id == id);
        }
    }
}
