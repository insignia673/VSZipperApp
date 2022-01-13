using File_Folder_Selector;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ZipperExtension.Utils
{
    public class Zip
    {
        public static List<string> Exclusion { get; set; }
        public static void ZipProject(string path, string targetPath, string targetName, File_Folder_Selector.Structs.Options options, LoadingForm form)
        {
            Exclusion = new List<string>();

            var temp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Exclusion.Add("Zipped Projects");

            foreach (var item in options.FileDirSettings)
                if (item.Value)
                    Exclusion.Add(item.Key);

            targetPath += targetName;
            var info = new DirectoryInfo(path);
            var target = new DirectoryInfo(targetPath + temp);

            if (File.Exists(targetPath + ".zip"))
                File.Delete(targetPath + ".zip");

            form.ChangeLabel("Copying data...");
            CopyAll(info, target);

            form.ChangeLabel("Creating zip...");
            ZipFile.CreateFromDirectory(target.FullName, targetPath + ".zip");

            form.ChangeLabel("Finishing up...");
            target.Delete(true);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                if (Exclusion.Contains(fi.Name) ||
                    (Exclusion.Any(x => x[0] == '*' &&
                    fi.Name.EndsWith(new string(x.Skip(1).ToArray())))))
                    continue;

                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                // exclude unwanted director and temporary dir if needed
                if (Exclusion.Contains(diSourceSubDir.Name) || diSourceSubDir.Name == target.Name)
                    continue;

                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
