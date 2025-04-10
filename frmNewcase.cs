using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmNewcase : Form
    {
        public delegate void CaseAddedEventHandler(object sender, EventArgs e);
        public event CaseAddedEventHandler CaseAdded;
        private string username;    
        private int errorcount;
        public string StudentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Level { get; set; }
        public string StrandCourse { get; set; }
        Class1 newcase = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
        public frmNewcase(string username)
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
            if (cmbviolation.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbviolation, "Select a violation.");
                errorcount++;
            }

        }
        private void loadViolations()
        {
            try
            {
                DataTable violationsdata = newcase.GetData("SELECT violationcode FROM tblviolations");
                cmbviolation.DisplayMember = "violationcode";  
                cmbviolation.ValueMember = "violationcode"; 
                cmbviolation.DataSource = violationsdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on accounts load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmNewcase_Load(object sender, EventArgs e)
        {
            txtstudentID.Text = StudentNumber;
            txtlastname.Text = LastName;
            txtfirstname.Text = FirstName;
            txtmiddlename.Text = MiddleName;
            txtlevel.Text = Level;
            txtcourse.Text = StrandCourse;
            loadViolations();
            cmbviolation.SelectedIndex = -1;
        }

        private void cmbviolation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbviolation.SelectedValue != null)
            {
                string selectedcode = cmbviolation.SelectedValue.ToString();
                //fetch description
                DataTable violationData = newcase.GetData($"SELECT description FROM tblviolations WHERE violationcode = '{selectedcode}'");
                if (violationData.Rows.Count > 0)
                {
                    // Display description in the RichTextBox
                    txtdescription.Text = violationData.Rows[0]["description"].ToString();
                }
            }
            else
            {
                txtdescription.Clear();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            validateform();

            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to add this case?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //unique caseID
                        string caseID = "case" + DateTime.Now.ToString("yyyyMMddHHmmss");

                        // Check previous violations
                        DataTable previousCases = newcase.GetData("SELECT COUNT(*) AS violationcount FROM tblcases WHERE studentID = '" + txtstudentID.Text + "' AND violationID = '" + cmbviolation.SelectedValue.ToString() + "'");
                        int violationCount = (int)previousCases.Rows[0]["ViolationCount"] + 1; // Increment by 1 for the new violation
                        string violationLabel;
                        switch (violationCount)
                        {
                            case 1:
                                violationLabel = "1st Violation";
                                break;
                            case 2:
                                violationLabel = "2nd Violation";
                                break;
                            case 3:
                                violationLabel = "3rd Violation";
                                break;
                            default:
                                violationLabel = $"{violationCount}th Violation";
                                break;
                        }

                        newcase.executeSQL("INSERT INTO tblcases (caseID, studentID, violationID, violationcount, schoolyear, concernlevel, recommendation, status, resolution, createdby, datecreated) " +
                            "VALUES ('" + caseID + "', '" + txtstudentID.Text + "', '" + cmbviolation.SelectedValue.ToString() + "', '" + violationLabel + "','" + txtschoolyear.Text + "', '" + cmbconcernlevel.Text + "','" + txtrecommendation.Text + "', 'Ongoing', '', '" + username + "', '" + DateTime.Now.ToShortDateString() + "')");

                        if (newcase.rowAffected > 0)
                        {
                            // Log the action in tbllogs
                            newcase.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() +
                                "', '" + DateTime.Now.ToShortTimeString() + "', 'Add', 'Cases Management', '" + caseID + "', '" + username + "')");

                            MessageBox.Show("New case added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CaseAdded?.Invoke(this, EventArgs.Empty);
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
            cmbviolation.SelectedIndex = -1;
            txtschoolyear.Clear();
            cmbconcernlevel.SelectedIndex = -1;
            txtrecommendation.Clear();
        }
    }
}
