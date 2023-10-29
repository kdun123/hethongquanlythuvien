using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bansach
{
    public partial class FormThongke : Form
    {
        public FormThongke()
        {
            InitializeComponent();
        }

        private void FormThongke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bansachDataSet5.sach2' table. You can move, or remove it, as needed.
            this.sach2TableAdapter.Fill(this.bansachDataSet5.sach2);

            this.Thongke.RefreshReport();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            
        }
    }
}
