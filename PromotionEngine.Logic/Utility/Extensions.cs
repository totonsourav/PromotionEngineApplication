using Microsoft.Extensions.DependencyInjection;

using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Logic.Abstract;
using PromotionEngine.Logic.Logic.Implementation;

namespace PromotionEngine.Logic.Utility
{
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
