using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace bansach
{
    public partial class FormCuahang : Form
    {

        string str = @"Data Source=DESKTOP-7T8I7HD\SQLEXPRESS;Initial Catalog=bansach;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private int Status = 0;
        private Image bytearraytoImage(byte[] byteimage)
        {
            return (Bitmap)((new ImageConverter()).ConvertFrom(byteimage));
        }
        private byte[] ImagetoByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public FormCuahang()
        {
            InitializeComponent();
        }
        modify Modify = new modify();
        private void LoadData()
        {
            
        }

        private void FormCuahang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bansachDataSet2.sach2' table. You can move, or remove it, as needed.
            this.sach2TableAdapter2.Fill(this.bansachDataSet2.sach2);
        }
        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            PictureBox pt = new PictureBox();
            int r = dataGridView1.CurrentCell.RowIndex;
            opf.Filter = "Image File (*jpeg; *jpg; *png; *gif; *bmp)|*jpeg; *jpg; *png; *gif; *bmp";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pt.Image = new Bitmap(opf.FileName);
                pictureBox1.Image = new Bitmap(opf.FileName);

                pt.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                MemoryStream mmstr = new MemoryStream();
                pt.Image.Save(mmstr, pt.Image.RawFormat);
                dataGridView1.Rows[r].Cells[8].Value = mmstr.ToArray();
            }
            else dataGridView1.Rows[r].Cells[8].Value = DBNull.Value;
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            sach2BindingSource2.AddNew();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dòng này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                sach2BindingSource2.RemoveCurrent();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = sach2TableAdapter2.Update(bansachDataSet2.sach2);
            MessageBox.Show("Đã lưu thành công " + i + " dòng dữ liệu!", "Lưu mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            adapter = new SqlDataAdapter("select * from sach2 where tensach like '"+textBox1.Text+"%'", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MemoryStream mmstr = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[8].Value);
            pictureBox1.Image = Image.FromStream(mmstr);
        }
    }
}
