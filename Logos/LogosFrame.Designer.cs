using System;
using System.Drawing;
using System.Windows.Forms;
using ICSharpCode.TextEditor;

namespace Logos
{
    partial class LogosFrame
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
            this.codeEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // codeEditor
            // 
            this.codeEditor.AutoScroll = true;
            this.codeEditor.AutoSize = true;
            this.codeEditor.IsReadOnly = false;
            this.codeEditor.Location = new System.Drawing.Point(0, 0);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(3000, 1920);
            this.codeEditor.TabIndex = 0;
            this.codeEditor.Text = "textEditorControl1";
            this.codeEditor.Load += new System.EventHandler(this.codeEditor_Load);
            // 
            // LogosFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3000, 1920);
            this.Controls.Add(this.codeEditor);
            this.Name = "LogosFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogosFrame_Load);
            this.Load += new EventHandler(this.OnNormalize);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private ICSharpCode.TextEditor.TextEditorControl codeEditor;

     #endregion
    }
}