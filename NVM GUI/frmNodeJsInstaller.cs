using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NVM_GUI
{
    public partial class frmNodeJsInstaller : Form
    {
        Version _version;
        public frmNodeJsInstaller(Version version)
        {
            InitializeComponent();
            _version = version;
        }

        private async void frmNodeJsInstaller_Load(object sender, EventArgs e)
        {
            try
            {
                if (_version is null) throw new Exception("Invalid version");
                await Nvm.UseNode(_version);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
