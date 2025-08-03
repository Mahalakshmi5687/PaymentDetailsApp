using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models
{
    //to convert this class to dbcontext class we inherit the dbcontext class from parent class
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
