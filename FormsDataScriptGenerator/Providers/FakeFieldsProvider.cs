using System.Collections.Generic;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator.Providers
{
    public class FakeFieldsProvider : IFieldsProvider
    {
        public List<FieldItem> GetFieldsList()
        {
            List<FieldItem> list = new List<FieldItem>();
            //list.Add(new FieldItem("tt", "rsdf", "sdf", new FieldTypeItem("CheckBox", FieldTypes.CheckBox)));

            return list;
        }
    }
}