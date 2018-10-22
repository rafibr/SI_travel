﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoundButton
{
    class RoundButton : Button
    {

        protected override void OnPaint(PaintEventArgs pevent)
        {
            
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, 100, 100);
            this.Region = new Region(gp);
            base.OnPaint(pevent);
        }
    }
}
