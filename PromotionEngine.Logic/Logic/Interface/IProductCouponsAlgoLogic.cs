using System.Collections.Generic;
using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Interface
{
	public interface IProductCouponsAlgoLogic
   {
		decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection);
	}
}
