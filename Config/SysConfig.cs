using System.Windows;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;
using System;
using System.Globalization;

namespace Caliber
{
    public static class SysConfig
    {
        public static string GetSystemLanguage()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            return culture.ThreeLetterISOLanguageName;
        }
        public static int GetWidthScreen()
        {
            return VirtualScreenExtender.Width;
        }
        public static int GetHeightScreen()
        {
            return VirtualScreenExtender.Height;
        }
        public static string GetLogPath()
        {
            //string pathWithEnv = @"%USERPROFILE%\\AppData\\LocalLow\\1CGS\\Caliber\\Player.log";
            string pathWithEnv = Path.Combine("%USERPROFILE%", "AppData", "LocalLow", "1CGS", "Caliber", "Player.log");
            string filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            return filePath;
        }
        public static string GetStaticPath()
        {
            //string pathWithEnv = @"%USERPROFILE%\\AppData\\LocalLow\\1CGS\\Caliber\\CompressedData\\client\static";
            string pathWithEnv = Path.Combine("%USERPROFILE%", "AppData", "LocalLow", "1CGS", "Caliber", "CompressedData", "client", "static");
            string filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            return filePath;
        }
        private static class VirtualScreenExtender
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int Left; // x position of upper-left corner
                public int Top; // y position of upper-left corner
                public int Right; // x position of lower-right corner
                public int Bottom; // y position of lower-right corner
            }

            [DllImport("gdi32.dll")]
            private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

            [DllImport("user32.dll")]
            private static extern IntPtr GetDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect(HandleRef hwnd, out RECT lpRect);

            [DllImport("user32.dll", SetLastError = false)]
            private static extern IntPtr GetDesktopWindow();


            private const int LOGPIXELSX = 88;
            private const int LOGPIXELSY = 90;
            private static readonly object SyncRoot = new object();

            static VirtualScreenExtender()
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                DpiX = GetDeviceCaps(hdc, LOGPIXELSX);
                DpiY = GetDeviceCaps(hdc, LOGPIXELSY);

                var desktop = GetDesktopWindow();

                GetWindowRect(new HandleRef(SyncRoot, desktop), out RECT rect);
                Width = rect.Right;
                Height = rect.Bottom;
            }

            public static int DpiX { get; private set; }
            public static int DpiY { get; private set; }
            public static int Width { get; private set; }
            public static int Height { get; private set; }
        }
    }
}
