using System;
using System.Linq;
using System.Collections.Generic;

using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Implementation
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductCartLogic : IProductCartLogic
	{
		IProductPromotionLogic _productPromotionLogic = null;
		public ProductCartLogic(IProductPromotionLogic productPromotionLogic)
		{
			_productPromotionLogic = productPromotionLogic;
		}
		public ProductBuyModel CalculateTotalFromProductCart(List<ProductCartModel> productCartCollection, string productCouponApplied)
		{
			try
			{
				ProductBuyModel productBuyModel = new ProductBuyModel();

				productBuyModel.productCartModel = productCartCollection;
				productBuyModel.productCouponModel = _productPromotionLogic.GetAllCouponsAvailable(productCouponApplied);

				productBuyModel.productBuyTotalAmount = productCartCollection.Where(item => item.productUnitcount > 0).Any() ?
				_productPromotionLogic.CalculationBasedOnCouponLogic(productCartCollection, productCouponApplied) : 0;

				return productBuyModel;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
