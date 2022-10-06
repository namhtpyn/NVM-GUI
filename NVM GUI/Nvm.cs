using System.Diagnostics;

namespace NVM_GUI
{
    internal static class Nvm
    {
        private static readonly Octokit.GitHubClient  _git = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("nvm"));
        private static readonly string _owner = "coreybutler";
        private static readonly string _repo = "nvm-windows";


        private static readonly string _installer = "nvm-setup.zip";
        public static async Task<bool> IsInstalled()
        {
            try
            {
                await GetVersion();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task Install(Version version)
        {
            var installerPath = await DownloadInstaller(version);
            if (installerPath is null) throw new Exception("Unable to get installer");
            await Process.Start(installerPath, "/verysilent").WaitForExitAsync();
            Directory.Delete(Path.GetDirectoryName(installerPath), true);

        }

        private static async Task<string> DownloadInstaller(Version version)
        {
            var installerUrl = await GetInstallerUrl(version);
            if (installerUrl is null) throw new Exception("Installer not found");

            var folder = Application.StartupPath;
            var fileName = Path.GetFileName(installerUrl.ToString());
            var extension = Path.GetExtension(fileName).Trim('.');
            if (extension != "zip") throw new Exception("Invalid installer download url");

            var http = new HttpClient();
            var response = await http.GetAsync(installerUrl);
            var stream = await response.Content.ReadAsStreamAsync();
            var fs = new FileStream(fileName, FileMode.Create);
            await stream.CopyToAsync(fs);
            fs.Close();
            stream.Close();

            folder = Path.Combine(folder, Path.GetFileNameWithoutExtension(fileName));
            System.IO.Compression.ZipFile.ExtractToDirectory(fileName, folder, true);
            File.Delete(fileName);

            fileName = Directory.EnumerateFiles(folder, "*.exe").FirstOrDefault();
            if (fileName is null) throw new Exception("Unable to find installer");
            
            return Path.Combine(folder, fileName);
        }

        private static async Task<string?> GetInstallerUrl(Version version)
        {
            var release = await _git.Repository.Release.Get(_owner, _repo, version.ToString());
            return release?.Assets.Where(asset => asset.Name == _installer).FirstOrDefault()?.BrowserDownloadUrl;
        }

        public static async Task<IEnumerable<Version>> GetAvaiableVersions()
        {
            return await _git.Repository.GetAllTags(_owner, _repo, new Octokit.ApiOptions() { PageSize = 100, PageCount = 1 }).ContinueWith(value => value.Result.Select(tag => new Version(tag.Name)));
        }

        public static async Task<Version?> GetLatestVersion()
        {
           return await GetAvaiableVersions().ContinueWith(value => value.Result.FirstOrDefault());
        }

        public static async Task<Version> GetVersion()
        {
            return await Command("version").ContinueWith(value => new Version(value.Result));
        }

        public static async Task<bool> UseNode(Version version)
        {
            try
            {
                await Command($"install {version}");
                await Command($"use {version}");
                return true;
            }
            catch
            {
                return false;
            }
        }


        private static async Task<string> Command(string args)
        {
            var process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.StartInfo.FileName = "nvm.exe";
            process.StartInfo.Arguments = args;

            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            await process.WaitForExitAsync();

            return output;
        }
    }
}
