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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            design();
            
        }

        //declare login object
        Class1 login = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
        private int errorcount;

        private void design()
        {
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.BackColor = Color.FromArgb(52, 152, 219);
            btnlogin.ForeColor = Color.White;
            btnlogin.FlatAppearance.BorderSize = 0;

            btnreset.FlatStyle = FlatStyle.Flat;
            btnreset.BackColor = Color.FromArgb(52, 152, 219);
            btnreset.ForeColor = Color.White;
            btnreset.FlatAppearance.BorderSize = 0;

            btnlogin.MouseEnter += (s, e) => { btnlogin.BackColor = Color.FromArgb(61, 138, 195); };
            btnlogin.MouseLeave += (s, e) => { btnlogin.BackColor = Color.FromArgb(60, 160, 230); };

            btnreset.MouseEnter += (s, e) => { btnreset.BackColor = Color.FromArgb(61, 138, 195); };
            btnreset.MouseLeave += (s, e) => { btnreset.BackColor = Color.FromArgb(60, 160, 230); };
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(txtusername.Text))
                {
                    errorProvider1.SetError(txtusername, "Input is empty");
                }
                if (string.IsNullOrEmpty(txtpassword.Text))
                {
                    errorProvider1.SetError(txtpassword, "Input is empty");
                }
           
                errorcount = 0;
                foreach (Control c in errorProvider1.ContainerControl.Controls)
                {
                    if (!(string.IsNullOrEmpty(errorProvider1.GetError(c))))
                    {
                        errorcount++;
                    }
                }
            //process and output
            if(errorcount == 0)
            {
                try
                {
                    DataTable dt = login.GetData("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "' AND status = 'ACTIVE'");
                    if(dt.Rows.Count > 0)
                    {
                        frmMain mainForm = new frmMain(txtusername.Text, dt.Rows[0].Field<string>("usertype"));
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect account information or account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            errorProvider1.Clear();
            txtusername.Focus();
        }
    }
}
