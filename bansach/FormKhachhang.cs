using bansach.bansachDataSet6TableAdapters;
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
    public partial class FormKhachhang : Form
    {
        string str = @"Data Source=DESKTOP-7T8I7HD\SQLEXPRESS;Initial Catalog=bansach;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormKhachhang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khachhang1BindingSource.AddNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            adapter = new SqlDataAdapter("select * from khachhang1 where tenkhachhang like '"+textBox1.Text+"%'", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = khachhang1TableAdapter.Update(bansachDataSet7.khachhang1);
            MessageBox.Show("Đã lưu thành công " + i + " dòng dữ liệu!", "Lưu mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            khachhang1BindingSource.RemoveCurrent();
        }

        private void FormKhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bansachDataSet7.khachhang1' table. You can move, or remove it, as needed.
            this.khachhang1TableAdapter.Fill(this.bansachDataSet7.khachhang1);

        }
    }
}
