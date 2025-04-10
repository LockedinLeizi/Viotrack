using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmUpdateStudent : Form
    {
        public delegate void StudentUpdatedEventHandler(object sender, EventArgs e);
        public event StudentUpdatedEventHandler StudentUpdated;
        private string editstudentID, editLastName, editFirstName, editMiddleName, editYearLevel, editCourse, username;
        private int errorcount;

        private void btnclear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            cmbYearLevel.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbCourse.Items.Clear();
           
        }

        Class1 updatestudent = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");

        public frmUpdateStudent(string editstudentID, string editLastName, string editFirstName, string editMiddleName, string editYearLevel, string editCourse, string username)
        {
            InitializeComponent();
            this.username = username;
            this.editstudentID = editstudentID;
            this.editLastName = editLastName;
            this.editFirstName = editFirstName;
            this.editYearLevel = editYearLevel;
            this.editCourse = editCourse;
            this.editMiddleName = editMiddleName;
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
        }

        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYearLevel.SelectedItem != null)
            {
                cmbCourse.Items.Clear();
                string selectedValue = cmbYearLevel.SelectedItem.ToString();

                if (selectedValue == "Senior High School")
                {
                    cmbCourse.Text = string.Empty;
                    cmbCourse.SelectedIndex = -1;
                    cmbCourse.Items.Add("STEM");
                    cmbCourse.Items.Add("ABM");
                    cmbCourse.Items.Add("HUMSS");
                    cmbCourse.Items.Add("GAS");
                }
                else if (selectedValue == "College")
                {   
                    cmbCourse.Text = string.Empty;
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
        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = editstudentID;
            txtLastName.Text = editLastName;
            txtFirstName.Text = editFirstName;
            txtMiddleName.Text = editMiddleName;
            if (editYearLevel == "Elementary")
            {
                cmbYearLevel.SelectedIndex = 0;
            }
            else if (editYearLevel == "Junior High School")
            {
                cmbYearLevel.SelectedIndex = 1;
            }
            else if (editYearLevel == "Senior High School")
            {
                cmbYearLevel.SelectedIndex = 2;
            }
            else
            {
                cmbYearLevel.SelectedIndex = 3;
            }
            if (cmbYearLevel.SelectedIndex == 2)
            {
                if (editCourse == "STEM")
                {
                    cmbCourse.SelectedIndex = 0;
                }
                else if (editCourse == "ABM")
                {
                    cmbCourse.SelectedIndex = 1;
                }
                else if (editCourse == "HUMSS")
                {
                    cmbCourse.SelectedIndex = 2;
                }
                else
                {
                    cmbCourse.SelectedIndex = 3;
                }
            }
            if (cmbYearLevel.SelectedIndex == 3)
            {
                if (editCourse == "BS Computer Science")
                {
                    cmbCourse.SelectedIndex = 0;
                }
                else if (editCourse == "BS Criminilogy")
                {
                    cmbCourse.SelectedIndex = 1;
                }
                else if (editCourse == "BS Business Administration")
                {
                    cmbCourse.SelectedIndex = 2;
                }
                else if (editCourse == "BS Accountancy")
                {
                    cmbCourse.SelectedIndex = 3;
                }
                else if (editCourse == "BS Nursing")
                {
                    cmbCourse.SelectedIndex = 4;
                }
                else if (editCourse == "B Secondary Education")
                {
                    cmbCourse.SelectedIndex = 5;
                }
                else if (editCourse == "BA Political Science")
                {
                    cmbCourse.SelectedIndex = 6;
                }
                else
                {
                    cmbCourse.SelectedIndex = 7;
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            validateform();

            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        // Insert the update student record
                        updatestudent.executeSQL("UPDATE tblstudents SET studentLN = '" + txtLastName.Text + "', studentFN = '" + txtFirstName.Text + "', studentMN = '" + txtMiddleName.Text + "', yearLevel = '" + cmbYearLevel.Text + "', studentCourse = '" + cmbCourse.Text +
                            "' WHERE studentID = '" + txtStudentID.Text + "'");

                        if (updatestudent.rowAffected > 0)
                        {
                            // Log the action
                            updatestudent.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() +
                                "', '" + DateTime.Now.ToShortTimeString() + "', 'Update', 'Students Management', '" + txtStudentID.Text + "', '" + username + "')");
                            MessageBox.Show("Student data updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudentUpdated?.Invoke(this, EventArgs.Empty);
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
    }
}
