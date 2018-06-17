using SVI.Recibo.Context;
using SVI.Recibo.Model;
using SVI.Recibo.Repository;
using SVI.Recibo.Util;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SVI.Recibo.View
{
    /// <summary>
    /// Interaction logic for ConfiguracaoUserControl.xaml
    /// </summary>
    public partial class ConfiguracaoUserControl : UserControl
    {
        private IRepository<Configuracao, int> repository = new ConfiguracaoRepository( new SVIReciboDbContext() );
        private Configuracao config;

        public ConfiguracaoUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded( object sender, RoutedEventArgs e )
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                this.CancelarButton.IsEnabled = false;
                this.SalvarButton.IsEnabled = false;

                config = repository.SelecionarPorId( 1 );

                if( config == null )
                {
                    MessageBox.Show( "Não foi possivel carregar as configurações", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error );

                    config = new Configuracao();
                }
                else
                {
                    this.ProprietarioTextBox.Text = config.Proprietario;
                    this.LicencaTextBox.Text = config.Licenca;
                    this.EmailTextBox.Text = config.Email;
                    this.LocalTextBox.Text = config.Local;
                }
            }
            catch( Exception ex )
            {

                MessageBox.Show( ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error );
            }
        }

        private bool VerificaAlteracao()
        {
            if( this.ProprietarioTextBox.Text != config.Proprietario )
                return true;
            else if( this.EmailTextBox.Text != config.Email )
                return true;
            else if( this.LocalTextBox.Text != config.Local )
                return true;

            return false;
        }

        private void ProprietarioTextBox_LostFocus( object sender, RoutedEventArgs e )
        {
            this.SalvarButton.IsEnabled = this.CancelarButton.IsEnabled = VerificaAlteracao();
        }

        private void EmailTextBox_LostFocus( object sender, RoutedEventArgs e )
        {
            this.SalvarButton.IsEnabled = this.CancelarButton.IsEnabled = VerificaAlteracao();
        }

        private void LocalTextBox_LostFocus( object sender, RoutedEventArgs e )
        {
            this.SalvarButton.IsEnabled = this.CancelarButton.IsEnabled = VerificaAlteracao();
        }

        private void SalvarButton_Click( object sender, RoutedEventArgs e )
        {
            try
            {
                if( this.VerificaAlteracao() )
                {
                    MessageBoxResult result = MessageBox.Show( "Atenção\n\nDeseja salvar as alterações feitas?", "Questionar", MessageBoxButton.YesNo, MessageBoxImage.Question );

                    if( result != MessageBoxResult.Yes )
                        return;

                    config.Email = this.EmailTextBox.Text;
                    config.Local = this.LocalTextBox.Text;
                    config.Proprietario = this.ProprietarioTextBox.Text;

                    if( config.IDConfiguracao == 0 )
                    {
                        config.IDConfiguracao = 1;

                        repository.Inserir( config );
                    }
                    else
                    {
                        repository.Atualizar( config );
                    }                    

                    MessageBox.Show( "Configuração salva com sucesso!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information );

                    this.CarregarDados();
                }
            }
            catch( Exception ex )
            {

                MessageBox.Show( ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error );
            }
        }

        private void CancelarButton_Click( object sender, RoutedEventArgs e )
        {
            this.CarregarDados();
        }

        private void UserControl_KeyDown( object sender, System.Windows.Input.KeyEventArgs e )
        {
            e.MudarFocoComEnter();
        }
    }
}
