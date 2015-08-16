using System;
using System.Collections.Generic;
using System.Text;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator.Generators
{
    public class HtmlGenerator : BaseGenerator
    {
        private readonly string _resultFileName = string.Empty;
        private readonly string _resultFileDir = string.Empty;
        private readonly string _htmlTemplate = string.Empty;

        public override string ResultFileDir
        {
            get { return _resultFileDir; }
        }

        public override string ResultFileName
        {
            get { return _resultFileName; }
        }

        public HtmlGenerator()
        {
            _resultFileName = (string)Properties.Settings.Default["HtmlFileName"];
            _resultFileDir = (string)Properties.Settings.Default["ResultFolder"];
            _htmlTemplate = (string)Properties.Settings.Default["HtmlTemplate"];
        }

        public void Generate(List<FieldItem> fields, Guid formId)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldItem field in fields)
            {
                string generatedLine = _htmlTemplate.Replace("{0}", field.Key);
                    //string.Format(_htmlTemplate, field.Key);
                stringBuilder.AppendLine(generatedLine);
                stringBuilder.AppendLine(Environment.NewLine);
            }

            SaveToFile(stringBuilder);
        }
    }
}