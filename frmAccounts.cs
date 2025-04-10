using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmAccounts : Form
    {
        private string username;
        public frmAccounts(string username)
        {
            InitializeComponent();
            design();
            this.username = username;
        }
        Class1 accounts = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
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

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = accounts.GetData("SELECT username, password, usertype, status, createdby, datecreated FROM tblaccounts WHERE username <> '" + username + "' ORDER BY username");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on accounts load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = accounts.GetData("SELECT username, password, usertype, status, createdby, datecreated FROM tblaccounts WHERE username <> '" + username + "' AND (username LIKE '%" + txtsearch.Text + "%' OR usertype LIKE '%" + txtsearch.Text + "%') ORDER BY username");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmNewaccount newaccountform = new frmNewaccount(username);
            newaccountform.AccountAdded += (s, args) => frmAccounts_Load(sender, e);
            newaccountform.Show();
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
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                string selectedUser = dataGridView1.Rows[row].Cells[0].Value.ToString();
                try
                {
                    accounts.executeSQL("DELETE FROM tblaccounts WHERE username = '" + selectedUser + "'");
                    if (accounts.rowAffected > 0)
                    {
                        accounts.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() +
                                "', 'Delete', 'Accounts Management', '" + selectedUser + "', '" + username + "')");
                        frmAccounts_Load(sender, e);
                        MessageBox.Show("Account Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string editusername = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string editpassword = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string edittype = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string editstatus = dataGridView1.Rows[row].Cells[3].Value.ToString();
            frmUpdateAccount updateaccountfrm = new frmUpdateAccount(editusername, editpassword, edittype, editstatus, username);
            updateaccountfrm.AccountUpdated += (s, args) => frmAccounts_Load(sender, e);
            updateaccountfrm.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            frmAccounts_Load(sender, e);
        }
    }
}
