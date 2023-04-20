﻿using Day10API.Models;
using Microsoft.EntityFrameworkCore;

namespace Day10API.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DataInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void MigrateData()
        {
            _dbContext.Database.Migrate();
            SeedData();
            _dbContext.SaveChanges();
        }

        private void SeedData()
        {
            if (!_dbContext.SuperHeroes
        .Any(e => e.Name == "Super Richard"))
            {
                _dbContext.Add(new SuperHero
                {
                    Name = "Super Richard",
                    FirstName = "Richard",
                    SurName = "Chalk",
                    City = "York",
                });
            }
        }

    }

}
