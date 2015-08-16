using System.Collections.Generic;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator.Providers
{
    public class FieldsTypeProvider
    {
        public List<FieldTypeItem> GetFieldTypes()
        {
            List<FieldTypeItem> types = new List<FieldTypeItem>();
            types.Add(new FieldTypeItem(FieldTypes.CheckBox));
            types.Add(new FieldTypeItem(FieldTypes.CheckBoxList));
            types.Add(new FieldTypeItem(FieldTypes.ComboBox));
            types.Add(new FieldTypeItem(FieldTypes.Date));
            types.Add(new FieldTypeItem(FieldTypes.DateTime));
            types.Add(new FieldTypeItem(FieldTypes.Numeric));
            types.Add(new FieldTypeItem(FieldTypes.RadioButtonList));
            types.Add(new FieldTypeItem(FieldTypes.TextArea));
            types.Add(new FieldTypeItem(FieldTypes.TextBox));
            types.Add(new FieldTypeItem(FieldTypes.Time));

            return types;
        }
    }
}