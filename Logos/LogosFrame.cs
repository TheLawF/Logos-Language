using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using Logos.Logics;

namespace Logos
{
    public partial class LogosFrame : Form
    {
        private readonly PrivateFontCollection _pfc = new PrivateFontCollection();
        private readonly int _width = SystemInformation.PrimaryMonitorSize.Width;
        private readonly int _height = SystemInformation.PrimaryMonitorSize.Height;
        public LogosFrame()
        {
            InitializeComponent();
        }
        
        private void LogosFrame_Load(object sender, EventArgs e)
        {
            ImportFont();
            Size = new Size(_width, _height);
            
        }
        
        private void codeEditor_Load(object sender, EventArgs e)
        {

            codeEditor.Encoding = Encoding.UTF8;
            codeEditor.Size = new Size(_width, _height);
            var codeFont = new FontContainer(new Font("JetBrains Mono", 20));
            codeEditor.Font = codeFont.RegularFont;
            
            string path = Application.StartupPath + "\\HighLight\\TSQL-Mode.xshd";//指向自定义的文件
            //codeEditor.Text = path;
            
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(path))
            {
                fsmp = new FileSyntaxModeProvider(path);
                
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                codeEditor.SetHighlighting("C#");
                // codeEditor.Document.FoldingManager.UpdateFoldings(null, null);
                codeEditor.Text = "using System;\n\npublic class NewClass(){\n\t\n}";
            }
            // RunLogic.Run(codeEditor.Text);
        }

        private void codeEditor_TextChanged(object sender, EventArgs e)
        {
            // Point cursorPoint = Cursor.Position;
        }

        private void OnWindowStateChange(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    Size = new Size(_width - 100, _height - 60);
                    codeEditor.Size = new Size(_width - 100, _height - 60);
                    // codeEditor.Location = new Point(0, _height + 80);
                    break;
                case FormWindowState.Maximized:
                    Size = new Size(_width, _height);
                    codeEditor.Size = new Size(_width, _height - 1340);
                    // codeEditor.Location = new Point(0, _height + 80);
                    break;
            }
        }


        private void ImportFont()
        {
            //加载自定义的字体
            String projectName = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(projectName + ".Resource" + ".JetBrainsMono[wght].ttf");
            if (fontStream != null)
            {
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                fontStream.Close();
                unsafe
                {
                    fixed (byte* pFontData = fontdata)
                    {
                        _pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                    }
                }
            }
        }

        private void complementTable_load(object sender, PaintEventArgs e)
        {
            var cursorPos = Cursor.Position;
            
            // 如果用户输入了关键字，则显示该面板.
            // 请参阅 <see cref="SyntaxLogic"/> 里面用于语法树判断的方法

            // complementTable.Enabled = true;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Title = "请选择文件保存路径";
            sfd.Filter = "文本文件|*.txt|逻各斯符号表|*.logos|所有文件|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(codeEditor.Text.ToString().Trim());
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Title = "请选择要打开的文件";
            ofd.Multiselect = false;
            ofd.Filter = "文本文件|*.txt|逻各斯符号表|*.logos|所有文件|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string fileName = ofd.SafeFileName;
                using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] buffer = new byte[1024 * 1024 * 8];
                    int text = stream.Read(buffer, 0, buffer.Length);
                    codeEditor.Text = Encoding.UTF8.GetString(buffer, 0, text);
                }
            }
        }

        private void saveMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void txtItem_Click(object sender, EventArgs e)
        {

        }

        private void jsonItem_Click(object sender, EventArgs e)
        {

        }

        private void csItem_Click(object sender, EventArgs e)
        {

        }

        private void htmlItem_Click(object sender, EventArgs e)
        {

        }

        private void jsItem_Click(object sender, EventArgs e)
        {

        }

        private void cssItem_Click(object sender, EventArgs e)
        {

        }

        private void javaItem_Click(object sender, EventArgs e)
        {

        }

        private void runMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var lines = codeEditor.Text.Split('\n');
            foreach (var line in lines){
                if (line.Contains("@"))
                {
                    string phrase = line.Replace('@', ' ');
                    codeEditor.Text += SyntaxLogic.GetAddress(phrase);
                    codeEditor.Text += "\n";
                }
            }
        }

    }

}