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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        modify Modify = new modify();

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                dangnhap Dangnhap = new dangnhap();
                Dangnhap.ShowDialog();
            }    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCuahang());
            label3.Text = button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanvien());
            label3.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachhang());
            label3.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoadon());
            label3.Text = button5.Text;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string query = "Select * from taikhoan";
            label1.Text = "Xin chào: " + Modify.Taikhoans(query)[0].Tentaikhoan;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label3.Text = "Trang chủ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaikhoankh());
            label3.Text = button1.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
