namespace StudentsScore
{
    partial class frmManageStu
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
            this.gbxSeach = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxSeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSeach
            // 
            this.gbxSeach.Controls.Add(this.btnEdit);
            this.gbxSeach.Controls.Add(this.btnCancel);
            this.gbxSeach.Controls.Add(this.btnSeach);
            this.gbxSeach.Controls.Add(this.txtClass);
            this.gbxSeach.Controls.Add(this.lblClass);
            this.gbxSeach.Controls.Add(this.cboSex);
            this.gbxSeach.Controls.Add(this.lblSex);
            this.gbxSeach.Controls.Add(this.txtName);
            this.gbxSeach.Controls.Add(this.lblName);
            this.gbxSeach.Controls.Add(this.txtSid);
            this.gbxSeach.Controls.Add(this.lblSid);
            this.gbxSeach.Location = new System.Drawing.Point(37, 22);
            this.gbxSeach.Name = "gbxSeach";
            this.gbxSeach.Size = new System.Drawing.Size(435, 162);
            this.gbxSeach.TabIndex = 0;
            this.gbxSeach.TabStop = false;
            this.gbxSeach.Text = "查询条件";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(312, 119);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.Location = new System.Drawing.Point(173, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "删除";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeach.Location = new System.Drawing.Point(25, 119);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 8;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(287, 73);
            this.txtClass.MaxLength = 20;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 7;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(225, 76);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "班级";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(83, 76);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(23, 76);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(287, 37);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(225, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名";
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(83, 37);
            this.txtSid.MaxLength = 10;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 1;
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(23, 37);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "学号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(37, 190);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(435, 136);
            this.dgvInfo.TabIndex = 1;
            // 
            // frmManageStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 361);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxSeach);
            this.Name = "frmManageStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理学生信息";
            this.gbxSeach.ResumeLayout(false);
            this.gbxSeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSeach;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.DataGridView dgvInfo;

    }
}