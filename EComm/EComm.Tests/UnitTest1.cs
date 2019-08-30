using EComm.DataAccess;
using EComm.Model;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace EComm.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, (2 + 2));
        }
        
        [Fact]
        public void ProductDetails()
        {
            // Arrange

            // Act

            // Asser
        }

        private ECommDataContext CreateStubContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ECommDataContext>();
            optionsBuilder.UseInMemoryDatabase("TestDb");
            var context = new ECommDataContext(optionsBuilder.Options);

            // Add sample data
            context.Products.Add(
                new Product
                {
                    Id = 1,
                    ProductName = "Milk",
                    UnitPrice = 2.50M
                });

            context.Products.Add(
                new Product
                {
                    Id = 2,
                    ProductName = "Bread",
                    UnitPrice = 3.25M,
                    SupplierId = 1
                });

            context.Products.Add(
                new Product
                {
                    Id = 3,
                    ProductName = "Juice",
                    UnitPrice = 5.75M
                });

            context.Suppliers.Add(
                new Supplier
                {
                    Id = 1,
                    CompanyName = "Acme"
                });

            context.SaveChanges();
            return context;
        }
    }
}
