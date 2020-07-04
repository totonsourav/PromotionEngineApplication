using System;

namespace PromotionEngine.Logic.Models
{
	/// <summary>
	/// This class includes the properties of each available coupon's
	/// </summary>
	public class ProductCouponModel
    {
		public int couponId { get; set; }
	
		public string couponName { get; set; }

		public string couponDescription { get; set; }

		public DateTime couponExpirationDate { get; set; }

		public Boolean couponSelected { get; set; }

		public ProductCouponModel() { }

		public ProductCouponModel(int couponId, string couponName, string couponDescription, DateTime couponExpirationDate, Boolean couponSelected)
		{
			this.couponId = couponId;
			this.couponName = couponName;
			this.couponDescription = couponDescription;
			this.couponExpirationDate = couponExpirationDate;
			this.couponSelected = couponSelected;
		}
	 }
}
