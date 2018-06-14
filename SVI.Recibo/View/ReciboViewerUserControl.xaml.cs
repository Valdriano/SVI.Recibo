using Microsoft.Reporting.WinForms;
using SVI.Recibo.Model;
using SVI.Recibo.Util;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SVI.Recibo.View
{
    /// <summary>
    /// Interaction logic for ReciboViewerUserControl.xaml
    /// </summary>
    public partial class ReciboViewerUserControl : UserControl
    {
        protected EmitirRecibo emitirRecibo;

        public ReciboViewerUserControl( EmitirRecibo emitirRecibo )
        {
            InitializeComponent();

            this.emitirRecibo = emitirRecibo;
        }

        private void reportViewer_Load( object sender, EventArgs e )
        {
            try
            {
                IList<EmitirRecibo> list = new List<EmitirRecibo>();

                list.Add( emitirRecibo );

                ReportDataSource dataSource = new ReportDataSource( "dsRecibo", list );

                reportViewer.LocalReport.DataSources.Add( dataSource );
                reportViewer.LocalReport.ReportEmbeddedResource = "SVI.Recibo.Reports.ReciboReport.rdlc";

                IList<ReportParameter> rp = new List<ReportParameter>();

                rp.Add( new ReportParameter( "CPFCNPJ", emitirRecibo.CPFCNPJ.Length == 14 ? "CPF" : "CNPJ" ) );
                rp.Add( new ReportParameter( "Extenso", AppUtil.EscreverExtenso( emitirRecibo.Valor ) ) );
                rp.Add( new ReportParameter( "Ano", DateTime.Now.Year.ToString() ) );

                reportViewer.LocalReport.EnableExternalImages = true;
                reportViewer.LocalReport.SetParameters( rp );
                reportViewer.RefreshReport();
                reportViewer.SetDisplayMode( DisplayMode.PrintLayout );
                reportViewer.ZoomMode = ZoomMode.PageWidth;
            }
            catch( LocalProcessingException ex )
            {

                MessageBox.Show( ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error );
            }
        }

        private void FecharMenuItem_Click( object sender, RoutedEventArgs e )
        {
            
        }
    }
}
