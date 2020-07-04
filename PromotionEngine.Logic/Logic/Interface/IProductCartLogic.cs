using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Interface
{
	public interface IProductCartLogic
	{
		ProductBuyModel CalculateTotalFromProductCart(List<ProductCartModel> productCartCollection, string productCouponApplied);	
	}
}
