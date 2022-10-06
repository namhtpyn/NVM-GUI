using System.Data;
using System.Diagnostics;
using System.Net.Http.Json;

namespace NVM_GUI
{
    public partial class frmNvmInstaller : Form
    {
        Version _version;
        public frmNvmInstaller(Version version)
        {
            InitializeComponent();
            _version = version;
        }

        private async void frmNvmInstaller_Load(object sender, EventArgs e)
        {
            try
            {
                if (_version is null) throw new Exception("Invalid version");
                await Nvm.Install(_version);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

    }
}
