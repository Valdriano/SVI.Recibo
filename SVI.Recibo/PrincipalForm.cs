using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVI.Recibo
{
    public partial class PrincipalForm : Form
    {
        protected bool MouseMove;
        protected Point PointForm;
        protected Point PointCursor;
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load( object sender, EventArgs e )
        {
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.FixedPanel = FixedPanel.Panel1;
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
        }

        private void Recibobutton_Click( object sender, EventArgs e )
        {
            MoveSelecao( sender );
        }

        private void Forncedoresbutton_Click( object sender, EventArgs e )
        {
            MoveSelecao( sender );
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
    }
}
