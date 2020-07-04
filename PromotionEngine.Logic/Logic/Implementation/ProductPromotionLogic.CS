using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Logic.Abstract;
using PromotionEngine.Logic.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Implementation
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductPromotionLogic : IProductPromotionLogic
	{
		AProductCouponsAlgoLogic _aProductCouponsAlgoLogic = null;
		public ProductPromotionLogic(AProductCouponsAlgoLogic aProductCouponsAlgoLogic)
		{
			_aProductCouponsAlgoLogic = aProductCouponsAlgoLogic;
		}

		/// <summary>
		/// Mocking the data for now till the database layer accessibility comes into picture
		/// </summary>
		/// <returns></returns>
		public List<ProductCouponModel> GetAllCouponsAvailable(string productCouponApplied = "")
		{
			try
			{
				var productCouponsCollection = new List<ProductCouponModel>()
				{
					new ProductCouponModel(1, "Coupon-A", "3 of A's for 130", DateTime.Now, productCouponApplied == "Coupon-A"),
					new ProductCouponModel(2, "Coupon-B", "2 of B's for 45", DateTime.Now, productCouponApplied == "Coupon-B"),
					new ProductCouponModel(3, "Coupon-C", "C + D for 30", DateTime.Now, productCouponApplied == "Coupon-C"),
					new ProductCouponModel(4, "None", "None", DateTime.Now, productCouponApplied == "None")
				};
				return productCouponsCollection;
			}
			catch (Exception ex)
			{
				throw ex;
			}	
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="productCartCollection"></param>
		/// <param name="productCouponApplied"></param>
		/// <returns></returns>
		public decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection, string productCouponApplied)
		{
			decimal totalAmount = 0; 
			try
			{
				totalAmount = _aProductCouponsAlgoLogic.GetCouponType(productCouponApplied).CalculationBasedOnCouponLogic(productCartCollection);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return totalAmount;
		}
	}
}
