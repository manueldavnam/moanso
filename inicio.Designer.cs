namespace SistemaConsultorio
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menupacientes = new FontAwesome.Sharp.IconMenuItem();
            this.menucitas = new FontAwesome.Sharp.IconMenuItem();
            this.menuconsultas = new FontAwesome.Sharp.IconMenuItem();
            this.menuservicios = new FontAwesome.Sharp.IconMenuItem();
            this.menupagos = new FontAwesome.Sharp.IconMenuItem();
            this.menutratamientos = new FontAwesome.Sharp.IconMenuItem();
            this.menuespecialistas = new FontAwesome.Sharp.IconMenuItem();
            this.menusalir = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menupacientes,
            this.menucitas,
            this.menuconsultas,
            this.menuservicios,
            this.menupagos,
            this.menutratamientos,
            this.menuespecialistas,
            this.menusalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 96);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 75);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // menupacientes
            // 
            this.menupacientes.AutoSize = false;
            this.menupacientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menupacientes.IconColor = System.Drawing.Color.Black;
            this.menupacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menupacientes.IconSize = 52;
            this.menupacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menupacientes.Name = "menupacientes";
            this.menupacientes.Size = new System.Drawing.Size(92, 71);
            this.menupacientes.Text = "Pacientes";
            this.menupacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menucitas
            // 
            this.menucitas.AutoSize = false;
            this.menucitas.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.menucitas.IconColor = System.Drawing.Color.Black;
            this.menucitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucitas.IconSize = 52;
            this.menucitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucitas.Name = "menucitas";
            this.menucitas.Size = new System.Drawing.Size(92, 71);
            this.menucitas.Text = "Citas";
            this.menucitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuconsultas
            // 
            this.menuconsultas.AutoSize = false;
            this.menuconsultas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.menuconsultas.IconColor = System.Drawing.Color.Black;
            this.menuconsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuconsultas.IconSize = 52;
            this.menuconsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuconsultas.Name = "menuconsultas";
            this.menuconsultas.Size = new System.Drawing.Size(92, 71);
            this.menuconsultas.Text = "Consultas";
            this.menuconsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuservicios
            // 
            this.menuservicios.AutoSize = false;
            this.menuservicios.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.menuservicios.IconColor = System.Drawing.Color.Black;
            this.menuservicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuservicios.IconSize = 52;
            this.menuservicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuservicios.Name = "menuservicios";
            this.menuservicios.Size = new System.Drawing.Size(92, 71);
            this.menuservicios.Text = "Servicios";
            this.menuservicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menupagos
            // 
            this.menupagos.AutoSize = false;
            this.menupagos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.menupagos.IconColor = System.Drawing.Color.Black;
            this.menupagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menupagos.IconSize = 52;
            this.menupagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menupagos.Name = "menupagos";
            this.menupagos.Size = new System.Drawing.Size(92, 71);
            this.menupagos.Text = "Pagos";
            this.menupagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutratamientos
            // 
            this.menutratamientos.AutoSize = false;
            this.menutratamientos.IconChar = FontAwesome.Sharp.IconChar.SuitcaseMedical;
            this.menutratamientos.IconColor = System.Drawing.Color.Black;
            this.menutratamientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menutratamientos.IconSize = 52;
            this.menutratamientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menutratamientos.Name = "menutratamientos";
            this.menutratamientos.Size = new System.Drawing.Size(92, 71);
            this.menutratamientos.Text = "Tratamientos";
            this.menutratamientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menutratamientos.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // menuespecialistas
            // 
            this.menuespecialistas.AutoSize = false;
            this.menuespecialistas.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.menuespecialistas.IconColor = System.Drawing.Color.Black;
            this.menuespecialistas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuespecialistas.IconSize = 52;
            this.menuespecialistas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuespecialistas.Name = "menuespecialistas";
            this.menuespecialistas.Size = new System.Drawing.Size(152, 71);
            this.menuespecialistas.Text = "Dentista";
            this.menuespecialistas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuespecialistas.Click += new System.EventHandler(this.iconMenuItem1_Click_1);
            // 
            // menusalir
            // 
            this.menusalir.AutoSize = false;
            this.menusalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.menusalir.IconColor = System.Drawing.Color.Black;
            this.menusalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusalir.IconSize = 52;
            this.menusalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusalir.Name = "menusalir";
            this.menusalir.Size = new System.Drawing.Size(92, 71);
            this.menusalir.Text = "Salir";
            this.menusalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Teal;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1171, 96);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menutitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Consultorio Dental";
            this.label1.Click += new System.EventHandler(this.uytrujhyghj_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Silver;
            this.contenedor.Controls.Add(this.lblHora);
            this.contenedor.Controls.Add(this.pictureBox2);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 171);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1171, 542);
            this.contenedor.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Teal;
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(887, 426);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 78);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(905, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 713);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuespecialistas;
        private FontAwesome.Sharp.IconMenuItem menupacientes;
        private FontAwesome.Sharp.IconMenuItem menucitas;
        private FontAwesome.Sharp.IconMenuItem menuconsultas;
        private FontAwesome.Sharp.IconMenuItem menuservicios;
        private FontAwesome.Sharp.IconMenuItem menupagos;
        private FontAwesome.Sharp.IconMenuItem menutratamientos;
        private FontAwesome.Sharp.IconMenuItem menusalir;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerReloj;
    }
}

