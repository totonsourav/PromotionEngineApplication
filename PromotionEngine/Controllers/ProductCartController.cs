using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromotionEngine.Core.Utility;
using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;
using System;

namespace PromotionEngine.Core.Controllers
{
	/// <summary>
	/// This controller includes all the functions related to the items which the user has added
	/// to the cart so that he/she can progress for buying
	/// </summary>
	public class ProductCartController : Controller
    {
		  IProductCartLogic _productCartLogic = null;
		  public ProductCartController(IProductCartLogic productCartLogic)
		  {
				_productCartLogic = productCartLogic;
		  }
		  /// <summary>
		  /// Get the total amount of the items which the user has added into the cart for the checkout process
		  /// </summary>
		  /// <param name="collection"></param>
		  /// <returns></returns>
		  // POST: ProductCart/Create
		  [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetProductCardTotal(IFormCollection collection)
        {
			try
			{
				var productCartModel = (HttpContext.Session.GetObject<ProductBuyModel>("productBuyModel")).productCartModel;
				if (ModelState.IsValid)
				{
					var productUnitCountValues = collection["item.productUnitcount"];
					var productCouponApplied = collection["Coupon"].ToArray().Length !=0 ? (collection["Coupon"].ToArray()[0]).ToString() : "";

					int i= 0;
					foreach (var item in productCartModel)
					{
						item.productUnitcount = Convert.ToInt32(productUnitCountValues.ToArray()[i]);
						i++;
					}

					var productBuyModel = _productCartLogic.CalculateTotalFromProductCart(productCartModel, productCouponApplied);
					HttpContext.Session.SetObject("productBuyModel", productBuyModel);

					return RedirectToAction("GetAllProductsWithDetails", "ProductDetails");
				}
				else
				{
					return RedirectToAction("GetAllProductsWithDetails", "ProductDetails");
				}
			}
			catch(Exception ex)
			{
				return RedirectToAction("GetAllProductsWithDetails", "ProductDetails");
			}
        }
    }
}