using ClinicManagement_proj.BLL.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Doctor Management panel
    /// </summary>
    public class DoctorManagementController : IPanelController
    {
        private readonly Panel panel;
        private DataGridView dgvDoctors => (DataGridView)panel.Controls["dgvDoctors"];
        private GroupBox grpDoctorMgmt => (GroupBox)panel.Controls["grpDoctorMgmt"];
        private TableLayoutPanel actionsLayout => (TableLayoutPanel)grpDoctorMgmt.Controls["layoutDoctorActions"];
        private TextBox txtDoctorFName => (TextBox)grpDoctorMgmt.Controls["txtDoctorFName"];
        private TextBox txtDoctorLName => (TextBox)grpDoctorMgmt.Controls["txtDoctorLName"];
        private ComboBox comboDoctorUserId => (ComboBox)grpDoctorMgmt.Controls["comboDoctorUserId"];
        private ComboBox comboSpecialization => (ComboBox)grpDoctorMgmt.Controls["comboSpecialization"];
        private Button btnDoctorSubmit => (Button)actionsLayout.Controls["btnDoctorSubmit"];
        private Button btnDoctorCancel => (Button)actionsLayout.Controls["btnDoctorCancel"];
        private Button btnDoctorDelete => (Button)actionsLayout.Controls["btnDoctorDelete"];
        private Label lblDocUserId => (Label)grpDoctorMgmt.Controls["lblDocUserId"];

        private bool isEditMode = false;

        public Panel Panel => panel;

        public DoctorManagementController(Panel panel)
        {
            this.panel = panel;
        }

        public void Initialize()
        {
            btnDoctorSubmit.Click += new EventHandler(btnDoctorSubmit_Click);
            btnDoctorCancel.Click += new EventHandler(btnDoctorCancel_Click);
            btnDoctorDelete.Click += new EventHandler(btnDoctorDelete_Click);
            dgvDoctors.Click += new EventHandler(dgvDoctors_Click);
            comboDoctorUserId.SelectedIndexChanged += new EventHandler(comboDoctorUserId_SelectedIndexChanged);
        }

        public void OnShow()
        {
            ResetDoctorForm();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            // var doctors = doctorService.GetAllDoctors();
            // dgvDoctors.DataSource = doctors;
        }

        /// <summary>
        /// Reset the doctor management form to initial state
        /// </summary>
        private void ResetDoctorForm()
        {
            txtDoctorFName.Text = string.Empty;
            txtDoctorLName.Text = string.Empty;

            // Load available usernames for doctor association
            List<string> usernames = new List<string>();
            // TODO: Load from BLL when implemented

            comboDoctorUserId.DataSource = usernames;
            comboDoctorUserId.SelectedIndex = -1;

            // TODO: Load specializations when enum is available
            comboSpecialization.SelectedIndex = -1;

            isEditMode = false;
            btnDoctorCancel.Visible = false;
            btnDoctorDelete.Visible = false;
            dgvDoctors.ClearSelection();
            btnDoctorSubmit.Text = "Create";
            grpDoctorMgmt.Text = "Create Doctor";
        }

        /// <summary>
        /// Enter edit mode for doctor management
        /// </summary>
        private void EnterDoctorEditMode()
        {
            isEditMode = true;
            btnDoctorCancel.Visible = true;
            btnDoctorDelete.Visible = true;
            btnDoctorSubmit.Text = "Update";
            grpDoctorMgmt.Text = "Edit Doctor";
        }

        /// <summary>
        /// Handle doctor selection from grid
        /// </summary>
        private void dgvDoctors_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                // Load selected doctor data
                txtDoctorFName.Text = dgvDoctors.CurrentRow.Cells["FirstName"].Value.ToString();
                txtDoctorLName.Text = dgvDoctors.CurrentRow.Cells["LastName"].Value.ToString();
                EnterDoctorEditMode();
            }
        }

        /// <summary>
        /// Handle doctor user association selection change
        /// </summary>
        private void comboDoctorUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update label based on selection
            lblDocUserId.Text = "User Associated";
        }

        /// <summary>
        /// Cancel doctor form operation
        /// </summary>
        private void btnDoctorCancel_Click(object sender, EventArgs e)
        {
            ResetDoctorForm();
        }

        /// <summary>
        /// Submit doctor form (create or update)
        /// </summary>
        private void btnDoctorSubmit_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("Doctor operation simulated!", NotificationType.Info);
            ResetDoctorForm();
        }

        /// <summary>
        /// Delete selected doctor
        /// </summary>
        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("Doctor delete simulated!", NotificationType.Info);
            ResetDoctorForm();
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
