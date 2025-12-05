using System;
using System.Windows.Forms;

namespace AgenciaTourYaslina
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Manejo de errores global
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) =>
            {
                MessageBox.Show($"Error no manejado:\n{e.Exception.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                MessageBox.Show($"Error crítico:\n{((Exception)e.ExceptionObject).Message}",
                    "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Iniciar aplicación con MainForm
            Application.Run(new MainForm());
        }
    }
}
