namespace StudentsScore
{
    partial class frmAddStu
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
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.lblBitth = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(this.txtAddress);
            this.gbxStudent.Controls.Add(this.lblAddress);
            this.gbxStudent.Controls.Add(this.txtTel);
            this.gbxStudent.Controls.Add(this.lblTel);
            this.gbxStudent.Controls.Add(this.txtClass);
            this.gbxStudent.Controls.Add(this.lblClass);
            this.gbxStudent.Controls.Add(this.txtBirth);
            this.gbxStudent.Controls.Add(this.lblBitth);
            this.gbxStudent.Controls.Add(this.cboSex);
            this.gbxStudent.Controls.Add(this.lblSex);
            this.gbxStudent.Controls.Add(this.txtSName);
            this.gbxStudent.Controls.Add(this.lblSName);
            this.gbxStudent.Controls.Add(this.txtSid);
            this.gbxStudent.Controls.Add(this.lblSid);
            this.gbxStudent.Location = new System.Drawing.Point(33, 45);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(411, 191);
            this.gbxStudent.TabIndex = 0;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "学生信息";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(85, 150);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(287, 21);
            this.txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 12);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "家庭住址";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(272, 108);
            this.txtTel.MaxLength = 30;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 21);
            this.txtTel.TabIndex = 11;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(210, 111);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(29, 12);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "电话";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(60, 103);
            this.txtClass.MaxLength = 20;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 9;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(10, 112);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "班级";
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(272, 63);
            this.txtBirth.MaxLength = 20;
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(100, 21);
            this.txtBirth.TabIndex = 7;
            // 
            // lblBitth
            // 
            this.lblBitth.AutoSize = true;
            this.lblBitth.Location = new System.Drawing.Point(208, 71);
            this.lblBitth.Name = "lblBitth";
            this.lblBitth.Size = new System.Drawing.Size(29, 12);
            this.lblBitth.TabIndex = 6;
            this.lblBitth.Text = "生日";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(60, 63);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(8, 71);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(272, 26);
            this.txtSName.MaxLength = 10;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(100, 21);
            this.txtSName.TabIndex = 3;
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(208, 26);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(29, 12);
            this.lblSName.TabIndex = 2;
            this.lblSName.Text = "姓名";
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(60, 29);
            this.txtSid.MaxLength = 10;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 1;
            this.txtSid.TextChanged += new System.EventHandler(this.txtSid_TextChanged);
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(6, 29);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "学号";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(118, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(330, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxStudent);
            this.Name = "frmAddStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生信息";
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label lblBitth;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}