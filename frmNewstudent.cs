using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmNewstudent : Form
    {
        public delegate void StudentAddedEventHandler(object sender, EventArgs e);
        public event StudentAddedEventHandler StudentAdded;
        private string username; 
        private int errorcount;
        Class1 newstudent = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");

        public frmNewstudent(string username)
        {
            InitializeComponent();
            this.username = username; 
            design();
        }

        private void design()
        {
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.BackColor = Color.FromArgb(52, 152, 219);
            btnsave.ForeColor = Color.White;
            btnsave.FlatAppearance.BorderSize = 0;

            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.BackColor = Color.FromArgb(52, 152, 219);
            btnclear.ForeColor = Color.White;
            btnclear.FlatAppearance.BorderSize = 0;

            btnsave.MouseEnter += (s, e) => { btnsave.BackColor = Color.FromArgb(61, 138, 195); };
            btnsave.MouseLeave += (s, e) => { btnsave.BackColor = Color.FromArgb(60, 160, 230); };

            btnclear.MouseEnter += (s, e) => { btnclear.BackColor = Color.FromArgb(61, 138, 195); };
            btnclear.MouseLeave += (s, e) => { btnclear.BackColor = Color.FromArgb(60, 160, 230); };
        }

        private void validateform()
        {
            errorProvider1.Clear();
            errorcount = 0;

            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                errorProvider1.SetError(txtStudentID, "Student ID is required.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last name is required.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First name is required.");
                errorcount++;
            }

            if (cmbYearLevel.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbYearLevel, "Select a year level.");
                errorcount++;
            }

            if (cmbYearLevel.SelectedIndex == 3) 
            { 
                if (cmbCourse.SelectedIndex < 0)
                {
                    errorProvider1.SetError(cmbCourse, "Select a course");
                    errorcount++;
                }
             }
            if (cmbYearLevel.SelectedIndex == 2)
            {
                if (cmbCourse.SelectedIndex < 0)
                {
                    errorProvider1.SetError(cmbCourse, "Select a strand");
                    errorcount++;
                }
            }
            // Check if Student ID already exists
            try
            {
                DataTable dt = newstudent.GetData("SELECT * FROM tblstudents WHERE studentID = '" + txtStudentID.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtStudentID, "Student ID already exists");
                    errorcount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on validating existing student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYearLevel.SelectedItem != null) 
            { 
                cmbCourse.Items.Clear();
                string selectedValue = cmbYearLevel.SelectedItem.ToString();

                if (selectedValue == "Senior High School")
                {
                    cmbCourse.Items.Add("STEM");
                    cmbCourse.Items.Add("ABM");
                    cmbCourse.Items.Add("HUMSS");
                    cmbCourse.Items.Add("GAS");
                }
                else if (selectedValue == "College")
                {
                    cmbCourse.Items.Add("BS Computer Science");
                    cmbCourse.Items.Add("BS Criminilogy");
                    cmbCourse.Items.Add("BS Business Administration");
                    cmbCourse.Items.Add("BS Accountancy");
                    cmbCourse.Items.Add("BS Nursing");
                    cmbCourse.Items.Add("B Secondary Education");
                    cmbCourse.Items.Add("BA Political Science");
                    cmbCourse.Items.Add("BA Psychology");
                }
                else
                {
                    cmbCourse.Items.Add("N/A");
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateform();

            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to add this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        // Insert the new student record
                        newstudent.executeSQL("INSERT INTO tblstudents (studentID, studentLN, studentFN, studentMN, yearLevel, studentCourse, datecreated, createdby) " +
                            "VALUES ('" + txtStudentID.Text + "', '" + txtLastName.Text + "', '" + txtFirstName.Text + "', '" + txtMiddleName.Text + "', '" +
                            cmbYearLevel.Text + "', '" + cmbCourse.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + username + "')");

                        if (newstudent.rowAffected > 0)
                        {
                            // Log the action
                            newstudent.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() +
                                "', '" + DateTime.Now.ToShortTimeString() + "', 'Add', 'Students Management', '" + txtStudentID.Text + "', '" + username + "')");
                            MessageBox.Show("New student added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudentAdded?.Invoke(this, EventArgs.Empty);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error on save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtStudentID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbCourse.Items.Clear();
            cmbYearLevel.SelectedIndex = -1;

            cmbCourse.Text = string.Empty;
            cmbYearLevel.Text = string.Empty;
        }

    }
}