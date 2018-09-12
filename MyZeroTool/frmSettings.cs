using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyZeroTool
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbECN.Text = Settings.ExistingCompanyName;
            tbEPN.Text = Settings.ExistingProjectName;
            tbSFE.Text = string.Join(",", Settings.SourceFileExtensions);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.ExistingCompanyName = tbECN.Text;
            Settings.ExistingProjectName = tbEPN.Text;
            Settings.SourceFileExtensions = tbSFE.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
