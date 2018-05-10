using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WMS.components
{
    public class cRadioButton : RadioButton
    {
        // CONSTRUCTOR
        public cRadioButton(){
            AutoSize = false;
            base.Size = new Size(cConfig.TxtWidth, cConfig.TxtHeight);
            base.Font = new Font(cConfig.FontFamily, cConfig.FontSize);
        }

        // METHODS
        public override bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }
    }
}
