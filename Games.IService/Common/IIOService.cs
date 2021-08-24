using Games.Common.Configuration;

namespace Games.IService.Common
{
    public interface IIOService : ICommonService
    {
        string GetImageFile(string folderName, string imageFile);
        DirectoryConfig GetDirectoryConfig(string directoryName, DirectoryConfig root = null);
        string GetFilePath(DirectoryConfig directory, string fileName);
        
    }
}
