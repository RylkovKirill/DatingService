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
    public class OrderServiceTests
    {
        private ApplicationDbContext applicationDbContext;
        private Repository<Order> repository;
        private OrderService orderService;
        [Fact]
        public void GetOrderTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Order>(applicationDbContext);
            orderService = new OrderService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Orders.Add(new Order() { Id = id, Price = 450 });
            applicationDbContext.SaveChanges();
            var order = orderService.Get(id);
            Assert.NotNull(order);
            Assert.IsType<Order>(order);
            Assert.Equal(id, order.Id);
            Assert.Equal(450, order.Price);
        }
        [Fact]
        public void GetOrdersTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Order>(applicationDbContext);
            orderService = new OrderService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Orders.Add(new Order() { Id = Guid.NewGuid(), Price = 450 });
            }
            applicationDbContext.SaveChanges();
            var orders = orderService.GetAll();
            Assert.NotNull(orders);
            Assert.Equal(10, orders.Count());
        }
        [Fact]
        public void GetOrdersByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Order>(applicationDbContext);
            orderService = new OrderService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Orders.Add(new Order() { Id = Guid.NewGuid(), Price = 450, User = user });
            }
            applicationDbContext.SaveChanges();
            var orders = orderService.GetAll(user);
            Assert.NotNull(orders);
            Assert.Equal(10, orders.Count());
            for (int i = 0; i < orders.Count(); i++)
            {
                Assert.Equal(user, orders.ToArray()[i].User);
            }
        }
        [Fact]
        public void AddOrderTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Order>(applicationDbContext);
            orderService = new OrderService(repository);
            orderService.Add(new Order() { Id = Guid.NewGuid(), Price = 450 });
            Assert.Equal(1, applicationDbContext.Orders.Count(p => p.Price == 450));
        }
        [Fact]
        public void UpdateOrderTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Order>(applicationDbContext);
            orderService = new OrderService(repository);
            Guid id = Guid.NewGuid();
            orderService.Add(new Order() { Id = id, Price = 450 });
            applicationDbContext.SaveChanges();
            Order order = applicationDbContext.Orders.SingleOrDefault(s => s.Id == id);
            order.Price = 500;
            orderService.Update(order);
            Assert.Equal(1, applicationDbContext.Orders.Count(p => p.Price == 500));
        }
        [Fact]
        public void RemoveOrderTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Order>(applicationDbContext);
            orderService = new OrderService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Orders.Add(new Order() { Id = id, Price = 450 });
            applicationDbContext.SaveChanges();
            orderService.Remove(id);
            Assert.Equal(0, applicationDbContext.Orders.Count(p => p.Price == 450));
        }
    }
}
