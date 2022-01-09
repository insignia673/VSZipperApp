using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace ZipperExtension.Utils
{
    public class Zip
    {
        public static List<string> DirectoriesExcluded { get; set; } = new List<string>() { "bin", "obj" };
        public static List<string> FilesExcluded { get; set; } = new List<string>();
        public static void ZipProject(string path, string targetName)
        {
            var temp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var target = new DirectoryInfo(path + "\\" + targetName + temp);
            var info = new DirectoryInfo(path);

            var targetPath = path + "\\" + targetName + ".zip";
            if (File.Exists(targetPath))
                File.Delete(targetPath);

            CopyAll(info, target);

            ZipFile.CreateFromDirectory(target.FullName, targetPath);
            target.Delete(true);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                if (FilesExcluded.Contains(fi.Name))
                    continue;

                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                // exclude unwanted director and temporary dir if needed
                if (DirectoriesExcluded.Contains(diSourceSubDir.Name) || diSourceSubDir.Name == target.Name)
                    continue;

                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
