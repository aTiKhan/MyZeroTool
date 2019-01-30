using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZeroTool
{
    public static class Settings
    {
        public static string RootPath { get; set; }
        public static string NewCompanyName { get; set; }
        public static string NewProjectName { get; set; }

        public static bool RenameDirectories { get; set; } = true;
        public static bool RenameFiles { get; set; } = true;
        public static bool UpdateFileContents { get; set; } = true;

        public static string[] SourceFileExtensions { get; set; } =
        {
            ".xaml", // mobile 
            ".html", ".js", ".ts", ".cshtml",
            ".cs", ".csproj", ".sln", ".config", ".user",
            ".json", ".txt", ".ps1", ".yml", ".nswag", ".conf", "Dockerfile", ".gitignore"
        };
        public static string ExistingCompanyName { get; set; } = "MyCompanyName";
        public static string ExistingProjectName { get; set; } = "AbpZeroTemplate";

    }
}
