﻿using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class ExpenseTrackerContext: DbContext
    {
        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) 
            : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Income> Incomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category() { Id = 1, Name = "Food" },
                new Category() { Id = 2, Name = "Travel" },
                new Category() { Id = 3, Name = "Entertainment" },
                new Category() { Id = 4, Name = "Education" },
                new Category() { Id = 5, Name = "Clothes" },
                new Category() { Id = 6, Name = "House" },
            });
            //modelBuilder.Entity<Expense>().HasData(new Expense[]
            //{
            //    new Expense()
            //    {
            //        Id = 7,
            //        Title = "a",
            //        Date = DateTime.Now,
            //        Amount = 100,
            //        Planned = true,
            //        CategoryId = 1,
            //    },
            //});
        }
    }
}
