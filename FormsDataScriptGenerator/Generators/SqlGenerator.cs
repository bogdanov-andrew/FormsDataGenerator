using System;
using System.Collections.Generic;
using System.Text;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator.Generators
{
    public class SqlGenerator : BaseGenerator
    {
        private readonly string _resultFileName = string.Empty;
        private readonly string _resultFileDir = string.Empty;
        private readonly string _sqlTemplate = string.Empty;

        public override string ResultFileDir
        {
            get { return _resultFileDir; }
        }

        public override string ResultFileName
        {
            get { return _resultFileName; }
        }

        public SqlGenerator()
        {
            _resultFileName = (string)Properties.Settings.Default["SQLFileName"];
            _resultFileDir = (string)Properties.Settings.Default["ResultFolder"];
            _sqlTemplate = (string)Properties.Settings.Default["SQLTemplate"];
        }

        public void Generate(List<FieldItem> fields, Guid formId)
        {
            int orderNumber = 1;
            
            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldItem field in fields)
            {
                string generatedLine = string.Format(_sqlTemplate, 
                    FormatGuidFields(field.Id),
                    FormatGuidFields(formId), 
                    (int)field.FieldType.FieldType, 
                    field.Key, 
                    field.Title,
                    orderNumber, 
                    field.LookupIdFormatted);

                stringBuilder.AppendLine(generatedLine);

                stringBuilder.AppendLine(Environment.NewLine);

                orderNumber++;
            }

            SaveToFile(stringBuilder);
        }

        private string FormatGuidFields(Guid guid)
        {
            return string.IsNullOrEmpty(guid.ToString()) ? "NULL" : string.Format("'{0}'", guid);
        }
    }
}