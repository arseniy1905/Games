using IronLogic.OCS.Admin.Common.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using NLog.Targets;
using NLog.Targets.Wrappers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace IronLogic.OCS.Admin.Common.NLogConfig
{
    public class SetConnectionStringMiddleware
    {
        private readonly RequestDelegate _next;
        public SetConnectionStringMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            SetTargetConnectionString("dbOCS", config);
            NLog.LogManager.ConfigurationReloaded += (sender, e) =>
            {
                SetTargetConnectionString("dbOCS", config);
            };
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }

        [ExcludeFromCodeCoverage]
        private void SetTargetConnectionString(string targetName, IConfiguration config)
        {
            var conn = config.GetSection("Services").Get<List<ServiceConfig>>()
                             .FirstOrDefault(x => x.Active && x.Connection != null)?.Connection;

            var dbTarget = ((AsyncTargetWrapper)NLog.LogManager.Configuration.FindTargetByName(targetName)).WrappedTarget as DatabaseTarget;
            dbTarget.ConnectionString = conn;
            NLog.LogManager.ReconfigExistingLoggers();
        }
    }

    [ExcludeFromCodeCoverage]
    public static class SetConnectionStringMiddlewareExtensions
    {
        public static IApplicationBuilder SetNLogDbConnectionString(
            this IApplicationBuilder builder, IConfiguration config)
        {
            return builder.UseMiddleware<SetConnectionStringMiddleware>(config);
        }
    }
}
