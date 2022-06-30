using System.Collections.Generic;
using System.IO;

namespace Templator
{
    public class TemplateFile
    {
        public string Content { get; set; }
    }

    public class TemplateModel
    {
        public string Name { get; set; }
        public string Selector { get; set; }

        public Dictionary<string, string> ConstructorTemplateDependencies { get; set; } = new Dictionary<string, string>();

        public IEnumerable<string> TemplateDependencies { get; set; } = new List<string>();
        public IEnumerable<string> NugetDependencies { get; set; } = new List<string>();
        public IEnumerable<string> InputVariables { get; set; } = new List<string>();
        public IEnumerable<string> GlobalVariables { get; set; } = new List<string>();
        public IEnumerable<string> FoldersToGenerate { get; set; } = new List<string>();
        public IEnumerable<string> FilesToGenerate { get; set; } = new List<string>();
    }
        
    public class TemplateReader
    {
        private const string TemplatePath = "././Templates";

        public static IEnumerable<TemplateFile> ReadAllTemplates()
        {
            var templates = new List<TemplateFile>();

            foreach (string file in Directory.EnumerateFiles(TemplatePath, "*.templCfg"))
            {
                templates.Add(new TemplateFile() { Content = File.ReadAllText(file) });
            }

            return templates;
        }

        public static IEnumerable<TemplateModel> GetTemplateModels(IEnumerable<TemplateFile> templates)
        {
            return new List<TemplateModel>();
        }
    }
}
