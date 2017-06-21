#if NETSTANDARD1_6
using System.Security.Cryptography;
using Microsoft.AspNetCore.Builder;
#elif NET461
using Microsoft.Owin.Extensions;
using Owin;
#endif

namespace Hawk.Middleware.Extensions
{
    public static class HawkAuthenticationExtension
    {


#if NETSTANDARD1_6
  

#elif NET461
        public static IAppBuilder UseHawkAuthentication(this IAppBuilder app, HawkAuthenticationOptions options)
        {
            app.Use(typeof(HawkAuthenticationMiddleware), app, options);
            app.UseStageMarker(PipelineStage.Authenticate);
            return app;
        }
#endif
    }
}
