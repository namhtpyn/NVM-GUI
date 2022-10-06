using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVM_GUI
{
    internal static class NodeJs
    {
        private static readonly Octokit.GitHubClient _git = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("nvm"));
        private static readonly string _owner = "nodejs";
        private static readonly string _repo = "node";

        public static async Task<IEnumerable<Version>> GetAvaiableVersions()
        {
            return await _git.Repository.GetAllTags(_owner, _repo, new Octokit.ApiOptions() { PageSize = 100, PageCount = 1 }).ContinueWith(value => value.Result.Select(tag => new Version(tag.Name.Trim('v'))));
        }

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

        public static async Task<Version> GetVersion()
        {
            var result = await Command("-v");

            return new Version(result.Trim('v'));
        }

        private static async Task<string> Command(string args)
        {
            var process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.StartInfo.FileName = "node.exe";
            process.StartInfo.Arguments = args;

            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            await process.WaitForExitAsync();

            return output;
        }
    }
}
