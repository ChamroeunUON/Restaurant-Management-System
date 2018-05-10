using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WMS.components
{
    public class cDataGridView : DataGridView
    {
        // CONSTRUCTOR
        public cDataGridView(){
            AutoSize = false;
            base.Size = new Size(cConfig.GridViewWidth, cConfig.GridViewHeight);
            base.Font = new Font(cConfig.FontFamily, cConfig.FontSize);
            base.RowTemplate.Height = cConfig.TxtHeight;
            base.RowHeadersVisible = false;
            base.ColumnHeadersHeight = cConfig.TxtHeight;
            base.BorderStyle = BorderStyle.Fixed3D;
            base.BackgroundColor = Color.White;
            base.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
        }

        // METHODS
        public override bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }
    }
}
