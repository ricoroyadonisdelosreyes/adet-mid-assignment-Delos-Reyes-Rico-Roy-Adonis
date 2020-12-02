using Microsoft.EntityFrameworkCore;
using ToDoListMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListMVC.Data
{
    public class ToDoContext : DbContext
    {
            public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
            {

            }
            public DbSet<ToDo> ToDoTask { get; set; }

    }
}
