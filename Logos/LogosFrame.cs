using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;

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
            var codeFont = new FontContainer(new Font("JetBrains Mono", 14));
            codeEditor.Font = codeFont.RegularFont;
        }

        private void OnNormalize(object sender, EventArgs e) 
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    Size = new Size(_width - 100, _height - 60);
                    codeEditor.Size = new Size(_width - 100, _height - 60);
                    break;
            }
        }

        private void ImportFont()
        {
            //加载自定义的字体
            String projectName = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(projectName + ".Resource" + ".Fixedsys.ttf");
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
    }

}