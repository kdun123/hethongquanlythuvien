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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmk Quenmatkhau = new quenmk();
            Quenmatkhau.ShowDialog();
        }

        modify Modify = new modify(); 
        private void button1_Click(object sender, EventArgs e)
        {
            string tenTaikhoan = textBox1.Text;
            string Matkhau = textBox2.Text;
            if (tenTaikhoan.Trim()=="") { MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");}
            else if (Matkhau.Trim()=="") { MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");}
            else
            {
                string query = "Select * from taikhoan where tenkh = '"+tenTaikhoan+"' and matkhau = '"+Matkhau+"' ";
                if(Modify.Taikhoans(query).Count>0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên tài khoản không chính xác");
                }
            }
        }
    }
}
