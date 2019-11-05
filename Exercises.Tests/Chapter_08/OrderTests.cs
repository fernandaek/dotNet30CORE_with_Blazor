using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercise1.Classes.Chapter_08_Loops;
using Exercises.Classes;

namespace Exercises.Tests.Chapter_08
{
    public class OrderTests
    {
        [Fact]
        public void CanCreateLineItemInstance()
        {
            LineItem item = new LineItem(1, "Book", 3, 10, 2);

            Assert.NotNull(item);
            Assert.Equal(1, item.Id);
            Assert.Equal("Book", item.Product);
            Assert.Equal(3, item.Quantity);
            Assert.Equal(10, item.Price);
            Assert.Equal(0.6, item.VatCost);
            Assert.Equal(30.6, item.Total);
        }
        [Fact]
        public void CanCreateOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");

            Assert.NotNull(order);
            Assert.Equal(1, order.Id);
            Assert.Equal("Customer 1", order.Customer);
            Assert.Equal("Address 1", order.Address);
            Assert.Empty(order.Items);
        }

        [Fact]
        public void CanAddLineItemToOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");
            order.AddLineItem("Product 1", 2, 10, 50);
            var addedItem = order.Items.Find(i => i.Id.Equals(1));

            // Assert Order
            Assert.NotNull(order);
            Assert.Equal(1, order.Id);
            Assert.Equal("Customer 1", order.Customer);
            Assert.Equal("Address 1", order.Address);
            Assert.NotEmpty(order.Items);

            // Assert LineItem
            Assert.Equal(1, addedItem.Id);
            Assert.Equal(2, addedItem.Quantity);
            Assert.Equal(10, addedItem.Price);
            Assert.Equal(10, addedItem.VatCost);
            Assert.Equal(30, addedItem.Total);
            Assert.Equal("Product 1", addedItem.Product);
        }

        [Fact]
        public void CanGetTotalAndVatInOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");

            order.AddLineItem("Product 1", 2, 10, 50);
            order.AddLineItem("Product 2", 1, 100, 0.5);
            order.GetOrderTotalAndVat(out double total, out double vat);

            Assert.NotNull(order);
            Assert.Equal(60, vat);
            Assert.Equal(180, total);
        }

        [Fact]
        public void CanCreateOrderFactoryInstance()
        {
            var orders = new OrderFactory();

            Assert.NotNull(orders);
        }

        [Fact]
        public void CanAddOrderWithFactoryInstance()
        {
            var orders = new OrderFactory();

            orders.Add("Customer 1", "Address 1");

            Assert.NotEmpty(orders.Get());
        }

        [Fact]
        public void CreateLineItemExceptionWrongId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(-1, "Product 1", 2, 10, 50);
            });
        }

        [Fact]
        public void CreateLineItemExceptionEmptyProductName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "", 2, 10, 50);
            });
        }

        [Fact]
        public void CreateLineItemExceptionWrongQuantity()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "Product 1", 0, 10, 50);
            });
        }

        [Fact]
        public void CreateLineItemExceptionWrongPrice()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "Product 1", 2, 0, 50);
            });
        }

        [Fact]
        public void CreateLineItemExceptionWrongVat()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "Product 1", 0, 10, -1);
            });
        }
        [Fact]
        public void CreateOrderExceptionWrongId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var order = new Order(-1, "Customer 1", "Address 1");
            });
        }

        [Fact]
        public void CreateOrderExceptionEmptyCustomerName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var order = new Order(1, "", "Address 1");
            });
        }

        [Fact]
        public void CreateOrderExceptionEmptyAddress()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var order = new Order(1, "Customer", "");
            });
        }

        [Fact]
        public void AddMethodInOrderFactoryThrowsExceptionForWrongCustomerData()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var orderFactory = new OrderFactory();
                orderFactory.Add("", "Address 1");
            });
        }

        [Fact]
        public void AddMethodInOrderFactoryThrowsExceptionForWrongAddressData()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var orderFactory = new OrderFactory();
                orderFactory.Add("Customer 1", "");
            });
        }


    }
}
