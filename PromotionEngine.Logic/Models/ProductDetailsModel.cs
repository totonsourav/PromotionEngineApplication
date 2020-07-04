using System;
using System.ComponentModel;

namespace PromotionEngine.Logic.Models
{
	/// <summary>
	/// This class includes the properties related to the product information w.r.t:
	/// the product id and the product unit price 
	/// </summary>
	public class ProductDetailsModel
	 {
		[DisplayName("Unit")]
		public Char productId { get; set; }

		[DisplayName("Price")]
		public decimal productUnitPrice { get; set; }

		public ProductDetailsModel() { }

		public ProductDetailsModel(Char productId, decimal productUnitPrice) {
			this.productId = productId;
			this.productUnitPrice = productUnitPrice;
		}
	 }
}
