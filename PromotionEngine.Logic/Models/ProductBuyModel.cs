using System.Collections.Generic;
using System.ComponentModel;

namespace PromotionEngine.Logic.Models
{
	/// <summary>
	/// This class includes the properties regarding -
	/// - the units the user has selected 
	/// - the coupon which the user has selected
	/// - the total amount after the calculation
	/// </summary>
	public class ProductBuyModel
   {
		public List<ProductCartModel> productCartModel { get; set; }

		public List<ProductCouponModel> productCouponModel { get; set; }

		[DisplayName("Total Bill")]
		public decimal? productBuyTotalAmount { get; set; }

		public ProductBuyModel() { }

		public ProductBuyModel(List<ProductCartModel> productCartModel, List<ProductCouponModel> productCouponModel = null, decimal productBuyTotalAmount=0) {
			this.productCartModel = productCartModel;
			this.productCouponModel = productCouponModel;
			this.productBuyTotalAmount = productBuyTotalAmount;
		}
	}
}
