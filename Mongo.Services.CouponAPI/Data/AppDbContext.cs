using Microsoft.EntityFrameworkCore;
using Mongo.Services.CouponAPI.Models;

namespace Mongo.Services.CouponAPI.Data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
                
        }
		public DbSet<Coupon> Coupons { get; set; }
	}
}
