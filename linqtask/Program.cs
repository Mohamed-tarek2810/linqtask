using DocumentFormat.OpenXml.Office2010.ExcelAc;
using linqtask.Data;
using linqtask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace linqtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new();
            //1 - List all customers' first and last names along with their email addresses.

            //var customers = context.Customer
            //    .Select(c => new
            //    {
            //        c.FirstName,
            //        c.LastName,
            //        c.Email
            //    });

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"fullname:{customer.FirstName} {customer.LastName} , Email:{customer.Email}");
            //}

            //--------------------------------
            //2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).

            //var orders = context.Orders
            //.Where(e => e.StaffId == 3);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"Order Id: {order.OrderId}, Staff Id: {order.StaffId}, Date: {order.OrderDate}");
            //}

            //-------------------------------------

            //3 - Get all products that belong to a category named "Mountain Bikes".

            //var Product = context.Products
            //    .Include(p => p.Category)
            //    .Where(p => p.Category.CategoryName == "Mountain Bikes");

            //foreach (var items in Product)
            //{
            //    Console.WriteLine(value: $"Product ID: {items.ProductId}, Name: {items.ProductName}, Category: {items.Category.CategoryName}");
            //}
            //------------------------------------------

            //4 - Count the total number of orders per store.

            //var ordercount = context.Orders.GroupBy
            //    (o => o.StoreId)
            //    .Select(g => new
            //    {
            //        StoreId = g.Key,
            //        OrderCount = g.Count()
            //    }
            //    );
            //foreach (var item in ordercount)
            //{
            //    Console.WriteLine($"StoreId:{item.StoreId}, OrdersCount:{item.OrderCount}");
            //}


            //-----------------------------------------
            //5 - List all orders that have not been shipped yet(shipped_date is null).

            //var unshippedOrders = context.Orders
            // .Where(o => o.ShippedDate == null);

            //foreach (var items in unshippedOrders)
            //{
            //    Console.WriteLine($"Order Id: {items.OrderId}, Order Date: {items.OrderDate} , Order Status : {items.OrderStatus}");
            //}

            //-----------------------------------------
            //6 - Display each customer’s full name and the number of orders they have placed.

            //    var customerOrdersCount = context.Customer
            //   .Select(c => new
            //   {
            //       FullName = c.FirstName + " " + c.LastName,
            //       OrdersCount = c.Orders.Count()
            //   });

            //foreach (var customer in customerOrdersCount)
            //{
            //    Console.WriteLine($"{customer.FullName} , Orders: {customer.OrdersCount}");
            //}
            //---------------------------------

            //7 - List all products that have never been ordered(not found in order_items).
            //   var productsNotOrdered = context.Products
            //.Where(p => !p.OrderItems.Any());

            //foreach (var items in productsNotOrdered)
            //{
            //    Console.WriteLine($"Product: {items.ProductName}");
            //}
            //---------------------------------------

            //8 - Display products that have a quantity of less than 5 in any store stock.

            //var lowproductsinstock = context.Stocks
            //    .Where(s => s.Quantity < 5)
            //   .Select(s => new
            //   {
            //       s.Product.ProductName,
            //       s.Quantity
            //   });
            //foreach (var item in lowproductsinstock)
            //{
            //    Console.WriteLine($" Product: {item.ProductName} , Quantity: {item.Quantity}");
            //}
            //-------------------------------------
            //9.Retrieve the first product from the products table.

            //var first = context.Products.FirstOrDefault();


            //Console.WriteLine($"First Product: {first.ProductName}");
            //----------------------------------
            //10 - Retrieve all products from the products table with a certain model year.

            //var modelyearsproducts = context.Products.Where(p => p.ModelYear == 2017);


            //foreach (var product in modelyearsproducts)
            //{
            //    Console.WriteLine($"{product.ProductName} , Model Year: {product.ModelYear}");
            //}
            //---------------------------------
            //11 - Display each product with the number of times it was ordered.
            //  var productsOrderCount = context.Products
            //.Select(p => new
            //{
            //    p.ProductName,
            //    OrderCount = p.OrderItems.Count()
            //});

            //foreach (var item in productsOrderCount)
            //{
            //    Console.WriteLine($"ProductName:{item.ProductName} , Ordered: {item.OrderCount}");
            //}

            //--------------------
            //12 - Count the number of products in a specific category.

            //   var countproducts = context.Products
            //        .Count(p => p.CategoryId == 4);
            //Console.WriteLine($"Number of products in category 4: {countproducts}");
            //-----------------------------------

            //13.Calculate the average list price of products.

            //var averageprice = context.Products
            //          .Average(p => p.ListPrice);
            //Console.WriteLine($"Average List Price: {averageprice:C}");

            //-------------------------------------
            //14.Retrieve a specific product from the products table by ID

            //var product = context.Products.Find(123);
            //Console.WriteLine($"Product: {product.ProductName}");
            //--------------------------------
            //15.List all products that were ordered with a quantity greater than 3 in any order
            //   var listofproducts = context.OrderItems
            //.Where(o => o.Quantity > 3)//المفروض مفيش حاجه هتظهر عشان الكميات الاتباعت مفيش اكتر منن 3 
            //.Select(o =>
            //o.Product
            //);
            //foreach (var items in listofproducts)
            //{
            //    Console.WriteLine($"Product: {items.ProductName}");
            //}

            //--------------------------------------------
            //16.Display each staff member’s name and how many orders they processed
            //var listofstaffs = context.Staffs
            //    .Select(s => new
            //    {
            //        fullname = s.FirstName + "  " + s.LastName,
            //        OrderCount = s.Orders.Count()
            //    });

            //foreach (var staff in listofstaffs)
            //{
            //    Console.WriteLine($"{staff.fullname} , OrdersProcessed: {staff.OrderCount}");
            //}
            //--------------------------------
            //17.List active staff members only(active = true) along with their phone numbers.

            //var activeStaff = context.Staffs
            //    .Where(s => Active == true)
            //    .Select(s => new
            //    {
            //        FullName = s.FirstName + " " + s.LastName,
            //        s.Phone
            //    });


            //foreach (var staff in activeStaff)
            //{
            //    Console.WriteLine($"{staff.FullName} , Phone: {staff.Phone}");
            //}

            //---------------------

            //18.List all products with their brand name and category name.
            //  var productsWithBrandAndCategory = context.Products
            //    .Include(p => p.Brand)
            //    .Include(p => p.Category)
            //   .Select(p => new
            //   {
            //       p.ProductName,
            //       p.Brand.BrandName,
            //       p.Category.CategoryName
            //   });

            //foreach (var item in productsWithBrandAndCategory)
            //{
            //    Console.WriteLine($"Product: {item.ProductName} , Brand: {item.BrandName} , Category: {item.CategoryName}");
            //}

            //----------------------------
            //19 - Retrieve orders that are completed.

            //var completedOrders = context.Orders
            //.Where(o => o.OrderStatus == 4);

            //foreach (var order in completedOrders)
            //{
            //    Console.WriteLine($"Orderid: {order.OrderId},shipeddate: {order.ShippedDate}, Status: {order.OrderStatus}");
            //}
            //-------------------------------------
            //20 - List each product with the total quantity sold(sum of quantity from order_items).
            //var productSales = context.Products
            //  .Select(p => new
            //  {
            //      p.ProductName,
            //      QuantitytotalSold = p.OrderItems
            //.Sum(o => o.Quantity)
            //  })
            //  .ToList();

            //foreach (var item in productSales)
            //{
            //    Console.WriteLine($"Product: {item.ProductName} , Total: {item.QuantitytotalSold}");
            //}


        }
    }
}
