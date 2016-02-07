using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedWinapi;
using System.Windows.Forms;

namespace Megajewel
{
    public class HotkeyManager
    {
        MegajewelForm Form;
        List<Hotkey> Hotkeys = new List<Hotkey>();
        public HotkeyManager(MegajewelForm form)
        {
            Form = form;
            AddHotkey(Keys.H, () =>
            {
                form.txtDebugLog.Text = "Hello, hotkeys!" + Environment.NewLine + form.txtDebugLog.Text;
            });
            AddHotkey(Keys.Tab, () =>
            {
                Form.IsAutonomous = !Form.IsAutonomous;
            });
           
        }
        public void AddHotkey(Keys key, Action callback, bool ctrl = false, bool shift = false, bool alt = false)
        {
            Hotkey h = new Hotkey();
            h.KeyCode = key;
            h.Ctrl = ctrl;
            h.Shift = shift;
            h.Alt = alt;
            h.HotkeyPressed += new EventHandler((obj, evargs)=>
            {
                callback();
            });
            h.Enabled = true;
            Hotkeys.Add(h);
        }
    }
}
