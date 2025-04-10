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
    public partial class frmNewviolation : Form
    {
        public delegate void ViolationAddedEventHandler(object sender, EventArgs e);
        public event ViolationAddedEventHandler ViolationAdded;
        private string username;
        private int errorcount;
        Class1 newviolation = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");
        public frmNewviolation(string username)
        {
            InitializeComponent();
            this.username = username;
            txtDescription.Multiline = true;
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

            if (string.IsNullOrEmpty(txtViolationcode.Text))
            {
                errorProvider1.SetError(txtViolationcode, "Violation code is required.");
                errorcount++;
            }
            if (txtViolationcode.TextLength > 15)
            {
                errorProvider1.SetError(txtViolationcode, "Violation code should not exceed 15 characters");
                errorcount++;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Description is required.");
                errorcount++;
            }
            if (txtViolationcode.TextLength > 100)
            {
                errorProvider1.SetError(txtViolationcode, "Description should not exceed 100 characters");
                errorcount++;
            }
            if (cmbType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbType, "Select a type.");
                errorcount++;
            }
            if (cmbStatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbStatus, "Select a status.");
                errorcount++;
            }
            // Check if Violation code already exists
            try
            {
                DataTable dt = newviolation.GetData("SELECT * FROM tblviolations WHERE violationcode = '" + txtViolationcode.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtViolationcode, "Violation code already exists");
                    errorcount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on validating existing violation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateform();
            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to add this violation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        newviolation.executeSQL("INSERT INTO tblviolations (violationcode, description, type, status, createdby, datecreated) VALUES ('" + txtViolationcode.Text + "', '" +
                            txtDescription.Text + "', '" + cmbType.Text + "', '" + cmbStatus.Text.ToUpper() + "', '" + username + "', '" + DateTime.Now.ToShortDateString() + "')");
                        if (newviolation.rowAffected > 0)
                        {
                            newviolation.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() +
                                "', 'Add', 'Violations Management', '" + txtViolationcode.Text + "', '" + username + "')");
                            MessageBox.Show("New violation added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViolationAdded?.Invoke(this, EventArgs.Empty);
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
            txtViolationcode.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;

            cmbStatus.Text = string.Empty;
            cmbType.Text = string.Empty;
        }
    }
}
