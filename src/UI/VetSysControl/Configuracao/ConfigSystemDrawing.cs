using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetSysControl.Configuracao
{
    public class ConfigSystemDrawing
    {
        public void DrawToolStripButtonBorder(Graphics graphics, Rectangle borderRectangle, ToolStripButton btn)
        {
            borderRectangle.Width = btn.Width;
            borderRectangle.Height = btn.Height;

            Color borderColor = Color.FromArgb(136, 158, 247);
            ButtonBorderStyle borderStyle = ButtonBorderStyle.Solid;
            int borderWidth = 5;

            ControlPaint.DrawBorder(
                                graphics,
                                borderRectangle,
                                borderColor, borderWidth, borderStyle,
                                borderColor, borderWidth, borderStyle,
                                borderColor, borderWidth, borderStyle,
                                borderColor, borderWidth, borderStyle);
        }

        public void SetToolStripButtonFont(ToolStripButton btn)
        {
            btn.Font = new Font("Arial", 10, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(65, 103, 247);
        }
    }
}
