namespace StudentsScore
{
    partial class frmManageScore
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
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.btnEdit);
            this.gbxCourse.Controls.Add(this.btnDel);
            this.gbxCourse.Controls.Add(this.btnSeach);
            this.gbxCourse.Controls.Add(this.txtClass);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.txtSname);
            this.gbxCourse.Controls.Add(this.txtSid);
            this.gbxCourse.Controls.Add(this.lblClass);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Controls.Add(this.lblSname);
            this.gbxCourse.Controls.Add(this.lblSid);
            this.gbxCourse.Location = new System.Drawing.Point(54, 40);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(435, 164);
            this.gbxCourse.TabIndex = 0;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "查询条件";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(290, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(166, 119);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.Color.White;
            this.btnSeach.Location = new System.Drawing.Point(20, 119);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 8;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(290, 75);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 7;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(290, 34);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 6;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(84, 75);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 5;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(84, 35);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 4;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(220, 75);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "班级";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(218, 34);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 2;
            this.lblCid.Text = "课程编号";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(20, 75);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(29, 12);
            this.lblSname.TabIndex = 1;
            this.lblSname.Text = "姓名";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(18, 35);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "学号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowDrop = true;
            this.dgvInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(54, 210);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(435, 150);
            this.dgvInfo.TabIndex = 1;
            // 
            // frmManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 394);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxCourse);
            this.Name = "frmManageScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理成绩信息";
            this.Load += new System.EventHandler(this.frmManageScore_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}