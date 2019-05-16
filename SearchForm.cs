// Copyright Eric Chauvin 2017 - 2019.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CodeEditor2
{
  public class SearchForm : Form
  {
  private string SearchText = "";
  private System.Windows.Forms.TextBox SearchTextBox;



  public SearchForm()
    {
    InitializeGuiComponents();
    }



  private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
    {
    if( e.KeyCode == Keys.Enter ) //  && (e.Alt || e.Control || e.Shift))
      {
      SearchText = SearchTextBox.Text.Trim();
      DialogResult = DialogResult.OK;
      Close();
      }
    }



  internal string GetSearchText()
    {
    return SearchText;
    }




  private void InitializeGuiComponents()
    {
      this.SearchTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      //
      // SearchTextBox
      //
      this.SearchTextBox.Location = new System.Drawing.Point(25, 24);
      this.SearchTextBox.Name = "SearchTextBox";
      this.SearchTextBox.Size = new System.Drawing.Size( 400, 39 );
      this.SearchTextBox.TabIndex = 0;
      this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);

      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(450, 138);
      this.Controls.Add(this.SearchTextBox);

      // this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.Font = new System.Drawing.Font( "Consolas", 30.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));

      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SearchForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Search";
      this.ResumeLayout(false);
      this.PerformLayout();
    }



  internal void FreeEverything()
    {
    SearchTextBox.Dispose();
    }



  }
}

















