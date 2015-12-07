namespace KioskSaver
{
  partial class OptionsForm : System.Windows.Forms.Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
      this.backgroundImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.backgroundImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // backgroundImageFolderBrowser
      // 
      this.backgroundImageFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyPictures;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(97, 79);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Close";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(137, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "There are no options to set.";
      this.label1.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(184, 114);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Name = "OptionsForm";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.Text = "Screen Saver Settings";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog backgroundImageOpenFileDialog;
    private System.Windows.Forms.FolderBrowserDialog backgroundImageFolderBrowser;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label label1;
  }
}