using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Documents;
using FormsDataScriptGenerator.Entities;

namespace FormsDataScriptGenerator
{
    public class LoadSaveProvider
    {
        public void Save(List<FieldItem> list, string pathToFile)
        {
            try
            {
                using (Stream stream = File.Open(pathToFile, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, list);
                }
            }
            catch (IOException)
            {
            }
        }

        public List<FieldItem> Load(string pathToFile)
        {
            try
            {
                using (Stream stream = File.Open(pathToFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var list = (List<FieldItem>)bin.Deserialize(stream);

                    return list;

                }
            }
            catch (IOException)
            {
            }

            return null;
        }
    }
}