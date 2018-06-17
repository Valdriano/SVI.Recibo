using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVI.Recibo.View;

namespace SVI.Recibo.Pro
{
    public partial class MainForm : Form
    {
        protected SplashForm splashForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            splashForm = new SplashForm( () =>
             {
                 for( int i = 0; i <= 100; i++ )
                 {
                     splashForm.OnProgressBar( i );
                     System.Threading.Thread.Sleep( 100 );
                 }
             } );

            splashForm.ShowDialog( this );
        }

        private void MainForm_SizeChanged( object sender, EventArgs e )
        {
            this.BackgroundImage = null;
            this.BackgroundImage = Properties.Resources.Geometric_Background_1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
