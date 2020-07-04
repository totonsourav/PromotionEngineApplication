using PromotionEngine.Logic.Logic.Interface;

namespace PromotionEngine.Logic.Logic.Abstract
{
	/// <summary>
	/// This abstract class is responsible for creating the selected coupon object 
	/// based on the user's selection.
	/// It uses the Factory pattern to create the selected coupon instance 
	/// </summary>
	public abstract class AProductCouponsAlgoLogic
	{
		public abstract IProductCouponsAlgoLogic GetCouponType(string couponType);
	}
}
