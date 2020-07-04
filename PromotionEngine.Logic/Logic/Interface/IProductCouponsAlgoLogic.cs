using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Interface
{
	/// <summary>
	/// Interface which depicts the methods related to the calculation of total amount 
	/// based on the total units which the user has selected and also the selected coupon
	/// </summary>
	public interface IProductCouponsAlgoLogic
   {
		decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection);
	}
}
