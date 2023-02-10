using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logos
{
    public static class WindowsUtil
    {
        public static Size GetScaleSize(Size size, float ratio)
        {
            return new Size((int)(size.Width * ratio), (int)(size.Height * ratio));
        }

        // public static Size GetLocation(Point point, float ratio)
        // {
        //     
        // }

       
    }
}
