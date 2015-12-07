using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KioskSaver
{
  public partial class ScreenSaverForm : Form
  {
    private DateTime _logoutTime;
    private const string _COUNTDOWN_MSG = "Auto-logout in {0:00} seconds!";
    private const double _TIMEOUT = 0;

    public ScreenSaverForm()
    {
      InitializeComponent();
    }

    private void ScreenSaverForm_Load(object sender, EventArgs e)
    {
      _logoutTime = DateTime.Now.AddSeconds(_TIMEOUT);
      CheckTime();
      timer1.Interval = 1000;
      timer1.Start();
      this.Location =
        new Point(
          Screen.PrimaryScreen.Bounds.Left + Screen.PrimaryScreen.Bounds.Width / 2 - this.Width/2,
          Screen.PrimaryScreen.Bounds.Top + Screen.PrimaryScreen.Bounds.Height / 2 - this.Height/2
        );
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      CheckTime();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void CheckTime() 
    {
      TimeSpan left = _logoutTime.Subtract(DateTime.Now);
      lCountdown.Text = string.Format(_COUNTDOWN_MSG, left.Seconds);
      if (left.TotalSeconds < 1) Logout();
    }

    //[DllImport("User32.dll", SetLastError = true)]
    //private static extern bool ExitWindowsEx(UInt32 dwOptions, Int32 dwReason);

    private void Logout()
    {
      //const UInt32 EWX_LOGOFF  = 0x00000000;
      //const UInt32 EWX_FORCEIFHUNG = 0x00000010;
      //UInt32 uFlags = EWX_LOGOFF & EWX_FORCEIFHUNG;
      //Int32 dwReason = 0;
      //timer1.Stop();
      //if (!ExitWindowsEx(uFlags,dwReason))
      //{
      //  //MessageBox.Show("Logout Failed!");
      //  Environment.Exit(-1);
      //}

      ProcessStartInfo psi = new ProcessStartInfo("shutdown.exe", "/l");
      psi.WindowStyle = ProcessWindowStyle.Hidden;
      Process.Start(psi);
      Environment.Exit(0);
    }

  }
}