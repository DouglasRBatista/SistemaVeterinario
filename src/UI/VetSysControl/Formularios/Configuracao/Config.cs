using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace VetSysControl.Formularios.Configuracao
{
    internal class Config
    {
        public const int HWND_BROADCAST = 0xffff;

        public static int WM_WAKEUP_WINDOW = RegisterWindowMessage("0");

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int RegisterWindowMessage(string lpString);

        [DllImport("User32")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);



    }
}
