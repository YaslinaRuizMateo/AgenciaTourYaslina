namespace AgenciaTourYaslina
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnPaises;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnPaises = new System.Windows.Forms.Button();
            this.btnTours = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelSuperior.Controls.Add(this.labelSubtitulo);
            this.panelSuperior.Controls.Add(this.labelTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(900, 120);
            this.panelSuperior.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitulo.ForeColor = System.Drawing.Color.Wheat;
            this.labelSubtitulo.Location = new System.Drawing.Point(169, 80);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(600, 40);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Destino Yaslina Ruiz ";
            this.labelSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Beige;
            this.labelTitulo.Location = new System.Drawing.Point(150, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(600, 70);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "🏝️ AGENCIA DE TOURS";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.btnExportar);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnDestinos);
            this.panelMenu.Controls.Add(this.btnPaises);
            this.panelMenu.Controls.Add(this.btnTours);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Location = new System.Drawing.Point(100, 145);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(691, 501);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSalir.Location = new System.Drawing.Point(175, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(300, 50);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "🚪  SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Tan;
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnAyuda.FlatAppearance.BorderSize = 2;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAyuda.Location = new System.Drawing.Point(42, 260);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(300, 50);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "❓  AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Tan;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnExportar.FlatAppearance.BorderSize = 2;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExportar.Location = new System.Drawing.Point(368, 177);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(300, 50);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "📤  EXPORTAR DATOS CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Tan;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnReportes.FlatAppearance.BorderSize = 2;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReportes.Location = new System.Drawing.Point(368, 260);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(300, 50);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "📊  VER REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.BackColor = System.Drawing.Color.Tan;
            this.btnDestinos.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnDestinos.FlatAppearance.BorderSize = 2;
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDestinos.Location = new System.Drawing.Point(42, 177);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(300, 50);
            this.btnDestinos.TabIndex = 3;
            this.btnDestinos.Text = "📍  GESTIONAR DESTINOS";
            this.btnDestinos.UseVisualStyleBackColor = false;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnPaises
            // 
            this.btnPaises.BackColor = System.Drawing.Color.Tan;
            this.btnPaises.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPaises.FlatAppearance.BorderSize = 2;
            this.btnPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaises.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaises.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPaises.Location = new System.Drawing.Point(368, 96);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(300, 50);
            this.btnPaises.TabIndex = 2;
            this.btnPaises.Text = "🌍  GESTIONAR PAÍSES";
            this.btnPaises.UseVisualStyleBackColor = false;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnTours
            // 
            this.btnTours.BackColor = System.Drawing.Color.Tan;
            this.btnTours.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnTours.FlatAppearance.BorderSize = 2;
            this.btnTours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTours.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnTours.Location = new System.Drawing.Point(42, 96);
            this.btnTours.Name = "btnTours";
            this.btnTours.Size = new System.Drawing.Size(300, 50);
            this.btnTours.TabIndex = 1;
            this.btnTours.Text = "🏝️  GESTIONAR TOURS";
            this.btnTours.UseVisualStyleBackColor = false;
            this.btnTours.Click += new System.EventHandler(this.btnTours_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelMenu.Location = new System.Drawing.Point(186, 24);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(300, 40);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "MENÚ PRINCIPAL";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENCIA DE TOURS - DESTINO YASLINA RUIZ";
            this.panelSuperior.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}