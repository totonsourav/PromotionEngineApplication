using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PromotionEngine.Logic.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductCartModel : ProductDetailsModel
    {
		[DisplayName("Buy")]
		[Range(0, Int32.MaxValue,ErrorMessage = "This field must be equal or greater than 0")]
		[Required(ErrorMessage = "This field cannot be empty")]
		public int productUnitcount { get; set; }

		public ProductCartModel() { }

		public ProductCartModel(Char productId, decimal productUnitPrice, int productUnitcount=0)
		{
			this.productId = productId;
			this.productUnitPrice = productUnitPrice;
			this.productUnitcount = this.productUnitcount;
		}
	}
}
