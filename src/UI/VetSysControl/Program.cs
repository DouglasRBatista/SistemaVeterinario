using VetSysControl.Configuracao;

namespace VetSysControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) 
            {
                Config.PostMessage(Config.HWND_BROADCAST, Config.WM_WAKEUP_WINDOW, IntPtr.Zero, IntPtr.Zero);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
                
            ApplicationConfiguration.Initialize();
            //Application.Run(new Formularios.MDI());
            Application.Run(new FORMULARIOS.Login.Login());
        }
    }
}