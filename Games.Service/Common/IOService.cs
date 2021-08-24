using AutoMapper;
using Games.Common.Configuration;
using Games.IService.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IronLogic.OCS.Admin.Service.Common
{
    public class IOService : AbstractCommonService, IIOService
    {
        protected readonly List<DirectoryConfig> _directories;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IOService(IConfiguration configuration, IWebHostEnvironment hostingEnvironment, IHttpContextAccessor httpContextAccessor) : base(configuration, hostingEnvironment)
        {
            _httpContextAccessor = httpContextAccessor;
            var directorySection = _configuration.GetSection("Directories");
            _directories = directorySection.Get<List<DirectoryConfig>>();
        }

        protected override Action<IMapperConfigurationExpression> MapperConfig => cfg =>
        {
        };
        public string GetImageFile(string folderName, string imageFile)
        {
            var returnPath = "";

            var imageDirectoryConfig = GetDirectoryConfig("Images");
            if (imageDirectoryConfig == null)
            {
                throw (new KeyNotFoundException("The key named 'Images' could not find in the 'Directories' section of the configuration file"));
            }
            var directory = GetDirectoryConfig(folderName, imageDirectoryConfig);
            if (directory == null)
            {
                throw (new KeyNotFoundException(string.Format("The key named '{0}' could not find in the 'Directories' section of the configuration file", folderName)));
            }
            var imageDirectoryContents = _hostingEnvironment.WebRootFileProvider.GetDirectoryContents(imageDirectoryConfig.Path);
            if (!imageDirectoryContents.Exists)
            {
                throw (new DirectoryNotFoundException(string.Format("Could not find directory named '{0}' in the '{1}' folder", imageDirectoryConfig.Path, _hostingEnvironment.WebRootPath)));
            }
            var directoryPath = Path.Combine(imageDirectoryConfig.Path, directory.Path);
            var directoryContents = _hostingEnvironment.WebRootFileProvider.GetDirectoryContents(directoryPath);
            if (!directoryContents.Exists)
            {
                throw (new DirectoryNotFoundException(string.Format("Could not find directory named '{0}' in the '{1}' folder", directory.Path, _hostingEnvironment.WebRootPath)));
            }
            var relativeFilePath = Path.Combine(directoryPath, imageFile);
            var fileInfo = _hostingEnvironment.WebRootFileProvider.GetFileInfo(relativeFilePath);
            //directoryPath = Path.Combine(_hostingEnvironment.WebRootPath, directoryPath);// get absolute directory path
            string physicalPath = string.Empty;
            if (!fileInfo.Exists)
            {
                physicalPath = Path.Combine(directoryPath, string.Format("{0}.{1}", directory.FileNotAvailable.Path, directory.FileNotAvailable.Extension));


            }
            else
            {
                physicalPath = Path.Combine(directoryPath, fileInfo.Name);
            }
            if (physicalPath != string.Empty)
            {

                returnPath = string.Format("/{0}", physicalPath.Replace(@"\", "/").Trim());
            }
            return returnPath;
        }
        public DirectoryConfig GetDirectoryConfig(string directoryName, DirectoryConfig root = null)
        {
            var directoryConfig = null as DirectoryConfig;
            if (root == null)
            {
                return _directories.SingleOrDefault(d => d.Name == directoryName);

            }
            return root.SubDirectories == null ? null : root.SubDirectories.SingleOrDefault(d => d.Name == directoryName);
        }

        public string GetFilePath(DirectoryConfig directory, string fileName)
        {
            if (directory == null)
            {
                throw (new KeyNotFoundException("The key named 'Images' could not find in the 'Directories' section of the configuration file"));
            }
            var directoryContents = _hostingEnvironment.WebRootFileProvider.GetDirectoryContents(directory.Path);
            if (!directoryContents.Exists)
            {
                throw (new DirectoryNotFoundException(string.Format("Could not find directory named '{0}' in the '{1}' folder", directory.Path, _hostingEnvironment.WebRootPath)));
            }
            var relativeFilePath = Path.Combine(directory.Path, fileName);
            var fileInfo = _hostingEnvironment.WebRootFileProvider.GetFileInfo(relativeFilePath);
            
            string physicalPath;
            if (fileInfo.Exists)
            {
                physicalPath = fileInfo.PhysicalPath;
            }
            else
            {
                physicalPath = Path.Combine(_hostingEnvironment.ContentRootPath, directory.Path, fileName);
            }
            return physicalPath;
        }
        
    }
}
