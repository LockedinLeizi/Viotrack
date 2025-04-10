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
    public partial class frmNewaccount : Form
    {
        public delegate void AccountAddedEventHandler(object sender, EventArgs e);
        public event AccountAddedEventHandler AccountAdded;
        private string username;
        private int errorcount;
        Class1 newaccount = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
        public frmNewaccount(string username)
        {
            InitializeComponent();
            design();
            this.username = username;
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
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                errorProvider1.SetError(txtusername, "Username is empty");
                errorcount++;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.SetError(txtpassword, "Password is empty");
                errorcount++;
            }
            if (txtpassword.TextLength < 6)
            {
                errorProvider1.SetError(txtpassword, "Password must be atleast 6 characters");
                errorcount++;
            }
            if(cmbtype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbtype, "Select usertype");
                errorcount++;
            }
            try
            {
                DataTable dt = newaccount.GetData("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtusername, "Username already in use");
                    errorcount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on validating existing account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateform();
            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to add this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes) 
                { 
                    try
                    {
                        newaccount.executeSQL("INSERT INTO tblaccounts (username, password, usertype, status, createdby, datecreated) VALUES ('" + txtusername.Text + "', '" + 
                            txtpassword.Text + "', '" + cmbtype.Text.ToUpper() + "', 'ACTIVE', '" + username + "', '" + DateTime.Now.ToShortDateString() + "')");
                        if(newaccount.rowAffected > 0)
                        {
                            newaccount.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() +
                                "', 'Add', 'Accounts Management', '" + txtusername.Text + "', '" + username + "')");
                            MessageBox.Show("New account added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AccountAdded?.Invoke(this, EventArgs.Empty);
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

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            cmbtype.SelectedIndex = -1;
        }
    }
}
