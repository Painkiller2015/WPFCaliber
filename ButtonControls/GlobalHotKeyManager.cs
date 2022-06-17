using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caliber
{
    internal sealed class GlobalHotKeyManager : IDisposable
    {
        internal event EventHandler StartProcessEvent;

        internal bool StartedProcess { get; private set; } 


        private LowLevelKeyboardListener _listener;
        
        internal bool PressedLeftCtrl { get; private set; }
        internal bool PressedD { get; private set; }

        private const Key _keyLeftCtrl = Key.LeftCtrl;
        private const Key _keyD = Key.D;
        
        internal GlobalHotKeyManager()
        {
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyDown += _listener_OnKeyDown;
            _listener.OnKeyUp += _listener_OnKeyUp;

            _listener.HookKeyboard();
        }

        void _listener_OnKeyDown(object sender, KeyDownArgs e)
        {
            switch (e.KeyDown)
            {
                case _keyLeftCtrl:
                    PressedLeftCtrl = true;
                    break;
                case _keyD:
                    PressedD = true;
                    break;
            }

            if (PressedLeftCtrl)
            {
                if (PressedD)
                {
                    StartedProcess = !StartedProcess;

                    StartProcessEvent?.Invoke(null, null);

                    PressedLeftCtrl = false;
                    PressedD = false;
                }
            }
        }

        void _listener_OnKeyUp(object sender, KeyUpArgs e)
        {
            switch (e.KeyUp)
            {
                case _keyLeftCtrl:
                    PressedLeftCtrl = false;
                    break;
                case _keyD:
                    PressedD = false;
                    break;
            }
        }

        public void Dispose()
        {
            _listener.UnHookKeyboard();
        }
    }
}
