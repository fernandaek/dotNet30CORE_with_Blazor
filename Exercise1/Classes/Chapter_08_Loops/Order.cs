﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_08_Loops
{
    public class Order
    {
        public int Id { get; } = default;
        public string Customer { get; } = string.Empty;
        public string Address { get; } = string.Empty;

        public List<LineItem> Items { get; } = new List<LineItem>();

        private int MaxId => Items.Count.Equals(0) ? 0 : Items.Max(m => m.Id);
        private int CurrentId => MaxId + 1;

        public Order()
        {

        }

        public Order(int id, string customer, string address)
        {
            if (id < 1) throw new ArgumentException("The ID must be greater than 0");
            else if (customer == string.Empty || customer == default) throw new ArgumentException("Can't be empty.");
            else if (address == string.Empty || address == default) throw new ArgumentException("Can not be empty");

            try
            {
                Id = id;
                Customer = customer;
                Address = address;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddLineItem(string product, int quantity, double price, double vat) => Items.Add(new LineItem(CurrentId, product, quantity, price, vat));
        
        public void GetOrderTotalAndVat(out double total, out double vat)
        {
            {
                double totalPrice = default, totalVat = default;
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    totalPrice += item.Total;
                    totalVat += item.VatCost;
                }

                total = totalPrice;
                vat = totalVat;
            }
        }
    }
}
