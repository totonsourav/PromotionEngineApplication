using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Interface
{
	public interface IProductPromotionLogic
   {
		List<ProductCouponModel> GetAllCouponsAvailable(string productCouponApplied = "");
		decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection, string productCouponApplied);
	}
}
