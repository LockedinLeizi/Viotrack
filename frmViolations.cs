using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmViolations : Form
    {
        private string violationcode, username;
        Class1 violations = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
        public frmViolations(string violationcode, string username)
        {
            InitializeComponent();
            this.username = username;
            this.violationcode = violationcode;
            design();
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
        private void frmViolations_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = violations.GetData("SELECT violationcode, description, type, status, createdby, datecreated FROM tblviolations WHERE violationcode <> '" + violationcode + "' ORDER BY violationcode");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Adjust row height to fit
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns["description"].Width = 240;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on violations load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = violations.GetData("SELECT violationcode, description, type, status, createdby, datecreated FROM tblviolations WHERE violationcode <> '" + violationcode + "' AND (violationcode LIKE '%" + txtsearch.Text + "%' OR description LIKE '%" + txtsearch.Text + "%' OR type LIKE '%" + txtsearch.Text + "%') ORDER BY violationcode");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this violation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                string selectedUser = dataGridView1.Rows[row].Cells[0].Value.ToString();
                try
                {
                    violations.executeSQL("DELETE FROM tblviolations WHERE violationcode = '" + selectedUser + "'");
                    if (violations.rowAffected > 0)
                    {
                        violations.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() +
                                "', 'Delete', 'Violations Management', '" + selectedUser + "', '" + username + "')");
                        frmViolations_Load(sender, e);
                        MessageBox.Show("Violation Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmNewviolation newviolationform = new frmNewviolation(username);
            newviolationform.ViolationAdded += (s, args) => frmViolations_Load(sender, e);
            newviolationform.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string editviolationcode = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string editdescription = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string edittype = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string editstatus = dataGridView1.Rows[row].Cells[3].Value.ToString();
            frmUpdateViolation updateviolationfrm = new frmUpdateViolation(editviolationcode, editdescription, edittype, editstatus, username);
            updateviolationfrm.ViolationUpdated += (s, args) => frmViolations_Load(sender, e);
            updateviolationfrm.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            frmViolations_Load(sender, e);
        }

    }
}
