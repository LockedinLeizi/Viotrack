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
    public partial class frmUpdateViolation : Form
    {
        public delegate void ViolationUpdatedEventHandler(object sender, EventArgs e);
        public event ViolationUpdatedEventHandler ViolationUpdated;
        private string editviolationcode, editdescription, edittype, editstatus, username;
        private int errorcount;

        Class1 updateviolation = new Class1("DESKTOP-ADH3Q84", "cs311a2024", "marzel", "carreon");

        public frmUpdateViolation(string editviolationcode, string editdescription, string edittype, string editstatus, string username)
        {
            InitializeComponent();
            this.username = username;
            this.editviolationcode = editviolationcode;
            this.editdescription = editdescription;
            this.edittype = edittype;
            this.editstatus = editstatus;
            txtDescription.Multiline = true;
            design();
        }

        private void frmUpdateViolation_Load(object sender, EventArgs e)
        {
            txtViolationcode.Text = editviolationcode;
            txtDescription.Text = editdescription;
            if (edittype == "Minor offense")
            {
                cmbType.SelectedIndex = 0;
            }
            else
            {
                cmbType.SelectedIndex = 1;
            }

            if (editstatus == "ACTIVE")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }
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
        private void validateForm()
        {
            errorProvider1.Clear();
            errorcount = 0;
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Password is empty");
                errorcount++;
            }
            if (txtViolationcode.TextLength > 15)
            {
                errorProvider1.SetError(txtViolationcode, "Violation code should not exceed 15 characters");
                errorcount++;
            }
            if (cmbType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbType, "Select usertype");
                errorcount++;
            }
            if (cmbStatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbStatus, "Select status");
                errorcount++;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateForm();
            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to update this violation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        // Insert the update violation record
                        updateviolation.executeSQL("UPDATE tblviolations SET description = '" + txtDescription.Text + "', type = '" + cmbType.Text + "', status = '" + cmbStatus.Text.ToUpper() +
                            "' WHERE violationcode = '" + txtViolationcode.Text + "'");

                        if (updateviolation.rowAffected > 0)
                        {
                            // Log the action
                            updateviolation.executeSQL("INSERT INTO tbllogs (datelog, timelog, action, module, ID, performedby) VALUES ('" + DateTime.Now.ToShortDateString() +
                                "', '" + DateTime.Now.ToShortTimeString() + "', 'Update', 'Violations Management', '" + txtViolationcode.Text + "', '" + username + "')");
                            MessageBox.Show("Violation updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViolationUpdated?.Invoke(this, EventArgs.Empty);
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
            txtDescription.Clear();
            cmbType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }
    }
}
