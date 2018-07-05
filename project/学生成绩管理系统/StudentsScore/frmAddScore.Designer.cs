namespace StudentsScore
{
    partial class frmAddScore
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
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.txtSname);
            this.gbxCourse.Controls.Add(this.txtScore);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.txtSid);
            this.gbxCourse.Controls.Add(this.lblCname);
            this.gbxCourse.Controls.Add(this.lblSname);
            this.gbxCourse.Controls.Add(this.lblScore);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Controls.Add(this.lblSid);
            this.gbxCourse.Location = new System.Drawing.Point(33, 44);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(449, 151);
            this.gbxCourse.TabIndex = 0;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "成绩信息";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(323, 71);
            this.txtCname.MaxLength = 30;
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 9;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(323, 36);
            this.txtSname.MaxLength = 10;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 8;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(87, 109);
            this.txtScore.MaxLength = 10;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 21);
            this.txtScore.TabIndex = 7;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(87, 72);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 6;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(87, 36);
            this.txtSid.MaxLength = 10;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 5;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(239, 72);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(53, 12);
            this.lblCname.TabIndex = 4;
            this.lblCname.Text = "课程名称";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(237, 36);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(29, 12);
            this.lblSname.TabIndex = 3;
            this.lblSname.Text = "姓名";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(25, 112);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(29, 12);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "成绩";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(25, 72);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 1;
            this.lblCid.Text = "课程编号";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(23, 36);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "学号";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(120, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(356, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 293);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxCourse);
            this.Name = "frmAddScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加成绩信息";
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}