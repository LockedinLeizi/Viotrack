using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmUpdateCase : Form
    {
        public delegate void CaseUpdatedEventHandler(object sender, EventArgs e);
        public event CaseUpdatedEventHandler CaseUpdated;
        private string editStatus, editResolution, caseID, violationID, description, editSchoolyear, editConcernlevel, editRecommendation, username;
        private int errorcount;
        public string StudentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Level { get; set; }
        public string StrandCourse { get; set; }
        Class1 updatecase = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");


        public frmUpdateCase(string editStatus, string editResolution, string caseID, string violationID, string description, string editSchoolyear, string editConcernlevel, string editRecommendation, string username)
        {
            InitializeComponent();
            this.username = username;
            this.editStatus = editStatus;
            this.editResolution = editResolution;
            this.caseID = caseID;
            this.violationID = violationID;
            this.description = description;
            this.editSchoolyear = editSchoolyear;
            this.editConcernlevel = editConcernlevel;
            this.editRecommendation = editRecommendation;
            design();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            cmbstatus.SelectedIndex = -1;
            txtresolution.Clear();
            txtschoolyear.Clear();
            cmbconcernlevel.SelectedIndex = -1;
            txtrecommendation.Clear();
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

            if(cmbstatus.SelectedIndex == 1) 
            {
                if (string.IsNullOrEmpty(txtresolution.Text))
                {
                    errorProvider1.SetError(txtresolution, "Resolution is required.");
                    errorcount++;
                }
                if (txtresolution.TextLength > 100)
                {
                    errorProvider1.SetError(txtresolution, "Resolution should not exceed 100 characters");
                    errorcount++;
                }
            }
        }
        private void frmUpdateCase_Load(object sender, EventArgs e)
        {
            txtstudentID.Text = StudentNumber;
            txtlastname.Text = LastName;
            txtfirstname.Text = FirstName;
            txtmiddlename.Text = MiddleName;
            txtlevel.Text = Level;
            txtcourse.Text = StrandCourse;
            txtresolution.Text = editResolution;
            txtviolationcode.Text = violationID;
            txtdescription.Text = description;
            txtschoolyear.Text = editSchoolyear;
            cmbconcernlevel.Text = editConcernlevel;
            txtrecommendation.Text = editRecommendation;
            if (editStatus == "Ongoing")
            {
                cmbstatus.SelectedIndex = 0;
            }
            else 
            {
                cmbstatus.SelectedIndex = 1;
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbstatus.SelectedItem != null)
            {
                string selectedValue = cmbstatus.SelectedItem.ToString();

                if (selectedValue == "Resolved")
                {
                    txtresolution.Enabled = true;
                }
                else
                {
                    txtresolution.Clear();
                    txtresolution.Enabled = false;
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateform();

            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to update this case?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        // Insert the update student record
                        updatecase.executeSQL("UPDATE tblcases SET schoolyear = '" + txtschoolyear.Text + "', concernlevel = '" + cmbconcernlevel.Text + "', recommendation = '" + txtrecommendation.Text + "', status = '" + cmbstatus.Text + "', resolution = '" + txtresolution.Text +
                            "' WHERE caseID = '" + caseID + "'");

                        if (updatecase.rowAffected > 0)
                        {
                            // Log the action
                            updatecase.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() +
                                "', '" + DateTime.Now.ToShortTimeString() + "', 'Update', 'Cases Management', '" + caseID + "', '" + username + "')");
                            MessageBox.Show("Case data updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CaseUpdated?.Invoke(this, EventArgs.Empty);
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
