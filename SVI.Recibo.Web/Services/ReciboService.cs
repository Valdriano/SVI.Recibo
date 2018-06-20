using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Hosting;

namespace SVI.Recibo.Web.Services
{
    public class ReciboService
    {
        public static byte[] GetPDF_Recibo<T>( string NameReport, string NameDsReport, IList<T> Lista, ReportParameter[] parameters = null )
        {
            try
            {
                LocalReport report = new LocalReport();
                report.ReportPath = HostingEnvironment.MapPath( "~/Reports/" + NameReport );
                report.DataSources.Add( new ReportDataSource( NameDsReport, Lista ) );

                if( parameters != null )
                {
                    report.SetParameters( parameters );
                }

                report.Refresh();

                string mimeType = "";
                string encoding = "";
                string filenameExtension = "";
                string[] streams = null;
                Warning[] warnings = null;
                byte[] bytes = report.Render( "PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings );

                return bytes;
            }
            catch( Exception ex )
            {
                using( StreamWriter sw = new StreamWriter( "Debug.txt", false, Encoding.UTF8 ) )
                {
                    sw.WriteLine( "Message: " + ex.Message );
                    sw.WriteLine( "Trace: " + ex.StackTrace );
                    sw.WriteLine( "Source: " + ex.Source );
                }

                throw new Exception( ex.Message );
            }
        }

        public static string GetBase<T>( string NameReport, string NameDsReport, IList<T> Lista, System.Web.HttpResponseBase httpResponseBase, ReportParameter[] parameters = null )
        {
            try
            {
                LocalReport report = new LocalReport();
                report.ReportPath = HostingEnvironment.MapPath( "~/Reports/" + NameReport );
                report.DataSources.Add( new ReportDataSource( NameDsReport, Lista ) );

                if( parameters != null )
                {
                    report.SetParameters( parameters );
                }

                report.Refresh();

                string mimeType = "";
                string encoding = "";
                string filenameExtension = "";
                string[] streams = null;
                Warning[] warnings = null;
                byte[] bytes = report.Render( "PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings );

                string fileName = "ReportDoc";

                httpResponseBase.Buffer = true;
                httpResponseBase.Clear();
                httpResponseBase.ContentType = mimeType;
                httpResponseBase.AddHeader( "content-disposition", "attachment; filename=" + fileName + "." + filenameExtension );
                httpResponseBase.BinaryWrite( bytes ); // create the file
                httpResponseBase.Flush();

                return fileName;
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }
    }
}