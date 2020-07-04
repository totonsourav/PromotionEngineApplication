using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Interface
{
	/// <summary>
	/// Interface which depicts the methods related to the whereabouts of each coupon and also
	/// contains the wrapper for calculations of the checkout process
	/// </summary>
	public interface IProductPromotionLogic
   {
		List<ProductCouponModel> GetAllCouponsAvailable(string productCouponApplied = "");
		decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection, string productCouponApplied);
	}
}
