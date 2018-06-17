using SVI.Recibo.Model;
using SVI.Recibo.Repository;
using SVI.Recibo.View;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SVI.Recibo
{
    public partial class PrincipalForm : Form
    {
        private IRepository<Configuracao, int> confRepository = new ConfiguracaoRepository( new Context.SVIReciboDbContext() );
        private InicioUserControl inicioView;
        private ReciboUserControl reciboView;
        private FornecedorUserControl fornecedorView;
        private ConfiguracaoUserControl configuracaoView;

        protected bool _MouseMove;
        protected Point PointForm;
        protected Point PointCursor;

        public PrincipalForm()
        {
            InitializeComponent();

            inicioView = new InicioUserControl();
            reciboView = new ReciboUserControl( this );
            fornecedorView = new FornecedorUserControl();
            configuracaoView = new ConfiguracaoUserControl();
        }

        private void PrincipalForm_Load( object sender, EventArgs e )
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            Version version = entryAssembly.GetName().Version;

            VersaotoolStripStatusLabel.Text = $"Versão: {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";

            this.FechaSubbutton.Visible = false;
            this._MouseMove = false;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.FixedPanel = FixedPanel.Panel1;

            confRepository.SelecionarPorId( 1 );

            this.Iniciobutton.PerformClick();
        }

        private void Fecharbutton_Click( object sender, EventArgs e )
        {
            DialogResult dialog = MessageBox.Show( this, "Atenção deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 );

            if( dialog == DialogResult.Yes )
                Application.Exit();
        }

        private void Maximizarbutton_Click( object sender, EventArgs e )
        {
            if( this.WindowState != FormWindowState.Maximized )
            {
                this.MaximizedBounds = Screen.FromHandle( this.Handle ).WorkingArea;

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimizarbutton_Click( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MoveSelecao( object sender )
        {
            Button btn = ( sender as Button );

            Selecaopanel.Location = new Point( Selecaopanel.Location.X, btn.Location.Y );
        }

        private void Iniciobutton_Click( object sender, EventArgs e )
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is InicioUserControl ) )
            {
                SetUserControlWPF( inicioView );
            }

            Cursor.Current = Cursors.Default;
        }

        private void Recibobutton_Click( object sender, EventArgs e )
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is ReciboUserControl ) )
            {
                SetUserControlWPF( reciboView );
            }

            Cursor.Current = Cursors.Default;
        }

        private void Forncedoresbutton_Click( object sender, EventArgs e )
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is FornecedorUserControl ) )
            {
                SetUserControlWPF( fornecedorView );
            }

            Cursor.Current = Cursors.Default;
        }

        private void Superiorpanel_MouseDown( object sender, MouseEventArgs e )
        {
            this._MouseMove = true;
            this.PointForm = this.Location;
            this.PointCursor = Cursor.Position;
        }

        private void Superiorpanel_MouseUp( object sender, MouseEventArgs e )
        {
            this._MouseMove = false;
        }

        private void Superiorpanel_MouseMove( object sender, MouseEventArgs e )
        {
            if( this._MouseMove )
            {
                Point point = Point.Subtract( Cursor.Position, new Size( PointCursor ) );
                this.Location = Point.Add( PointForm, new Size( point ) );
            }
        }

        private void Configuracaobutton_Click( object sender, EventArgs e )
        {
            Application.DoEvents();
            Cursor.Current = Cursors.WaitCursor;

            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is ConfiguracaoUserControl ) )
            {
                SetUserControlWPF( configuracaoView );
            }

            Cursor.Current = Cursors.Default;
        }

        public void SetUserControlWPF( System.Windows.Controls.UserControl control ) => WPFelementHost.Child = control;

        private void FechaSubbutton_Click( object sender, EventArgs e )
        {

        }
    }
}
