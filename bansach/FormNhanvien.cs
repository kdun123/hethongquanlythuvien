using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bansach
{
    public partial class FormNhanvien : Form
    {
        string str = @"Data Source=DESKTOP-7T8I7HD\SQLEXPRESS;Initial Catalog=bansach;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormNhanvien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            adapter = new SqlDataAdapter("select * from nhanvien where tennv like '"+textBox1.Text+"%'", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void FormNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bansachDataSet6.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.bansachDataSet6.nhanvien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhanvienBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = nhanvienTableAdapter.Update(bansachDataSet6.nhanvien);
            MessageBox.Show("Đã lưu thành công " + i + " dòng dữ liệu!", "Lưu mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dòng này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                nhanvienBindingSource.RemoveCurrent();
            }
        }
    }
}
