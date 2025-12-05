using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaTourYaslina.Forms; // NECESARIO para llamar a ToursForm, PaisesForm, y DestinosForm

namespace AgenciaTourYaslina
{
    public partial class MainForm : Form
    {
        private bool salirConfirmado = false;

        public MainForm()
        {
            InitializeComponent();
            ConfigurarEfectosHover();
        }

        private void ConfigurarEfectosHover()
        {
            Button[] botones = { btnTours, btnPaises, btnDestinos, btnReportes, btnExportar, btnAyuda, btnSalir };

            foreach (Button btn in botones)
            {
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.Wheat;
                    btn.ForeColor = Color.SaddleBrown;
                };

                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.Tan;
                    btn.ForeColor = Color.SaddleBrown;
                };
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !salirConfirmado)
            {
                e.Cancel = true;
                MostrarConfirmacionSalida();
            }
            base.OnFormClosing(e);
        }

        private void MostrarConfirmacionSalida()
        {
            DialogResult result = MessageBox.Show(
                "⚠️ ¿ESTÁ SEGURO QUE DESEA SALIR DEL SISTEMA?\n\n" +
                "Se cerrará la aplicación completa de Agencia de Tours.\n" +
                "Asegúrese de haber guardado todos los cambios importantes.\n\n" +
                "¿Continuar con la salida?",
                "CONFIRMAR SALIDA DEL SISTEMA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                salirConfirmado = true;

                MessageBox.Show(
                    "👋 ¡GRACIAS POR USAR AGENCIA DE TOURS!\n\n" +
                    "Sistema desarrollado por:\n" +
                    "Destino Yaslina Ruiz\n\n" +
                    "© 2024 - Agencia de Tours Internacional\n" +
                    "¡Hasta pronto! 🏝️",
                    "DESPEDIDA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Application.Exit();
            }
        }

        // 🟢 Llama al formulario real ToursForm
        private void btnTours_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        ToursForm toursForm = new ToursForm();
                        toursForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"❌ Error al abrir Gestión de Tours:\n{ex.Message}",
                                        "Error de Apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });
        }

        // 🟢 Llama al formulario real PaisesForm
        private void btnPaises_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        PaisesForm paisesForm = new PaisesForm();
                        paisesForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"❌ Error al abrir Gestión de Países:\n{ex.Message}",
                                        "Error de Apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });
        }

        // 🟢 Llama al formulario real DestinosForm
        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        DestinosForm destinosForm = new DestinosForm();
                        destinosForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"❌ Error al abrir Gestión de Destinos:\n{ex.Message}",
                                        "Error de Apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });
        }

        // Se mantiene la función de EJEMPLO de Tours (pendiente de reemplazar).
        private void CrearFormularioTours()
        {
            Form formTours = new Form();
            formTours.Text = "🏝️ GESTIÓN DE TOURS";
            formTours.Size = new Size(1000, 600);
            formTours.StartPosition = FormStartPosition.CenterScreen;
            formTours.BackColor = Color.FromArgb(245, 245, 220);
            formTours.FormBorderStyle = FormBorderStyle.FixedSingle;
            formTours.MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "GESTIÓN COMPLETA DE TOURS";
            lblTitulo.Font = new Font("Monotype Corsiva", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(139, 69, 19);
            lblTitulo.Size = new Size(500, 50);
            lblTitulo.Location = new Point(250, 20);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            formTours.Controls.Add(lblTitulo);

            Panel panelBotones = new Panel();
            panelBotones.Location = new Point(50, 100);
            panelBotones.Size = new Size(250, 400);
            panelBotones.BackColor = Color.White;
            panelBotones.BorderStyle = BorderStyle.FixedSingle;
            formTours.Controls.Add(panelBotones);

            string[] funcionesTours = {
                "📋 LISTAR TOURS",
                "➕ AGREGAR TOUR",
                "✏️ EDITAR TOUR",
                "🗑️ ELIMINAR TOUR",
                "🔍 BUSCAR TOUR",
                "📅 TOURS POR FECHA",
                "💰 CALCULAR PRECIOS",
                "✅ VER ESTADOS"
            };

            int yPos = 20;
            foreach (string funcion in funcionesTours)
            {
                Button btnFuncion = new Button();
                btnFuncion.Text = funcion;
                btnFuncion.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnFuncion.ForeColor = Color.FromArgb(101, 67, 33);
                btnFuncion.BackColor = Color.FromArgb(210, 180, 140);
                btnFuncion.FlatStyle = FlatStyle.Flat;
                btnFuncion.FlatAppearance.BorderColor = Color.FromArgb(139, 69, 19);
                btnFuncion.FlatAppearance.BorderSize = 1;
                btnFuncion.Size = new Size(200, 40);
                btnFuncion.Location = new Point(25, yPos);
                btnFuncion.Click += (s, ev) => MessageBox.Show($"Función: {funcion}\n\nEn desarrollo...", "Tours");

                btnFuncion.MouseEnter += (s, ev) => btnFuncion.BackColor = Color.FromArgb(245, 222, 179);
                btnFuncion.MouseLeave += (s, ev) => btnFuncion.BackColor = Color.FromArgb(210, 180, 140);

                panelBotones.Controls.Add(btnFuncion);
                yPos += 45;
            }

            Panel panelDatos = new Panel();
            panelDatos.Location = new Point(320, 100);
            panelDatos.Size = new Size(600, 400);
            panelDatos.BackColor = Color.White;
            panelDatos.BorderStyle = BorderStyle.FixedSingle;
            formTours.Controls.Add(panelDatos);

            DataGridView dgvTours = new DataGridView();
            dgvTours.Location = new Point(20, 20);
            dgvTours.Size = new Size(560, 300);
            dgvTours.BackgroundColor = Color.White;
            dgvTours.BorderStyle = BorderStyle.Fixed3D;
            dgvTours.ColumnHeadersHeight = 30;
            dgvTours.RowHeadersVisible = false;
            panelDatos.Controls.Add(dgvTours);

            dgvTours.Columns.Add("ID", "ID");
            dgvTours.Columns.Add("Nombre", "Nombre del Tour");
            dgvTours.Columns.Add("Fecha", "Fecha");
            dgvTours.Columns.Add("Precio", "Precio");
            dgvTours.Columns.Add("Estado", "Estado");

            dgvTours.Rows.Add("1", "Tour Caribe", "2024-12-01", "$1,500.00", "Vigente");
            dgvTours.Rows.Add("2", "Tour Montaña", "2024-11-15", "$2,000.00", "Finalizado");
            dgvTours.Rows.Add("3", "Tour Playa", "2024-12-20", "$1,800.00", "Vigente");

            Button btnCerrar = new Button();
            btnCerrar.Text = "🚪 CERRAR FORMULARIO";
            btnCerrar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.FromArgb(139, 69, 19);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Size = new Size(200, 45);
            btnCerrar.Location = new Point(400, 520);
            btnCerrar.Click += (s, ev) => formTours.Close();
            formTours.Controls.Add(btnCerrar);

            formTours.Show();
        }

        // La función CrearFormularioPaises() ha sido eliminada.

        private void CrearFormularioDestinos()
        {
            Form formDestinos = new Form();
            formDestinos.Text = "📍 GESTIÓN DE DESTINOS";
            formDestinos.Size = new Size(900, 600);
            formDestinos.StartPosition = FormStartPosition.CenterScreen;
            formDestinos.BackColor = Color.FromArgb(245, 245, 220);
            formDestinos.FormBorderStyle = FormBorderStyle.FixedSingle;
            formDestinos.MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "GESTIÓN DE DESTINOS TURÍSTICOS";
            lblTitulo.Font = new Font("Monotype Corsiva", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(139, 69, 19);
            lblTitulo.Size = new Size(500, 50);
            lblTitulo.Location = new Point(200, 20);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            formDestinos.Controls.Add(lblTitulo);

            DataGridView dgvDestinos = new DataGridView();
            dgvDestinos.Location = new Point(50, 100);
            dgvDestinos.Size = new Size(800, 350);
            dgvDestinos.BackgroundColor = Color.White;
            dgvDestinos.BorderStyle = BorderStyle.Fixed3D;
            dgvDestinos.ColumnHeadersHeight = 30;
            formDestinos.Controls.Add(dgvDestinos);

            dgvDestinos.Columns.Add("ID", "ID");
            dgvDestinos.Columns.Add("Destino", "Nombre del Destino");
            dgvDestinos.Columns.Add("País", "País");
            dgvDestinos.Columns.Add("Duración", "Duración");
            dgvDestinos.Columns.Add("Descripción", "Descripción");

            dgvDestinos.Rows.Add("1", "Punta Cana", "República Dominicana", "7 días", "Playa paradisíaca");
            dgvDestinos.Rows.Add("2", "Cancún", "México", "5 días", "Aguas turquesas");
            dgvDestinos.Rows.Add("3", "Barcelona", "España", "4 días", "Arquitectura única");
            dgvDestinos.Rows.Add("4", "Roma", "Italia", "6 días", "Historia antigua");

            Panel panelBotones = new Panel();
            panelBotones.Location = new Point(50, 470);
            panelBotones.Size = new Size(800, 80);
            panelBotones.BackColor = Color.FromArgb(245, 245, 220);
            formDestinos.Controls.Add(panelBotones);

            string[] botonesDestinos = { "➕ AGREGAR", "✏️ EDITAR", "🗑️ ELIMINAR", "🔍 BUSCAR", "🚪 CERRAR" };
            EventHandler[] accionesDestinos = {
                (s, ev) => MessageBox.Show("Agregar nuevo destino", "Agregar"),
                (s, ev) => MessageBox.Show("Editar destino seleccionado", "Editar"),
                (s, ev) => MessageBox.Show("Eliminar destino", "Eliminar"),
                (s, ev) => MessageBox.Show("Buscar destino", "Buscar"),
                (s, ev) => formDestinos.Close()
            };

            int xPos = 50;
            for (int i = 0; i < botonesDestinos.Length; i++)
            {
                Button btn = new Button();
                btn.Text = botonesDestinos[i];
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.ForeColor = Color.FromArgb(101, 67, 33);
                btn.BackColor = Color.FromArgb(210, 180, 140);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(139, 69, 19);
                btn.FlatAppearance.BorderSize = 2;
                btn.Size = new Size(120, 40);
                btn.Location = new Point(xPos, 20);
                btn.Click += accionesDestinos[i];

                btn.MouseEnter += (s, ev) => btn.BackColor = Color.FromArgb(245, 222, 179);
                btn.MouseLeave += (s, ev) => btn.BackColor = Color.FromArgb(210, 180, 140);

                panelBotones.Controls.Add(btn);
                xPos += 140;
            }

            formDestinos.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Form formReportes = new Form();
            formReportes.Text = "📊 REPORTES DEL SISTEMA";
            formReportes.Size = new Size(800, 600);
            formReportes.StartPosition = FormStartPosition.CenterScreen;
            formReportes.BackColor = Color.FromArgb(245, 245, 220);
            formReportes.FormBorderStyle = FormBorderStyle.FixedSingle;
            formReportes.MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "REPORTES ESTADÍSTICOS";
            lblTitulo.Font = new Font("Monotype Corsiva", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(139, 69, 19);
            lblTitulo.Size = new Size(400, 50);
            lblTitulo.Location = new Point(200, 20);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            formReportes.Controls.Add(lblTitulo);

            Panel panelReportes = new Panel();
            panelReportes.Location = new Point(50, 100);
            panelReportes.Size = new Size(700, 400);
            panelReportes.BackColor = Color.White;
            panelReportes.BorderStyle = BorderStyle.FixedSingle;
            panelReportes.Padding = new Padding(20);
            formReportes.Controls.Add(panelReportes);

            string[] reportes = {
                "📈 Tours por país (Gráfico de barras)",
                "📊 Tours vigentes vs finalizados (Gráfico de pastel)",
                "💰 Ingresos por mes (Gráfico de líneas)",
                "📍 Destinos más populares (Top 10)",
                "📅 Tours por temporada (Análisis estacional)",
                "👥 Clientes por tour (Estadísticas de participación)",
                "⭐ Calificaciones promedio de tours",
                "🔄 Tours más reeditados (Historial de cambios)"
            };

            int yPosReportes = 20;
            foreach (string reporte in reportes)
            {
                Button btnReporte = new Button();
                btnReporte.Text = reporte;
                btnReporte.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                btnReporte.ForeColor = Color.FromArgb(101, 67, 33);
                btnReporte.BackColor = Color.FromArgb(245, 245, 220);
                btnReporte.FlatStyle = FlatStyle.Flat;
                btnReporte.FlatAppearance.BorderColor = Color.FromArgb(139, 69, 19);
                btnReporte.FlatAppearance.BorderSize = 1;
                btnReporte.Size = new Size(650, 35);
                btnReporte.Location = new Point(10, yPosReportes);
                btnReporte.TextAlign = ContentAlignment.MiddleLeft;
                btnReporte.Click += (s, ev) => MessageBox.Show($"Generando reporte:\n{reporte}", "Reporte");

                btnReporte.MouseEnter += (s, ev) => btnReporte.BackColor = Color.FromArgb(210, 180, 140);
                btnReporte.MouseLeave += (s, ev) => btnReporte.BackColor = Color.FromArgb(245, 245, 220);

                panelReportes.Controls.Add(btnReporte);
                yPosReportes += 45;
            }

            Button btnCerrarReportes = new Button();
            btnCerrarReportes.Text = "🚪 CERRAR REPORTES";
            btnCerrarReportes.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnCerrarReportes.ForeColor = Color.White;
            btnCerrarReportes.BackColor = Color.FromArgb(139, 69, 19);
            btnCerrarReportes.FlatStyle = FlatStyle.Flat;
            btnCerrarReportes.Size = new Size(200, 45);
            btnCerrarReportes.Location = new Point(300, 520);
            btnCerrarReportes.Click += (s, ev) => formReportes.Close();
            formReportes.Controls.Add(btnCerrarReportes);

            formReportes.Show();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📊 La función de Exportación General ha sido movida a los formularios individuales (Tours, Países, Destinos) para asegurar que solo se exporten los datos visibles. Procede a exportar desde la gestión deseada.",
                    "Exportación General (Movida)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Form formAyuda = new Form();
            formAyuda.Text = "❓ CENTRO DE AYUDA - AGENCIA DE TOURS";
            formAyuda.Size = new Size(700, 600);
            formAyuda.StartPosition = FormStartPosition.CenterScreen;
            formAyuda.BackColor = Color.FromArgb(245, 245, 220);
            formAyuda.FormBorderStyle = FormBorderStyle.FixedSingle;
            formAyuda.MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "CENTRO DE AYUDA - SISTEMA DE TOURS";
            lblTitulo.Font = new Font("Monotype Corsiva", 20, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(139, 69, 19);
            lblTitulo.Size = new Size(500, 40);
            lblTitulo.Location = new Point(100, 20);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            formAyuda.Controls.Add(lblTitulo);

            RichTextBox rtbAyuda = new RichTextBox();
            rtbAyuda.Location = new Point(50, 80);
            rtbAyuda.Size = new Size(600, 350);
            rtbAyuda.BackColor = Color.White;
            rtbAyuda.BorderStyle = BorderStyle.FixedSingle;
            rtbAyuda.Font = new Font("Segoe UI", 10);
            rtbAyuda.ReadOnly = true;

            string ayudaTexto = @"🏝️ AGENCIA DE TOURS INTERNACIONAL
Sistema de Gestión Turística Profesional
Versión: 2.0 | © 2024 Todos los derechos reservados

📞 INFORMACIÓN DE CONTACTO:
• Teléfono: +1 (809) 555-TOUR
• Email: info@agenciatours.com
• Sitio Web: www.agenciatours.com
• Dirección: Av. Turística #123, Santo Domingo

🕐 HORARIOS DE ATENCIÓN:
• Lunes a Viernes: 8:00 AM - 6:00 PM
• Sábados: 9:00 AM - 2:00 PM
• Domingos: Cerrado

🎯 FUNCIONALIDADES DEL SISTEMA:

1. GESTIÓN DE TOURS
   • Registro completo de tours
   • Control de disponibilidad
   • Gestión de precios y promociones
   • Asignación de guías turísticos
   • Control de cupos y reservas

2. ADMINISTRACIÓN DE PAÍSES
   • Catálogo mundial de destinos
   • Información de requisitos de viaje
   • Documentación necesaria
   • Alertas de seguridad por país

3. CONTROL DE DESTINOS
   • Detalles de atracciones
   • Alojamientos disponibles
   • Transportes incluidos
   • Actividades turísticas

4. REPORTES AVANZADOS
   • Análisis de ventas por temporada
   • Rentabilidad por tour
   • Satisfacción del cliente
   • Tendencias del mercado turístico

5. HERRAMIENTAS DE EXPORTACIÓN
   • Reportes para contabilidad
   • Datos para análisis de mercado
   • Informes para socios comerciales
   • Backup automático del sistema

⚠️ MEDIDAS DE SEGURIDAD:
• Encriptación de datos sensibles
• Control de acceso por roles
• Auditoría de cambios
• Backup automático diario

🔧 SOPORTE TÉCNICO:
• Asistencia telefónica: Ext. 101
• Soporte por email: soporte@agenciatours.com
• Manual de usuario disponible en recepción
• Capacitaciones mensuales para personal

🌟 NUESTROS VALORES:
• Calidad en el servicio
• Seguridad para nuestros clientes
• Innovación tecnológica
• Sostenibilidad turística";

            rtbAyuda.Text = ayudaTexto;
            formAyuda.Controls.Add(rtbAyuda);

            Button btnCerrarAyuda = new Button();
            btnCerrarAyuda.Text = "🚪 CERRAR AYUDA";
            btnCerrarAyuda.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnCerrarAyuda.ForeColor = Color.White;
            btnCerrarAyuda.BackColor = Color.FromArgb(139, 69, 19);
            btnCerrarAyuda.FlatStyle = FlatStyle.Flat;
            btnCerrarAyuda.Size = new Size(350, 60);
            btnCerrarAyuda.Location = new Point(200, 470);
            btnCerrarAyuda.Click += (s, ev) => formAyuda.Close();
            formAyuda.Controls.Add(btnCerrarAyuda);

            formAyuda.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MostrarConfirmacionSalida();
        }
    }
}