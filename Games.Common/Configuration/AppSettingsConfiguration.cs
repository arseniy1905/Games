using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Games.Common.Configuration
{
    public static class AppSettingsConfiguration
    {
        public static IConfiguration Configuration { get; set; }
        public static bool? IsDev = null;
        public static string _B2BWebUploadsCloudStorageConnstr = string.Empty;
        public static string _B2BPrivateWebUploadsCloudStorageConnstr = string.Empty;
        
        //public static string GetConnectionString()
        //{
        //    var configs = Configuration.GetSection("Services").Get<List<ServiceConfig>>()[0];

        //    return configs.Connection;

        //}

        public static string GetConnectionString()
        {
           
            if(IsDevEnvironment())
            {
                var configs = Configuration.GetSection("Services").Get<List<ServiceConfig>>()[0];
                return configs.Connection;
            }
            else
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

                var str = config.GetConnectionString("WebConnStr");
                return str;
            }
            
        }

        public static bool IsDevEnvironment()
        {
            if(IsDev.HasValue == false)
            {
                var configs = Configuration.GetSection("Services").Get<List<ServiceConfig>>()[0];
                IsDev = configs.IsDevEnvironment;
            }
            return IsDev.Value;
        }

        public static string GetAzApplicationSetting(string AzApplicationSettingKey)
        {
            var appSettingValue = Environment.GetEnvironmentVariable(AzApplicationSettingKey);
            return appSettingValue;
        }

        public static string GetB2BWebUploadsCloudStorageConnstr()
        {
            if (string.IsNullOrEmpty(_B2BWebUploadsCloudStorageConnstr))
            {
                if (!IsDevEnvironment())
                {
                    _B2BWebUploadsCloudStorageConnstr = GetAzApplicationSetting("B2BWebUploadsCloudStorageConnstr");
                }
                else
                {
                    _B2BWebUploadsCloudStorageConnstr = Configuration.GetSection("Services").Get<List<ServiceConfig>>()
                                                         .FirstOrDefault(x => x.Active && x.CloudStorageConnStr != null)?
                                                         .CloudStorageConnStr;
                }
            }
            return _B2BWebUploadsCloudStorageConnstr;
        }

        public static string GetB2BPrivateWebUploadsCloudStorageConnstr()
        {
            if (string.IsNullOrEmpty(_B2BPrivateWebUploadsCloudStorageConnstr))
            {
                if (!IsDevEnvironment())
                {
                    _B2BPrivateWebUploadsCloudStorageConnstr = GetAzApplicationSetting("B2BPrivateWebUploadsCloudStorageConnstr");
                }
                else
                {
                    _B2BPrivateWebUploadsCloudStorageConnstr = Configuration.GetSection("Services").Get<List<ServiceConfig>>()
                                                         .FirstOrDefault(x => x.Active && x.PrivateCloudStorageConnStr != null)?
                                                         .PrivateCloudStorageConnStr;
                }
            }
            return _B2BPrivateWebUploadsCloudStorageConnstr;
        }
    }
}
