using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Folder_Selector
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        public void ChangeLabel(string value)
        {
            InvokeUI(() =>
            {
                this.progressLabel.Text = value;
            });
        }

        private void InvokeUI(Action action) => this.BeginInvoke(action);
    }
}
