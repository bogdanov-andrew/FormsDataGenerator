using System.IO;
using System.Text;

namespace FormsDataScriptGenerator.Generators
{
    public abstract class BaseGenerator
    {
        public abstract string ResultFileDir { get; }
        public abstract string ResultFileName { get; }

        public void SaveToFile(StringBuilder stringBuilder)
        {
            using (TextWriter writer = File.CreateText(Path.Combine(ResultFileDir, ResultFileName)))
            {
                writer.Write(stringBuilder);
            }
        }
    }
}