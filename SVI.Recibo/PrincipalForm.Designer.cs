namespace SVI.Recibo
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.Superiorpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InferiorstatusStrip = new System.Windows.Forms.StatusStrip();
            this.VersaotoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.Selecaopanel = new System.Windows.Forms.Panel();
            this.Contentpanel = new System.Windows.Forms.Panel();
            this.Configuracaobutton = new System.Windows.Forms.Button();
            this.Recibobutton = new System.Windows.Forms.Button();
            this.Forncedoresbutton = new System.Windows.Forms.Button();
            this.Iniciobutton = new System.Windows.Forms.Button();
            this.Minimizarbutton = new System.Windows.Forms.Button();
            this.Maximizarbutton = new System.Windows.Forms.Button();
            this.Fecharbutton = new System.Windows.Forms.Button();
            this.WPFelementHost = new System.Windows.Forms.Integration.ElementHost();
            this.Superiorpanel.SuspendLayout();
            this.InferiorstatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.Contentpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Superiorpanel
            // 
            this.Superiorpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Superiorpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Superiorpanel.Controls.Add(this.Minimizarbutton);
            this.Superiorpanel.Controls.Add(this.Maximizarbutton);
            this.Superiorpanel.Controls.Add(this.Fecharbutton);
            this.Superiorpanel.Controls.Add(this.label1);
            this.Superiorpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Superiorpanel.Location = new System.Drawing.Point(0, 0);
            this.Superiorpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Superiorpanel.Name = "Superiorpanel";
            this.Superiorpanel.Size = new System.Drawing.Size(905, 41);
            this.Superiorpanel.TabIndex = 0;
            this.Superiorpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Superiorpanel_MouseDown);
            this.Superiorpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Superiorpanel_MouseMove);
            this.Superiorpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Superiorpanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SVI Recibo";
            // 
            // InferiorstatusStrip
            // 
            this.InferiorstatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.InferiorstatusStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InferiorstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersaotoolStripStatusLabel});
            this.InferiorstatusStrip.Location = new System.Drawing.Point(0, 578);
            this.InferiorstatusStrip.Name = "InferiorstatusStrip";
            this.InferiorstatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.InferiorstatusStrip.Size = new System.Drawing.Size(905, 22);
            this.InferiorstatusStrip.SizingGrip = false;
            this.InferiorstatusStrip.TabIndex = 1;
            this.InferiorstatusStrip.Text = "Barra de status";
            // 
            // VersaotoolStripStatusLabel
            // 
            this.VersaotoolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.VersaotoolStripStatusLabel.Name = "VersaotoolStripStatusLabel";
            this.VersaotoolStripStatusLabel.Size = new System.Drawing.Size(888, 17);
            this.VersaotoolStripStatusLabel.Spring = true;
            this.VersaotoolStripStatusLabel.Text = "Versão: 1.0.0.0";
            this.VersaotoolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 41);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.splitContainer.Panel1.Controls.Add(this.Configuracaobutton);
            this.splitContainer.Panel1.Controls.Add(this.Selecaopanel);
            this.splitContainer.Panel1.Controls.Add(this.Recibobutton);
            this.splitContainer.Panel1.Controls.Add(this.Forncedoresbutton);
            this.splitContainer.Panel1.Controls.Add(this.Iniciobutton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.Contentpanel);
            this.splitContainer.Size = new System.Drawing.Size(905, 537);
            this.splitContainer.SplitterDistance = 302;
            this.splitContainer.TabIndex = 2;
            // 
            // Selecaopanel
            // 
            this.Selecaopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Selecaopanel.Location = new System.Drawing.Point(11, 27);
            this.Selecaopanel.Name = "Selecaopanel";
            this.Selecaopanel.Size = new System.Drawing.Size(10, 55);
            this.Selecaopanel.TabIndex = 7;
            // 
            // Contentpanel
            // 
            this.Contentpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contentpanel.BackColor = System.Drawing.SystemColors.Window;
            this.Contentpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Contentpanel.Controls.Add(this.WPFelementHost);
            this.Contentpanel.Location = new System.Drawing.Point(3, 27);
            this.Contentpanel.Name = "Contentpanel";
            this.Contentpanel.Size = new System.Drawing.Size(583, 505);
            this.Contentpanel.TabIndex = 0;
            // 
            // Configuracaobutton
            // 
            this.Configuracaobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Configuracaobutton.FlatAppearance.BorderSize = 0;
            this.Configuracaobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Configuracaobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Configuracaobutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuracaobutton.ForeColor = System.Drawing.SystemColors.Window;
            this.Configuracaobutton.Image = global::SVI.Recibo.Properties.Resources.settings;
            this.Configuracaobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configuracaobutton.Location = new System.Drawing.Point(31, 471);
            this.Configuracaobutton.Name = "Configuracaobutton";
            this.Configuracaobutton.Size = new System.Drawing.Size(258, 55);
            this.Configuracaobutton.TabIndex = 11;
            this.Configuracaobutton.Text = "Configuração";
            this.Configuracaobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Configuracaobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Configuracaobutton.UseVisualStyleBackColor = true;
            this.Configuracaobutton.Click += new System.EventHandler(this.Configuracaobutton_Click);
            // 
            // Recibobutton
            // 
            this.Recibobutton.FlatAppearance.BorderSize = 0;
            this.Recibobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Recibobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recibobutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recibobutton.ForeColor = System.Drawing.SystemColors.Window;
            this.Recibobutton.Image = global::SVI.Recibo.Properties.Resources.printer;
            this.Recibobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recibobutton.Location = new System.Drawing.Point(31, 88);
            this.Recibobutton.Name = "Recibobutton";
            this.Recibobutton.Size = new System.Drawing.Size(258, 55);
            this.Recibobutton.TabIndex = 6;
            this.Recibobutton.Text = "Recibo";
            this.Recibobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Recibobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Recibobutton.UseVisualStyleBackColor = true;
            this.Recibobutton.Click += new System.EventHandler(this.Recibobutton_Click);
            // 
            // Forncedoresbutton
            // 
            this.Forncedoresbutton.FlatAppearance.BorderSize = 0;
            this.Forncedoresbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Forncedoresbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forncedoresbutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forncedoresbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.Forncedoresbutton.Image = global::SVI.Recibo.Properties.Resources.worker;
            this.Forncedoresbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Forncedoresbutton.Location = new System.Drawing.Point(31, 149);
            this.Forncedoresbutton.Name = "Forncedoresbutton";
            this.Forncedoresbutton.Size = new System.Drawing.Size(258, 55);
            this.Forncedoresbutton.TabIndex = 5;
            this.Forncedoresbutton.Text = "Fornecedores";
            this.Forncedoresbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Forncedoresbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Forncedoresbutton.UseVisualStyleBackColor = true;
            this.Forncedoresbutton.Click += new System.EventHandler(this.Forncedoresbutton_Click);
            // 
            // Iniciobutton
            // 
            this.Iniciobutton.FlatAppearance.BorderSize = 0;
            this.Iniciobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Iniciobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciobutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciobutton.ForeColor = System.Drawing.SystemColors.Window;
            this.Iniciobutton.Image = global::SVI.Recibo.Properties.Resources.yelp;
            this.Iniciobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Iniciobutton.Location = new System.Drawing.Point(31, 27);
            this.Iniciobutton.Name = "Iniciobutton";
            this.Iniciobutton.Size = new System.Drawing.Size(258, 55);
            this.Iniciobutton.TabIndex = 4;
            this.Iniciobutton.Text = "Inicio";
            this.Iniciobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Iniciobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Iniciobutton.UseVisualStyleBackColor = true;
            this.Iniciobutton.Click += new System.EventHandler(this.Iniciobutton_Click);
            // 
            // Minimizarbutton
            // 
            this.Minimizarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizarbutton.FlatAppearance.BorderSize = 0;
            this.Minimizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizarbutton.Image = global::SVI.Recibo.Properties.Resources.window_minimize;
            this.Minimizarbutton.Location = new System.Drawing.Point(737, 7);
            this.Minimizarbutton.Name = "Minimizarbutton";
            this.Minimizarbutton.Size = new System.Drawing.Size(45, 29);
            this.Minimizarbutton.TabIndex = 3;
            this.Minimizarbutton.TabStop = false;
            this.Minimizarbutton.UseVisualStyleBackColor = true;
            this.Minimizarbutton.Click += new System.EventHandler(this.Minimizarbutton_Click);
            // 
            // Maximizarbutton
            // 
            this.Maximizarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizarbutton.FlatAppearance.BorderSize = 0;
            this.Maximizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximizarbutton.Image = global::SVI.Recibo.Properties.Resources.window_maximize;
            this.Maximizarbutton.Location = new System.Drawing.Point(788, 7);
            this.Maximizarbutton.Name = "Maximizarbutton";
            this.Maximizarbutton.Size = new System.Drawing.Size(45, 29);
            this.Maximizarbutton.TabIndex = 2;
            this.Maximizarbutton.TabStop = false;
            this.Maximizarbutton.UseVisualStyleBackColor = true;
            this.Maximizarbutton.Click += new System.EventHandler(this.Maximizarbutton_Click);
            // 
            // Fecharbutton
            // 
            this.Fecharbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecharbutton.FlatAppearance.BorderSize = 0;
            this.Fecharbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fecharbutton.Image = global::SVI.Recibo.Properties.Resources.close_box;
            this.Fecharbutton.Location = new System.Drawing.Point(848, 7);
            this.Fecharbutton.Name = "Fecharbutton";
            this.Fecharbutton.Size = new System.Drawing.Size(45, 29);
            this.Fecharbutton.TabIndex = 1;
            this.Fecharbutton.TabStop = false;
            this.Fecharbutton.UseVisualStyleBackColor = true;
            this.Fecharbutton.Click += new System.EventHandler(this.Fecharbutton_Click);
            // 
            // WPFelementHost
            // 
            this.WPFelementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WPFelementHost.Location = new System.Drawing.Point(0, 0);
            this.WPFelementHost.Name = "WPFelementHost";
            this.WPFelementHost.Size = new System.Drawing.Size(579, 501);
            this.WPFelementHost.TabIndex = 0;
            this.WPFelementHost.Text = "Elemento";
            this.WPFelementHost.Child = null;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(905, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.InferiorstatusStrip);
            this.Controls.Add(this.Superiorpanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SVI Recibo";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.Superiorpanel.ResumeLayout(false);
            this.Superiorpanel.PerformLayout();
            this.InferiorstatusStrip.ResumeLayout(false);
            this.InferiorstatusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.Contentpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Superiorpanel;
        private System.Windows.Forms.StatusStrip InferiorstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel VersaotoolStripStatusLabel;
        private System.Windows.Forms.Button Fecharbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Maximizarbutton;
        private System.Windows.Forms.Button Minimizarbutton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button Iniciobutton;
        private System.Windows.Forms.Button Forncedoresbutton;
        private System.Windows.Forms.Button Recibobutton;
        private System.Windows.Forms.Panel Selecaopanel;
        private System.Windows.Forms.Panel Contentpanel;
        private System.Windows.Forms.Button Configuracaobutton;
        private System.Windows.Forms.Integration.ElementHost WPFelementHost;
    }
}

