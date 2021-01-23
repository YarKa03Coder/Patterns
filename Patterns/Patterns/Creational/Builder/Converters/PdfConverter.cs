using System;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace Patterns.Creational.Builder.Converters
{
    class PdfConverter : Converter
    {
        private const WdExportFormat ExportFormat = WdExportFormat.wdExportFormatPDF;

        public override void ConvertRtfDocument(Document document, string outputFileName)
        {
            if (Path.GetExtension(outputFileName).ToLower() == ".pdf")
            {
                document.ExportAsFixedFormat(outputFileName, ExportFormat);
            }
            else
            {
                throw new Exception("Wrong extension of output file name. Must be .pdf");
            }
        }
    }
}
