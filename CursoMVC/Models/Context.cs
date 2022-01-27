﻿using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context:DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CursoMVC;Trusted_Connection=True");
        }

    }
}