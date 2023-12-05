using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentAPI.Context
{
	public class PaymentDetailContext : DbContext
	{
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
