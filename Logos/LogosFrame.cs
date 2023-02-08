using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logos
{
    public partial class LogosFrame : Form
    {
        public LogosFrame()
        {
            InitializeComponent();
        }

        private void LogosFrame_Load(object sender, EventArgs e)
        {
            
        }

        private void codeEditor_Load(object sender, EventArgs e)
        {
            codeEditor.Encoding = Encoding.UTF8;
            codeEditor.Font = new Font("Consolas", 24);
        }
    }
}