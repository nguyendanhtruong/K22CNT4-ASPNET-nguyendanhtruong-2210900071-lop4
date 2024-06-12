using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onktra01
{
    public partial class sinhvien : Form
    {
        public sinhvien()
        {
            InitializeComponent();
        }

        private void sinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_on22052024DataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qLSV_on22052024DataSet.KHOA);
            // TODO: This line of code loads data into the 'qLSV_on22052024DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLSV_on22052024DataSet.SINHVIEN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.AddNew();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] row = qLSV_on22052024DataSet.SINHVIEN.Select("MaSv='" + txtmasv.Text + "'");
                if(row.Length>0)
                {
                    MessageBox.Show("ma sinh vien da ton tai");
                    return;
                }
                //them moi du lieu vao bang sinh vieen 
                DataRow newRow = qLSV_on22052024DataSet.SINHVIEN.NewRow();
                newRow["MaSv"] = txtmasv.Text;
                newRow["TenSv"] = txtten.Text; 
                newRow["GT"] = txtgt.Text;
                newRow["NgaySinh"] = dtpngaysinh.Text;
                newRow["DiaChi"] = txtdiachi.Text;
                newRow["MaKhoa"] = cmbmakhoa.Text;
                sINHVIENBindingSource.EndEdit();
                sINHVIENTableAdapter.Update(qLSV_on22052024DataSet.SINHVIEN);
                MessageBox.Show("them moi thanh cong!");
                dataGridView1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi cap nhat" + ex.Message);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban co chc muon xoa ko?",
                "thong bao",
                MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                sINHVIENBindingSource.EndEdit();
                sINHVIENTableAdapter.Update(qLSV_on22052024DataSet.SINHVIEN);
                MessageBox.Show("da xoa thanh cong");
                dataGridView1.Refresh();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
