using System.Windows.Forms;
using ZipperExtension.Utils;

namespace ZipperExtension
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
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

                Zip.ZipProject(projectPath, name);
                await VS.MessageBox.ShowWarningAsync($"Adding zipped project to {name}.zip", "Button clicked");
            }
        }
    }
}
