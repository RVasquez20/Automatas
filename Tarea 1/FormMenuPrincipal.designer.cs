namespace Tarea_1
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedorForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.rtb_Texto = new System.Windows.Forms.RichTextBox();
            this.panelContenedorPrincipal.SuspendLayout();
            this.panelContenedorForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedorPrincipal
            // 
            this.panelContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedorPrincipal.Controls.Add(this.panelContenedorForm);
            this.panelContenedorPrincipal.Controls.Add(this.panel1);
            this.panelContenedorPrincipal.Controls.Add(this.panelMenu);
            this.panelContenedorPrincipal.Controls.Add(this.PanelBarraTitulo);
            this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            this.panelContenedorPrincipal.Size = new System.Drawing.Size(1100, 600);
            this.panelContenedorPrincipal.TabIndex = 0;
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedorForm.Controls.Add(this.rtb_Texto);
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(230, 68);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(870, 532);
            this.panelContenedorForm.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(230, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 25);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(605, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 5;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(436, 7);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(150, 13);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(357, 5);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 15);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 43);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 557);
            this.panelMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbrir});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(53, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(126, 61);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAbrir
            // 
            this.ToolStripMenuItemAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ToolStripMenuItemAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolStripMenuItemAbrir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemAbrir.ForeColor = System.Drawing.Color.Snow;
            this.ToolStripMenuItemAbrir.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemAbrir.Image")));
            this.ToolStripMenuItemAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItemAbrir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemAbrir.Name = "ToolStripMenuItemAbrir";
            this.ToolStripMenuItemAbrir.Size = new System.Drawing.Size(119, 36);
            this.ToolStripMenuItemAbrir.Text = "   ABRIR";
            this.ToolStripMenuItemAbrir.Click += new System.EventHandler(this.ToolStripMenuItemAbrir_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelBarraTitulo.Controls.Add(this.label1);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1100, 43);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarea 1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1043, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // rtb_Texto
            // 
            this.rtb_Texto.Location = new System.Drawing.Point(0, 0);
            this.rtb_Texto.Name = "rtb_Texto";
            this.rtb_Texto.Size = new System.Drawing.Size(867, 529);
            this.rtb_Texto.TabIndex = 0;
            this.rtb_Texto.Text = "";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedorPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "FormMenuPrincipal";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.panelContenedorPrincipal.ResumeLayout(false);
            this.panelContenedorForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorPrincipal;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContenedorForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbrir;
        private System.Windows.Forms.RichTextBox rtb_Texto;
    }
}

