using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;

namespace SVI.Recibo.Web.Util
{
    [RoutePrefix( "api/relatorio" )]
    public class ReportPdfApi : ApiController
    {
        [HttpGet]
        public static HttpResponseMessage GetPDF<T>( string NameReport, string NameDsReport, IList<T> ListData, ReportParameter[] parameters = null )
        {
            try
            {
                LocalReport report = new LocalReport();
                report.ReportPath = HostingEnvironment.MapPath( "~/Reports/" + NameReport );
                report.DataSources.Add( new ReportDataSource( NameDsReport, ListData ) );

                if( parameters != null )
                {
                    report.SetParameters( parameters );
                }

                report.Refresh();

                string mimeType = "";
                string encoding = "";
                string filenameExtension = "";
                string[] streams = null;
                Microsoft.Reporting.WebForms.Warning[] warnings = null;
                byte[] bytes = report.Render( "PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings );

                HttpResponseMessage result = new HttpResponseMessage( HttpStatusCode.OK );
                result.Content = new ByteArrayContent( bytes );
                result.Content.Headers.ContentType = new MediaTypeHeaderValue( mimeType );

                return result;
            }
            catch( Exception )
            {

                return new HttpResponseMessage( HttpStatusCode.InternalServerError );
            }
        }

        public static MemoryStream OutPut<T>( string NameReport, string NameDsReport, IList<T> ListData, ReportParameter[] parameters = null )
        {
            LocalReport report = new LocalReport();
            report.ReportPath = HostingEnvironment.MapPath( "~/Reports/" + NameReport );
            report.DataSources.Add( new ReportDataSource( NameDsReport, ListData ) );

            if( parameters != null )
            {
                report.SetParameters( parameters );
            }

            report.Refresh();

            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string[] streams = null;
            Microsoft.Reporting.WebForms.Warning[] warnings = null;
            byte[] bytes = report.Render( "PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings );

            //HttpResponseMessage result = new HttpResponseMessage( HttpStatusCode.OK );
            //result.Content = new ByteArrayContent( bytes );
            //result.Content.Headers.ContentType = new MediaTypeHeaderValue( mimeType );

            return new MemoryStream( bytes, true );
        }

    }
}