﻿using Facile.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Orders.com.Core.Domain
{
    public class InventoryItem : DomainBase
    {
        public long InventoryItemID { get; set; }

        [FacileRequired, Display(Name = "Quantity on Hand")]
        public decimal QuantityOnHand { get; set; }

        public long ProductID { get; set; }

        public override long ID
        {
            get { return InventoryItemID; }
            set { InventoryItemID = value; }
        }
    }
}
