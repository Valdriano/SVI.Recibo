using SVI.Recibo.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SVI.Recibo
{
    public partial class PrincipalForm : Form
    {
        private InicioUserControl inicioView;
        private ReciboUserControl reciboView;
        private FornecedorUserControl fornecedorView;
        private ConfiguracaoUserControl configuracaoView;

        protected bool MouseMove;
        protected Point PointForm;
        protected Point PointCursor;

        public PrincipalForm()
        {
            InitializeComponent();

            inicioView = new InicioUserControl();
            reciboView = new ReciboUserControl();
            fornecedorView = new FornecedorUserControl();
            configuracaoView = new ConfiguracaoUserControl();
        }

        private void PrincipalForm_Load( object sender, EventArgs e )
        {
            this.MouseMove = false;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.FixedPanel = FixedPanel.Panel1;

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
            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is InicioUserControl ) )
            {
                SetUserControlWPF( inicioView );
            }
        }

        private void Recibobutton_Click( object sender, EventArgs e )
        {
            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is ReciboUserControl ) )
            {
                SetUserControlWPF( reciboView );
            }
        }

        private void Forncedoresbutton_Click( object sender, EventArgs e )
        {
            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is FornecedorUserControl ) )
            {
                SetUserControlWPF( fornecedorView );
            }
        }

        private void Superiorpanel_MouseDown( object sender, MouseEventArgs e )
        {
            this.MouseMove = true;
            this.PointForm = this.Location;
            this.PointCursor = Cursor.Position;
        }

        private void Superiorpanel_MouseUp( object sender, MouseEventArgs e )
        {
            this.MouseMove = false;
        }

        private void Superiorpanel_MouseMove( object sender, MouseEventArgs e )
        {
            if( this.MouseMove )
            {
                Point point = Point.Subtract( Cursor.Position, new Size( PointCursor ) );
                this.Location = Point.Add( PointForm, new Size( point ) );
            }
        }

        private void Configuracaobutton_Click( object sender, EventArgs e )
        {
            MoveSelecao( sender );

            if( !( this.WPFelementHost.Child is ConfiguracaoUserControl ) )
            {
                SetUserControlWPF( configuracaoView );
            }
        }

        private void SetUserControlWPF( System.Windows.Controls.UserControl control ) => WPFelementHost.Child = control;
    }
}
