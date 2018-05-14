using SVI.Recibo.Model;
using SVI.Recibo.Repository;
using SVI.Recibo.Util;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SVI.Recibo.View
{
    /// <summary>
    /// Interaction logic for ReciboUserControl.xaml
    /// </summary>
    public partial class ReciboUserControl : UserControl
    {
        private IRepository<Configuracao, int> confRepository = new ConfiguracaoRepository( new Context.SVIReciboDbContext() );
        private ReciboRepository repository = new ReciboRepository( new Context.SVIReciboDbContext() );
        private Fornecedor fornecedor;
        private Model.Recibo recibo;
        private EmitirRecibo emitirRecibo;
        protected PrincipalForm principalForm;

        public ReciboUserControl( PrincipalForm principalForm )
        {
            InitializeComponent();

            this.principalForm = principalForm;

            this.ValorTextBox.ToMoney();
            this.CodigoTextBox.ToNumeric();
        }

        private void CodigoTextBox_LostFocus( object sender, RoutedEventArgs e )
        {
            if( !string.IsNullOrWhiteSpace( this.CodigoTextBox.Text ) )
            {
                fornecedor = repository.GetFornecedor( Convert.ToInt32( this.CodigoTextBox.Text ) );

                if( fornecedor == null )
                {
                    MessageBox.Show( "Fornecedor: " + this.CodigoTextBox.Text + " não localizado!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning );

                    this.CodigoTextBox.Focus();

                    return;
                }
                else
                {
                    FornecedorTextBox.Text = fornecedor.Nome;
                }
            }
        }

        private void EmitirButton_Click( object sender, RoutedEventArgs e )
        {
            try
            {
                if( Convert.ToDecimal( this.ValorTextBox.Text ) == 0 )
                {
                    MessageBox.Show( "Atenção: não e possivel emitir recibo com valor zerado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning );

                    this.ValorTextBox.Focus();

                    return;
                }
                else if( fornecedor == null )
                {
                    MessageBox.Show( "Atenção: é necessario informa o fornecedor.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning );

                    this.CodigoTextBox.Focus();

                    return;
                }
                else if( string.IsNullOrWhiteSpace( this.ReferenteTextBox.Text ) )
                {
                    MessageBox.Show( "Atenção: informe a referencia do recibo para emissão", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning );

                    this.ReferenteTextBox.Focus();

                    return;
                }
                else
                {
                    recibo = new Model.Recibo();

                    recibo.DataHora = DateTime.Now;
                    recibo.IDFornecedor = fornecedor.IDFornecedor;
                    recibo.Referencia = this.ReferenteTextBox.Text;
                    recibo.Valor = Convert.ToDecimal( this.ValorTextBox.Text );

                    repository.Inserir( recibo );

                    emitirRecibo = new EmitirRecibo();

                    recibo = repository.SelecionarPorId( repository.MaxID() );

                    emitirRecibo.Bairro = recibo._Fornecedor.Bairro.ToUpper();
                    emitirRecibo.CEP = recibo._Fornecedor.CEP.ToString().Substring( 0, 5 ) + "-" + recibo._Fornecedor.CEP.ToString().Substring( 6 );
                    emitirRecibo.CPFCNPJ = recibo._Fornecedor.CPFCNPJ.MaskCPFCNPJ();
                    emitirRecibo.IDRecibo = recibo.IDRecibo;
                    emitirRecibo.Local = confRepository.SelecionarPorId( 1 ).Local;
                    emitirRecibo.Logo = recibo._Fornecedor.Logo;
                    emitirRecibo.Logradouro = recibo._Fornecedor.Lougradouro.ToUpper();
                    emitirRecibo.NomeFornecedor = recibo._Fornecedor.Nome.ToUpper();
                    emitirRecibo.Referente = recibo.Referencia.ToUpper();
                    emitirRecibo.Valor = recibo.Valor;

                    ReciboViewerUserControl reciboViewer = new ReciboViewerUserControl( emitirRecibo );

                    principalForm.SetUserControlWPF( reciboViewer );
                }
            }
            catch( Exception ex )
            {

                MessageBox.Show( ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error );
            }
        }

        private void CancelarButton_Click( object sender, RoutedEventArgs e )
        {
            this.CodigoTextBox.Text = "";
            this.ValorTextBox.Text = "";
            this.ReferenteTextBox.Text = "";
        }
    }
}
