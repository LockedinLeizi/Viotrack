using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using System.Runtime.InteropServices;

namespace CS311MALABON2024_DATABASE_CARREON
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private string username, usertype;
        public frmMain(string username,string usertype)
        {
            InitializeComponent();
            this.username = username;
            this.usertype = usertype;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            hideSubMenu();
            hover();
        }
        private void hover()
        {
            btnExit.MouseEnter += (s, e) => btnExit.BackColor = Color.Red;
            btnExit.MouseLeave += (s, e) => btnExit.BackColor = Color.FromArgb(0, 0, 77);

            btnMaximize.MouseEnter += (s, e) => btnMaximize.BackColor = Color.FromArgb(128, 128, 255);
            btnMaximize.MouseLeave += (s, e) => btnMaximize.BackColor = Color.FromArgb(0, 0, 77);

            btnMinimize.MouseEnter += (s, e) => btnMinimize.BackColor = Color.FromArgb(128, 128, 255);
            btnMinimize.MouseLeave += (s, e) => btnMinimize.BackColor = Color.FromArgb(0, 0, 77);
        }
        private void hideSubMenu()
        {
            panelMaintenanceSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(102, 102, 255);
            public static Color color2 = Color.FromArgb(255, 102, 102);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 0, 85);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1) ;
            showSubMenu(panelMaintenanceSubMenu);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccounts(username));
            hideSubMenu();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            string studentID = "";
            OpenChildForm(new frmStudents(studentID, username));
            hideSubMenu();
        }

        private void btnViolations_Click(object sender, EventArgs e)
        {
            string violationcode = "";
            OpenChildForm(new frmViolations(violationcode,username));
            hideSubMenu();
        }
        private void btnCases_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCases(username));
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color2);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.FromArgb(255, 77, 77);
            lblTitleChildForm.Text = "Home";
            hideSubMenu();
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            panelDesktop.Refresh();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Username: " + username;
            toolStripStatusLabel2.Text = "User Type: " + usertype;
            if(usertype == "ADMINISTRATOR")
            {
                btnAccounts.Visible = true;
                btnEvents.Visible = true;
                btnTickets.Visible = true;
                btnStudents.Visible = true;
                btnViolations.Visible = true;
                btnCases.Visible = true;
            }
            else if (usertype == "BRANCH ADMINISTRATOR")
            {
                btnAccounts.Visible = false;
                btnStudents.Visible = false;
                btnEvents.Visible = true;
                btnTickets.Visible = true;
                btnViolations.Visible = false;
                btnCases.Visible = false;
            }
            else
            {
                btnAccounts.Visible = false;
                btnStudents.Visible = false;
                btnEvents.Visible = false;
                btnTickets.Visible = true;
                btnViolations.Visible = false;
                btnCases.Visible= false;
            }
        }
    }

}

