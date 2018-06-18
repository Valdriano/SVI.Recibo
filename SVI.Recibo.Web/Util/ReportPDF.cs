using Microsoft.Reporting.WebForms;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SVI.Recibo.Web.Util
{
    public class ReportPDF
    {
        private LocalReport report;
        private IList<Stream> streams;
        private IList<string> cTempFilesList;

        private string cArquivoFileName;

        public ReportPDF( LocalReport report, string cArquivoFileName )
        {
            this.report = report;

            this.cArquivoFileName = cArquivoFileName;
        }

        private Stream CreateStream( string cArquivoFileName, string cArquivoExtension, Encoding encoding, string mimeType, bool willSeek )
        {
            string cTempFile = this.cArquivoFileName == string.Empty ? Path.GetTempFileName() : this.cArquivoFileName;

            this.cTempFilesList.Add( cTempFile );

            Stream stream = new FileStream( cTempFile, FileMode.Create );

            this.streams.Add( stream );

            return stream;
        }

        private void Render()
        {
            string deviceInfo = "<DeviceInfo>" +
                                "  <DpiX>600</DpiX>" +
                                "  <DpiY>600</DpiY>" +
                                "  <OutputFormat>EMF</OutputFormat>" +
                                "  <PageWidth>210mm</PageWidth>" +
                                "  <PageHeight>297mm</PageHeight>" +
                                "  <MarginTop>0mm</MarginTop>" +
                                "  <MarginLeft>0mm</MarginLeft>" +
                                "  <MarginRight>0mm</MarginRight>" +
                                "  <MarginBottom>8mm</MarginBottom>" +
                                "</DeviceInfo>";

            Warning[] warnings;

            this.streams = new List<Stream>();
            this.cTempFilesList = new List<string>();

            this.report.Render( "PDF", deviceInfo, CreateStream, out warnings );

            foreach( Stream stream in this.streams )
            {
                stream.Position = 0;
            }
        }

        public void PDF()
        {
            this.Render();

            if( this.streams == null || this.streams.Count == 0 )
            {
                return;
            }
        }

        public void Dispose()
        {
            if( this.streams != null )
            {
                foreach( Stream stream in this.streams )
                {
                    stream.Close();
                }

                this.streams.Clear();
            }

            this.cTempFilesList.Clear();
        }
    }
}