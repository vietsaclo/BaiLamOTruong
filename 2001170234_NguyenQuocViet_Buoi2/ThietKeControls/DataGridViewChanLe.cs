using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ThietKeControls
{
    public class DataGridViewChanLe : DataGridView
    {
        public DataGridViewChanLe()
        {
            RowsAdded += DataGridViewChanLe_RowsAdded;
        }

        void DataGridViewChanLe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int index = e.RowIndex;
            if (index % 2 == 0)
                Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            else
                Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
        }
    }
}
