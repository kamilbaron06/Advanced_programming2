using AdvancedProgramming_Lesson4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedProgramming_Lesson4.Data
{
    public class ApplicationDbContext2 : DbContext
    {
        public ApplicationDbContext2(DbContextOptions<ApplicationDbContext2> options)
            : base(options)
        {
        }


        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<ChatMessage> Message { get; set; }



    }
}
