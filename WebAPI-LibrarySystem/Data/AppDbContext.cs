﻿using Microsoft.EntityFrameworkCore;
using WebAPI_LibrarySystem.Models;

namespace WebAPI_LibrarySystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    
    public DbSet<AutorModel> Autores { get; set; }
    public DbSet<LivroModel> Livros { get; set; }
}