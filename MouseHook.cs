using System.Runtime.InteropServices;

namespace BattleBit_Remastered_RCS
{
    public static class MouseHook
    {
        // Get async key state
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);
        // Get mouse event
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        // Move mouse
        public static void RelativeMove(int x, int y)
        {
            mouse_event(0x0001, x, y, 0, 0);
        }
        // Check if a key is pressed
        public static bool IsKeyPressed(Keys vKey)
        {
            return (GetAsyncKeyState(vKey) & 0x8000) == 0x8000;
        }
    }
}