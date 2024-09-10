using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitvain
{
    public partial class Overlay : Form
    {

        #region rounded form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
         );
        #endregion

        public Overlay()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(1);

            // Create and set the rounded region
            GraphicsPath path = RoundedRectangle.Create(0, 0, Width, Height, 30);
            this.Region = new Region(path);

        }

        public static class RoundedRectangle
        {
            public static GraphicsPath Create(int x, int y, int width, int height, int radius)
            {
                GraphicsPath path = new();
                path.AddArc(x, y, radius, radius, 180, 90);
                path.AddLine(x + radius, y, x + width - radius, y);
                path.AddArc(x + width - radius, y, radius, radius, 270, 90);
                path.AddLine(x + width, y + radius, x + width, y + height - radius);
                path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                path.AddLine(x + width - radius, y + height, x + radius, y + height);
                path.AddArc(x, y + height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                return path;
            }
        }
    }
}
