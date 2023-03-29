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

    public partial class DetailForm : Form
    {
        public delegate void MyDelegate();
        public MyDelegate ReloadMainform { get; set; }
        public DetailForm()
        {
            InitializeComponent();
        }
        public DetailForm(String _TenGiangVien = "")
        {
            if (_TenGiangVien != String.Empty)
            {
                
                tbxProfName.Enabled = false;
            }

            else
                tbxProfName.Enabled = true;
        }
        private void AddHandle()
        {
            try
            {
                DBHelper.Instance.InsertProfessor(txbProfID.Text, tbxProfName.Text,cbxFac.Text, Convert.ToDateTime(dtp.Text), rbMale.Checked, cbxHocHam.Text, cbxHocVi.Text, cbxHocphan.Text );

                MessageBox.Show("Prof is added successfully.");

                ReloadMainform();

                this.Dispose();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void EditHandle()
        {
            //DBHelper.Instance.UpdateProduct(tbMaSP.Text, tbTenSP.Text, Convert.ToDateTime(dtp.Text), rbCon.Checked, cbMathang.Text);

            MessageBox.Show("Professor is edited successfully.");

            ReloadMainform();

            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
                    this.AddHandle();
            
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            cbxFac.Items.Clear();
            foreach (DataRow dr in DBHelper.Instance.GetFacList().Rows)
            {
                cbxFac.Items.Add(dr[0].ToString());
            }
            cbxHocphan.Items.Clear();
            foreach (DataRow dr in DBHelper.Instance.GetSubList().Rows)
            {
                cbxHocphan.Items.Add(dr[0].ToString());
            }
            cbxHocHam.Items.Clear();
            cbxHocHam.Items.Add("Giáo sư");
            cbxHocHam.Items.Add("Phó giáo sư");
            cbxHocHam.Items.Add("Không");
            cbxHocHam.SelectedItem = "Không";
            cbxHocVi.Items.Clear();
            cbxHocVi.Items.Add("Tiến sỹ");
            cbxHocVi.Items.Add("Tiến sỹ khoa học");
            cbxHocVi.Items.Add("Thạc sỹ");
            cbxHocVi.SelectedItem = "Thạc sỹ";
            if (this.tbxProfName.Enabled == false)
            {
                DataRow dr = DBHelper.Instance.GetSpecificProf(tbxProfName.Text);

                tbxProfName.Text = dr["Tên Giảng Viên"].ToString();
                cbxFac.Text = dr["Khoa"].ToString();
                cbxHocHam.Text = dr["Học Hàm"].ToString();
                cbxHocVi.Text = dr["Học Vị"].ToString();
                cbxHocphan.Text = dr["Tên Học Phần"].ToString();

                if (Convert.ToBoolean(dr["Giới Tính"].ToString()) == true) rbMale.Checked = true;
                else rbFemale.Checked = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
