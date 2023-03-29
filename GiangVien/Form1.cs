using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiangVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxSort.Items.Clear();
            cbxSort.Items.Add("NONE");
            cbxSort.Items.Add("Tên Giảng Viên");
            cbxSort.Items.Add("Ngày Sinh");
            cbxSort.Items.Add("Học Phần");

            cbxSort.SelectedItem = "NONE";
        }
        private void ReloadDGV()
        {
            dgv.DataSource = DBHelper.Instance.GetProfessorsList();

            dgv.Columns["STT"].Width = 40;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm dform = new DetailForm();
            dform.ReloadMainform = new DetailForm.MyDelegate(this.ReloadDGV);
            dform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                DetailForm dform = new DetailForm(dgv.SelectedRows[0].Cells["Tên Giảng Viên"].Value.ToString());
                dform.ReloadMainform = new DetailForm.MyDelegate(this.ReloadDGV);
                dform.Show();
            }

            else
            {
                MessageBox.Show("Please select only one row!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgv.DataSource = DBHelper.Instance.GetProfessorsList(txbSearch.Text, cbxSort.SelectedItem.ToString());
            dgv.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv.DataSource = DBHelper.Instance.GetProfessorsList(txbSearch.Text);
            dgv.Refresh();

            cbxSort.SelectedItem = "NONE";
        }
    }
}
