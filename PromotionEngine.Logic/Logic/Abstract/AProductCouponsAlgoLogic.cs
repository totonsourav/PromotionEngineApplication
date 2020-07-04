using PromotionEngine.Logic.Logic.Interface;

namespace PromotionEngine.Logic.Logic.Abstract
{
	public abstract class AProductCouponsAlgoLogic
	{
		public abstract IProductCouponsAlgoLogic GetCouponType(string couponType);
	}
}
