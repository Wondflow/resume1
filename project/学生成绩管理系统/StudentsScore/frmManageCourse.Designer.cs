namespace StudentsScore
{
    partial class frmManageCourse
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
            this.txtCname = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxSeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSeach
            // 
            this.gbxSeach.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSeach.Controls.Add(this.txtCname);
            this.gbxSeach.Controls.Add(this.btnEdit);
            this.gbxSeach.Controls.Add(this.btnDel);
            this.gbxSeach.Controls.Add(this.btnSeach);
            this.gbxSeach.Controls.Add(this.txtCid);
            this.gbxSeach.Controls.Add(this.lblCname);
            this.gbxSeach.Controls.Add(this.lblCid);
            this.gbxSeach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxSeach.Location = new System.Drawing.Point(29, 49);
            this.gbxSeach.Name = "gbxSeach";
            this.gbxSeach.Size = new System.Drawing.Size(423, 100);
            this.gbxSeach.TabIndex = 0;
            this.gbxSeach.TabStop = false;
            this.gbxSeach.Text = "查询条件";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(293, 26);
            this.txtCname.MaxLength = 30;
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(293, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(147, 66);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeach.Location = new System.Drawing.Point(20, 66);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 3;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(91, 26);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 2;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(217, 26);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(53, 12);
            this.lblCname.TabIndex = 1;
            this.lblCname.Text = "课程名称";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(18, 26);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "课程编号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(29, 182);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(423, 119);
            this.dgvInfo.TabIndex = 1;
            // 
            // frmManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 328);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxSeach);
            this.Name = "frmManageCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理课程信息";
            this.gbxSeach.ResumeLayout(false);
            this.gbxSeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSeach;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}