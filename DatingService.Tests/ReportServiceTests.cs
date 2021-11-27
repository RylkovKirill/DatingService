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
    public class ReportServiceTests
    {
        
        private ApplicationDbContext applicationDbContext;
        private Repository<Report> repository;
        private ReportService reportService;

       

        [Fact]
        public void GetReportTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options );
            repository = new Repository<Report>(applicationDbContext);
            reportService = new ReportService(repository);
            applicationDbContext.Reports.Add(new Report() { Id = Guid.Parse("401a67e1-e241-456e-b8d9-def83405bdbc") });
            applicationDbContext.SaveChanges();
            var report = reportService.Get(Guid.Parse("401a67e1-e241-456e-b8d9-def83405bdbc"));
            Assert.NotNull(report);
            Assert.IsType<Report>(report);
            Assert.Equal(Guid.Parse("401a67e1-e241-456e-b8d9-def83405bdbc"), report.Id);
        }

        [Fact]
        public void GetReportsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Report>(applicationDbContext);
            reportService = new ReportService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Reports.Add(new Report() { Id = Guid.NewGuid() });
            }
            applicationDbContext.SaveChanges();
            var reports = reportService.GetAll();
            Assert.NotNull(reports);
            Assert.Equal(10, reports.Count());
        }

        [Fact]
        public void GetReportsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Report>(applicationDbContext);
            reportService = new ReportService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Reports.Add(new Report() { Id = Guid.NewGuid(), Receiver = user });
            }
            applicationDbContext.SaveChanges();
            var reports = reportService.GetAll(user);
            Assert.NotNull(reports);
            Assert.Equal(10, reports.Count());
            for (int i = 0; i < reports.Count(); i++)
            {
                Assert.Equal(user, reports.ToArray()[i].Receiver);
            }
        }

        

        [Fact]
        public void AddReportTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Report>(applicationDbContext);
            reportService = new ReportService(repository);
            reportService.Add(new Report() { Id = Guid.Parse("1b7b7549-9338-43dc-a1a1-de9b9a40bf60") });
            Assert.Equal(1, applicationDbContext.Reports.Count());
        }

        [Fact]
        public void UpdateReportTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Report>(applicationDbContext);
            reportService = new ReportService(repository);
            reportService.Add(new Report() { Id = Guid.Parse("5df72e56-a5af-4fcb-8151-5d7812640dc8") });
            applicationDbContext.SaveChanges();
            Report reports = applicationDbContext.Reports.SingleOrDefault(s => s.Id == Guid.Parse("5df72e56-a5af-4fcb-8151-5d7812640dc8"));
            reportService.Update(reports);
            Assert.Equal(1, applicationDbContext.Reports.Count());
        }

        [Fact]
        public void RemoveReportTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Report>(applicationDbContext);
            reportService = new ReportService(repository);
            reportService.Add(new Report() { Id = Guid.Parse("22e34370-ee6f-415c-a177-159e87a2b4d8") });
            applicationDbContext.SaveChanges();
            reportService.Remove(Guid.Parse("22e34370-ee6f-415c-a177-159e87a2b4d8"));
            Assert.Equal(0, applicationDbContext.Reports.Count());
        }
    }
}
