namespace NVM_GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            await Task.WhenAll(new Task[]
            {
                DisplayNvmAvailableVersions(),
                DisplayNodeJsAvailableVersions(),
                DisplayNvmInstalledVersion(),
                DisplayNodeJsUsingVersion()
            });
        }

        private async Task DisplayNvmAvailableVersions()
        {
            cbbNvmAvailableVersions.DataSource = await Nvm.GetAvaiableVersions().ContinueWith(value => value.Result.ToList());
        }
        private async Task DisplayNvmInstalledVersion()
        {
            var installed = await Nvm.IsInstalled();
            if (!installed)
            {
                lblNvmInstalledVersion.Text = "Not installed";
                lblNvmInstalledVersion.ForeColor = Color.Red;
                gbNodeJs.Enabled = false;
                return;
            }
            var installedVersion = await Nvm.GetVersion();
            lblNvmInstalledVersion.Text = installedVersion.ToString();

            var latestVersion = await Nvm.GetLatestVersion();
            if (latestVersion?.CompareTo(installedVersion) > 0) lblNvmInstalledVersion.ForeColor = Color.Orange;
            else lblNvmInstalledVersion.ForeColor = Color.Green;
            gbNodeJs.Enabled = true;

        }


        private async Task DisplayNodeJsAvailableVersions()
        {
            var ds = await NodeJs.GetAvaiableVersions().ContinueWith(value => value.Result.ToList());
            cbbNodeJsAvailableVersions.DataSource = ds;

        }

        private async Task DisplayNodeJsUsingVersion()
        {
            var installed = await NodeJs.IsInstalled();
            if (!installed)
            {
                lblNodeJsUsingVersion.Text = "Not installed";
                lblNodeJsUsingVersion.ForeColor = Color.Red;
                return;
            }
            var installedVersion = await NodeJs.GetVersion();
            lblNodeJsUsingVersion.Text = installedVersion.ToString();
            lblNodeJsUsingVersion.ForeColor = Color.Green;

        }

        private async void btnNvmInstall_Click(object sender, EventArgs e)
        {
            var selectedVersion = cbbNvmAvailableVersions.SelectedItem as Version;
            if (selectedVersion is null) return;

            if (new frmNvmInstaller(selectedVersion).ShowDialog() == DialogResult.OK)
                await DisplayNvmInstalledVersion();
            else
                MessageBox.Show("Install failed");
        }

        private async void btnNodeJsUse_Click(object sender, EventArgs e)
        {
            var selectedVersion = cbbNodeJsAvailableVersions.SelectedItem as Version;
            if (selectedVersion is null) return;
            if (new frmNodeJsInstaller(selectedVersion).ShowDialog() == DialogResult.OK)
                await DisplayNodeJsUsingVersion();
            else
                MessageBox.Show("use failed");

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                Hide();

        }

        private void niTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}