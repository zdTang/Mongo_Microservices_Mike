using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mongo.Services.CouponAPI.Data;
using Mongo.Services.CouponAPI.Models;

namespace Mongo.Services.CouponAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CouponAPIController : ControllerBase
	{
		private readonly AppDbContext _db;

		public CouponAPIController(AppDbContext db)
		{
			_db = db;
		}

		[HttpGet]
		public object Get()
		{
			try
			{
				IEnumerable<Coupon> objList = _db.Coupons.ToList();
				return objList;
			}
			catch (Exception ex)
			{

			}
			return null;
		}

		[HttpGet]
		[Route("{id:int}")]
		public object Get(int id)
		{
			try
			{
				Coupon objList = _db.Coupons.First(u => u.CouponId == id);
				return objList;
			}
			catch (Exception ex)
			{

			}
			return null;
		}
	}
}
