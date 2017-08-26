using CommandLine;
using CommandLine.Text;

namespace Alteridem.GetChanges
{
    public class Options
    {
        [Option('o', "org", Required = true, HelpText = "The GitHub user or organization")]
        public string Organization { get; set; }

        [Option('r', "repo", Required = true, HelpText = "The GitHub repository")]
        public string Repository { get; set; }

        [Option('l', "link", HelpText = "Link issue numbers to the issues")]
        public bool LinkIssues { get; set; }

        [HelpOption]
        public string GetUsage() => HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
    }
}
