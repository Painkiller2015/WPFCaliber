using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Caliber
{ 
    public static class HotkeyServices
    {
        public static void test()
        {
            var hotkey = new Hotkey(IntPtr.Zero);

           // hotkey.Add(new Hotkey.NativeKey(Hotkey.ModifierKeys.Shift, Hotkey.WindowsKeys.Up), () => Program.);
            hotkey.Add(new Hotkey.NativeKey(Hotkey.ModifierKeys.Shift, Hotkey.WindowsKeys.Down), () => Process.GetCurrentProcess().Kill());
            hotkey.Add(new Hotkey.NativeKey(Hotkey.ModifierKeys.Shift, Hotkey.WindowsKeys.Left), () => Process.GetCurrentProcess().Kill());

            hotkey.Start();

        }


        static void Pause()
        {
            while (true)
            {
                Thread.Sleep(100);
            }
        }

    }
}
