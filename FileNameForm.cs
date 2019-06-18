// Copyright Eric Chauvin 2019.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace CodeEditor2
{
  public class FileNameForm : Form
  {
  private string StartDirectory = "";
  private string FileNameText = "";
  private System.Windows.Forms.ComboBox FileNameComboBox;
  private System.Windows.Forms.Label FileNameLabel;
  private string FileExtension = "*.*";



  private FileNameForm()
    {
    // InitializeGuiComponents();
    }




  public FileNameForm( string StartDir, string FileExt )
    {
    FileExtension = FileExt;
    StartDirectory = StartDir;
    InitializeGuiComponents();

    SetupFileNames( StartDirectory );
    }



  private void SetupFileNames( string DirName )
    {
    try
    {
    FileNameComboBox.Text = "";
    FileNameComboBox.Items.Clear();
    FileNameComboBox.Items.Add( "A> C:\\Eric" );

    string[] FileEntries = Directory.GetFiles( DirName, FileExtension );
    foreach( string FileName in FileEntries )
      {
      // if( !MForm.CheckEvents())
        // return false;

      FileNameComboBox.Items.Add( FileName );
      }

    string [] SubDirEntries = Directory.GetDirectories( DirName );
    foreach( string SubDir in SubDirEntries )
      {
      // if( !MForm.CheckEvents())
      //  return false;

      FileNameComboBox.Items.Add( "A> " + SubDir );

      // Call itself recursively to go down in to each
      // subdirectory.
      // if( !SearchOneDirectory( SubDir ))
      //  return false;
      }
    }
    catch( Exception Except )
      {
      string ShowS = "Searching the directory. Is this a file name? Exception getting file names.\r\n" +
                     DirName + "\r\n" +
                     Except.Message;

      MessageBox.Show( ShowS, "Exception", MessageBoxButtons.OK );
      }
    }




  private void FileNameComboBox_KeyDown(object sender, KeyEventArgs e)
    {
    if( e.KeyCode == Keys.Enter ) //  && (e.Alt || e.Control || e.Shift))
      {
      FileNameText = FileNameComboBox.Text.Trim();
      if( FileNameText.StartsWith( "A> " ))
        {
        FileNameText = FileNameText.Replace( "A> ", "" );
        SetupFileNames( FileNameText );
        return;
        }

      DialogResult = DialogResult.OK;
      Close();
      }
    }



  internal string GetFileNameText()
    {
    return FileNameText;
    }



  private void InitializeGuiComponents()
    {
    FileNameComboBox = new System.Windows.Forms.ComboBox();
    FileNameLabel = new System.Windows.Forms.Label();

    this.SuspendLayout();

    // FileNameComboBox.BackColor = System.Drawing.Color.Black;
    // FileNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    // FileNameComboBox.ForeColor = System.Drawing.Color.White;
    FileNameComboBox.FormattingEnabled = true;
    // FileNameComboBox.Items.AddRange(new object[] {
    //         "that",
    //         "this"});

    FileNameComboBox.Location = new System.Drawing.Point( 10, 50 );

    // Set IntegralHeight = false so that
    // MaxDropDownItems will work.
    FileNameComboBox.IntegralHeight = false;
    FileNameComboBox.MaxDropDownItems = 8;

    FileNameComboBox.Name = "FileNameComboBox";
    FileNameComboBox.Size = new System.Drawing.Size( 960, 10 );
    FileNameComboBox.Sorted = true;
    FileNameComboBox.TabIndex = 1;
    FileNameComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler( this.FileNameComboBox_KeyDown );
    FileNameComboBox.Text = ""; // StartDirectory;

    FileNameLabel.AutoSize = true;
    // FileNameLabel.BackColor = System.Drawing.Color.Black;
    // FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    // FileNameLabel.ForeColor = System.Drawing.Color.White;
    FileNameLabel.Location = new System.Drawing.Point( 10, 10 );
    FileNameLabel.Name = "FileNameLabel";
    FileNameLabel.Size = new System.Drawing.Size(60, 24);
    FileNameLabel.TabIndex = 2;
    FileNameLabel.Text = "File Name: ";


    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
    this.BackColor = System.Drawing.Color.Black;
    this.ClientSize = new System.Drawing.Size( 990, 138 );
    this.Controls.Add( FileNameLabel );
    this.Controls.Add( FileNameComboBox );
    this.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
    this.ForeColor = System.Drawing.Color.White;
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
    this.Name = "FileNameForm";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "File Name";

    this.ResumeLayout(false);
    this.PerformLayout();
    }



  internal void FreeEverything()
    {
    FileNameComboBox.Dispose();
    FileNameLabel.Dispose();
    }




  }
}





