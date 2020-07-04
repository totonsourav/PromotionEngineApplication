using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Implementation
{
	public class ProductDetailsLogic : IProductDetailsLogic
	{
		IProductPromotionLogic _productPromotionLogic = null;
		public ProductDetailsLogic(IProductPromotionLogic productPromotionLogic)
		{
			_productPromotionLogic = productPromotionLogic;
		}

		/// <summary>
		/// This method is responsible for creating 
		/// - the product info collection which the user see on the home page.
		/// - Moreover, it also includes the available coupons  
		/// Mocking the data for now till the database layer accessibility comes into picture
		/// </summary>
		/// <returns>ProductBuyModel object</returns>
		public ProductBuyModel GetAllProductsWithDetails()
		{
			try
			{
				var productDetailsCollection = new List<ProductCartModel>()
				{
					new ProductCartModel('A', 50),
					new ProductCartModel('B', 30),
					new ProductCartModel('C', 20),
					new ProductCartModel('D', 15)
				};

				var productCouponCollection = _productPromotionLogic.GetAllCouponsAvailable();
				return new ProductBuyModel(productDetailsCollection, productCouponCollection);
			}
			catch (Exception ex)
			{
				throw ex;
			}		
		}
	}
}
