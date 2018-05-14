using SVI.Recibo.Model;
using SVI.Recibo.Repository;
using SVI.Recibo.Util;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SVI.Recibo.View
{
    /// <summary>
    /// Interaction logic for FornecedorUserControl.xaml
    /// </summary>
    public partial class FornecedorUserControl : UserControl
    {
        private IRepository<Fornecedor, int> repository = new FornecedorRepository( new Context.SVIReciboDbContext() );
        private Fornecedor fornecedor;

        public FornecedorUserControl()
        {
            InitializeComponent();

            this.IDFornecedorTextBox.ToNumeric();
            this.CPFCNPJTextBox.ToNumeric();
            this.CEPTextBox.ToNumeric();
        }

        private void UserControl_Loaded( object sender, RoutedEventArgs e )
        {
            this.CarregarDados();
        }

        private void CarregarDados()
        {
            this.DesabilitarControles();
            //Expression<Func<Fornecedor, bool>> ex = ( f => f.IDFornecedor == 1 );
            this.FornecedorDataGrid.ItemsSource = repository.Listar();
        }

        private void HabilitarControles()
        {
            this.IDFornecedorTextBox.Text = "";
            this.FornecedorTextBox.Text = "";
            this.CPFCNPJTextBox.Text = "";
            this.CEPTextBox.Text = "";
            this.BairroTextBox.Text = "";
            this.LogradouroTextBox.Text = "";
            this.NumeroTextBox.Text = "";
            this.ComplementoTextBox.Text = "";
            this.LogoImage.Source = null;

            this.FornecedorTextBox.IsEnabled = true;
            this.CPFCNPJTextBox.IsEnabled = true;
            this.CEPTextBox.IsEnabled = true;
            this.BairroTextBox.IsEnabled = true;
            this.LogradouroTextBox.IsEnabled = true;
            this.NumeroTextBox.IsEnabled = true;
            this.ComplementoTextBox.IsEnabled = true;
            this.DiretorioButton.IsEnabled = true;

            this.SalvarButton.IsEnabled = true;
            this.CancelarButton.IsEnabled = true;
            this.NovoButton.IsEnabled = false;
            this.EditarButton.IsEnabled = false;
            this.ExcluirButton.IsEnabled = false;
        }

        private void DesabilitarControles()
        {
            this.IDFornecedorTextBox.Text = "";
            this.FornecedorTextBox.Text = "";
            this.CPFCNPJTextBox.Text = "";
            this.CEPTextBox.Text = "";
            this.BairroTextBox.Text = "";
            this.LogradouroTextBox.Text = "";
            this.NumeroTextBox.Text = "";
            this.ComplementoTextBox.Text = "";
            this.LogoImage.Source = null;

            this.FornecedorTextBox.IsEnabled = false;
            this.CPFCNPJTextBox.IsEnabled = false;
            this.CEPTextBox.IsEnabled = false;
            this.BairroTextBox.IsEnabled = false;
            this.LogradouroTextBox.IsEnabled = false;
            this.NumeroTextBox.IsEnabled = false;
            this.ComplementoTextBox.IsEnabled = false;
            this.DiretorioButton.IsEnabled = false;

            this.SalvarButton.IsEnabled = false;
            this.CancelarButton.IsEnabled = false;
            this.NovoButton.IsEnabled = true;
            this.EditarButton.IsEnabled = true;
            this.ExcluirButton.IsEnabled = true;
        }

        private void SalvarButton_Click( object sender, RoutedEventArgs e )
        {
            bool novo = fornecedor == null;

            if( novo )
            {
                fornecedor = new Fornecedor();
            }

            fornecedor.Bairro = this.BairroTextBox.Text;
            fornecedor.CEP = Convert.ToInt32( this.CEPTextBox.Text );
            fornecedor.Complemento = this.ComplementoTextBox.Text;
            fornecedor.CPFCNPJ = Convert.ToInt64( this.CPFCNPJTextBox.Text );
            fornecedor.Lougradouro = this.LogradouroTextBox.Text;
            fornecedor.Nome = this.FornecedorTextBox.Text;
            fornecedor.Numero = this.NumeroTextBox.Text;

            if( novo )
            {
                repository.Inserir( fornecedor );
            }
            else
            {
                repository.Atualizar( fornecedor );
            }

            MessageBox.Show( "Fornecedor salvo com sucesso!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information );

            this.CarregarDados();
        }

        private void CancelarButton_Click( object sender, RoutedEventArgs e )
        {
            this.DesabilitarControles();
        }

        private void NovoButton_Click( object sender, RoutedEventArgs e )
        {
            this.HabilitarControles();
        }

        private void EditarButton_Click( object sender, RoutedEventArgs e )
        {
            if( FornecedorDataGrid.Items.Count > 0 && this.FornecedorDataGrid.SelectedItem != null )
            {
                this.HabilitarControles();

                fornecedor = this.FornecedorDataGrid.SelectedItem as Fornecedor;

                this.IDFornecedorTextBox.Text = fornecedor.IDFornecedor.ToString();
                this.FornecedorTextBox.Text = fornecedor.Nome;
                this.CPFCNPJTextBox.Text = fornecedor.CPFCNPJ.ToString();
                this.CEPTextBox.Text = fornecedor.CEP.ToString();
                this.BairroTextBox.Text = fornecedor.Bairro;
                this.LogradouroTextBox.Text = fornecedor.Lougradouro;
                this.NumeroTextBox.Text = fornecedor.Numero;
                this.ComplementoTextBox.Text = fornecedor.Complemento;

                if( fornecedor.Logo != null )
                {
                    MemoryStream memoryStream = new MemoryStream( fornecedor.Logo );

                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = memoryStream;
                    bitmap.EndInit();

                    this.LogoImage.Source = bitmap;
                }
            }
        }

        private void ExcluirButton_Click( object sender, RoutedEventArgs e )
        {
            if( FornecedorDataGrid.Items.Count > 0 && this.FornecedorDataGrid.SelectedItem != null )
            {
                fornecedor = this.FornecedorDataGrid.SelectedItem as Fornecedor;

                MessageBoxResult result = MessageBox.Show( "Deseja exluir o fornecedor: " + fornecedor.Nome, "Questionar", MessageBoxButton.YesNo, MessageBoxImage.Question );

                if( result != MessageBoxResult.Yes )
                    return;
            }
        }

        private void DiretorioButton_Click( object sender, RoutedEventArgs e )
        {
            System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult result;

            fileDialog.Multiselect = false;
            fileDialog.FileName = "Logo";
            fileDialog.Filter = "*.png| *.jpg";
            fileDialog.FilterIndex = 0;
            fileDialog.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
            fileDialog.Title = "Importando Logo do Fornecedor";

            result = fileDialog.ShowDialog();

            if( result == System.Windows.Forms.DialogResult.OK )
            {
                BitmapImage bitmap = new BitmapImage( new Uri( fileDialog.FileName ) );

                this.LogoImage.Source = bitmap;
            }
        }
    }
}
