using File_Folder_Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipperExtension.Commands
{
    [Command(PackageIds.ZipSettings)]
    internal sealed class ZipSettings : BaseCommand<ZipSettings>
    {
        protected override void Execute(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }
    }
}
