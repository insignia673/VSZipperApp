using File_Folder_Selector.Structs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZipperExtension.Utils;

namespace ZipperExtension.Commands
{
    [Command(PackageIds.ZipSolution)]
    internal sealed class ZipSolution : BaseCommand<ZipSolution>
    {
        public Options Options { get; set; }
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            Options = new File_Folder_Selector.Utils.Settings().Options;

            var activeItem = await VS.Solutions.GetActiveItemAsync();
            var projectPath = activeItem.FullPath.ToString().Replace(@$"\{activeItem.Name}", "");

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.RestoreDirectory = true;
            saveDialog.InitialDirectory = projectPath;
            saveDialog.FileName = $"{activeItem.Name.Replace(".sln", "")}.zip";
            saveDialog.Filter = "zip files (*.zip)|*.zip";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var name = Path.GetFileName(saveDialog.FileName).Replace(".zip", "");
                var targetPath = saveDialog.FileName.Replace($"\\{name}.zip", "") + "\\";

                if (Options.CreateZipFolder && !targetPath.EndsWith("Zipped Projects\\"))
                {
                    targetPath += "Zipped Projects\\";
                }

                await Task.Run(() => Zip.ZipProject(projectPath, targetPath, name, Options));
                await VS.MessageBox.ShowAsync($"Added zipped project to {name}.zip");
            }
        }
    }
}
