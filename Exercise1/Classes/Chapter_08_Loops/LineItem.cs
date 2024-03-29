﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_08_Loops
{
    public class LineItem
    {
        public int Id { get; } = default;
        public string Product { get; } = string.Empty;
        public int Quantity { get; } = default;
        public double Price { get; } = default;

        public LineItem(int id, string product, int quantity, double price, double vat)
        {
            try
            {
                if (id < 1) throw new ArgumentException("The id must be greater than 0");
                else if (product == string.Empty || product == default) throw new ArgumentException("The product can not be empty");
                else if (quantity < 1) throw new ArgumentException("The quantity must be greater than 0");
                else if (price <= 0) throw new ArgumentException("The price must be greater or equal than 0");
                else if (_vat < 0) throw new ArgumentException("The VAT must be greater than 0");

                Id = id;
                Product = product;
                Quantity = quantity;
                Price = price;
                _vat = vat;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private double _vat = default;

        private void Deconstruct(out double vat) => (vat) = (_vat);

        public double Vat =>
            this switch
            {
                var (vat) when vat >= 1 && vat <= 100 => vat / 100,
                var (vat) when vat > 0 && vat < 1 => vat,
                _ => 0
            };

        public double Total => Quantity * Price * (Vat + 1);
        public double VatCost => Quantity * Price * Vat;

    }
}
