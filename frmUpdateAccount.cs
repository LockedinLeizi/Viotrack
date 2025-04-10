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
    public partial class frmUpdateAccount : Form
    {
        public delegate void AccountUpdatedEventHandler(object sender, EventArgs e);
        public event AccountUpdatedEventHandler AccountUpdated;
        private string editusername, editpassword, edittype, editstatus, username;
        private int errorcount;
        Class1 updateaccount = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
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
        private void validateForm()
        {
            errorProvider1.Clear();
            errorcount = 0;
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
            if (cmbtype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbtype, "Select usertype");
                errorcount++;
            }
            if (cmbstatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbstatus, "Select status");
                errorcount++;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateForm();
            if(errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to update this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        updateaccount.executeSQL("UPDATE tblaccounts SET password = '" + txtpassword.Text + "', usertype = '" + cmbtype.Text.ToUpper() + "', status = '" +  cmbstatus.Text.ToUpper() +
                            "' WHERE username = '" + txtusername.Text + "'");
                        if (updateaccount.rowAffected > 0)
                        {
                            updateaccount.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() +
                                "', 'Update', 'Accounts Management', '" + txtusername.Text + "', '" + username + "')");
                            MessageBox.Show("Account Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AccountUpdated?.Invoke(this, EventArgs.Empty);
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
            txtusername.Clear();
            txtpassword.Clear();
            cmbtype.SelectedIndex = -1;
            cmbstatus.SelectedIndex = -1;
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

        public frmUpdateAccount(string editusername, string editpassword, string edittype, string editstatus, string username)
        {
            InitializeComponent();
            design();
            this.username = username;
            this.editusername = editusername;
            this.editpassword = editpassword;
            this.edittype = edittype;
            this.editstatus = editstatus;
        }

        private void frmUpdateAccount_Load(object sender, EventArgs e)
        {
            txtusername.Text = editusername;
            txtpassword.Text = editpassword;
            if(edittype == "ADMINISTRATOR")
            {
                cmbtype.SelectedIndex = 0;
            }
            else if(edittype == "BRANCH ADMINISTRATOR")
            {
                cmbtype.SelectedIndex = 1;
            }
            else
            {
                cmbtype.SelectedIndex = 2;
            }
            if(editstatus == "ACTIVE")
            {
                cmbstatus.SelectedIndex = 0;
            }
            else
            {
                cmbstatus.SelectedIndex = 1;
            }
        }
    }
}
