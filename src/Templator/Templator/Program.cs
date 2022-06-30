using System.Linq;

namespace Templator
{
    class Program
    {
        static void Main(string[] args)
        {
            var templateFiles = TemplateReader.ReadAllTemplates();
            var templateModels = TemplateReader.GetTemplateModels(templateFiles);

            var allTemplateDependencies = templateModels.SelectMany(x => x.TemplateDependencies).Distinct();
        }
    }
}
