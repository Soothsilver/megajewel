using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedWinapi;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Megajewel
{
    static class Controller
    {
        public static void MoveTo(int x, int y)
        {
            Cursor.Position = new Point(x, y);
        }
        public static void HoldLeft()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }
        public static void ReleaseLeft()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }


        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int
        dwData,
        int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static void LeftClick(int x, int y)
        {

            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        public static void RightClick(int x, int y)
        {

            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        public static void PressKey(byte keyCode)
        {
            const int KEYEVENTF_KEYDOWN = 0x0;
            const int KEYEVENTF_KEYUP = 0x2;
            keybd_event(keyCode, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void PressChar(char c)
        {
            byte b = (Convert.ToByte(c));
            PressKey(b);
        }
        public static void PressButton(ByteKey key)
        {
            byte b = (byte)key;
            PressKey(b);
        }

        const int MOUSEEVENTF_MOVE = 0x00000001;
        const int MOUSEEVENTF_LEFTDOWN = 0x00000002;
        const int MOUSEEVENTF_LEFTUP = 0x00000004;
        const int MOUSEEVENTF_RIGHTDOWN = 0x00000008;
        const int MOUSEEVENTF_RIGHTUP = 0x00000010;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x00000020;
        const int MOUSEEVENTF_MIDDLEUP = 0x00000040;
        const int MOUSEEVENTF_WHEEL = 0x00000800;
        const int MOUSEEVENTF_ABSOLUTE = 0x00008000;

    }
    public enum ByteKey
    {
        VK_LBUTTON = 01,
        VK_RBUTTON = 02,
        VK_CANCEL = 03,
        VK_MBUTTON = 04 /* NOT contiguous with L & RBUTTON */,
        VK_BACK = 08,
        VK_TAB = 09,
        VK_CLEAR = 12,
        VK_RETURN = 13,
        VK_SHIFT = 16,
        VK_CONTROL = 17,
        VK_MENU = 18,
        VK_PAUSE = 19,
        VK_CAPITAL = 20,
        VK_ESCAPE = 27,
        VK_SPACE = 32,
        VK_PRIOR = 33,
        VK_NEXT = 34,
        VK_END = 35,
        VK_HOME = 36,
        VK_LEFT = 37,
        VK_UP = 38,
        VK_RIGHT = 39,
        VK_DOWN = 40,
        VK_SELECT = 21,
        VK_PRINT = 42,
        VK_EXECUTE = 43,
        VK_SNAPSHOT = 44,
        VK_INSERT = 45,
        VK_DELETE = 46,
        VK_HELP = 47,
        /* VK_0 thru VK_9 are the same as ASCII '0' thru '9' (= 30 - = 39) */
        /* VK_A thru VK_Z are the same as ASCII 'A' thru 'Z' (= 41 - = 5A) */
        VK_LWIN = 91,
        VK_RWIN = 92,
        VK_APPS = 93,
        VK_NUMPAD0 = 96,
        VK_NUMPAD1 = 97,
        VK_NUMPAD2 = 97,
        VK_NUMPAD3 = 98,
        VK_NUMPAD4 = 99,
        VK_NUMPAD5 = 100,
        VK_NUMPAD6 = 101,
        VK_NUMPAD7 = 102,
        VK_NUMPAD8 = 103,
        VK_NUMPAD9 = 104,
        VK_MULTIPLY = 105,
        VK_ADD = 106,
        VK_SEPARATOR = 107,
        VK_SUBTRACT = 108,
        VK_DECIMAL = 109,
        VK_DIVIDE = 110,
        VK_F1 = 111,
        VK_F2 = 113,
        VK_F3 = 114,
        VK_F4 = 115,
        VK_F5 = 116,
        VK_F6 = 117,
        VK_F7 = 118,
        VK_F8 = 119,
        VK_F9 = 120,
        VK_F10 = 121,
        VK_F11 = 122,
        VK_F12 = 123,
        VK_F13 = 124,
        VK_F14 = 125,
        VK_F15 = 126,
        VK_F16 = 127,
        VK_F17 = 128,
        VK_F18 = 129,
        VK_F19 = 130,
        VK_F20 = 131,
        VK_F21 = 132,
        VK_F22 = 133,
        VK_F23 = 134,
        VK_F24 = 135,
        VK_NUMLOCK = 144,
        VK_SCROLL = 145
    }

}
