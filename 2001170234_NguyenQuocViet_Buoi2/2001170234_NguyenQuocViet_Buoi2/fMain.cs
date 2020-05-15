using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001170234_NguyenQuocViet_Buoi2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            gridView.Rows.Add(new string[] { "1", "Nguyen Quoc Viet"});
            gridView.Rows.Add(new string[] { "2", "Ly Xuan Thanh" });
            gridView.Rows.Add(new string[] { "3", "Le Dang Truong" });
            gridView.Rows.Add(new string[] { "4", "Huynh Ngoc Khanh" });
            gridView.Rows.Add(new string[] { "5", "Tran Bao Long" });
            gridView.Rows.Add(new string[] { "6", "Le An Huy" });
            gridView.Rows.Add(new string[] { "6", "Bui Vu Truong" });
        }
    }
}
