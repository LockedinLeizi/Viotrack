using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmCases : Form
    {
        private string username;
        Class1 cases = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
        public frmCases(string username)
        {
            InitializeComponent();
            design();
            this.username = username;
            dataGridView1.Columns["caseID"].Width = 120;
            dataGridView1.Columns["violationID"].Width = 80;
            dataGridView1.Columns["violationDescription"].Width = 140;
            dataGridView1.Columns["recommendation"].Width = 110;
            dataGridView1.Columns["status"].Width = 60;
            dataGridView1.Columns["resolution"].Width = 140;
            dataGridView1.Columns["createdby"].Width = 85;
            dataGridView1.Columns["datecreated"].Width = 95;
            dataGridView1.Columns["schoolyear"].Width = 90;
            dataGridView1.Columns["concernlevel"].Width = 110;
            

        }
        private void design()
        {
            btnaddcase.FlatStyle = FlatStyle.Flat;
            btnaddcase.BackColor = Color.FromArgb(52, 152, 219);
            btnaddcase.ForeColor = Color.White;
            btnaddcase.FlatAppearance.BorderSize = 0;

            btnupdatecase.FlatStyle = FlatStyle.Flat;
            btnupdatecase.BackColor = Color.FromArgb(52, 152, 219);
            btnupdatecase.ForeColor = Color.White;
            btnupdatecase.FlatAppearance.BorderSize = 0;

            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.BackColor = Color.FromArgb(52, 152, 219);
            btnclear.ForeColor = Color.White;
            btnclear.FlatAppearance.BorderSize = 0;

            btnrefresh.FlatStyle = FlatStyle.Flat;
            btnrefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.FlatAppearance.BorderSize = 0;

            btnaddcase.MouseEnter += (s, e) => { btnaddcase.BackColor = Color.FromArgb(61, 138, 195); };
            btnaddcase.MouseLeave += (s, e) => { btnaddcase.BackColor = Color.FromArgb(60, 160, 230); };

            btnupdatecase.MouseEnter += (s, e) => { btnupdatecase.BackColor = Color.FromArgb(61, 138, 195); };
            btnupdatecase.MouseLeave += (s, e) => { btnupdatecase.BackColor = Color.FromArgb(60, 160, 230); };

            btnclear.MouseEnter += (s, e) => { btnclear.BackColor = Color.FromArgb(61, 138, 195); };
            btnclear.MouseLeave += (s, e) => { btnclear.BackColor = Color.FromArgb(60, 160, 230); };

            btnrefresh.MouseEnter += (s, e) => { btnrefresh.BackColor = Color.FromArgb(61, 138, 195); };
            btnrefresh.MouseLeave += (s, e) => { btnrefresh.BackColor = Color.FromArgb(60, 160, 230); };
        }
        private void Clear()
        {
            txtlastname.Clear();
            txtfirstname.Clear();
            txtmiddlename.Clear();
            txtlevel.Clear();
            txtcourse.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
        private bool loadcases()
        {
            string studentID = txtstudentID.Text;
            if (!string.IsNullOrEmpty(studentID))
            {
                dataGridView1.Rows.Clear();
                DataTable studentData = cases.GetData($"SELECT studentLN, studentFN, studentMN, yearLevel, studentCourse FROM tblstudents WHERE studentID = '{studentID}'");

                if (studentData.Rows.Count > 0)
                {
                    DataRow row = studentData.Rows[0];
                    txtlastname.Text = row["studentLN"].ToString();
                    txtfirstname.Text = row["studentFN"].ToString();
                    txtmiddlename.Text = row["studentMN"].ToString();
                    txtlevel.Text = row["yearLevel"].ToString();
                    txtcourse.Text = row["studentCourse"].ToString();

                    // Retrieve case and violation data for the student
                    string queryCases = $@"
                        SELECT c.caseID, c.violationID, v.description AS 'violationDescription', c.violationcount, c.schoolyear, c.concernlevel, c.recommendation, 
                               c.status, c.resolution, c.createdby, c.datecreated
                        FROM tblcases c, tblviolations v
                        WHERE c.studentID = '{studentID}' AND c.violationID = v.violationcode ORDER BY c.caseID";
                    DataTable caseData = cases.GetData(queryCases);

                    foreach (DataRow caseRow in caseData.Rows)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        DataGridViewRow newRow = dataGridView1.Rows[rowIndex];
                        newRow.Cells["caseID"].Value = caseRow["caseID"];
                        newRow.Cells["violationID"].Value = caseRow["violationID"];
                        newRow.Cells["violationDescription"].Value = caseRow["violationDescription"];
                        newRow.Cells["violationcount"].Value = caseRow["violationcount"];
                        newRow.Cells["schoolyear"].Value = caseRow["schoolyear"];
                        newRow.Cells["concernlevel"].Value = caseRow["concernlevel"];
                        newRow.Cells["recommendation"].Value = caseRow["recommendation"];
                        newRow.Cells["status"].Value = caseRow["status"];
                        newRow.Cells["resolution"].Value = caseRow["resolution"];
                        newRow.Cells["createdby"].Value = caseRow["createdby"];
                        newRow.Cells["datecreated"].Value = caseRow["datecreated"];
                    }
                    dataGridView1.Columns["violationDescription"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Columns["resolution"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Columns["recommendation"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    return true;
                }
                else
                {
                    Clear();
                    return false;
                }
            }
            else
            {
                Clear();
                return false;
            }
        }
        private void txtstudentID_TextChanged(object sender, EventArgs e)
        {
            loadcases();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentID.Clear();
        }
        private int row;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = (int)e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on datagrid cellclick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnaddcase_Click(object sender, EventArgs e)
        {
            frmNewcase newCaseForm = new frmNewcase(username)
            {
                StudentNumber = txtstudentID.Text,
                LastName = txtlastname.Text,
                FirstName = txtfirstname.Text,
                MiddleName = txtmiddlename.Text,
                Level = txtlevel.Text,
                StrandCourse = txtcourse.Text,
            };
            newCaseForm.CaseAdded += (s, args) => loadcases();
            newCaseForm.Show();
        }

        private void btnupdatecase_Click(object sender, EventArgs e)
        {
            string editStatus = dataGridView1.Rows[row].Cells[7].Value.ToString();
            string editResolution = dataGridView1.Rows[row].Cells[8].Value.ToString();
            string caseID = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string violationID = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string description = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string editSchoolyear = dataGridView1.Rows[row].Cells[4].Value.ToString();
            string editConcernlevel = dataGridView1.Rows[row].Cells[5].Value.ToString();
            string editRecommendation = dataGridView1.Rows[row].Cells[6].Value.ToString();
            frmUpdateCase updateCaseForm = new frmUpdateCase(editStatus, editResolution, caseID, violationID, description, editSchoolyear, editConcernlevel, editRecommendation, username)
            {
                StudentNumber = txtstudentID.Text,
                LastName = txtlastname.Text,
                FirstName = txtfirstname.Text,
                MiddleName = txtmiddlename.Text,
                Level = txtlevel.Text,
                StrandCourse = txtcourse.Text,
            };
            updateCaseForm.CaseUpdated += (s, args) => loadcases();
            updateCaseForm.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            loadcases();
        }

        private void txtstudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!loadcases())
                {
                    MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

