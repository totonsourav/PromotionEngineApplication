using PromotionEngine.Logic.Logic.Abstract;
using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Logic.Logic.Implementation
{
	public class ProductCouponsAlgoLogic : AProductCouponsAlgoLogic
	{
		/// <summary>
		/// This method is responsible for returning the coupon class instance 
		/// based on the user's selection.
		/// The user may or may not select any coupon but if user choose to 
		/// opt for a coupon, he/she can select any one. 
		/// </summary>
		/// <param name="couponType"></param>
		/// <returns>Selected coupon class instance</returns>
		public override IProductCouponsAlgoLogic GetCouponType(string couponType)
		{
			try
			{
				switch (couponType)
				{
					case "Coupon-A": return new CouponA();
					case "Coupon-B": return new CouponB();
					case "Coupon-C": return new CouponC();
					default: return new DefaultCoupon();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		
		}
	}

	/// <summary>
	/// This class will get instantiated 
	/// - If the user does not select any coupon and click on CheckTotal button
	/// - If the user select none option.
	/// </summary>
	public class DefaultCoupon : IProductCouponsAlgoLogic
	{
		public decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection)
		{
			try
			{
				decimal totalAmount = 0;
				foreach (var item in productCartCollection)
				{
					totalAmount += item.productUnitPrice * item.productUnitcount;
				}
				return totalAmount;
			}
			catch (Exception ex)
			{
				throw ex;
			}			
		} 	
	}

	/// <summary>
	/// This class will get instantiated 
	/// If the user selects CouponA and click on CheckTotal button.
	/// </summary>
	public class CouponA : IProductCouponsAlgoLogic
	{
		public decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection)
		{
			try
			{
				decimal totalAmount = 0;
				foreach (var item in productCartCollection)
				{
					if (item.productUnitcount == 0)
						continue;
					else
					{
						if (item.productId.Equals('A'))
						{
							int count = item.productUnitcount;
							if (count >= 3)
							{
								totalAmount += 130;
								count -= 3;
							}
							if (count > 0)
								totalAmount += count * item.productUnitPrice;
						}
						else
						{
							totalAmount += item.productUnitPrice * item.productUnitcount;
						}
					}
				}
				return totalAmount;
			}
			catch (Exception ex)
			{
				throw ex;
			}		
		}
	}
	
	/// <summary>
	/// This class will get instantiated 
	/// If the user selects CouponB and click on CheckTotal button.
	/// </summary>
	public class CouponB : IProductCouponsAlgoLogic
	{
		public decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection)
		{
			try
			{
				decimal totalAmount = 0;

				foreach (var item in productCartCollection)
				{
					if (item.productUnitcount == 0)
						continue;
					else
					{
						if (item.productId.Equals('B'))
						{
							int count = item.productUnitcount;
							if (count >= 2)
							{
								totalAmount += 45;
								count -= 2;
							}
							if (count > 0)
								totalAmount += count * item.productUnitPrice;
						}
						else
						{
							totalAmount += item.productUnitPrice * item.productUnitcount;
						}
					}
				}
				return totalAmount;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}	
	}

	/// <summary>
	/// This class will get instantiated 
	/// If the user selects CouponC and click on CheckTotal button.
	/// </summary>
	public class CouponC : IProductCouponsAlgoLogic
	{
		public decimal CalculationBasedOnCouponLogic(List<ProductCartModel> productCartCollection)
		{
			try
			{
				decimal totalAmount = 0;

				StringBuilder productCombination = new StringBuilder();

				foreach (var item in productCartCollection)
				{
					if (item.productUnitcount == 0)
						continue;
					else
					{
						var productId = item.productId;
						if (item.productId.Equals('C') || item.productId.Equals('D'))
						{
							int count = item.productUnitcount;
							if (count == 1)
							{
								productCombination.Append(Char.ToString(item.productId));
							}
							else
							{
								count -= 1;
								totalAmount += count * item.productUnitPrice;
								productCombination.Append(Char.ToString(item.productId));
							}
						}
						else
						{
							totalAmount += item.productUnitcount * item.productUnitPrice;
						}
					}
				}
				if (productCombination.ToString().Equals("CD"))
					totalAmount += 30;
				else
				  if (productCombination.ToString().Equals("C"))
					totalAmount += productCartCollection.Where(x => x.productId == 'C').Select(x => x.productUnitPrice).FirstOrDefault();
				else
					totalAmount += productCartCollection.Where(x => x.productId == 'D').Select(x => x.productUnitPrice).FirstOrDefault();

				return totalAmount;
			}
			catch (Exception ex)
			{
				throw ex;
			}	
		}
	}
}
