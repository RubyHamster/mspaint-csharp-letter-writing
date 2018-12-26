using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace mspaintArtist
{
    public class alphabet
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public static void A()
        {

            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 10;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 10;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 2;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void B()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void C()
        {
            uint X = (uint)Cursor.Position.X + 25;
            uint Y = (uint)Cursor.Position.Y;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 25;
            Y -= 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y -= 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 10;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void D()
        {

            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void E()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 25;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 20;
            Y += 15;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void F()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 25;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 20;
            Y += 15;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void G()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 30;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 25;
            Y += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void H()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void I()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 40;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 40;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 40;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void J()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 40;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 40;
            Y += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 23;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void K()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y -= 25; Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 3;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void L()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void M()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 5;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void N()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 30;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            X += 5;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void O()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 37;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void P()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 26;
            X += 25;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void Q()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 5;
            Y -= 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 10;
            Y += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 5;
            Y -= 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void R()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 12;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 26;
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 5;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void S()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            X += 5;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void T()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 40;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 40;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 47;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void U()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void V()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y - 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void W()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y - 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 50;
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y -= 50;
            X += 10;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void X()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y-50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y -= 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Y += 50;
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void Y()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y - 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Y -= 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X -= 20;
            Y += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Y += 30;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 27;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void Z()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y - 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X -= 20;
            Y += 50;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            X += 7;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
        public static void SPACE()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            X += 20;
            Cursor.Position = new System.Drawing.Point(Int32.Parse(X.ToString()), Int32.Parse(Y.ToString()));
        }
    }
}
