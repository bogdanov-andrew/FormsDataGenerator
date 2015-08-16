using System.Collections.Generic;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator.Providers
{
    public interface IFieldsProvider
    {
        List<FieldItem> GetFieldsList();
    }
}