using System;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace Patterns.Creational.Builder.Converters
{
    class XpsConverter : Converter
    {
        private const WdExportFormat ExportFormat = WdExportFormat.wdExportFormatXPS;

        public override void ConvertRtfDocument(Document document, string outputFileName)
        {
            if (Path.GetExtension(outputFileName).ToLower() == ".xps")
            {
                document.ExportAsFixedFormat(outputFileName, ExportFormat);
            }
            else
            {
                throw new Exception("Wrong extension of output file name. Must be .xps");
            }
        }
    }
}
