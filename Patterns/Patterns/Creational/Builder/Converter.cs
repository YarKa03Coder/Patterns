using Microsoft.Office.Interop.Word;

namespace Patterns.Creational.Builder
{
    public abstract class Converter
    {
        public abstract void ConvertRtfDocument(Document document, string outputFileName);
    }
}
