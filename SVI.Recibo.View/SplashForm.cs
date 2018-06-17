using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVI.Recibo.View
{
    public partial class SplashForm : Form
    {
        protected Action metodo;

        public SplashForm( Action metodo )
        {
            InitializeComponent();

            this.metodo = metodo;
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            try
            {
                Task.Factory.StartNew( this.metodo ).ContinueWith( a => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext() );
            }
            catch( Exception ex )
            {

                MessageBox.Show( ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public void OnProgressBar( int progress, string Mensagem = null )
        {
            if( this.progressBar.InvokeRequired )
            {
                this.progressBar.Invoke( ( MethodInvoker )delegate
                {
                    if( progress > 0 )
                    {
                        this.progressBar.Value = progress;
                        //this.Progressolabel.Text = progress + " %";
                        Application.DoEvents();
                    }

                    //if( Mensagem != null )
                    //{
                    //    this.Mensagemlabel.Text = Mensagem;
                    //}
                    //else
                    //{
                    //    this.Mensagemlabel.Text = string.Empty;
                    //}
                } );
            }
        }
    }
}
