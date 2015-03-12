using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mip2Win
{
    class WinampControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        public static extern IntPtr FindWindow( 
            [MarshalAs(UnmanagedType.LPTStr)] string lpClassName,
            [MarshalAs(UnmanagedType.LPTStr)] string lpWindowName
            );


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessageA(IntPtr hwnd, int wMsg, int wParam, uint lParam );

        private const string m_windowName = "Winamp v1.x";
        const int WM_COMMAND = 0x0111;
        const int WM_USER = 0x0400;
        const int WA_NOTHING = 0;
        const int WA_PREVTRACK = 40044;
        const int WA_PLAY = 40045;
        const int WA_PAUSE = 40046;
        const int WA_STOP = 40047;
        const int WA_NEXTTRACK = 40048;
        const int WA_VOLUMEUP = 40058;
        const int WA_VOLUMEDOWN = 40059;
        const int WINAMP_FFWD5S = 40060;
        const int WINAMP_REW5S = 40061;
        const int WINAMP_CURRENT = 40029;

        public void getCurrent()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WINAMP_CURRENT, WA_NOTHING);
            //return retval;
        }

        public void Stop()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_STOP, WA_NOTHING);
        }

        public void Play()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_PLAY, WA_NOTHING);
        }

        public void Pause()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_PAUSE, WA_NOTHING);
        }

        public void PrevTrack()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_PREVTRACK, WA_NOTHING);
        }

        public void NextTrack()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_NEXTTRACK, WA_NOTHING);
        }

        public void VolumeUp()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_VOLUMEUP, WA_NOTHING);
        }
        
        public void VolumeDown()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WA_VOLUMEDOWN, WA_NOTHING);
        }

        public void Forward5Sec()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WINAMP_FFWD5S, WA_NOTHING);
        }

        public void Rewind5Sec()
        {
            IntPtr hwnd = FindWindow(m_windowName, null);
            SendMessageA(hwnd, WM_COMMAND, WINAMP_REW5S, WA_NOTHING);
        } 
    }
}
