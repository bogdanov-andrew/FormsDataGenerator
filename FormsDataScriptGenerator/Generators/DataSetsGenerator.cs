using System;
using System.Collections.Generic;
using System.Text;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator.Generators
{
    public class DataSetsGenerator : BaseGenerator
    {
        private readonly string _resultFileName = string.Empty;
        private readonly string _resultFileDir = string.Empty;
        private readonly string _dataSetTemplate = string.Empty;

        public override string ResultFileDir
        {
            get { return _resultFileDir; }
        }

        public override string ResultFileName
        {
            get { return _resultFileName; }
        }

        public DataSetsGenerator()
        {
            _resultFileName = (string)Properties.Settings.Default["DataSetsFileName"];
            _resultFileDir = (string)Properties.Settings.Default["ResultFolder"];
            _dataSetTemplate = (string)Properties.Settings.Default["DataSetTemplate"];
        }

        public void Generate(List<FieldItem> fields, Guid formId)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldItem field in fields)
            {
                string generatedLine = string.Format(_dataSetTemplate, field.Key, ResolveType(field.FieldType.FieldType));
                stringBuilder.AppendLine(generatedLine);
                //stringBuilder.AppendLine(Environment.NewLine);
            }

            SaveToFile(stringBuilder);
        }


        private string ResolveType(FieldTypes fieldType)
        {
            switch (fieldType)
            {
                case FieldTypes.CheckBox:
                    return "System.Boolean";
                case FieldTypes.Time:
                case FieldTypes.Date:
                case FieldTypes.DateTime:
                    return "System.DateTime";
                case FieldTypes.CheckBoxList:
                case FieldTypes.ComboBox:
                case FieldTypes.Numeric:
                case FieldTypes.RadioButtonList:
                case FieldTypes.TextArea:
                    return "System.String";
                default:
                    return "System.String";
            }
        }
        
    }
}