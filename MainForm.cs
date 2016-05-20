using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace clickAuto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */
        
		public MainForm()
		{
			InitializeComponent();
			currentCursorPosition.Tick += getCursorPosition;
			currentCursorPosition.Enabled = true;
		}
		private void getCursorPosition(object sender, EventArgs e)
	    {
			L_Position.Text = String.Format("X: {0}{2}Y: {1}", Cursor.Position.X, Cursor.Position.Y, Environment.NewLine);
        }
        // Update current cursor position
        private readonly Timer currentCursorPosition = new Timer
        {
            Interval = 50,
            Enabled = false,
        };


        private static void performLeftClick(int x, int y)
		{
	        Cursor.Position = new System.Drawing.Point(x, y);
	        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // left button down
	        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // left button up
		}		
		private static void performRightClick(int x, int y)
		{
	        Cursor.Position = new System.Drawing.Point(x, y);
	        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0); // right button down
	        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0); // right button up
		}

        private bool running;
        private void B_Go_Click(object sender, EventArgs e)
		{
		    if (running)
		        return;
            Random rnd = new Random();
		    int x1 = (int)nud_x1.Value;
            int x2 = (int)nud_x2.Value;
            int y1 = (int)nud_y1.Value;
            int y2 = (int)nud_y2.Value;
		    int sleepms = (int)nud_sleep.Value;
            if (sleepms <= 0)
                sleepms = 1;

            new Thread(() =>
            {
                running = true;
                while (ModifierKeys != Keys.Control)
                {
                    performLeftClick(rnd.Next(x1,x2), rnd.Next(y1,y2));
                    Thread.Sleep(sleepms);
                }
                running = false;
            }).Start();
		}
	}
}
