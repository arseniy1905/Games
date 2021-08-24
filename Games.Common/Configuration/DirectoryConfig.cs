using System.Collections.Generic;

namespace Games.Common.Configuration
{
    public class DirectoryConfig
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public IEnumerable<DirectoryConfig> SubDirectories { get; set; }

        public FileConfig FileNotAvailable { get; set; }

    }
}
