
namespace GiangVien
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbgt = new System.Windows.Forms.Label();
            this.llb4 = new System.Windows.Forms.Label();
            this.cbxHocVi = new System.Windows.Forms.ComboBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbxHocHam = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tbxProfName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.cbxHocphan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProfID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFac = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(480, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxFac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbProfID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxHocphan);
            this.groupBox1.Controls.Add(this.lbgt);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.llb4);
            this.groupBox1.Controls.Add(this.cbxHocVi);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.lb6);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.cbxHocHam);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.tbxProfName);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Location = new System.Drawing.Point(28, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Location = new System.Drawing.Point(25, 180);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(73, 17);
            this.lbgt.TabIndex = 12;
            this.lbgt.Text = "Tình trạng";
            // 
            // llb4
            // 
            this.llb4.AutoSize = true;
            this.llb4.Location = new System.Drawing.Point(415, 80);
            this.llb4.Name = "llb4";
            this.llb4.Size = new System.Drawing.Size(47, 17);
            this.llb4.TabIndex = 11;
            this.llb4.Text = "Học vị";
            // 
            // cbxHocVi
            // 
            this.cbxHocVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHocVi.FormattingEnabled = true;
            this.cbxHocVi.Location = new System.Drawing.Point(500, 80);
            this.cbxHocVi.Name = "cbxHocVi";
            this.cbxHocVi.Size = new System.Drawing.Size(121, 24);
            this.cbxHocVi.TabIndex = 10;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(415, 43);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(64, 17);
            this.lb3.TabIndex = 9;
            this.lb3.Text = "Học hàm";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(27, 139);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(71, 17);
            this.lb6.TabIndex = 8;
            this.lb6.Text = "Ngày sinh";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(25, 92);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(41, 17);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "Khoa";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(234, 180);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(47, 21);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(138, 180);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 21);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbxHocHam
            // 
            this.cbxHocHam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHocHam.FormattingEnabled = true;
            this.cbxHocHam.Location = new System.Drawing.Point(500, 40);
            this.cbxHocHam.Name = "cbxHocHam";
            this.cbxHocHam.Size = new System.Drawing.Size(121, 24);
            this.cbxHocHam.TabIndex = 3;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(138, 133);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 22);
            this.dtp.TabIndex = 2;
            // 
            // tbxProfName
            // 
            this.tbxProfName.Location = new System.Drawing.Point(138, 64);
            this.tbxProfName.Name = "tbxProfName";
            this.tbxProfName.Size = new System.Drawing.Size(157, 22);
            this.tbxProfName.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(25, 64);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(102, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Tên giảng viên";
            // 
            // cbxHocphan
            // 
            this.cbxHocphan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHocphan.FormattingEnabled = true;
            this.cbxHocphan.Location = new System.Drawing.Point(500, 120);
            this.cbxHocphan.Name = "cbxHocphan";
            this.cbxHocphan.Size = new System.Drawing.Size(121, 24);
            this.cbxHocphan.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Học phần";
            // 
            // txbProfID
            // 
            this.txbProfID.Location = new System.Drawing.Point(138, 26);
            this.txbProfID.Name = "txbProfID";
            this.txbProfID.Size = new System.Drawing.Size(157, 22);
            this.txbProfID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã giảng viên";
            // 
            // cbxFac
            // 
            this.cbxFac.FormattingEnabled = true;
            this.cbxFac.Location = new System.Drawing.Point(138, 92);
            this.cbxFac.Name = "cbxFac";
            this.cbxFac.Size = new System.Drawing.Size(121, 24);
            this.cbxFac.TabIndex = 17;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.Label llb4;
        private System.Windows.Forms.ComboBox cbxHocVi;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbxHocHam;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox tbxProfName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxHocphan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProfID;
        private System.Windows.Forms.ComboBox cbxFac;
    }
}