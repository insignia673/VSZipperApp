using File_Folder_Selector.Structs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace File_Folder_Selector.Utils
{
    public class Settings
    {
        public Options Options;
        private static string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VSZipperExtension";
        private static string file = @"\ZipperSettings.json";
        public Settings()
        {
            if (File.Exists($"{directory + file}") == false)
            {
                Directory.CreateDirectory(directory);
                File.Create($"{directory + file}").Dispose();

                //write default settings
                var dict = new Dictionary<string, bool>()
                {
                    { "bin", true },
                    { "obj", true },
                    { ".git", true },
                    { ".vs", true}
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
            File.WriteAllText($"{directory + file}", json);
        }

        public Options GetOptions()
        {
            var text = File.ReadAllText($"{directory + file}");
            var data = JsonConvert.DeserializeObject<Options>(text);
            return data;
        }
    }
}
