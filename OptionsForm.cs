using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;


namespace KioskSaver
{
  partial class OptionsForm : Form
  {
    public OptionsForm()
    {
      InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}