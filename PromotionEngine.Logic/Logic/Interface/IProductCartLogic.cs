using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Interface
{
	/// <summary>
	/// Interface which depicts the methods related to the checkout process for a particular user
	/// </summary>
	public interface IProductCartLogic
	{
		ProductBuyModel CalculateTotalFromProductCart(List<ProductCartModel> productCartCollection, string productCouponApplied);	
	}
}
