namespace CS311MALABON2024_DATABASE_CARREON
{
    partial class frmUpdateCase
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
            this.components = new System.ComponentModel.Container();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gradientPanel1 = new CS311MALABON2024_DATABASE_CARREON.GradientPanel();
            this.txtviolationcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.txtresolution = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtrecommendation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbconcernlevel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtschoolyear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Location = new System.Drawing.Point(574, 422);
            this.btnclear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(77, 28);
            this.btnclear.TabIndex = 41;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Location = new System.Drawing.Point(437, 422);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(74, 28);
            this.btnsave.TabIndex = 40;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.gradientPanel1.Controls.Add(this.btnclear);
            this.gradientPanel1.Controls.Add(this.btnsave);
            this.gradientPanel1.Controls.Add(this.label11);
            this.gradientPanel1.Controls.Add(this.txtrecommendation);
            this.gradientPanel1.Controls.Add(this.label12);
            this.gradientPanel1.Controls.Add(this.cmbconcernlevel);
            this.gradientPanel1.Controls.Add(this.label13);
            this.gradientPanel1.Controls.Add(this.txtschoolyear);
            this.gradientPanel1.Controls.Add(this.txtviolationcode);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.cmbstatus);
            this.gradientPanel1.Controls.Add(this.txtresolution);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.txtmiddlename);
            this.gradientPanel1.Controls.Add(this.txtfirstname);
            this.gradientPanel1.Controls.Add(this.txtlastname);
            this.gradientPanel1.Controls.Add(this.txtstudentID);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.txtdescription);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.txtcourse);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.txtlevel);
            this.gradientPanel1.Controls.Add(this.label10);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(756, 532);
            this.gradientPanel1.TabIndex = 46;
            // 
            // txtviolationcode
            // 
            this.txtviolationcode.Enabled = false;
            this.txtviolationcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtviolationcode.Location = new System.Drawing.Point(141, 192);
            this.txtviolationcode.Name = "txtviolationcode";
            this.txtviolationcode.Size = new System.Drawing.Size(179, 20);
            this.txtviolationcode.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(443, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Level:";
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Ongoing",
            "Resolved"});
            this.cmbstatus.Location = new System.Drawing.Point(141, 228);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(179, 20);
            this.cmbstatus.TabIndex = 43;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // txtresolution
            // 
            this.txtresolution.Enabled = false;
            this.txtresolution.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresolution.Location = new System.Drawing.Point(141, 266);
            this.txtresolution.Multiline = true;
            this.txtresolution.Name = "txtresolution";
            this.txtresolution.Size = new System.Drawing.Size(210, 90);
            this.txtresolution.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(355, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 14);
            this.label8.TabIndex = 36;
            this.label8.Text = "Violation Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Student Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(390, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "Strand/Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "Middle name:";
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Enabled = false;
            this.txtmiddlename.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddlename.Location = new System.Drawing.Point(141, 157);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(178, 20);
            this.txtmiddlename.TabIndex = 31;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Enabled = false;
            this.txtfirstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(142, 122);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(179, 20);
            this.txtfirstname.TabIndex = 30;
            // 
            // txtlastname
            // 
            this.txtlastname.Enabled = false;
            this.txtlastname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(141, 86);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(178, 20);
            this.txtlastname.TabIndex = 29;
            // 
            // txtstudentID
            // 
            this.txtstudentID.Enabled = false;
            this.txtstudentID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentID.Location = new System.Drawing.Point(141, 51);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(210, 20);
            this.txtstudentID.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 42;
            this.label9.Text = "Status:";
            // 
            // txtdescription
            // 
            this.txtdescription.Enabled = false;
            this.txtdescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(491, 154);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(208, 90);
            this.txtdescription.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "First name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Violation Code:";
            // 
            // txtcourse
            // 
            this.txtcourse.Enabled = false;
            this.txtcourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.Location = new System.Drawing.Point(491, 119);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(142, 20);
            this.txtcourse.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last name:";
            // 
            // txtlevel
            // 
            this.txtlevel.Enabled = false;
            this.txtlevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlevel.Location = new System.Drawing.Point(491, 83);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(142, 20);
            this.txtlevel.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(63, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 44;
            this.label10.Text = "Resolution:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 14);
            this.label11.TabIndex = 51;
            this.label11.Text = "Recommendation:";
            // 
            // txtrecommendation
            // 
            this.txtrecommendation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecommendation.Location = new System.Drawing.Point(143, 420);
            this.txtrecommendation.Multiline = true;
            this.txtrecommendation.Name = "txtrecommendation";
            this.txtrecommendation.Size = new System.Drawing.Size(208, 84);
            this.txtrecommendation.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(51, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 14);
            this.label12.TabIndex = 49;
            this.label12.Text = "Concern level:";
            // 
            // cmbconcernlevel
            // 
            this.cmbconcernlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbconcernlevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbconcernlevel.FormattingEnabled = true;
            this.cmbconcernlevel.Items.AddRange(new object[] {
            "Prefect of Discipline",
            "Branch OSA",
            "Dean of OSA",
            "Council of Discipline"});
            this.cmbconcernlevel.Location = new System.Drawing.Point(143, 390);
            this.cmbconcernlevel.Name = "cmbconcernlevel";
            this.cmbconcernlevel.Size = new System.Drawing.Size(179, 20);
            this.cmbconcernlevel.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 14);
            this.label13.TabIndex = 47;
            this.label13.Text = "School year:";
            // 
            // txtschoolyear
            // 
            this.txtschoolyear.Location = new System.Drawing.Point(142, 362);
            this.txtschoolyear.Name = "txtschoolyear";
            this.txtschoolyear.Size = new System.Drawing.Size(179, 20);
            this.txtschoolyear.TabIndex = 46;
            // 
            // frmUpdateCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 532);
            this.Controls.Add(this.gradientPanel1);
            this.MaximizeBox = false;
            this.Name = "frmUpdateCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update case";
            this.Load += new System.EventHandler(this.frmUpdateCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtviolationcode;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtresolution;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtrecommendation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbconcernlevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtschoolyear;
    }
}