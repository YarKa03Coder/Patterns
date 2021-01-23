using System;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace Patterns.Creational.Builder
{
    class RtfReader
    {
        #region Private fields

        private readonly Converter _builder;

        private readonly Word.Application _application;

        private Word.Document _document;

        #endregion

        public RtfReader(Converter builder)
        {
            _builder = builder;

            _application = new Word.Application();
        }

        public string FileName { get; set; }

        public string OutputFileName { get; set; }

        public void Convert()
        {
            try
            {
                _document = _application.Documents.Open(FileName, ReadOnly: true);
                var oldName = _document.Name;

                _builder.ConvertRtfDocument(_document, OutputFileName);

                Console.WriteLine($"{oldName} to {_document.Name} converted successfully");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                if (_document != null)
                {
                    _document.Close(SaveChanges: false);
                    Marshal.FinalReleaseComObject(_document);
                }

                if (_application != null)
                {
                    _application.Quit(SaveChanges: false);
                    Marshal.FinalReleaseComObject(_application);
                }
            }
        }

    }
}
