using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
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

                throw new Exception( ex.Message );
            }
        }
    }
}