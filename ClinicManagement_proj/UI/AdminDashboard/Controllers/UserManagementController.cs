using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.BLL.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the User Management panel
    /// </summary>
    public class UserManagementController : IPanelController
    {
        private readonly Panel panel;
        private readonly UserService userService;
        private DataGridView dgvUsers => (DataGridView)panel.Controls["dgvUsers"];
        private GroupBox grpAdminForm => (GroupBox)panel.Controls["grpAdminForm"];
        private Panel pnlButtons => (Panel)grpAdminForm.Controls["pnlButtons"];
        private Button btnUsrSubmit => (Button)pnlButtons.Controls["btnUsrSubmit"];
        private Button btnUsrCancel => (Button)pnlButtons.Controls["btnUsrCancel"];
        private Button btnUsrDelete => (Button)pnlButtons.Controls["btnUsrDelete"];
        private Panel pnlPassword => (Panel)grpAdminForm.Controls["pnlPassword"];
        private Button btnTogglePassword => (Button)pnlPassword.Controls["btnTogglePassword"];
        private Button btnGenPassword => (Button)pnlButtons.Controls["btnGenPassword"];
        private TextBox txtUsrUsername => (TextBox)grpAdminForm.Controls["txtUsrUsername"];
        private TextBox txtUsrPassword => (TextBox)pnlPassword.Controls["txtUsrPassword"];
        private ComboBox comboRoles => (ComboBox)grpAdminForm.Controls["comboRoles"];

        private bool isEditMode = false;
        private bool isPasswordChanged = false;

        public Panel Panel => panel;

        public UserManagementController(Panel panel)
        {
            this.panel = panel;
            this.userService = new UserService();
        }

        public void Initialize()
        {
            btnUsrSubmit.Click += new EventHandler(BtnUsrSubmit_Click);
            btnUsrCancel.Click += new EventHandler(btnUsrCancel_Click);
            btnUsrDelete.Click += new EventHandler(btnUsrDelete_Click);
            btnTogglePassword.Click += new EventHandler(btnTogglePassword_Click);
            btnGenPassword.Click += new EventHandler(btnGenPassword_Click);
            txtUsrPassword.TextChanged += new EventHandler(txtUsrPassword_TextChanged);
            dgvUsers.Click += new EventHandler(dgvUsers_Click);
        }

        public void OnShow()
        {
            LoadUsers();
            ResetUsrForm();
            // comboRoles.DataSource = 
        }

        private void LoadUsers()
        {
            var users = userService.GetAllUsers();
            dgvUsers.DataSource = users;
        }

        private void BtnUsrSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsrUsername.Text.Trim();
            string password = txtUsrPassword.Text.Trim();
            string role = comboRoles.SelectedItem?.ToString();

            try
            {
                if (isEditMode)
                {
                    // userService.UpdateUser();
                    NotificationManager.AddNotification("User updated successfully!", NotificationType.Info);
                }
                else
                {
                    // userService.CreateUser(username, password, role);
                    NotificationManager.AddNotification("User created successfully!", NotificationType.Info);
                }
                LoadUsers();
                ResetUsrForm();
            }
            catch (Exception ex)
            {
                NotificationManager.AddNotification($"Error: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Reset the user management form to initial state
        /// </summary>
        private void ResetUsrForm()
        {
            txtUsrUsername.Text = string.Empty;
            txtUsrPassword.Text = string.Empty;
            comboRoles.SelectedIndex = -1;
            isEditMode = false;
            isPasswordChanged = false;
            btnUsrCancel.Visible = false;
            btnUsrDelete.Visible = false;
            dgvUsers.ClearSelection();
            btnUsrSubmit.Text = "Create";
            grpAdminForm.Text = "Create User";
            txtUsrPassword.UseSystemPasswordChar = true;
            btnTogglePassword.Text = "Show";
            txtUsrPassword.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Enter edit mode for user management
        /// </summary>
        private void EnterUsrEditMode()
        {
            isEditMode = true;
            btnUsrCancel.Visible = true;
            btnUsrDelete.Visible = true;
            txtUsrPassword.Text = string.Empty;
            txtUsrPassword.BackColor = SystemColors.ControlDark;
            isPasswordChanged = false;
            btnUsrSubmit.Text = "Update";
            grpAdminForm.Text = "Edit User";
        }

        /// <summary>
        /// Handle password text change to track modifications
        /// </summary>
        private void txtUsrPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsrPassword.Text.Length == 0)
            {
                txtUsrPassword.BackColor = SystemColors.ControlDark;
            }
            else
            {
                txtUsrPassword.BackColor = SystemColors.Window;
                if (!isPasswordChanged)
                    isPasswordChanged = true;
            }
        }

        /// <summary>
        /// Handle user selection from grid
        /// </summary>
        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                txtUsrUsername.Text = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
                EnterUsrEditMode();
            }
        }

        /// <summary>
        /// Cancel user form operation
        /// </summary>
        private void btnUsrCancel_Click(object sender, EventArgs e)
        {
            ResetUsrForm();
        }

        /// <summary>
        /// Toggle password visibility
        /// </summary>
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtUsrPassword.UseSystemPasswordChar = !txtUsrPassword.UseSystemPasswordChar;
            if (txtUsrPassword.UseSystemPasswordChar)
            {
                btnTogglePassword.Text = "Show";
            }
            else
            {
                btnTogglePassword.Text = "Hide";
            }
        }

        /// <summary>
        /// Delete selected user
        /// </summary>
        private void btnUsrDelete_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("User delete simulated!", NotificationType.Info);
            ResetUsrForm();
        }

        /// <summary>
        /// Generate a random password
        /// </summary>
        private void btnGenPassword_Click(object sender, EventArgs e)
        {
            string generatedPassword = "GeneratedPassword123"; // Simulated
            txtUsrPassword.Text = generatedPassword;
        }

        public void OnHide()
        {
            // Cleanup when leaving panel
        }

        public void Cleanup()
        {
            // Dispose resources if needed
        }
    }
}
