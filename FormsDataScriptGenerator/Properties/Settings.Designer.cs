﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormsDataScriptGenerator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"INSERT INTO iep.FormFieldDefinition (
      FormFieldDefinitionId ,
      FormDefinitionId ,
      [Type] ,
      FormFieldDefinitionKey ,
      Title ,
      RenderTitle ,
      ListOrientation ,
      OrderNumber ,
      IsCustom ,
      IsActive ,
      LookupTypeId
) VALUES (
       /* FormFieldDefinitionId - uniqueidentifier */ {0},
       /* FormDefinitionId - uniqueidentifier */ {1},
       /* Type - int */ {2},
       /* FormFieldDefinitionKey - nvarchar(250) */ N'{3}',
       /* Title - nvarchar(2000) */ N'{4}' ,
       /* RenderTitle - bit */ 1,
       /* ListOrientation - int */ 0,
       /* OrderNumber - int */ {5},
       /* IsCustom - bit */ 0,
       /* IsActive - bit */ 1,
       /* LookupTypeId - uniqueidentifier */ {6} )")]
        public string SQLTemplate {
            get {
                return ((string)(this["SQLTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\")]
        public string ResultFolder {
            get {
                return ((string)(this["ResultFolder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sqlResult.txt")]
        public string SQLFileName {
            get {
                return ((string)(this["SQLFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dataSetsResult.txt")]
        public string DataSetsFileName {
            get {
                return ((string)(this["DataSetsFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<Field Name=\"{0}\">\r\n          <DataField>{0}</DataField>\r\n          <rd:TypeName>" +
            "{1}</rd:TypeName>\r\n</Field>")]
        public string DataSetTemplate {
            get {
                return ((string)(this["DataSetTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("htmlResults.txt")]
        public string HtmlFileName {
            get {
                return ((string)(this["HtmlFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<div class=\"column\">\r\n\t<div> @{ Html.RenderPartial (\"FormsFields/FormFieldValue\"," +
            "Model.FormFieldValues.GetByKey( \"{0}\")); }</div >\r\n</div>")]
        public string HtmlTemplate {
            get {
                return ((string)(this["HtmlTemplate"]));
            }
        }
    }
}
