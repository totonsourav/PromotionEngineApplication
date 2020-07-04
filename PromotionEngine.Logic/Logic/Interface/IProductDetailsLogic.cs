using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Interface
{
	/// <summary>
	/// Interface which depicts the methods related to the whereabouts of each product
	/// </summary>
	public interface IProductDetailsLogic
    {
		ProductBuyModel GetAllProductsWithDetails();
    }
}
