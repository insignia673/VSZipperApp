using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Folder_Selector.Structs
{
    public struct Options
    {
        public Options(Dictionary<string, bool> dict, bool createZip)
        {
            FileDirSettings = dict;
            CreateZipFolder = createZip;
        }
        public Dictionary<string, bool> FileDirSettings { get; set; }
        public bool CreateZipFolder { get; set; }
    }
}
