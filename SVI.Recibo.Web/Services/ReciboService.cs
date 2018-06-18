using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WebForms;
using SVI.Recibo.Web.Util;
using System;
using System.Collections.Generic;
using System.IO;

namespace SVI.Recibo.Web.Services
{
    public class ReciboService : PdfReport
    {
        private List<Models.Recibo> Recibos;

        public ReciboService( List<Models.Recibo> Recibos )
        {
            Paisagem = false;

            Recibos = this.Recibos;
        }

        public override void MontaCorpoDados()
        {
            //base.MontaCorpoDados();

            if( !Paisagem )
            {
                doc = new Document( PageSize.A4, 20, 10, 80, 40 );
            }
            else
            {
                doc = new Document( PageSize.A4.Rotate(), 20, 10, 80, 80 );
            }

            output = new MemoryStream();
            writer = PdfWriter.GetInstance( doc, output );

            MSPDFFooter footer = new MSPDFFooter();
            footer.PageTitle = PageTitle;
            footer.PageSubTitle = PageSubTitle;
            footer.BasePath = BasePath;
            footer.ImprimirCabecalhoPadrao = ImprimirCabecalhoPadrao;
            footer.ImprimirRodapePadrao = ImprimirRodapePadrao;

            writer.PageEvent = footer;

            doc.Open();

            #region Cabeçalho do Relatório
            PdfPTable table = new PdfPTable( 5 );
            BaseColor preto = new BaseColor( 0, 0, 0 );
            BaseColor fundo = new BaseColor( 200, 200, 200 );
            Font font = FontFactory.GetFont( "Arial", 8, Font.NORMAL, preto );
            Font titulo = FontFactory.GetFont( "Arial", 8, Font.BOLD, preto );

            float[] colsW = { 10, 10, 10, 10, 10 };
            table.SetWidths( colsW );
            table.HeaderRows = 1;
            table.WidthPercentage = 100f;

            table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
            table.DefaultCell.BorderColor = preto;
            table.DefaultCell.BorderColorBottom = new BaseColor( 255, 255, 255 );
            table.DefaultCell.Padding = 10;

            table.AddCell( getNewCell( "Número", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo ) );
            table.AddCell( getNewCell( "Emissão", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo ) );
            table.AddCell( getNewCell( "Vencimento", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo ) );
            table.AddCell( getNewCell( "Valor", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo ) );
            table.AddCell( getNewCell( "Saldo", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo ) );
            #endregion

            var cell = getNewCell( "Razao Social", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER );
            cell.Colspan = 5;
            table.AddCell( cell );
            table.AddCell( getNewCell( "Numero", font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER ) );
            table.AddCell( getNewCell( "Data", font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER ) );
            table.AddCell( getNewCell( "Vencimento", font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER ) );
            table.AddCell( getNewCell( "Valor", font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER ) );
            table.AddCell( getNewCell( "Saldo", font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER ) );

            doc.Add( table );
        }

        //public void GetPDF<T>( string NameReport, string NameDsReport, IList<T> ListData, ReportParameter[] parameters = null )
        //{
        //    LocalReport report = new LocalReport();
        //    report.ReportPath = HostingEnvironment.MapPath( "~/Reports/" + NameReport );
        //    report.DataSources.Add( new ReportDataSource( NameDsReport, ListData ) );

        //    if( parameters != null )
        //    {
        //        report.SetParameters( parameters );
        //    }

        //    report.Refresh();

        //    string mimeType = "application/pdf";
        //    string encoding = "";
        //    string filenameExtension = "";
        //    string[] streams = null;
        //    Microsoft.Reporting.WebForms.Warning[] warnings = null;
        //    byte[] bytes = report.Render( "PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings );

        //    Response
        //}

        //public MemoryStream GetPdf()
        //{
        //    try
        //    {
        //        Models.Recibo rec = Recibos[ 0 ];

        //        Document document = new Document( PageSize.A4, 20, 10, 80, 40 );
        //        //Cabeçalho
        //        BaseColor preto = new BaseColor( 0, 0, 0 );
        //        Font font = FontFactory.GetFont( "Arial", 8, Font.NORMAL, preto );
        //        Font titulo = FontFactory.GetFont( "Arial", 12, Font.BOLD, preto );
        //        float[] sizes = new float[] { 1f, 3f, 1f };

        //        PdfPTable table = new PdfPTable( 3 );
        //        table.TotalWidth = document.PageSize.Width - ( document.LeftMargin + document.RightMargin );
        //        table.SetWidths( sizes );

        //        PdfPCell cell = new PdfPCell();
        //        cell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        cell.Border = 0;
        //        cell.BorderWidthTop = 1.5f;
        //        cell.BorderWidthBottom = 1.5f;
        //        cell.PaddingTop = 10f;
        //        cell.PaddingBottom = 10f;
        //        table.AddCell( cell );

        //        PdfPTable micros = new PdfPTable( 1 );
        //        cell = new PdfPCell( new Phrase( PageSubTitle, font ) );
        //        cell.Border = 0;
        //        cell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        micros.AddCell( cell );
        //        cell = new PdfPCell( new Phrase( PageTitle, titulo ) );
        //        cell.Border = 0;
        //        cell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        micros.AddCell( cell );

        //        cell = new PdfPCell( micros );
        //        cell.HorizontalAlignment = Element.ALIGN_LEFT;
        //        cell.Border = 0;
        //        cell.BorderWidthTop = 1.5f;
        //        cell.BorderWidthBottom = 1.5f;
        //        cell.PaddingTop = 10f;
        //        table.AddCell( cell );
        //    }
        //    catch( Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}