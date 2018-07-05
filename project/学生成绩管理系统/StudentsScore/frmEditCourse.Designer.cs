namespace StudentsScore
{
    partial class frmEditCourse
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(318, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(114, 201);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.txtCredit);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.label3);
            this.gbxCourse.Controls.Add(this.label2);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Location = new System.Drawing.Point(36, 38);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(416, 129);
            this.gbxCourse.TabIndex = 3;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "课程信息";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(78, 78);
            this.txtCname.MaxLength = 30;
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 5;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(282, 31);
            this.txtCredit.MaxLength = 10;
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 21);
            this.txtCredit.TabIndex = 4;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(78, 34);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "学分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程名称";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(16, 34);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "课程编号";
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbxCourse);
            this.Name = "frmEditCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改课程信息";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCid;
    }
}