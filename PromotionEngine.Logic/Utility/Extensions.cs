using Microsoft.Extensions.DependencyInjection;
using PromotionEngine.Logic.Logic.Abstract;
using PromotionEngine.Logic.Logic.Implementation;
using PromotionEngine.Logic.Logic.Interface;

namespace PromotionEngine.Logic.Utility
{
	/// <summary>
	/// This class includes all the methods related to extension methods
	/// </summary>
	public static class IServiceCollectionExtension
	{
		public static IServiceCollection AddPromotionEngineLogicLibrary(this IServiceCollection services)
		{
			services.AddTransient<IProductDetailsLogic, ProductDetailsLogic>();
			services.AddTransient<IProductCartLogic, ProductCartLogic>();
			services.AddTransient<IProductPromotionLogic, ProductPromotionLogic>();
			services.AddTransient<AProductCouponsAlgoLogic, ProductCouponsAlgoLogic>();

			return services;
		}
	}
}
