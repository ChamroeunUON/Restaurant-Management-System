using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WMS.components
{
    public class cDateTimePicker : DateTimePicker
    {
        // CONSTRUCTOR
        public cDateTimePicker(){
            AutoSize = false;
            base.Size = new Size(cConfig.TxtWidth, cConfig.TxtHeight);
            base.Font = new Font(cConfig.TmpFontFamily, cConfig.FontSize + 2);
            base.Value = DateTime.Now;
            base.Format = DateTimePickerFormat.Custom;
            base.CustomFormat = "dd-MM-yyyy hh:mm tt";
        }

        // METHODS
        public override bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }
    }
}
