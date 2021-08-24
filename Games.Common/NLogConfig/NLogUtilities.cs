using System;

namespace Games.Common.NLogConfig
{
    public class NLogUtilities
    {
        public static string GetNLogConfigFilePath()
        {
            //var solutionName = "Games";
            var mainPath = AppContext.BaseDirectory + "/NLogConfig/nlog.config";
            //return Path.Combine(mainPath.Substring(0, mainPath.IndexOf(solutionName)), $"{ solutionName }.Common\\NLogConfig\\nlog.config");
            return mainPath;
        }
    }
}
