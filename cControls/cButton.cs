using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.components
{
    public class cButton : Button
    {
        public cButton() {
            AutoSize = false;
            base.Font = new Font(cConfig.FontFamily, cConfig.FontSize);
            base.Size = new Size(cConfig.BtnWidth, cConfig.BtnHeight);
        }

        public override bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }
    }
}
