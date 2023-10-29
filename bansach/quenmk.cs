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
    public partial class quenmk : Form
    {
        public quenmk()
        {
            InitializeComponent();
            label3.Text = "";
        }
        modify Modify = new modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string ttk = textBox1.Text;
            if (ttk.Trim()=="") { MessageBox.Show("Vui lòng nhập tên tài khoản của bạn"); }
            else
            {
                string query = "Select * from taikhoan where makh = '"+ttk+"' ";
                if (Modify.Taikhoans(query).Count!=0)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Mật khẩu của bạn là: " + Modify.Taikhoans(query)[0].MatKhau;
                }    
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Tài khoản không tồn tại";
                }    
            }
        }
    }
}
