﻿using AngleSharp.Dom;
using Microsoft.EntityFrameworkCore;
using System;

namespace CursoMVC.Models
{
    public class Context:DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CursoMVC;Trusted_Connection=True");
        }

        public virtual void SetModified(Object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
