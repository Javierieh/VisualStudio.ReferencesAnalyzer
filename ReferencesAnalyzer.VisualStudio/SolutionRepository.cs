using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesAnalyzer.VisualStudio
{
    public class SolutionRepository
    {
        public static Solution FindSolution(string sourceFilePath)
        {
            var directoryPath = Path.GetDirectoryName(sourceFilePath);

            while (!string.IsNullOrWhiteSpace(directoryPath))
            {
                var solutionFiles = Directory.GetFiles(directoryPath, "*.sln", SearchOption.TopDirectoryOnly);
                if(solutionFiles.Length == 1)
                {
                }
                var parentDirectory = Directory.GetParent(directoryPath);
                directoryPath = parentDirectory == null ? null : parentDirectory.FullName;
            }

            return null;
        }
    }
}
