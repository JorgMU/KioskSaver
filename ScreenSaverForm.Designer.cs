namespace KioskSaver
{
  partial class ScreenSaverForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnAbort = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lCountdown = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnAbort
      // 
      this.btnAbort.Location = new System.Drawing.Point(104, 65);
      this.btnAbort.Name = "btnAbort";
      this.btnAbort.Size = new System.Drawing.Size(75, 23);
      this.btnAbort.TabIndex = 0;
      this.btnAbort.Text = "Abort";
      this.btnAbort.UseVisualStyleBackColor = true;
      this.btnAbort.Click += new System.EventHandler(this.button1_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // lCountdown
      // 
      this.lCountdown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lCountdown.ForeColor = System.Drawing.Color.Red;
      this.lCountdown.Location = new System.Drawing.Point(12, 24);
      this.lCountdown.Name = "lCountdown";
      this.lCountdown.Size = new System.Drawing.Size(260, 23);
      this.lCountdown.TabIndex = 1;
      this.lCountdown.Text = "lCountdown";
      this.lCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ScreenSaverForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 114);
      this.Controls.Add(this.lCountdown);
      this.Controls.Add(this.btnAbort);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ScreenSaverForm";
      this.Text = "KioskSaver";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAbort;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label lCountdown;
  }
}