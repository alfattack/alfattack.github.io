using System;
using Site.Wasm.Services;

namespace Site.Wasm.Config
{
	public static class ServiceRegistry
	{
		public static void RegisterServices(IServiceCollection services)
		{
			services.AddScoped<IPaintingListService, PaintingListService>();
        }
	}
}

