using DatingService.Domain.Entities;
using DatingService.Persistence;
using DatingService.Service;
using DatingService.Service.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DatingService.Tests
{
    public class ReportCategoryServiceTests
    {

        private ApplicationDbContext applicationDbContext;
        private Repository<ReportCategory> repository;
        private ReportCategoryService reportCategoryService;



        [Fact]
        public void GetCategoryTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<ReportCategory>(applicationDbContext);
            reportCategoryService = new ReportCategoryService(repository);
            applicationDbContext.ReportCategory.Add(new ReportCategory() { Id = Guid.Parse("6441e6a4-db3b-4701-b1d5-d5ab9f1c6793") });
            applicationDbContext.SaveChanges();
            var reportCategory = reportCategoryService.Get(Guid.Parse("6441e6a4-db3b-4701-b1d5-d5ab9f1c6793"));
            Assert.NotNull(reportCategory);
            Assert.IsType<ReportCategory>(reportCategory);
            Assert.Equal(Guid.Parse("6441e6a4-db3b-4701-b1d5-d5ab9f1c6793"), reportCategory.Id);
        }

        [Fact]
        public void GetCategoriesTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<ReportCategory>(applicationDbContext);
            reportCategoryService = new ReportCategoryService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.ReportCategory.Add(new ReportCategory() { Id = Guid.NewGuid() });
            }
            applicationDbContext.SaveChanges();
            var reportCategories = reportCategoryService.GetAll();
            Assert.NotNull(reportCategories);
            Assert.Equal(10, reportCategories.Count());
        }

        [Fact]
        public void AddCategoryTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<ReportCategory>(applicationDbContext);
            reportCategoryService = new ReportCategoryService(repository);
            reportCategoryService.Add(new ReportCategory() { Id = Guid.Parse("791ea5ae-a4c6-4f20-8b8f-f3c150fb62ec") });
            Assert.Equal(1, applicationDbContext.ReportCategory.Count());
        }

        [Fact]
        public void UpdateCategoryTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<ReportCategory>(applicationDbContext);
            reportCategoryService = new ReportCategoryService(repository);
            reportCategoryService.Add(new ReportCategory() { Id = Guid.Parse("2eb1d729-8d4c-4a94-90b6-ed9dfbd0bc76") });
            applicationDbContext.SaveChanges();
            ReportCategory reports = applicationDbContext.ReportCategory.SingleOrDefault(s => s.Id == Guid.Parse("2eb1d729-8d4c-4a94-90b6-ed9dfbd0bc76"));
            reportCategoryService.Update(reports);
            Assert.Equal(1, applicationDbContext.ReportCategory.Count());
        }

        [Fact]
        public void RemoveCategoryTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<ReportCategory>(applicationDbContext);
            reportCategoryService = new ReportCategoryService(repository);
            reportCategoryService.Add(new ReportCategory() { Id = Guid.Parse("2d531f40-d0c2-474f-ab60-9cfcb07a999d") });
            applicationDbContext.SaveChanges();
            reportCategoryService.Remove(Guid.Parse("2d531f40-d0c2-474f-ab60-9cfcb07a999d"));
            Assert.Equal(0, applicationDbContext.ReportCategory.Count());
        }
    }
}
