using System;

namespace FormsDataScriptGenerator.Entities
{
    [Serializable]
    public class FieldTypeItem
    {
        protected bool Equals(FieldTypeItem other)
        {
            return FieldType == other.FieldType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FieldTypeItem) obj);
        }

        public override int GetHashCode()
        {
            return (int) FieldType;
        }

        public string Name { get; set; }
        public FieldTypes FieldType { get; set; }

        public FieldTypeItem()
        {
        }

        public FieldTypeItem(string name, FieldTypes fieldType)
        {
            Name = name;
            FieldType = fieldType;
        }

        public FieldTypeItem(FieldTypes fieldType)
        {
            Name = fieldType.ToString();
            FieldType = fieldType;
        }
    }
}