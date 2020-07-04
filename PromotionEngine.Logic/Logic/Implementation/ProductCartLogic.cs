using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Logic.Logic.Implementation
{
	public class ProductCartLogic : IProductCartLogic
	{
		IProductPromotionLogic _productPromotionLogic = null;
		public ProductCartLogic(IProductPromotionLogic productPromotionLogic)
		{
			_productPromotionLogic = productPromotionLogic;
		}

		/// <summary>
		/// This method is responsible for creating the ProductBuyModel instance which will get returned
		/// to the home page after user goes for the checkout process by clicking on the CheckTotal button 
		/// to see the total amount
		/// </summary>
		/// <param name="productCartCollection"></param>
		/// <param name="productCouponApplied"></param>
		/// <returns>ProductBuyModel object</returns>
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
