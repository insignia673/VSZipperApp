using File_Folder_Selector.Structs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Folder_Selector.Utils
{
    public class Settings
    {
        public Options Options;
        public Settings()
        {
            if (File.Exists("ZipperSettings.json") == false)
            {
                File.Create("ZipperSettings.json").Dispose();

                //write default settings
                var dict = new Dictionary<string, bool>()
                {
                    { "bin", true },
                    { "obj", true }
                };
                bool createZip = true;

                Options = new Options(dict, createZip);

                Save();
            }
            else
                Options = GetOptions();
        }
        ~Settings() { }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(Options, Formatting.Indented);
            File.WriteAllText("ZipperSettings.json", json);
        }

        public Options GetOptions()
        {
            var text = File.ReadAllText("ZipperSettings.json");
            var data = JsonConvert.DeserializeObject<Options>(text);
            return data;
        }
    }
}
