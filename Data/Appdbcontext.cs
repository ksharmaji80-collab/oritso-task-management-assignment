using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.Data
{
    public class Appdbcontext: DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
           : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
