namespace CS311MALABON2024_DATABASE_CARREON
{
    partial class frmCases
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concernlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddcase = new System.Windows.Forms.Button();
            this.btnupdatecase = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number:";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentID.Location = new System.Drawing.Point(200, 41);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(285, 22);
            this.txtstudentID.TabIndex = 1;
            this.txtstudentID.TextChanged += new System.EventHandler(this.txtstudentID_TextChanged);
            this.txtstudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentID_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(124, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(124, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(108, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle name:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(610, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Level:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(557, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Strand/Course:";
            // 
            // txtlastname
            // 
            this.txtlastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlastname.Enabled = false;
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(200, 89);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(235, 22);
            this.txtlastname.TabIndex = 7;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfirstname.Enabled = false;
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(200, 134);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(236, 22);
            this.txtfirstname.TabIndex = 8;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmiddlename.Enabled = false;
            this.txtmiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddlename.Location = new System.Drawing.Point(200, 176);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(236, 22);
            this.txtmiddlename.TabIndex = 9;
            // 
            // txtlevel
            // 
            this.txtlevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlevel.Enabled = false;
            this.txtlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlevel.Location = new System.Drawing.Point(659, 92);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(213, 22);
            this.txtlevel.TabIndex = 10;
            // 
            // txtcourse
            // 
            this.txtcourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcourse.Enabled = false;
            this.txtcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.Location = new System.Drawing.Point(659, 137);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(213, 22);
            this.txtcourse.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caseID,
            this.violationID,
            this.violationDescription,
            this.violationCount,
            this.schoolyear,
            this.concernlevel,
            this.recommendation,
            this.status,
            this.resolution,
            this.createdby,
            this.dateCreated});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(5, 240);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 267);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // caseID
            // 
            this.caseID.HeaderText = "caseID";
            this.caseID.Name = "caseID";
            // 
            // violationID
            // 
            this.violationID.HeaderText = "violationID";
            this.violationID.Name = "violationID";
            // 
            // violationDescription
            // 
            this.violationDescription.HeaderText = "Violation Description";
            this.violationDescription.Name = "violationDescription";
            // 
            // violationCount
            // 
            this.violationCount.HeaderText = "Violation Count";
            this.violationCount.Name = "violationCount";
            // 
            // schoolyear
            // 
            this.schoolyear.HeaderText = "School Year";
            this.schoolyear.Name = "schoolyear";
            // 
            // concernlevel
            // 
            this.concernlevel.HeaderText = "Concern Level";
            this.concernlevel.Name = "concernlevel";
            // 
            // recommendation
            // 
            this.recommendation.HeaderText = "Recommendation";
            this.recommendation.Name = "recommendation";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // resolution
            // 
            this.resolution.HeaderText = "Resolution";
            this.resolution.Name = "resolution";
            // 
            // createdby
            // 
            this.createdby.HeaderText = "Created by";
            this.createdby.Name = "createdby";
            // 
            // dateCreated
            // 
            this.dateCreated.HeaderText = "Date Created";
            this.dateCreated.Name = "dateCreated";
            // 
            // btnaddcase
            // 
            this.btnaddcase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaddcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcase.Location = new System.Drawing.Point(178, 576);
            this.btnaddcase.Name = "btnaddcase";
            this.btnaddcase.Size = new System.Drawing.Size(102, 28);
            this.btnaddcase.TabIndex = 13;
            this.btnaddcase.Text = "&Add new case";
            this.btnaddcase.UseVisualStyleBackColor = true;
            this.btnaddcase.Click += new System.EventHandler(this.btnaddcase_Click);
            // 
            // btnupdatecase
            // 
            this.btnupdatecase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdatecase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecase.Location = new System.Drawing.Point(383, 576);
            this.btnupdatecase.Name = "btnupdatecase";
            this.btnupdatecase.Size = new System.Drawing.Size(102, 28);
            this.btnupdatecase.TabIndex = 16;
            this.btnupdatecase.Text = "&Update case";
            this.btnupdatecase.UseVisualStyleBackColor = true;
            this.btnupdatecase.Click += new System.EventHandler(this.btnupdatecase_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(659, 576);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 28);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(859, 576);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(100, 28);
            this.btnrefresh.TabIndex = 18;
            this.btnrefresh.Text = "&Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // frmCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdatecase);
            this.Controls.Add(this.btnaddcase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.txtlevel);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCases";
            this.Text = "Cases Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnaddcase;
        private System.Windows.Forms.Button btnupdatecase;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn concernlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendation;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
    }
}