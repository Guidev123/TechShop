﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Domain.DomainObjects;

namespace TechShop.Domain.Entities
{
    public class OrderItem : IEntity
    {
        public OrderItem(Guid productId, int quantity, decimal price)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public Guid Id {  get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
