using System;

namespace FormsDataScriptGenerator.Entities
{
    [Serializable]
    public class FieldItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Key { get; set; }
        public string LookupId { get; set; }
        public FieldTypeItem FieldType { get; set; }

        public string LookupIdFormatted
        {
            get { return string.IsNullOrEmpty(LookupId) ? "NULL" : string.Format("'{0}'",LookupId); }
        }

        public string IdFormatted
        {
            get { return string.IsNullOrEmpty(LookupId) ? "NULL" : string.Format("'{0}'", Id); }
        }

        public FieldItem(Guid id, FieldTypeItem fieldType)
        {
            Id = id;
            FieldType = fieldType;
        }

        public FieldItem(string title, string key, string lookupId, FieldTypeItem fieldType)
        {
            Title = title;
            Key = key;
            LookupId = lookupId;
            FieldType = fieldType;
        }
    }
}