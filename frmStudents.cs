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
    public partial class frmStudents : Form
    {
        private string studentID, username;
        public frmStudents(string studentID, string username)
        {
            InitializeComponent();
            this.username = username;
            this.studentID = studentID;
            design();
        }
        Class1 students = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");

        private void frmStudents_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = students.GetData("SELECT studentID, studentLN, studentFN, studentMN, yearLevel, studentCourse, datecreated, createdby FROM tblstudents WHERE studentID <> '" + studentID + "' ORDER BY studentID");
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["studentCourse"].Width = 135;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on students load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void design()
        {
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.BackColor = Color.FromArgb(52, 152, 219);
            btnadd.ForeColor = Color.White;
            btnadd.FlatAppearance.BorderSize = 0;

            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.BackColor = Color.FromArgb(52, 152, 219);
            btnupdate.ForeColor = Color.White;
            btnupdate.FlatAppearance.BorderSize = 0;

            btnrefresh.FlatStyle = FlatStyle.Flat;
            btnrefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.FlatAppearance.BorderSize = 0;

            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.BackColor = Color.FromArgb(255, 0, 0);
            btndelete.ForeColor = Color.White;
            btndelete.FlatAppearance.BorderSize = 0;


            btnadd.MouseEnter += (s, e) => { btnadd.BackColor = Color.FromArgb(61, 138, 195); };
            btnadd.MouseLeave += (s, e) => { btnadd.BackColor = Color.FromArgb(60, 160, 230); };

            btnupdate.MouseEnter += (s, e) => { btnupdate.BackColor = Color.FromArgb(61, 138, 195); };
            btnupdate.MouseLeave += (s, e) => { btnupdate.BackColor = Color.FromArgb(60, 160, 230); };

            btnrefresh.MouseEnter += (s, e) => { btnrefresh.BackColor = Color.FromArgb(61, 138, 195); };
            btnrefresh.MouseLeave += (s, e) => { btnrefresh.BackColor = Color.FromArgb(60, 160, 230); };

            btndelete.MouseEnter += (s, e) => { btndelete.BackColor = Color.FromArgb(139, 0, 0); };
            btndelete.MouseLeave += (s, e) => { btndelete.BackColor = Color.FromArgb(255, 0, 0); };


        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            frmNewstudent newstudentform = new frmNewstudent(username);
            newstudentform.StudentAdded += (s, args) => frmStudents_Load(sender, e);
            newstudentform.Show();
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            frmStudents_Load(sender, e);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = students.GetData("SELECT studentID, studentLN, studentFN, studentMN, yearLevel, studentCourse, datecreated, createdby FROM tblstudents WHERE studentID <> '" + studentID + "' AND (studentID LIKE '%" + txtsearch.Text + "%' OR studentLN LIKE '%" + txtsearch.Text + "%' OR yearLevel LIKE '%" + txtsearch.Text + "%') ORDER BY studentID");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string editstudentID = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string editLastName = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string editFirstName = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string editMiddleName = dataGridView1.Rows[row].Cells[3].Value.ToString();
            string editYearLevel = dataGridView1.Rows[row].Cells[4].Value.ToString();
            string editCourse = dataGridView1.Rows[row].Cells[5].Value.ToString();
            frmUpdateStudent updatestudentfrm = new frmUpdateStudent(editstudentID, editLastName, editFirstName, editMiddleName, editYearLevel, editCourse, username);
            updatestudentfrm.StudentUpdated += (s, args) => frmStudents_Load(sender, e);
            updatestudentfrm.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                string selectedUser = dataGridView1.Rows[row].Cells[0].Value.ToString();
                try
                {
                    students.executeSQL("DELETE FROM tblstudents WHERE studentID = '" + selectedUser + "'");
                    if (students.rowAffected > 0)
                    {
                        students.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() +
                                "', 'Delete', 'Students Management', '" + selectedUser + "', '" + username + "')");
                        frmStudents_Load(sender, e);
                        MessageBox.Show("Student Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
