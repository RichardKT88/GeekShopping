﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.OrderAPI.Model.Base
{
    [Table("order_detail")]
    public class OrderDetails : BaseEntity
    {
        public long OrderHeaderId { get; set; }
        [ForeignKey("OrderHeaderId")]
        public virtual OrderHeader? OrderHeader { get; set; }
        [Column("ProductId")]
        public long ProductId { get; set; }
        [Column("count")]
        public int Count { get; set; }
        [Column("product_name")]
        public string? ProductName { get; set; }
        [Column("price")]
        public decimal Price { get; set; }

    }
}
