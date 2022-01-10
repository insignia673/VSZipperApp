﻿using System.Windows.Forms;
using ZipperExtension.Utils;
using File_Folder_Selector.Utils;
using File_Folder_Selector.Structs;

namespace ZipperExtension
{
    [Command(PackageIds.ZipProject)]
    internal sealed class ZipProject : BaseCommand<ZipProject>
    {
        public Options Options { get; set; }
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            Options = new File_Folder_Selector.Utils.Settings().Options;

            var activeItem = await VS.Solutions.GetActiveItemAsync();
            var projectPath = activeItem.FullPath.ToString().Replace(@$"\{activeItem.Name}.csproj", "");

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.RestoreDirectory = true;
            saveDialog.InitialDirectory = projectPath;
            saveDialog.FileName = $"{activeItem.Name}.zip";
            saveDialog.Filter = "zip files (*.zip)|*.zip";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var name = saveDialog.FileName.Replace(saveDialog.InitialDirectory + "\\", "").Replace(".zip", "");

                Zip.ZipProject(projectPath, name, Options);
                await VS.MessageBox.ShowAsync($"Adding zipped project to {name}.zip");
            }
        }
    }
}