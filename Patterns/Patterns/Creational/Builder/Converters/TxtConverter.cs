using System;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace Patterns.Creational.Builder.Converters
{
    class TxtConverter : Converter
    {
        private const WdSaveFormat SaveFormat = WdSaveFormat.wdFormatText;

        public override void ConvertRtfDocument(Document document, string outputFileName)
        {
            if (Path.GetExtension(outputFileName).ToLower() == ".txt")
            {
                document.SaveAs2(outputFileName, SaveFormat);
            }
            else
            {
                throw new Exception("Wrong extension of output file name. Must be .txt");
            }
        }
    }
}
