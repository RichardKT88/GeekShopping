using GeekShopping.OrderAPI.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.OrderAPI.Model.Context
{
    public class MySQLContext :DbContext
    {
        public MySQLContext(){}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<OrderDetails> Details { get; set; } = null!;       
        public DbSet<OrderHeader> Headers { get; set; } = null!;       
    }
}
