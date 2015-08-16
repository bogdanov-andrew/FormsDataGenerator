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
            get { return string.IsNullOrEmpty(LookupId) ? "NULL" : LookupId; }
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