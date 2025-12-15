using System.Drawing;

namespace ClinicManagement_proj.UI
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnAppointmentManagement = new System.Windows.Forms.Button();
            this.btnPatientRegistration = new System.Windows.Forms.Button();
            this.btnDoctorScheduling = new System.Windows.Forms.Button();
            this.btnDoctorManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabDoctorTodaySchedule = new System.Windows.Forms.TabPage();
            this.dgvDoctorTodaySchedule = new System.Windows.Forms.DataGridView();
            this.pnlDoctorTodayScheduleTop = new System.Windows.Forms.Panel();
            this.cmbVwDoctorScheduleSelect = new System.Windows.Forms.ComboBox();
            this.lblVwDoctorScheduleSelect = new System.Windows.Forms.Label();
            this.tabPatientRecords = new System.Windows.Forms.TabPage();
            this.dgvPatientRecords = new System.Windows.Forms.DataGridView();
            this.pnlPatientRecordsTop = new System.Windows.Forms.Panel();
            this.cmbVwPatientSelect = new System.Windows.Forms.ComboBox();
            this.lblVwPatientSelect = new System.Windows.Forms.Label();
            this.tabUpcomingAppointments = new System.Windows.Forms.TabPage();
            this.dgvUpcomingAppointments = new System.Windows.Forms.DataGridView();
            this.pnlUpcomingApptTop = new System.Windows.Forms.Panel();
            this.cmbVwDoctorSelect = new System.Windows.Forms.ComboBox();
            this.lblVwDoctorSelect = new System.Windows.Forms.Label();
            this.tabPatientClinicalSummary = new System.Windows.Forms.TabPage();
            this.dgvPatientClinicalSummary = new System.Windows.Forms.DataGridView();
            this.pnlPatientClinicalSummaryTop = new System.Windows.Forms.Panel();
            this.cmbVwPatientSelectClinical = new System.Windows.Forms.ComboBox();
            this.lblVwPatientSelectClinical = new System.Windows.Forms.Label();
            this.pnlDoctorManagement = new System.Windows.Forms.Panel();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.grpDoctorMgmt = new System.Windows.Forms.GroupBox();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtDoctorLName = new System.Windows.Forms.TextBox();
            this.lblDoctorLName = new System.Windows.Forms.Label();
            this.txtDoctorFName = new System.Windows.Forms.TextBox();
            this.lblDoctorFName = new System.Windows.Forms.Label();
            this.txtDoctorLicense = new System.Windows.Forms.TextBox();
            this.lblDoctorLicense = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.layoutDoctorActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoctorCreate = new System.Windows.Forms.Button();
            this.btnDoctorUpdate = new System.Windows.Forms.Button();
            this.btnDoctorSearch = new System.Windows.Forms.Button();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            this.btnDoctorDisplay = new System.Windows.Forms.Button();
            this.btnDoctorCancel = new System.Windows.Forms.Button();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpAdminForm = new System.Windows.Forms.GroupBox();
            this.txtUsrId = new System.Windows.Forms.TextBox();
            this.lblUsrId = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenPassword = new System.Windows.Forms.Button();
            this.btnUsrCreate = new System.Windows.Forms.Button();
            this.btnUsrUpdate = new System.Windows.Forms.Button();
            this.btnUsrSearch = new System.Windows.Forms.Button();
            this.btnUsrCancel = new System.Windows.Forms.Button();
            this.btnUsrDisplay = new System.Windows.Forms.Button();
            this.btnUsrDelete = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.TableLayoutPanel();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.txtUsrPassword = new System.Windows.Forms.TextBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsrUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlDoctorScheduling = new System.Windows.Forms.Panel();
            this.grpDoctorScheduling = new System.Windows.Forms.GroupBox();
            this.layoutSchedulingContent = new System.Windows.Forms.TableLayoutPanel();
            this.layoutHours = new System.Windows.Forms.TableLayoutPanel();
            this.lblHour12 = new System.Windows.Forms.Label();
            this.lblHour11 = new System.Windows.Forms.Label();
            this.lblHour10 = new System.Windows.Forms.Label();
            this.lblHour9 = new System.Windows.Forms.Label();
            this.lblHour8 = new System.Windows.Forms.Label();
            this.lblHour7 = new System.Windows.Forms.Label();
            this.lblHour6 = new System.Windows.Forms.Label();
            this.lblHour5 = new System.Windows.Forms.Label();
            this.lblHour4 = new System.Windows.Forms.Label();
            this.lblHour3 = new System.Windows.Forms.Label();
            this.lblHour2 = new System.Windows.Forms.Label();
            this.lblHour1 = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lbSunday = new System.Windows.Forms.ListBox();
            this.lbMonday = new System.Windows.Forms.ListBox();
            this.lbTuesday = new System.Windows.Forms.ListBox();
            this.lbWednesday = new System.Windows.Forms.ListBox();
            this.lbThursday = new System.Windows.Forms.ListBox();
            this.lbFriday = new System.Windows.Forms.ListBox();
            this.lbSaturday = new System.Windows.Forms.ListBox();
            this.layoutSchedulingHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDoctorPicker = new System.Windows.Forms.Panel();
            this.cmbDoctorSelect = new System.Windows.Forms.ComboBox();
            this.lblDoctorSelect = new System.Windows.Forms.Label();
            this.layoutSchedulingActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnScheduleRevert = new System.Windows.Forms.Button();
            this.btnScheduleSave = new System.Windows.Forms.Button();
            this.pnlAppointmentManagement = new System.Windows.Forms.Panel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.grpApptMgmt = new System.Windows.Forms.GroupBox();
            this.layoutApptButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnApptCreate = new System.Windows.Forms.Button();
            this.btnApptUpdate = new System.Windows.Forms.Button();
            this.btnApptSearch = new System.Windows.Forms.Button();
            this.btnApptDisplay = new System.Windows.Forms.Button();
            this.btnApptCancel = new System.Windows.Forms.Button();
            this.cmbApptDoctor = new System.Windows.Forms.ComboBox();
            this.lblApptPatient = new System.Windows.Forms.Label();
            this.cmbApptPatient = new System.Windows.Forms.ComboBox();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.dtpApptDate = new System.Windows.Forms.DateTimePicker();
            this.lblApptTimeSlot = new System.Windows.Forms.Label();
            this.cmbApptTimeSlots = new System.Windows.Forms.ComboBox();
            this.lblApptNotes = new System.Windows.Forms.Label();
            this.txtApptNotes = new System.Windows.Forms.TextBox();
            this.lblApptStatus = new System.Windows.Forms.Label();
            this.cmbApptStatus = new System.Windows.Forms.ComboBox();
            this.txtApptId = new System.Windows.Forms.TextBox();
            this.lblApptDoctor = new System.Windows.Forms.Label();
            this.lblApptId = new System.Windows.Forms.Label();
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.dgvRegPatients = new System.Windows.Forms.DataGridView();
            this.grpPatientRegistration = new System.Windows.Forms.GroupBox();
            this.layoutPatientButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPCreate = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPSearch = new System.Windows.Forms.Button();
            this.btnPDisplay = new System.Windows.Forms.Button();
            this.btnPCancel = new System.Windows.Forms.Button();
            this.txtPPhone = new System.Windows.Forms.TextBox();
            this.lblPPhone = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.txtMedicalNumber = new System.Windows.Forms.TextBox();
            this.lblMedicalNumber = new System.Windows.Forms.Label();
            this.txtPLName = new System.Windows.Forms.TextBox();
            this.lblPLName = new System.Windows.Forms.Label();
            this.txtPFName = new System.Windows.Forms.TextBox();
            this.lblPFName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlNotificationsTop = new System.Windows.Forms.Panel();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.lblToast = new System.Windows.Forms.Label();
            this.lblNotificationsTitle = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.flowLayoutPanelNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.timerToast = new System.Windows.Forms.Timer(this.components);
            this.grpAppointmentForm = new System.Windows.Forms.GroupBox();
            this.lblAppointmentPlaceholder = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.tabControlReports.SuspendLayout();
            this.tabDoctorTodaySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorTodaySchedule)).BeginInit();
            this.pnlDoctorTodayScheduleTop.SuspendLayout();
            this.tabPatientRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).BeginInit();
            this.pnlPatientRecordsTop.SuspendLayout();
            this.tabUpcomingAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).BeginInit();
            this.pnlUpcomingApptTop.SuspendLayout();
            this.tabPatientClinicalSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientClinicalSummary)).BeginInit();
            this.pnlPatientClinicalSummaryTop.SuspendLayout();
            this.pnlDoctorManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.grpDoctorMgmt.SuspendLayout();
            this.layoutDoctorActions.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpAdminForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlDoctorScheduling.SuspendLayout();
            this.grpDoctorScheduling.SuspendLayout();
            this.layoutSchedulingContent.SuspendLayout();
            this.layoutHours.SuspendLayout();
            this.layoutSchedulingHeader.SuspendLayout();
            this.pnlDoctorPicker.SuspendLayout();
            this.layoutSchedulingActions.SuspendLayout();
            this.pnlAppointmentManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.grpApptMgmt.SuspendLayout();
            this.layoutApptButtons.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPatients)).BeginInit();
            this.grpPatientRegistration.SuspendLayout();
            this.layoutPatientButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlNotificationsTop.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(1896, 150);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Admin Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSidebar.Controls.Add(this.pnlLogout);
            this.pnlSidebar.Controls.Add(this.btnAppointmentManagement);
            this.pnlSidebar.Controls.Add(this.btnPatientRegistration);
            this.pnlSidebar.Controls.Add(this.btnDoctorScheduling);
            this.pnlSidebar.Controls.Add(this.btnDoctorManagement);
            this.pnlSidebar.Controls.Add(this.btnUserManagement);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 150);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(358, 901);
            this.pnlSidebar.TabIndex = 2;
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Controls.Add(this.lblLogout);
            this.pnlLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlLogout.Location = new System.Drawing.Point(0, 779);
            this.pnlLogout.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.pnlLogout.Size = new System.Drawing.Size(358, 122);
            this.pnlLogout.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::ClinicManagement_proj.Properties.Resources.logout_icon;
            this.btnLogout.Location = new System.Drawing.Point(260, 24);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 74);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(24, 24);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(236, 74);
            this.lblLogout.TabIndex = 4;
            this.lblLogout.Text = "Welcome, [USER]";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAppointmentManagement
            // 
            this.btnAppointmentManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAppointmentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointmentManagement.FlatAppearance.BorderSize = 0;
            this.btnAppointmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentManagement.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentManagement.Image = global::ClinicManagement_proj.Properties.Resources.appointment_icon;
            this.btnAppointmentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointmentManagement.Location = new System.Drawing.Point(0, 480);
            this.btnAppointmentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointmentManagement.Name = "btnAppointmentManagement";
            this.btnAppointmentManagement.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnAppointmentManagement.Size = new System.Drawing.Size(358, 84);
            this.btnAppointmentManagement.TabIndex = 6;
            this.btnAppointmentManagement.Text = "    Appointments";
            this.btnAppointmentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointmentManagement.UseVisualStyleBackColor = false;
            this.btnAppointmentManagement.Click += new System.EventHandler(this.btnAppointmentManagement_Click);
            // 
            // btnPatientRegistration
            // 
            this.btnPatientRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPatientRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientRegistration.FlatAppearance.BorderSize = 0;
            this.btnPatientRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegistration.ForeColor = System.Drawing.Color.White;
            this.btnPatientRegistration.Image = global::ClinicManagement_proj.Properties.Resources.patient_icon;
            this.btnPatientRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientRegistration.Location = new System.Drawing.Point(0, 396);
            this.btnPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientRegistration.Name = "btnPatientRegistration";
            this.btnPatientRegistration.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnPatientRegistration.Size = new System.Drawing.Size(358, 84);
            this.btnPatientRegistration.TabIndex = 4;
            this.btnPatientRegistration.Text = "    Patient Registration";
            this.btnPatientRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientRegistration.UseVisualStyleBackColor = false;
            this.btnPatientRegistration.Click += new System.EventHandler(this.btnPatientRegistration_Click);
            // 
            // btnDoctorScheduling
            // 
            this.btnDoctorScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorScheduling.FlatAppearance.BorderSize = 0;
            this.btnDoctorScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorScheduling.ForeColor = System.Drawing.Color.White;
            this.btnDoctorScheduling.Image = global::ClinicManagement_proj.Properties.Resources.schedule_icon;
            this.btnDoctorScheduling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorScheduling.Location = new System.Drawing.Point(0, 312);
            this.btnDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorScheduling.Name = "btnDoctorScheduling";
            this.btnDoctorScheduling.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDoctorScheduling.Size = new System.Drawing.Size(358, 84);
            this.btnDoctorScheduling.TabIndex = 5;
            this.btnDoctorScheduling.Text = "    Doctor Scheduling";
            this.btnDoctorScheduling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorScheduling.UseVisualStyleBackColor = false;
            this.btnDoctorScheduling.Click += new System.EventHandler(this.btnDoctorScheduling_Click);
            // 
            // btnDoctorManagement
            // 
            this.btnDoctorManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDoctorManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorManagement.FlatAppearance.BorderSize = 0;
            this.btnDoctorManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorManagement.ForeColor = System.Drawing.Color.White;
            this.btnDoctorManagement.Image = global::ClinicManagement_proj.Properties.Resources.doctor_icon;
            this.btnDoctorManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorManagement.Location = new System.Drawing.Point(0, 228);
            this.btnDoctorManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorManagement.Name = "btnDoctorManagement";
            this.btnDoctorManagement.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDoctorManagement.Size = new System.Drawing.Size(358, 84);
            this.btnDoctorManagement.TabIndex = 3;
            this.btnDoctorManagement.Text = "    Doctor Management";
            this.btnDoctorManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorManagement.UseVisualStyleBackColor = false;
            this.btnDoctorManagement.Click += new System.EventHandler(this.btnDoctorManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Image = global::ClinicManagement_proj.Properties.Resources.users_icon;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 144);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(358, 84);
            this.btnUserManagement.TabIndex = 2;
            this.btnUserManagement.Text = "    User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::ClinicManagement_proj.Properties.Resources.reports_icon;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 60);
            this.btnReports.Margin = new System.Windows.Forms.Padding(1);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(358, 84);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "    Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(358, 60);
            this.pnlSidebarHeader.TabIndex = 0;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSidebarTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(358, 60);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "NAVIGATION";
            this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlMainContent.Controls.Add(this.pnlReports);
            this.pnlMainContent.Controls.Add(this.pnlDoctorManagement);
            this.pnlMainContent.Controls.Add(this.pnlUserManagement);
            this.pnlMainContent.Controls.Add(this.pnlDoctorScheduling);
            this.pnlMainContent.Controls.Add(this.pnlAppointmentManagement);
            this.pnlMainContent.Controls.Add(this.pnlPatientRegistration);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(358, 150);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.pnlMainContent.Size = new System.Drawing.Size(1538, 901);
            this.pnlMainContent.TabIndex = 3;
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.tabControlReports);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(24, 24);
            this.pnlReports.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(1490, 853);
            this.pnlReports.TabIndex = 1;
            this.pnlReports.Visible = false;
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabDoctorTodaySchedule);
            this.tabControlReports.Controls.Add(this.tabPatientRecords);
            this.tabControlReports.Controls.Add(this.tabUpcomingAppointments);
            this.tabControlReports.Controls.Add(this.tabPatientClinicalSummary);
            this.tabControlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlReports.Location = new System.Drawing.Point(0, 0);
            this.tabControlReports.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1490, 853);
            this.tabControlReports.TabIndex = 3;
            // 
            // tabDoctorTodaySchedule
            // 
            this.tabDoctorTodaySchedule.BackColor = System.Drawing.Color.White;
            this.tabDoctorTodaySchedule.Controls.Add(this.dgvDoctorTodaySchedule);
            this.tabDoctorTodaySchedule.Controls.Add(this.pnlDoctorTodayScheduleTop);
            this.tabDoctorTodaySchedule.Location = new System.Drawing.Point(4, 35);
            this.tabDoctorTodaySchedule.Margin = new System.Windows.Forms.Padding(2);
            this.tabDoctorTodaySchedule.Name = "tabDoctorTodaySchedule";
            this.tabDoctorTodaySchedule.Padding = new System.Windows.Forms.Padding(2);
            this.tabDoctorTodaySchedule.Size = new System.Drawing.Size(1482, 814);
            this.tabDoctorTodaySchedule.TabIndex = 2;
            this.tabDoctorTodaySchedule.Text = "Doctor\'s Today Schedule";
            // 
            // dgvDoctorTodaySchedule
            // 
            this.dgvDoctorTodaySchedule.AllowUserToAddRows = false;
            this.dgvDoctorTodaySchedule.AllowUserToDeleteRows = false;
            this.dgvDoctorTodaySchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoctorTodaySchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctorTodaySchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctorTodaySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorTodaySchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorTodaySchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDoctorTodaySchedule.Location = new System.Drawing.Point(2, 98);
            this.dgvDoctorTodaySchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoctorTodaySchedule.MultiSelect = false;
            this.dgvDoctorTodaySchedule.Name = "dgvDoctorTodaySchedule";
            this.dgvDoctorTodaySchedule.ReadOnly = true;
            this.dgvDoctorTodaySchedule.RowHeadersWidth = 51;
            this.dgvDoctorTodaySchedule.RowTemplate.Height = 30;
            this.dgvDoctorTodaySchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctorTodaySchedule.Size = new System.Drawing.Size(1478, 714);
            this.dgvDoctorTodaySchedule.TabIndex = 1;
            // 
            // pnlDoctorTodayScheduleTop
            // 
            this.pnlDoctorTodayScheduleTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlDoctorTodayScheduleTop.Controls.Add(this.cmbVwDoctorScheduleSelect);
            this.pnlDoctorTodayScheduleTop.Controls.Add(this.lblVwDoctorScheduleSelect);
            this.pnlDoctorTodayScheduleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDoctorTodayScheduleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlDoctorTodayScheduleTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorTodayScheduleTop.Name = "pnlDoctorTodayScheduleTop";
            this.pnlDoctorTodayScheduleTop.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.pnlDoctorTodayScheduleTop.Size = new System.Drawing.Size(1478, 96);
            this.pnlDoctorTodayScheduleTop.TabIndex = 0;
            // 
            // cmbVwDoctorScheduleSelect
            // 
            this.cmbVwDoctorScheduleSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVwDoctorScheduleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVwDoctorScheduleSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVwDoctorScheduleSelect.FormattingEnabled = true;
            this.cmbVwDoctorScheduleSelect.Location = new System.Drawing.Point(216, 26);
            this.cmbVwDoctorScheduleSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVwDoctorScheduleSelect.Name = "cmbVwDoctorScheduleSelect";
            this.cmbVwDoctorScheduleSelect.Size = new System.Drawing.Size(1235, 34);
            this.cmbVwDoctorScheduleSelect.TabIndex = 1;
            // 
            // lblVwDoctorScheduleSelect
            // 
            this.lblVwDoctorScheduleSelect.AutoSize = true;
            this.lblVwDoctorScheduleSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVwDoctorScheduleSelect.Location = new System.Drawing.Point(24, 30);
            this.lblVwDoctorScheduleSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVwDoctorScheduleSelect.Name = "lblVwDoctorScheduleSelect";
            this.lblVwDoctorScheduleSelect.Size = new System.Drawing.Size(163, 26);
            this.lblVwDoctorScheduleSelect.TabIndex = 0;
            this.lblVwDoctorScheduleSelect.Text = "Select Doctor:";
            // 
            // tabPatientRecords
            // 
            this.tabPatientRecords.BackColor = System.Drawing.Color.White;
            this.tabPatientRecords.Controls.Add(this.dgvPatientRecords);
            this.tabPatientRecords.Controls.Add(this.pnlPatientRecordsTop);
            this.tabPatientRecords.Location = new System.Drawing.Point(4, 35);
            this.tabPatientRecords.Margin = new System.Windows.Forms.Padding(2);
            this.tabPatientRecords.Name = "tabPatientRecords";
            this.tabPatientRecords.Padding = new System.Windows.Forms.Padding(2);
            this.tabPatientRecords.Size = new System.Drawing.Size(1482, 814);
            this.tabPatientRecords.TabIndex = 0;
            this.tabPatientRecords.Text = "Patient Records";
            // 
            // dgvPatientRecords
            // 
            this.dgvPatientRecords.AllowUserToAddRows = false;
            this.dgvPatientRecords.AllowUserToDeleteRows = false;
            this.dgvPatientRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatientRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPatientRecords.Location = new System.Drawing.Point(2, 98);
            this.dgvPatientRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPatientRecords.MultiSelect = false;
            this.dgvPatientRecords.Name = "dgvPatientRecords";
            this.dgvPatientRecords.ReadOnly = true;
            this.dgvPatientRecords.RowHeadersWidth = 51;
            this.dgvPatientRecords.RowTemplate.Height = 30;
            this.dgvPatientRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientRecords.Size = new System.Drawing.Size(1478, 714);
            this.dgvPatientRecords.TabIndex = 1;
            // 
            // pnlPatientRecordsTop
            // 
            this.pnlPatientRecordsTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlPatientRecordsTop.Controls.Add(this.cmbVwPatientSelect);
            this.pnlPatientRecordsTop.Controls.Add(this.lblVwPatientSelect);
            this.pnlPatientRecordsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatientRecordsTop.Location = new System.Drawing.Point(2, 2);
            this.pnlPatientRecordsTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPatientRecordsTop.Name = "pnlPatientRecordsTop";
            this.pnlPatientRecordsTop.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.pnlPatientRecordsTop.Size = new System.Drawing.Size(1478, 96);
            this.pnlPatientRecordsTop.TabIndex = 0;
            // 
            // cmbVwPatientSelect
            // 
            this.cmbVwPatientSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVwPatientSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVwPatientSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVwPatientSelect.FormattingEnabled = true;
            this.cmbVwPatientSelect.Location = new System.Drawing.Point(216, 26);
            this.cmbVwPatientSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVwPatientSelect.Name = "cmbVwPatientSelect";
            this.cmbVwPatientSelect.Size = new System.Drawing.Size(1235, 34);
            this.cmbVwPatientSelect.TabIndex = 1;
            // 
            // lblVwPatientSelect
            // 
            this.lblVwPatientSelect.AutoSize = true;
            this.lblVwPatientSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVwPatientSelect.Location = new System.Drawing.Point(24, 30);
            this.lblVwPatientSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVwPatientSelect.Name = "lblVwPatientSelect";
            this.lblVwPatientSelect.Size = new System.Drawing.Size(168, 26);
            this.lblVwPatientSelect.TabIndex = 0;
            this.lblVwPatientSelect.Text = "Select Patient:";
            // 
            // tabUpcomingAppointments
            // 
            this.tabUpcomingAppointments.BackColor = System.Drawing.Color.White;
            this.tabUpcomingAppointments.Controls.Add(this.dgvUpcomingAppointments);
            this.tabUpcomingAppointments.Controls.Add(this.pnlUpcomingApptTop);
            this.tabUpcomingAppointments.Location = new System.Drawing.Point(4, 35);
            this.tabUpcomingAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.tabUpcomingAppointments.Name = "tabUpcomingAppointments";
            this.tabUpcomingAppointments.Padding = new System.Windows.Forms.Padding(2);
            this.tabUpcomingAppointments.Size = new System.Drawing.Size(1482, 814);
            this.tabUpcomingAppointments.TabIndex = 1;
            this.tabUpcomingAppointments.Text = "Upcoming Appointments";
            // 
            // dgvUpcomingAppointments
            // 
            this.dgvUpcomingAppointments.AllowUserToAddRows = false;
            this.dgvUpcomingAppointments.AllowUserToDeleteRows = false;
            this.dgvUpcomingAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUpcomingAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpcomingAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpcomingAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpcomingAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUpcomingAppointments.Location = new System.Drawing.Point(2, 98);
            this.dgvUpcomingAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUpcomingAppointments.MultiSelect = false;
            this.dgvUpcomingAppointments.Name = "dgvUpcomingAppointments";
            this.dgvUpcomingAppointments.ReadOnly = true;
            this.dgvUpcomingAppointments.RowHeadersWidth = 51;
            this.dgvUpcomingAppointments.RowTemplate.Height = 30;
            this.dgvUpcomingAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpcomingAppointments.Size = new System.Drawing.Size(1478, 714);
            this.dgvUpcomingAppointments.TabIndex = 1;
            // 
            // pnlUpcomingApptTop
            // 
            this.pnlUpcomingApptTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlUpcomingApptTop.Controls.Add(this.cmbVwDoctorSelect);
            this.pnlUpcomingApptTop.Controls.Add(this.lblVwDoctorSelect);
            this.pnlUpcomingApptTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpcomingApptTop.Location = new System.Drawing.Point(2, 2);
            this.pnlUpcomingApptTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpcomingApptTop.Name = "pnlUpcomingApptTop";
            this.pnlUpcomingApptTop.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.pnlUpcomingApptTop.Size = new System.Drawing.Size(1478, 96);
            this.pnlUpcomingApptTop.TabIndex = 0;
            // 
            // cmbVwDoctorSelect
            // 
            this.cmbVwDoctorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVwDoctorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVwDoctorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVwDoctorSelect.FormattingEnabled = true;
            this.cmbVwDoctorSelect.Location = new System.Drawing.Point(216, 26);
            this.cmbVwDoctorSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVwDoctorSelect.Name = "cmbVwDoctorSelect";
            this.cmbVwDoctorSelect.Size = new System.Drawing.Size(1235, 34);
            this.cmbVwDoctorSelect.TabIndex = 1;
            // 
            // lblVwDoctorSelect
            // 
            this.lblVwDoctorSelect.AutoSize = true;
            this.lblVwDoctorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVwDoctorSelect.Location = new System.Drawing.Point(24, 30);
            this.lblVwDoctorSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVwDoctorSelect.Name = "lblVwDoctorSelect";
            this.lblVwDoctorSelect.Size = new System.Drawing.Size(163, 26);
            this.lblVwDoctorSelect.TabIndex = 0;
            this.lblVwDoctorSelect.Text = "Select Doctor:";
            // 
            // tabPatientClinicalSummary
            // 
            this.tabPatientClinicalSummary.BackColor = System.Drawing.Color.White;
            this.tabPatientClinicalSummary.Controls.Add(this.dgvPatientClinicalSummary);
            this.tabPatientClinicalSummary.Controls.Add(this.pnlPatientClinicalSummaryTop);
            this.tabPatientClinicalSummary.Location = new System.Drawing.Point(4, 35);
            this.tabPatientClinicalSummary.Margin = new System.Windows.Forms.Padding(2);
            this.tabPatientClinicalSummary.Name = "tabPatientClinicalSummary";
            this.tabPatientClinicalSummary.Padding = new System.Windows.Forms.Padding(2);
            this.tabPatientClinicalSummary.Size = new System.Drawing.Size(1482, 814);
            this.tabPatientClinicalSummary.TabIndex = 3;
            this.tabPatientClinicalSummary.Text = "Patient Clinical Summary";
            // 
            // dgvPatientClinicalSummary
            // 
            this.dgvPatientClinicalSummary.AllowUserToAddRows = false;
            this.dgvPatientClinicalSummary.AllowUserToDeleteRows = false;
            this.dgvPatientClinicalSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatientClinicalSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientClinicalSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientClinicalSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientClinicalSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientClinicalSummary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPatientClinicalSummary.Location = new System.Drawing.Point(2, 98);
            this.dgvPatientClinicalSummary.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPatientClinicalSummary.MultiSelect = false;
            this.dgvPatientClinicalSummary.Name = "dgvPatientClinicalSummary";
            this.dgvPatientClinicalSummary.ReadOnly = true;
            this.dgvPatientClinicalSummary.RowHeadersWidth = 51;
            this.dgvPatientClinicalSummary.RowTemplate.Height = 30;
            this.dgvPatientClinicalSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientClinicalSummary.Size = new System.Drawing.Size(1478, 714);
            this.dgvPatientClinicalSummary.TabIndex = 1;
            // 
            // pnlPatientClinicalSummaryTop
            // 
            this.pnlPatientClinicalSummaryTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlPatientClinicalSummaryTop.Controls.Add(this.cmbVwPatientSelectClinical);
            this.pnlPatientClinicalSummaryTop.Controls.Add(this.lblVwPatientSelectClinical);
            this.pnlPatientClinicalSummaryTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatientClinicalSummaryTop.Location = new System.Drawing.Point(2, 2);
            this.pnlPatientClinicalSummaryTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPatientClinicalSummaryTop.Name = "pnlPatientClinicalSummaryTop";
            this.pnlPatientClinicalSummaryTop.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.pnlPatientClinicalSummaryTop.Size = new System.Drawing.Size(1478, 96);
            this.pnlPatientClinicalSummaryTop.TabIndex = 0;
            // 
            // cmbVwPatientSelectClinical
            // 
            this.cmbVwPatientSelectClinical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVwPatientSelectClinical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVwPatientSelectClinical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVwPatientSelectClinical.FormattingEnabled = true;
            this.cmbVwPatientSelectClinical.Location = new System.Drawing.Point(216, 26);
            this.cmbVwPatientSelectClinical.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVwPatientSelectClinical.Name = "cmbVwPatientSelectClinical";
            this.cmbVwPatientSelectClinical.Size = new System.Drawing.Size(1235, 34);
            this.cmbVwPatientSelectClinical.TabIndex = 1;
            // 
            // lblVwPatientSelectClinical
            // 
            this.lblVwPatientSelectClinical.AutoSize = true;
            this.lblVwPatientSelectClinical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVwPatientSelectClinical.Location = new System.Drawing.Point(24, 30);
            this.lblVwPatientSelectClinical.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVwPatientSelectClinical.Name = "lblVwPatientSelectClinical";
            this.lblVwPatientSelectClinical.Size = new System.Drawing.Size(168, 26);
            this.lblVwPatientSelectClinical.TabIndex = 0;
            this.lblVwPatientSelectClinical.Text = "Select Patient:";
            // 
            // pnlDoctorManagement
            // 
            this.pnlDoctorManagement.Controls.Add(this.dgvDoctors);
            this.pnlDoctorManagement.Controls.Add(this.grpDoctorMgmt);
            this.pnlDoctorManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorManagement.Location = new System.Drawing.Point(24, 24);
            this.pnlDoctorManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorManagement.Name = "pnlDoctorManagement";
            this.pnlDoctorManagement.Size = new System.Drawing.Size(1490, 853);
            this.pnlDoctorManagement.TabIndex = 2;
            this.pnlDoctorManagement.Visible = false;
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDoctors.Location = new System.Drawing.Point(647, 0);
            this.dgvDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDoctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(843, 853);
            this.dgvDoctors.TabIndex = 7;
            // 
            // grpDoctorMgmt
            // 
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorId);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorId);
            this.grpDoctorMgmt.Controls.Add(this.lblNotice);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorLName);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorLName);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorFName);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorFName);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorLicense);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorLicense);
            this.grpDoctorMgmt.Controls.Add(this.lblSpecialization);
            this.grpDoctorMgmt.Controls.Add(this.cmbSpecialization);
            this.grpDoctorMgmt.Controls.Add(this.layoutDoctorActions);
            this.grpDoctorMgmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDoctorMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctorMgmt.Location = new System.Drawing.Point(0, 0);
            this.grpDoctorMgmt.Margin = new System.Windows.Forms.Padding(2);
            this.grpDoctorMgmt.Name = "grpDoctorMgmt";
            this.grpDoctorMgmt.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.grpDoctorMgmt.Size = new System.Drawing.Size(647, 853);
            this.grpDoctorMgmt.TabIndex = 6;
            this.grpDoctorMgmt.TabStop = false;
            this.grpDoctorMgmt.Text = "Create Doctor";
            // 
            // lblDoctorId
            // 
            this.lblDoctorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorId.Location = new System.Drawing.Point(29, 47);
            this.lblDoctorId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(587, 42);
            this.lblDoctorId.TabIndex = 13;
            this.lblDoctorId.Text = "Doctor Id";
            this.lblDoctorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorId.Location = new System.Drawing.Point(29, 102);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(585, 35);
            this.txtDoctorId.TabIndex = 16;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(35, 558);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(587, 61);
            this.lblNotice.TabIndex = 12;
            this.lblNotice.Text = "Please set the availability in the Doctor Scheduling tab and make sure there is a" +
    "n existing User for this Doctor";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorLName
            // 
            this.txtDoctorLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorLName.Location = new System.Drawing.Point(30, 299);
            this.txtDoctorLName.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtDoctorLName.Name = "txtDoctorLName";
            this.txtDoctorLName.Size = new System.Drawing.Size(585, 35);
            this.txtDoctorLName.TabIndex = 11;
            // 
            // lblDoctorLName
            // 
            this.lblDoctorLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorLName.Location = new System.Drawing.Point(30, 247);
            this.lblDoctorLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorLName.Name = "lblDoctorLName";
            this.lblDoctorLName.Size = new System.Drawing.Size(587, 42);
            this.lblDoctorLName.TabIndex = 6;
            this.lblDoctorLName.Text = "Last Name";
            this.lblDoctorLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorFName
            // 
            this.txtDoctorFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorFName.Location = new System.Drawing.Point(30, 203);
            this.txtDoctorFName.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtDoctorFName.Name = "txtDoctorFName";
            this.txtDoctorFName.Size = new System.Drawing.Size(585, 35);
            this.txtDoctorFName.TabIndex = 5;
            // 
            // lblDoctorFName
            // 
            this.lblDoctorFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorFName.Location = new System.Drawing.Point(30, 149);
            this.lblDoctorFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorFName.Name = "lblDoctorFName";
            this.lblDoctorFName.Size = new System.Drawing.Size(587, 42);
            this.lblDoctorFName.TabIndex = 4;
            this.lblDoctorFName.Text = "First Name";
            this.lblDoctorFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorLicense
            // 
            this.txtDoctorLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorLicense.Location = new System.Drawing.Point(30, 397);
            this.txtDoctorLicense.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtDoctorLicense.Name = "txtDoctorLicense";
            this.txtDoctorLicense.Size = new System.Drawing.Size(585, 35);
            this.txtDoctorLicense.TabIndex = 11;
            // 
            // lblDoctorLicense
            // 
            this.lblDoctorLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorLicense.Location = new System.Drawing.Point(30, 346);
            this.lblDoctorLicense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorLicense.Name = "lblDoctorLicense";
            this.lblDoctorLicense.Size = new System.Drawing.Size(587, 42);
            this.lblDoctorLicense.TabIndex = 6;
            this.lblDoctorLicense.Text = "License Number";
            this.lblDoctorLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(28, 444);
            this.lblSpecialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(587, 42);
            this.lblSpecialization.TabIndex = 8;
            this.lblSpecialization.Text = "Specialization";
            this.lblSpecialization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Location = new System.Drawing.Point(30, 496);
            this.cmbSpecialization.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(586, 37);
            this.cmbSpecialization.TabIndex = 9;
            // 
            // layoutDoctorActions
            // 
            this.layoutDoctorActions.ColumnCount = 4;
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.Controls.Add(this.btnDoctorCreate, 0, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorUpdate, 1, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorSearch, 2, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorDelete, 3, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorDisplay, 0, 1);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorCancel, 1, 1);
            this.layoutDoctorActions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutDoctorActions.Location = new System.Drawing.Point(29, 623);
            this.layoutDoctorActions.Margin = new System.Windows.Forms.Padding(2);
            this.layoutDoctorActions.Name = "layoutDoctorActions";
            this.layoutDoctorActions.RowCount = 2;
            this.layoutDoctorActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDoctorActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDoctorActions.Size = new System.Drawing.Size(586, 133);
            this.layoutDoctorActions.TabIndex = 15;
            // 
            // btnDoctorCreate
            // 
            this.btnDoctorCreate.AutoSize = true;
            this.btnDoctorCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDoctorCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorCreate.ForeColor = System.Drawing.Color.White;
            this.btnDoctorCreate.Location = new System.Drawing.Point(2, 2);
            this.btnDoctorCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorCreate.Name = "btnDoctorCreate";
            this.btnDoctorCreate.Size = new System.Drawing.Size(142, 62);
            this.btnDoctorCreate.TabIndex = 5;
            this.btnDoctorCreate.Text = "Create";
            this.btnDoctorCreate.UseVisualStyleBackColor = false;
            // 
            // btnDoctorUpdate
            // 
            this.btnDoctorUpdate.AutoSize = true;
            this.btnDoctorUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDoctorUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDoctorUpdate.Location = new System.Drawing.Point(148, 2);
            this.btnDoctorUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorUpdate.Name = "btnDoctorUpdate";
            this.btnDoctorUpdate.Size = new System.Drawing.Size(142, 62);
            this.btnDoctorUpdate.TabIndex = 11;
            this.btnDoctorUpdate.Text = "Update";
            this.btnDoctorUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDoctorSearch
            // 
            this.btnDoctorSearch.AutoSize = true;
            this.btnDoctorSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDoctorSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorSearch.ForeColor = System.Drawing.Color.White;
            this.btnDoctorSearch.Location = new System.Drawing.Point(294, 2);
            this.btnDoctorSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorSearch.Name = "btnDoctorSearch";
            this.btnDoctorSearch.Size = new System.Drawing.Size(142, 62);
            this.btnDoctorSearch.TabIndex = 4;
            this.btnDoctorSearch.Text = "Search";
            this.btnDoctorSearch.UseVisualStyleBackColor = false;
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.AutoSize = true;
            this.btnDoctorDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDoctorDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDelete.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDelete.Location = new System.Drawing.Point(440, 2);
            this.btnDoctorDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(144, 62);
            this.btnDoctorDelete.TabIndex = 7;
            this.btnDoctorDelete.Text = "Delete";
            this.btnDoctorDelete.UseVisualStyleBackColor = false;
            // 
            // btnDoctorDisplay
            // 
            this.btnDoctorDisplay.AutoSize = true;
            this.btnDoctorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDoctorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDisplay.Location = new System.Drawing.Point(2, 68);
            this.btnDoctorDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorDisplay.Name = "btnDoctorDisplay";
            this.btnDoctorDisplay.Size = new System.Drawing.Size(142, 63);
            this.btnDoctorDisplay.TabIndex = 10;
            this.btnDoctorDisplay.Text = "Display";
            this.btnDoctorDisplay.UseVisualStyleBackColor = false;
            // 
            // btnDoctorCancel
            // 
            this.btnDoctorCancel.AutoSize = true;
            this.btnDoctorCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnDoctorCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorCancel.ForeColor = System.Drawing.Color.White;
            this.btnDoctorCancel.Location = new System.Drawing.Point(148, 68);
            this.btnDoctorCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorCancel.Name = "btnDoctorCancel";
            this.btnDoctorCancel.Size = new System.Drawing.Size(142, 63);
            this.btnDoctorCancel.TabIndex = 9;
            this.btnDoctorCancel.Text = "Cancel";
            this.btnDoctorCancel.UseVisualStyleBackColor = false;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.dgvUsers);
            this.pnlUserManagement.Controls.Add(this.grpAdminForm);
            this.pnlUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserManagement.Location = new System.Drawing.Point(24, 24);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1490, 853);
            this.pnlUserManagement.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.Location = new System.Drawing.Point(762, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(728, 853);
            this.dgvUsers.TabIndex = 4;
            // 
            // grpAdminForm
            // 
            this.grpAdminForm.Controls.Add(this.txtUsrId);
            this.grpAdminForm.Controls.Add(this.lblUsrId);
            this.grpAdminForm.Controls.Add(this.pnlButtons);
            this.grpAdminForm.Controls.Add(this.pnlPassword);
            this.grpAdminForm.Controls.Add(this.cmbRoles);
            this.grpAdminForm.Controls.Add(this.lblRole);
            this.grpAdminForm.Controls.Add(this.lblPassword);
            this.grpAdminForm.Controls.Add(this.txtUsrUsername);
            this.grpAdminForm.Controls.Add(this.lblUsername);
            this.grpAdminForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdminForm.Location = new System.Drawing.Point(0, 0);
            this.grpAdminForm.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdminForm.Name = "grpAdminForm";
            this.grpAdminForm.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.grpAdminForm.Size = new System.Drawing.Size(762, 853);
            this.grpAdminForm.TabIndex = 5;
            this.grpAdminForm.TabStop = false;
            this.grpAdminForm.Text = "Create User";
            // 
            // txtUsrId
            // 
            this.txtUsrId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrId.Location = new System.Drawing.Point(24, 95);
            this.txtUsrId.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtUsrId.Name = "txtUsrId";
            this.txtUsrId.Size = new System.Drawing.Size(700, 35);
            this.txtUsrId.TabIndex = 13;
            // 
            // lblUsrId
            // 
            this.lblUsrId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrId.Location = new System.Drawing.Point(24, 46);
            this.lblUsrId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrId.Name = "lblUsrId";
            this.lblUsrId.Size = new System.Drawing.Size(702, 42);
            this.lblUsrId.TabIndex = 12;
            this.lblUsrId.Text = "User Id";
            this.lblUsrId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 4;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.Controls.Add(this.btnGenPassword, 2, 1);
            this.pnlButtons.Controls.Add(this.btnUsrCreate, 0, 0);
            this.pnlButtons.Controls.Add(this.btnUsrUpdate, 1, 0);
            this.pnlButtons.Controls.Add(this.btnUsrSearch, 2, 0);
            this.pnlButtons.Controls.Add(this.btnUsrCancel, 1, 1);
            this.pnlButtons.Controls.Add(this.btnUsrDisplay, 3, 0);
            this.pnlButtons.Controls.Add(this.btnUsrDelete, 0, 1);
            this.pnlButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnlButtons.Location = new System.Drawing.Point(24, 586);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Size = new System.Drawing.Size(702, 133);
            this.pnlButtons.TabIndex = 16;
            // 
            // btnGenPassword
            // 
            this.btnGenPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenPassword.AutoSize = true;
            this.btnGenPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlButtons.SetColumnSpan(this.btnGenPassword, 2);
            this.btnGenPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPassword.ForeColor = System.Drawing.Color.White;
            this.btnGenPassword.Location = new System.Drawing.Point(352, 68);
            this.btnGenPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenPassword.Name = "btnGenPassword";
            this.btnGenPassword.Size = new System.Drawing.Size(348, 63);
            this.btnGenPassword.TabIndex = 6;
            this.btnGenPassword.Text = "Generate Password";
            this.btnGenPassword.UseVisualStyleBackColor = false;
            // 
            // btnUsrCreate
            // 
            this.btnUsrCreate.AutoSize = true;
            this.btnUsrCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUsrCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrCreate.ForeColor = System.Drawing.Color.White;
            this.btnUsrCreate.Location = new System.Drawing.Point(2, 2);
            this.btnUsrCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrCreate.Name = "btnUsrCreate";
            this.btnUsrCreate.Size = new System.Drawing.Size(171, 62);
            this.btnUsrCreate.TabIndex = 5;
            this.btnUsrCreate.Text = "Create";
            this.btnUsrCreate.UseVisualStyleBackColor = false;
            // 
            // btnUsrUpdate
            // 
            this.btnUsrUpdate.AutoSize = true;
            this.btnUsrUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUsrUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUsrUpdate.Location = new System.Drawing.Point(177, 2);
            this.btnUsrUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrUpdate.Name = "btnUsrUpdate";
            this.btnUsrUpdate.Size = new System.Drawing.Size(171, 62);
            this.btnUsrUpdate.TabIndex = 11;
            this.btnUsrUpdate.Text = "Update";
            this.btnUsrUpdate.UseVisualStyleBackColor = false;
            // 
            // btnUsrSearch
            // 
            this.btnUsrSearch.AutoSize = true;
            this.btnUsrSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUsrSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrSearch.ForeColor = System.Drawing.Color.White;
            this.btnUsrSearch.Location = new System.Drawing.Point(352, 2);
            this.btnUsrSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrSearch.Name = "btnUsrSearch";
            this.btnUsrSearch.Size = new System.Drawing.Size(171, 62);
            this.btnUsrSearch.TabIndex = 4;
            this.btnUsrSearch.Text = "Search";
            this.btnUsrSearch.UseVisualStyleBackColor = false;
            // 
            // btnUsrCancel
            // 
            this.btnUsrCancel.AutoSize = true;
            this.btnUsrCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnUsrCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrCancel.ForeColor = System.Drawing.Color.White;
            this.btnUsrCancel.Location = new System.Drawing.Point(177, 68);
            this.btnUsrCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrCancel.Name = "btnUsrCancel";
            this.btnUsrCancel.Size = new System.Drawing.Size(171, 63);
            this.btnUsrCancel.TabIndex = 9;
            this.btnUsrCancel.Text = "Cancel";
            this.btnUsrCancel.UseVisualStyleBackColor = false;
            // 
            // btnUsrDisplay
            // 
            this.btnUsrDisplay.AutoSize = true;
            this.btnUsrDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUsrDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrDisplay.ForeColor = System.Drawing.Color.White;
            this.btnUsrDisplay.Location = new System.Drawing.Point(527, 2);
            this.btnUsrDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrDisplay.Name = "btnUsrDisplay";
            this.btnUsrDisplay.Size = new System.Drawing.Size(173, 62);
            this.btnUsrDisplay.TabIndex = 10;
            this.btnUsrDisplay.Text = "Display";
            this.btnUsrDisplay.UseVisualStyleBackColor = false;
            // 
            // btnUsrDelete
            // 
            this.btnUsrDelete.AutoSize = true;
            this.btnUsrDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUsrDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrDelete.ForeColor = System.Drawing.Color.White;
            this.btnUsrDelete.Location = new System.Drawing.Point(2, 68);
            this.btnUsrDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrDelete.Name = "btnUsrDelete";
            this.btnUsrDelete.Size = new System.Drawing.Size(171, 63);
            this.btnUsrDelete.TabIndex = 7;
            this.btnUsrDelete.Text = "Delete";
            this.btnUsrDelete.UseVisualStyleBackColor = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPassword.ColumnCount = 2;
            this.pnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.01681F));
            this.pnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.98319F));
            this.pnlPassword.Controls.Add(this.btnTogglePassword, 1, 0);
            this.pnlPassword.Controls.Add(this.txtUsrPassword, 0, 0);
            this.pnlPassword.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnlPassword.Location = new System.Drawing.Point(22, 302);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.RowCount = 1;
            this.pnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlPassword.Size = new System.Drawing.Size(706, 46);
            this.pnlPassword.TabIndex = 11;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTogglePassword.AutoSize = true;
            this.btnTogglePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.Location = new System.Drawing.Point(581, 2);
            this.btnTogglePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(123, 42);
            this.btnTogglePassword.TabIndex = 8;
            this.btnTogglePassword.Text = "Show";
            this.btnTogglePassword.UseVisualStyleBackColor = false;
            // 
            // txtUsrPassword
            // 
            this.txtUsrPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrPassword.BackColor = System.Drawing.Color.White;
            this.txtUsrPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrPassword.Location = new System.Drawing.Point(6, 2);
            this.txtUsrPassword.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtUsrPassword.Name = "txtUsrPassword";
            this.txtUsrPassword.Size = new System.Drawing.Size(571, 35);
            this.txtUsrPassword.TabIndex = 7;
            this.txtUsrPassword.UseSystemPasswordChar = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(25, 418);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(701, 37);
            this.cmbRoles.TabIndex = 9;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(25, 365);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(702, 42);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 258);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(702, 42);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsrUsername
            // 
            this.txtUsrUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrUsername.Location = new System.Drawing.Point(25, 199);
            this.txtUsrUsername.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtUsrUsername.Name = "txtUsrUsername";
            this.txtUsrUsername.Size = new System.Drawing.Size(700, 35);
            this.txtUsrUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(25, 151);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(702, 42);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDoctorScheduling
            // 
            this.pnlDoctorScheduling.Controls.Add(this.grpDoctorScheduling);
            this.pnlDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorScheduling.Location = new System.Drawing.Point(24, 24);
            this.pnlDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorScheduling.Name = "pnlDoctorScheduling";
            this.pnlDoctorScheduling.Size = new System.Drawing.Size(1490, 853);
            this.pnlDoctorScheduling.TabIndex = 4;
            this.pnlDoctorScheduling.Visible = false;
            // 
            // grpDoctorScheduling
            // 
            this.grpDoctorScheduling.Controls.Add(this.layoutSchedulingContent);
            this.grpDoctorScheduling.Controls.Add(this.layoutSchedulingHeader);
            this.grpDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDoctorScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctorScheduling.Location = new System.Drawing.Point(0, 0);
            this.grpDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.grpDoctorScheduling.Name = "grpDoctorScheduling";
            this.grpDoctorScheduling.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.grpDoctorScheduling.Size = new System.Drawing.Size(1490, 853);
            this.grpDoctorScheduling.TabIndex = 6;
            this.grpDoctorScheduling.TabStop = false;
            this.grpDoctorScheduling.Text = "Adjust a Doctor\'s Schedule";
            // 
            // layoutSchedulingContent
            // 
            this.layoutSchedulingContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutSchedulingContent.ColumnCount = 8;
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.Controls.Add(this.layoutHours, 0, 1);
            this.layoutSchedulingContent.Controls.Add(this.lblDay1, 1, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay2, 2, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay3, 3, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay4, 4, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay5, 5, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay6, 6, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay7, 7, 0);
            this.layoutSchedulingContent.Controls.Add(this.lbSunday, 1, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbMonday, 2, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbTuesday, 3, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbWednesday, 4, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbThursday, 5, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbFriday, 6, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbSaturday, 7, 1);
            this.layoutSchedulingContent.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutSchedulingContent.Location = new System.Drawing.Point(30, 157);
            this.layoutSchedulingContent.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingContent.Name = "layoutSchedulingContent";
            this.layoutSchedulingContent.RowCount = 2;
            this.layoutSchedulingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layoutSchedulingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingContent.Size = new System.Drawing.Size(1430, 665);
            this.layoutSchedulingContent.TabIndex = 10;
            // 
            // layoutHours
            // 
            this.layoutHours.ColumnCount = 1;
            this.layoutHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutHours.Controls.Add(this.lblHour12, 0, 23);
            this.layoutHours.Controls.Add(this.lblHour11, 0, 21);
            this.layoutHours.Controls.Add(this.lblHour10, 0, 19);
            this.layoutHours.Controls.Add(this.lblHour9, 0, 17);
            this.layoutHours.Controls.Add(this.lblHour8, 0, 15);
            this.layoutHours.Controls.Add(this.lblHour7, 0, 13);
            this.layoutHours.Controls.Add(this.lblHour6, 0, 11);
            this.layoutHours.Controls.Add(this.lblHour5, 0, 9);
            this.layoutHours.Controls.Add(this.lblHour4, 0, 7);
            this.layoutHours.Controls.Add(this.lblHour3, 0, 5);
            this.layoutHours.Controls.Add(this.lblHour2, 0, 3);
            this.layoutHours.Controls.Add(this.lblHour1, 0, 1);
            this.layoutHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutHours.Location = new System.Drawing.Point(2, 56);
            this.layoutHours.Margin = new System.Windows.Forms.Padding(2);
            this.layoutHours.Name = "layoutHours";
            this.layoutHours.RowCount = 24;
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.030001F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.030013F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.030013F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001301F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303598F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.030001F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.300277F));
            this.layoutHours.Size = new System.Drawing.Size(92, 607);
            this.layoutHours.TabIndex = 1;
            // 
            // lblHour12
            // 
            this.lblHour12.AutoSize = true;
            this.lblHour12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour12.Location = new System.Drawing.Point(2, 550);
            this.lblHour12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour12.Name = "lblHour12";
            this.lblHour12.Size = new System.Drawing.Size(88, 57);
            this.lblHour12.TabIndex = 11;
            this.lblHour12.Text = "22:00";
            this.lblHour12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour11
            // 
            this.lblHour11.AutoSize = true;
            this.lblHour11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour11.Location = new System.Drawing.Point(2, 500);
            this.lblHour11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour11.Name = "lblHour11";
            this.lblHour11.Size = new System.Drawing.Size(88, 50);
            this.lblHour11.TabIndex = 10;
            this.lblHour11.Text = "20:00";
            this.lblHour11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour10
            // 
            this.lblHour10.AutoSize = true;
            this.lblHour10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour10.Location = new System.Drawing.Point(2, 450);
            this.lblHour10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour10.Name = "lblHour10";
            this.lblHour10.Size = new System.Drawing.Size(88, 50);
            this.lblHour10.TabIndex = 9;
            this.lblHour10.Text = "18:00";
            this.lblHour10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour9
            // 
            this.lblHour9.AutoSize = true;
            this.lblHour9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour9.Location = new System.Drawing.Point(2, 400);
            this.lblHour9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour9.Name = "lblHour9";
            this.lblHour9.Size = new System.Drawing.Size(88, 50);
            this.lblHour9.TabIndex = 8;
            this.lblHour9.Text = "16:00";
            this.lblHour9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour8
            // 
            this.lblHour8.AutoSize = true;
            this.lblHour8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour8.Location = new System.Drawing.Point(2, 350);
            this.lblHour8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour8.Name = "lblHour8";
            this.lblHour8.Size = new System.Drawing.Size(88, 50);
            this.lblHour8.TabIndex = 7;
            this.lblHour8.Text = "14:00";
            this.lblHour8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour7
            // 
            this.lblHour7.AutoSize = true;
            this.lblHour7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour7.Location = new System.Drawing.Point(2, 300);
            this.lblHour7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour7.Name = "lblHour7";
            this.lblHour7.Size = new System.Drawing.Size(88, 50);
            this.lblHour7.TabIndex = 6;
            this.lblHour7.Text = "12:00";
            this.lblHour7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour6
            // 
            this.lblHour6.AutoSize = true;
            this.lblHour6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour6.Location = new System.Drawing.Point(2, 250);
            this.lblHour6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour6.Name = "lblHour6";
            this.lblHour6.Size = new System.Drawing.Size(88, 50);
            this.lblHour6.TabIndex = 5;
            this.lblHour6.Text = "10:00";
            this.lblHour6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour5
            // 
            this.lblHour5.AutoSize = true;
            this.lblHour5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour5.Location = new System.Drawing.Point(2, 200);
            this.lblHour5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour5.Name = "lblHour5";
            this.lblHour5.Size = new System.Drawing.Size(88, 50);
            this.lblHour5.TabIndex = 4;
            this.lblHour5.Text = "08:00";
            this.lblHour5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour4
            // 
            this.lblHour4.AutoSize = true;
            this.lblHour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour4.Location = new System.Drawing.Point(2, 150);
            this.lblHour4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour4.Name = "lblHour4";
            this.lblHour4.Size = new System.Drawing.Size(88, 50);
            this.lblHour4.TabIndex = 3;
            this.lblHour4.Text = "06:00";
            this.lblHour4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour3
            // 
            this.lblHour3.AutoSize = true;
            this.lblHour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour3.Location = new System.Drawing.Point(2, 100);
            this.lblHour3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour3.Name = "lblHour3";
            this.lblHour3.Size = new System.Drawing.Size(88, 50);
            this.lblHour3.TabIndex = 2;
            this.lblHour3.Text = "04:00";
            this.lblHour3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour2
            // 
            this.lblHour2.AutoSize = true;
            this.lblHour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour2.Location = new System.Drawing.Point(2, 50);
            this.lblHour2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour2.Name = "lblHour2";
            this.lblHour2.Size = new System.Drawing.Size(88, 50);
            this.lblHour2.TabIndex = 1;
            this.lblHour2.Text = "02:00";
            this.lblHour2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour1
            // 
            this.lblHour1.AutoSize = true;
            this.lblHour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour1.Location = new System.Drawing.Point(2, 0);
            this.lblHour1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour1.Name = "lblHour1";
            this.lblHour1.Size = new System.Drawing.Size(88, 50);
            this.lblHour1.TabIndex = 0;
            this.lblHour1.Text = "00:00";
            this.lblHour1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay1.Location = new System.Drawing.Point(98, 0);
            this.lblDay1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(186, 54);
            this.lblDay1.TabIndex = 2;
            this.lblDay1.Text = "Sunday";
            this.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay2.Location = new System.Drawing.Point(288, 0);
            this.lblDay2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(186, 54);
            this.lblDay2.TabIndex = 15;
            this.lblDay2.Text = "Monday";
            this.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay3.Location = new System.Drawing.Point(478, 0);
            this.lblDay3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(186, 54);
            this.lblDay3.TabIndex = 16;
            this.lblDay3.Text = "Tuesday";
            this.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay4.Location = new System.Drawing.Point(668, 0);
            this.lblDay4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(186, 54);
            this.lblDay4.TabIndex = 17;
            this.lblDay4.Text = "Wednesday";
            this.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay5.Location = new System.Drawing.Point(858, 0);
            this.lblDay5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(186, 54);
            this.lblDay5.TabIndex = 16;
            this.lblDay5.Text = "Thursday";
            this.lblDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay6.Location = new System.Drawing.Point(1048, 0);
            this.lblDay6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(186, 54);
            this.lblDay6.TabIndex = 16;
            this.lblDay6.Text = "Friday";
            this.lblDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay7.Location = new System.Drawing.Point(1238, 0);
            this.lblDay7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(190, 54);
            this.lblDay7.TabIndex = 16;
            this.lblDay7.Text = "Saturday";
            this.lblDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSunday
            // 
            this.lbSunday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSunday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSunday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunday.ItemHeight = 25;
            this.lbSunday.Location = new System.Drawing.Point(98, 56);
            this.lbSunday.Margin = new System.Windows.Forms.Padding(2);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSunday.Size = new System.Drawing.Size(186, 600);
            this.lbSunday.TabIndex = 18;
            // 
            // lbMonday
            // 
            this.lbMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMonday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonday.ItemHeight = 25;
            this.lbMonday.Location = new System.Drawing.Point(288, 56);
            this.lbMonday.Margin = new System.Windows.Forms.Padding(2);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMonday.Size = new System.Drawing.Size(186, 600);
            this.lbMonday.TabIndex = 19;
            // 
            // lbTuesday
            // 
            this.lbTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTuesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuesday.ItemHeight = 25;
            this.lbTuesday.Location = new System.Drawing.Point(478, 56);
            this.lbTuesday.Margin = new System.Windows.Forms.Padding(2);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTuesday.Size = new System.Drawing.Size(186, 600);
            this.lbTuesday.TabIndex = 19;
            // 
            // lbWednesday
            // 
            this.lbWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWednesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWednesday.ItemHeight = 25;
            this.lbWednesday.Location = new System.Drawing.Point(668, 56);
            this.lbWednesday.Margin = new System.Windows.Forms.Padding(2);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbWednesday.Size = new System.Drawing.Size(186, 600);
            this.lbWednesday.TabIndex = 19;
            // 
            // lbThursday
            // 
            this.lbThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbThursday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThursday.ItemHeight = 25;
            this.lbThursday.Location = new System.Drawing.Point(858, 56);
            this.lbThursday.Margin = new System.Windows.Forms.Padding(2);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbThursday.Size = new System.Drawing.Size(186, 600);
            this.lbThursday.TabIndex = 19;
            // 
            // lbFriday
            // 
            this.lbFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFriday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriday.ItemHeight = 25;
            this.lbFriday.Location = new System.Drawing.Point(1048, 56);
            this.lbFriday.Margin = new System.Windows.Forms.Padding(2);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFriday.Size = new System.Drawing.Size(186, 600);
            this.lbFriday.TabIndex = 20;
            // 
            // lbSaturday
            // 
            this.lbSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSaturday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturday.ItemHeight = 25;
            this.lbSaturday.Location = new System.Drawing.Point(1238, 56);
            this.lbSaturday.Margin = new System.Windows.Forms.Padding(2);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSaturday.Size = new System.Drawing.Size(190, 600);
            this.lbSaturday.TabIndex = 19;
            // 
            // layoutSchedulingHeader
            // 
            this.layoutSchedulingHeader.ColumnCount = 2;
            this.layoutSchedulingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutSchedulingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutSchedulingHeader.Controls.Add(this.pnlDoctorPicker, 0, 0);
            this.layoutSchedulingHeader.Controls.Add(this.layoutSchedulingActions, 1, 0);
            this.layoutSchedulingHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutSchedulingHeader.Location = new System.Drawing.Point(30, 58);
            this.layoutSchedulingHeader.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingHeader.Name = "layoutSchedulingHeader";
            this.layoutSchedulingHeader.RowCount = 1;
            this.layoutSchedulingHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingHeader.Size = new System.Drawing.Size(1430, 94);
            this.layoutSchedulingHeader.TabIndex = 17;
            // 
            // pnlDoctorPicker
            // 
            this.pnlDoctorPicker.Controls.Add(this.cmbDoctorSelect);
            this.pnlDoctorPicker.Controls.Add(this.lblDoctorSelect);
            this.pnlDoctorPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorPicker.Location = new System.Drawing.Point(2, 2);
            this.pnlDoctorPicker.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorPicker.Name = "pnlDoctorPicker";
            this.pnlDoctorPicker.Size = new System.Drawing.Size(854, 90);
            this.pnlDoctorPicker.TabIndex = 0;
            // 
            // cmbDoctorSelect
            // 
            this.cmbDoctorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDoctorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorSelect.FormattingEnabled = true;
            this.cmbDoctorSelect.Location = new System.Drawing.Point(18, 41);
            this.cmbDoctorSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoctorSelect.Name = "cmbDoctorSelect";
            this.cmbDoctorSelect.Size = new System.Drawing.Size(834, 37);
            this.cmbDoctorSelect.TabIndex = 14;
            // 
            // lblDoctorSelect
            // 
            this.lblDoctorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSelect.Location = new System.Drawing.Point(13, 0);
            this.lblDoctorSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorSelect.Name = "lblDoctorSelect";
            this.lblDoctorSelect.Size = new System.Drawing.Size(288, 38);
            this.lblDoctorSelect.TabIndex = 13;
            this.lblDoctorSelect.Text = "Doctor";
            this.lblDoctorSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutSchedulingActions
            // 
            this.layoutSchedulingActions.ColumnCount = 2;
            this.layoutSchedulingActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutSchedulingActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutSchedulingActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutSchedulingActions.Controls.Add(this.btnScheduleRevert, 1, 0);
            this.layoutSchedulingActions.Controls.Add(this.btnScheduleSave, 0, 0);
            this.layoutSchedulingActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSchedulingActions.Location = new System.Drawing.Point(860, 2);
            this.layoutSchedulingActions.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingActions.Name = "layoutSchedulingActions";
            this.layoutSchedulingActions.Padding = new System.Windows.Forms.Padding(12, 37, 12, 0);
            this.layoutSchedulingActions.RowCount = 1;
            this.layoutSchedulingActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingActions.Size = new System.Drawing.Size(568, 90);
            this.layoutSchedulingActions.TabIndex = 2;
            // 
            // btnScheduleRevert
            // 
            this.btnScheduleRevert.AutoSize = true;
            this.btnScheduleRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnScheduleRevert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScheduleRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleRevert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleRevert.ForeColor = System.Drawing.Color.White;
            this.btnScheduleRevert.Location = new System.Drawing.Point(286, 39);
            this.btnScheduleRevert.Margin = new System.Windows.Forms.Padding(2);
            this.btnScheduleRevert.Name = "btnScheduleRevert";
            this.btnScheduleRevert.Size = new System.Drawing.Size(268, 49);
            this.btnScheduleRevert.TabIndex = 7;
            this.btnScheduleRevert.Text = "Revert";
            this.btnScheduleRevert.UseVisualStyleBackColor = false;
            // 
            // btnScheduleSave
            // 
            this.btnScheduleSave.AutoSize = true;
            this.btnScheduleSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnScheduleSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScheduleSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleSave.ForeColor = System.Drawing.Color.White;
            this.btnScheduleSave.Location = new System.Drawing.Point(14, 39);
            this.btnScheduleSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnScheduleSave.Name = "btnScheduleSave";
            this.btnScheduleSave.Size = new System.Drawing.Size(268, 49);
            this.btnScheduleSave.TabIndex = 6;
            this.btnScheduleSave.Text = "Save";
            this.btnScheduleSave.UseVisualStyleBackColor = false;
            // 
            // pnlAppointmentManagement
            // 
            this.pnlAppointmentManagement.Controls.Add(this.dgvAppointments);
            this.pnlAppointmentManagement.Controls.Add(this.grpApptMgmt);
            this.pnlAppointmentManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppointmentManagement.Location = new System.Drawing.Point(24, 24);
            this.pnlAppointmentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAppointmentManagement.Name = "pnlAppointmentManagement";
            this.pnlAppointmentManagement.Size = new System.Drawing.Size(1490, 853);
            this.pnlAppointmentManagement.TabIndex = 6;
            this.pnlAppointmentManagement.Visible = false;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAppointments.Location = new System.Drawing.Point(732, 0);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(758, 853);
            this.dgvAppointments.TabIndex = 8;
            // 
            // grpApptMgmt
            // 
            this.grpApptMgmt.Controls.Add(this.layoutApptButtons);
            this.grpApptMgmt.Controls.Add(this.cmbApptDoctor);
            this.grpApptMgmt.Controls.Add(this.lblApptPatient);
            this.grpApptMgmt.Controls.Add(this.cmbApptPatient);
            this.grpApptMgmt.Controls.Add(this.lblApptDate);
            this.grpApptMgmt.Controls.Add(this.dtpApptDate);
            this.grpApptMgmt.Controls.Add(this.lblApptTimeSlot);
            this.grpApptMgmt.Controls.Add(this.cmbApptTimeSlots);
            this.grpApptMgmt.Controls.Add(this.lblApptNotes);
            this.grpApptMgmt.Controls.Add(this.txtApptNotes);
            this.grpApptMgmt.Controls.Add(this.lblApptStatus);
            this.grpApptMgmt.Controls.Add(this.cmbApptStatus);
            this.grpApptMgmt.Controls.Add(this.txtApptId);
            this.grpApptMgmt.Controls.Add(this.lblApptDoctor);
            this.grpApptMgmt.Controls.Add(this.lblApptId);
            this.grpApptMgmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpApptMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApptMgmt.Location = new System.Drawing.Point(0, 0);
            this.grpApptMgmt.Margin = new System.Windows.Forms.Padding(2);
            this.grpApptMgmt.Name = "grpApptMgmt";
            this.grpApptMgmt.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.grpApptMgmt.Size = new System.Drawing.Size(732, 853);
            this.grpApptMgmt.TabIndex = 7;
            this.grpApptMgmt.TabStop = false;
            this.grpApptMgmt.Text = "Appointment Management";
            // 
            // layoutApptButtons
            // 
            this.layoutApptButtons.ColumnCount = 4;
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.layoutApptButtons.Controls.Add(this.btnApptCreate, 0, 0);
            this.layoutApptButtons.Controls.Add(this.btnApptUpdate, 1, 0);
            this.layoutApptButtons.Controls.Add(this.btnApptSearch, 2, 0);
            this.layoutApptButtons.Controls.Add(this.btnApptDisplay, 0, 1);
            this.layoutApptButtons.Controls.Add(this.btnApptCancel, 3, 0);
            this.layoutApptButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutApptButtons.Location = new System.Drawing.Point(34, 900);
            this.layoutApptButtons.Margin = new System.Windows.Forms.Padding(2);
            this.layoutApptButtons.Name = "layoutApptButtons";
            this.layoutApptButtons.RowCount = 2;
            this.layoutApptButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutApptButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutApptButtons.Size = new System.Drawing.Size(672, 139);
            this.layoutApptButtons.TabIndex = 10;
            // 
            // btnApptCreate
            // 
            this.btnApptCreate.AutoSize = true;
            this.btnApptCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnApptCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptCreate.ForeColor = System.Drawing.Color.White;
            this.btnApptCreate.Location = new System.Drawing.Point(2, 2);
            this.btnApptCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptCreate.Name = "btnApptCreate";
            this.btnApptCreate.Size = new System.Drawing.Size(164, 65);
            this.btnApptCreate.TabIndex = 5;
            this.btnApptCreate.Text = "Create";
            this.btnApptCreate.UseVisualStyleBackColor = false;
            // 
            // btnApptUpdate
            // 
            this.btnApptUpdate.AutoSize = true;
            this.btnApptUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnApptUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptUpdate.ForeColor = System.Drawing.Color.White;
            this.btnApptUpdate.Location = new System.Drawing.Point(170, 2);
            this.btnApptUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptUpdate.Name = "btnApptUpdate";
            this.btnApptUpdate.Size = new System.Drawing.Size(164, 65);
            this.btnApptUpdate.TabIndex = 11;
            this.btnApptUpdate.Text = "Update";
            this.btnApptUpdate.UseVisualStyleBackColor = false;
            // 
            // btnApptSearch
            // 
            this.btnApptSearch.AutoSize = true;
            this.btnApptSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApptSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptSearch.ForeColor = System.Drawing.Color.White;
            this.btnApptSearch.Location = new System.Drawing.Point(338, 2);
            this.btnApptSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptSearch.Name = "btnApptSearch";
            this.btnApptSearch.Size = new System.Drawing.Size(164, 65);
            this.btnApptSearch.TabIndex = 4;
            this.btnApptSearch.Text = "Search";
            this.btnApptSearch.UseVisualStyleBackColor = false;
            // 
            // btnApptDisplay
            // 
            this.btnApptDisplay.AutoSize = true;
            this.btnApptDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnApptDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptDisplay.ForeColor = System.Drawing.Color.White;
            this.btnApptDisplay.Location = new System.Drawing.Point(2, 71);
            this.btnApptDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptDisplay.Name = "btnApptDisplay";
            this.btnApptDisplay.Size = new System.Drawing.Size(164, 66);
            this.btnApptDisplay.TabIndex = 10;
            this.btnApptDisplay.Text = "Display";
            this.btnApptDisplay.UseVisualStyleBackColor = false;
            // 
            // btnApptCancel
            // 
            this.btnApptCancel.AutoSize = true;
            this.btnApptCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnApptCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptCancel.ForeColor = System.Drawing.Color.White;
            this.btnApptCancel.Location = new System.Drawing.Point(506, 2);
            this.btnApptCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptCancel.Name = "btnApptCancel";
            this.btnApptCancel.Size = new System.Drawing.Size(164, 65);
            this.btnApptCancel.TabIndex = 9;
            this.btnApptCancel.Text = "Cancel";
            this.btnApptCancel.UseVisualStyleBackColor = false;
            // 
            // cmbApptDoctor
            // 
            this.cmbApptDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApptDoctor.Location = new System.Drawing.Point(30, 194);
            this.cmbApptDoctor.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.cmbApptDoctor.Name = "cmbApptDoctor";
            this.cmbApptDoctor.Size = new System.Drawing.Size(671, 37);
            this.cmbApptDoctor.TabIndex = 13;
            // 
            // lblApptPatient
            // 
            this.lblApptPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptPatient.Location = new System.Drawing.Point(30, 250);
            this.lblApptPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptPatient.Name = "lblApptPatient";
            this.lblApptPatient.Size = new System.Drawing.Size(672, 42);
            this.lblApptPatient.TabIndex = 14;
            this.lblApptPatient.Text = "Patient";
            this.lblApptPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbApptPatient
            // 
            this.cmbApptPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApptPatient.Location = new System.Drawing.Point(30, 298);
            this.cmbApptPatient.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.cmbApptPatient.Name = "cmbApptPatient";
            this.cmbApptPatient.Size = new System.Drawing.Size(671, 37);
            this.cmbApptPatient.TabIndex = 15;
            // 
            // lblApptDate
            // 
            this.lblApptDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptDate.Location = new System.Drawing.Point(30, 353);
            this.lblApptDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(672, 42);
            this.lblApptDate.TabIndex = 16;
            this.lblApptDate.Text = "Appointment Date";
            this.lblApptDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpApptDate
            // 
            this.dtpApptDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpApptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpApptDate.Location = new System.Drawing.Point(30, 401);
            this.dtpApptDate.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.dtpApptDate.Name = "dtpApptDate";
            this.dtpApptDate.Size = new System.Drawing.Size(671, 35);
            this.dtpApptDate.TabIndex = 17;
            // 
            // lblApptTimeSlot
            // 
            this.lblApptTimeSlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptTimeSlot.Location = new System.Drawing.Point(30, 456);
            this.lblApptTimeSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptTimeSlot.Name = "lblApptTimeSlot";
            this.lblApptTimeSlot.Size = new System.Drawing.Size(672, 42);
            this.lblApptTimeSlot.TabIndex = 18;
            this.lblApptTimeSlot.Text = "Time Slot";
            this.lblApptTimeSlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbApptTimeSlots
            // 
            this.cmbApptTimeSlots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptTimeSlots.Location = new System.Drawing.Point(30, 504);
            this.cmbApptTimeSlots.Margin = new System.Windows.Forms.Padding(2);
            this.cmbApptTimeSlots.Name = "cmbApptTimeSlots";
            this.cmbApptTimeSlots.Size = new System.Drawing.Size(671, 37);
            this.cmbApptTimeSlots.TabIndex = 19;
            // 
            // lblApptNotes
            // 
            this.lblApptNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptNotes.Location = new System.Drawing.Point(34, 689);
            this.lblApptNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptNotes.Name = "lblApptNotes";
            this.lblApptNotes.Size = new System.Drawing.Size(348, 42);
            this.lblApptNotes.TabIndex = 20;
            this.lblApptNotes.Text = "Notes";
            this.lblApptNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApptNotes
            // 
            this.txtApptNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApptNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApptNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptNotes.Location = new System.Drawing.Point(34, 742);
            this.txtApptNotes.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtApptNotes.Multiline = true;
            this.txtApptNotes.Name = "txtApptNotes";
            this.txtApptNotes.Size = new System.Drawing.Size(672, 151);
            this.txtApptNotes.TabIndex = 21;
            // 
            // lblApptStatus
            // 
            this.lblApptStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptStatus.Location = new System.Drawing.Point(30, 588);
            this.lblApptStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptStatus.Name = "lblApptStatus";
            this.lblApptStatus.Size = new System.Drawing.Size(294, 42);
            this.lblApptStatus.TabIndex = 22;
            this.lblApptStatus.Text = "Status";
            this.lblApptStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbApptStatus
            // 
            this.cmbApptStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApptStatus.FormattingEnabled = true;
            this.cmbApptStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Cancelled",
            "No Show"});
            this.cmbApptStatus.Location = new System.Drawing.Point(30, 630);
            this.cmbApptStatus.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.cmbApptStatus.Name = "cmbApptStatus";
            this.cmbApptStatus.Size = new System.Drawing.Size(671, 37);
            this.cmbApptStatus.TabIndex = 23;
            // 
            // txtApptId
            // 
            this.txtApptId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApptId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptId.Location = new System.Drawing.Point(30, 91);
            this.txtApptId.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtApptId.Name = "txtApptId";
            this.txtApptId.Size = new System.Drawing.Size(672, 35);
            this.txtApptId.TabIndex = 25;
            // 
            // lblApptDoctor
            // 
            this.lblApptDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptDoctor.Location = new System.Drawing.Point(30, 145);
            this.lblApptDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptDoctor.Name = "lblApptDoctor";
            this.lblApptDoctor.Size = new System.Drawing.Size(672, 42);
            this.lblApptDoctor.TabIndex = 12;
            this.lblApptDoctor.Text = "Doctor";
            this.lblApptDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApptId
            // 
            this.lblApptId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptId.Location = new System.Drawing.Point(30, 36);
            this.lblApptId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptId.Name = "lblApptId";
            this.lblApptId.Size = new System.Drawing.Size(672, 42);
            this.lblApptId.TabIndex = 24;
            this.lblApptId.Text = "Appointment ID";
            this.lblApptId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.Controls.Add(this.dgvRegPatients);
            this.pnlPatientRegistration.Controls.Add(this.grpPatientRegistration);
            this.pnlPatientRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientRegistration.Location = new System.Drawing.Point(24, 24);
            this.pnlPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(1490, 853);
            this.pnlPatientRegistration.TabIndex = 3;
            this.pnlPatientRegistration.Visible = false;
            // 
            // dgvRegPatients
            // 
            this.dgvRegPatients.AllowUserToAddRows = false;
            this.dgvRegPatients.AllowUserToDeleteRows = false;
            this.dgvRegPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegPatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRegPatients.Location = new System.Drawing.Point(732, 0);
            this.dgvRegPatients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegPatients.MultiSelect = false;
            this.dgvRegPatients.Name = "dgvRegPatients";
            this.dgvRegPatients.ReadOnly = true;
            this.dgvRegPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRegPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRegPatients.RowTemplate.Height = 24;
            this.dgvRegPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegPatients.Size = new System.Drawing.Size(758, 853);
            this.dgvRegPatients.TabIndex = 7;
            // 
            // grpPatientRegistration
            // 
            this.grpPatientRegistration.Controls.Add(this.layoutPatientButtons);
            this.grpPatientRegistration.Controls.Add(this.txtPPhone);
            this.grpPatientRegistration.Controls.Add(this.lblPPhone);
            this.grpPatientRegistration.Controls.Add(this.dtpDoB);
            this.grpPatientRegistration.Controls.Add(this.lblDoB);
            this.grpPatientRegistration.Controls.Add(this.txtPatientId);
            this.grpPatientRegistration.Controls.Add(this.lblPatientId);
            this.grpPatientRegistration.Controls.Add(this.txtMedicalNumber);
            this.grpPatientRegistration.Controls.Add(this.lblMedicalNumber);
            this.grpPatientRegistration.Controls.Add(this.txtPLName);
            this.grpPatientRegistration.Controls.Add(this.lblPLName);
            this.grpPatientRegistration.Controls.Add(this.txtPFName);
            this.grpPatientRegistration.Controls.Add(this.lblPFName);
            this.grpPatientRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPatientRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientRegistration.Location = new System.Drawing.Point(0, 0);
            this.grpPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatientRegistration.Name = "grpPatientRegistration";
            this.grpPatientRegistration.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.grpPatientRegistration.Size = new System.Drawing.Size(732, 853);
            this.grpPatientRegistration.TabIndex = 6;
            this.grpPatientRegistration.TabStop = false;
            this.grpPatientRegistration.Text = "Register Patient";
            // 
            // layoutPatientButtons
            // 
            this.layoutPatientButtons.ColumnCount = 4;
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.Controls.Add(this.btnPCreate, 0, 0);
            this.layoutPatientButtons.Controls.Add(this.btnPUpdate, 1, 0);
            this.layoutPatientButtons.Controls.Add(this.btnPSearch, 2, 0);
            this.layoutPatientButtons.Controls.Add(this.btnPDisplay, 0, 1);
            this.layoutPatientButtons.Controls.Add(this.btnPCancel, 3, 0);
            this.layoutPatientButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutPatientButtons.Location = new System.Drawing.Point(30, 599);
            this.layoutPatientButtons.Margin = new System.Windows.Forms.Padding(2);
            this.layoutPatientButtons.Name = "layoutPatientButtons";
            this.layoutPatientButtons.RowCount = 2;
            this.layoutPatientButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPatientButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPatientButtons.Size = new System.Drawing.Size(672, 139);
            this.layoutPatientButtons.TabIndex = 10;
            // 
            // btnPCreate
            // 
            this.btnPCreate.AutoSize = true;
            this.btnPCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCreate.ForeColor = System.Drawing.Color.White;
            this.btnPCreate.Location = new System.Drawing.Point(2, 2);
            this.btnPCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCreate.Name = "btnPCreate";
            this.btnPCreate.Size = new System.Drawing.Size(164, 65);
            this.btnPCreate.TabIndex = 5;
            this.btnPCreate.Text = "Create";
            this.btnPCreate.UseVisualStyleBackColor = false;
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.AutoSize = true;
            this.btnPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPUpdate.Location = new System.Drawing.Point(170, 2);
            this.btnPUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(164, 65);
            this.btnPUpdate.TabIndex = 11;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPSearch
            // 
            this.btnPSearch.AutoSize = true;
            this.btnPSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSearch.ForeColor = System.Drawing.Color.White;
            this.btnPSearch.Location = new System.Drawing.Point(338, 2);
            this.btnPSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(164, 65);
            this.btnPSearch.TabIndex = 4;
            this.btnPSearch.Text = "Search";
            this.btnPSearch.UseVisualStyleBackColor = false;
            // 
            // btnPDisplay
            // 
            this.btnPDisplay.AutoSize = true;
            this.btnPDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDisplay.ForeColor = System.Drawing.Color.White;
            this.btnPDisplay.Location = new System.Drawing.Point(2, 71);
            this.btnPDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDisplay.Name = "btnPDisplay";
            this.btnPDisplay.Size = new System.Drawing.Size(164, 66);
            this.btnPDisplay.TabIndex = 10;
            this.btnPDisplay.Text = "Display";
            this.btnPDisplay.UseVisualStyleBackColor = false;
            // 
            // btnPCancel
            // 
            this.btnPCancel.AutoSize = true;
            this.btnPCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnPCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCancel.ForeColor = System.Drawing.Color.White;
            this.btnPCancel.Location = new System.Drawing.Point(506, 2);
            this.btnPCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCancel.Name = "btnPCancel";
            this.btnPCancel.Size = new System.Drawing.Size(164, 65);
            this.btnPCancel.TabIndex = 9;
            this.btnPCancel.Text = "Cancel";
            this.btnPCancel.UseVisualStyleBackColor = false;
            // 
            // txtPPhone
            // 
            this.txtPPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPhone.Location = new System.Drawing.Point(29, 506);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.Size = new System.Drawing.Size(672, 35);
            this.txtPPhone.TabIndex = 5;
            // 
            // lblPPhone
            // 
            this.lblPPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPhone.Location = new System.Drawing.Point(29, 458);
            this.lblPPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPPhone.Name = "lblPPhone";
            this.lblPPhone.Size = new System.Drawing.Size(672, 42);
            this.lblPPhone.TabIndex = 4;
            this.lblPPhone.Text = "Phone Number";
            this.lblPPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDoB
            // 
            this.dtpDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Location = new System.Drawing.Point(29, 298);
            this.dtpDoB.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(670, 35);
            this.dtpDoB.TabIndex = 5;
            // 
            // lblDoB
            // 
            this.lblDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(29, 250);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(672, 42);
            this.lblDoB.TabIndex = 4;
            this.lblDoB.Text = "Date of Birth";
            this.lblDoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(30, 90);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(672, 35);
            this.txtPatientId.TabIndex = 5;
            // 
            // lblPatientId
            // 
            this.lblPatientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.Location = new System.Drawing.Point(30, 42);
            this.lblPatientId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(672, 42);
            this.lblPatientId.TabIndex = 4;
            this.lblPatientId.Text = "Patient Id";
            this.lblPatientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedicalNumber
            // 
            this.txtMedicalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalNumber.Location = new System.Drawing.Point(29, 402);
            this.txtMedicalNumber.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtMedicalNumber.Name = "txtMedicalNumber";
            this.txtMedicalNumber.Size = new System.Drawing.Size(672, 35);
            this.txtMedicalNumber.TabIndex = 5;
            // 
            // lblMedicalNumber
            // 
            this.lblMedicalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedicalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalNumber.Location = new System.Drawing.Point(29, 354);
            this.lblMedicalNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicalNumber.Name = "lblMedicalNumber";
            this.lblMedicalNumber.Size = new System.Drawing.Size(672, 42);
            this.lblMedicalNumber.TabIndex = 4;
            this.lblMedicalNumber.Text = "Health Card Number";
            this.lblMedicalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPLName
            // 
            this.txtPLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLName.Location = new System.Drawing.Point(382, 194);
            this.txtPLName.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtPLName.Name = "txtPLName";
            this.txtPLName.Size = new System.Drawing.Size(320, 35);
            this.txtPLName.TabIndex = 5;
            // 
            // lblPLName
            // 
            this.lblPLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLName.Location = new System.Drawing.Point(382, 145);
            this.lblPLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPLName.Name = "lblPLName";
            this.lblPLName.Size = new System.Drawing.Size(322, 42);
            this.lblPLName.TabIndex = 4;
            this.lblPLName.Text = "Last Name";
            this.lblPLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPFName
            // 
            this.txtPFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPFName.Location = new System.Drawing.Point(30, 194);
            this.txtPFName.Margin = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.txtPFName.Name = "txtPFName";
            this.txtPFName.Size = new System.Drawing.Size(321, 35);
            this.txtPFName.TabIndex = 5;
            // 
            // lblPFName
            // 
            this.lblPFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFName.Location = new System.Drawing.Point(30, 145);
            this.lblPFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPFName.Name = "lblPFName";
            this.lblPFName.Size = new System.Drawing.Size(323, 42);
            this.lblPFName.TabIndex = 4;
            this.lblPFName.Text = "First Name";
            this.lblPFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlNotificationsTop);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1896, 150);
            this.pnlHeader.TabIndex = 4;
            // 
            // pnlNotificationsTop
            // 
            this.pnlNotificationsTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlNotificationsTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotificationsTop.Controls.Add(this.btnNotifications);
            this.pnlNotificationsTop.Controls.Add(this.lblToast);
            this.pnlNotificationsTop.Controls.Add(this.lblNotificationsTitle);
            this.pnlNotificationsTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotificationsTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlNotificationsTop.Location = new System.Drawing.Point(821, 0);
            this.pnlNotificationsTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNotificationsTop.Name = "pnlNotificationsTop";
            this.pnlNotificationsTop.Size = new System.Drawing.Size(1075, 150);
            this.pnlNotificationsTop.TabIndex = 3;
            // 
            // btnNotifications
            // 
            this.btnNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNotifications.Image = global::ClinicManagement_proj.Properties.Resources.notifications_icon;
            this.btnNotifications.Location = new System.Drawing.Point(959, 36);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(114, 112);
            this.btnNotifications.TabIndex = 0;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotifications.UseVisualStyleBackColor = false;
            // 
            // lblToast
            // 
            this.lblToast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblToast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToast.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblToast.ForeColor = System.Drawing.Color.White;
            this.lblToast.Location = new System.Drawing.Point(0, 36);
            this.lblToast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToast.Name = "lblToast";
            this.lblToast.Padding = new System.Windows.Forms.Padding(18, 12, 18, 12);
            this.lblToast.Size = new System.Drawing.Size(1073, 112);
            this.lblToast.TabIndex = 0;
            this.lblToast.Text = "Error message will appear here";
            this.lblToast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblToast.Visible = false;
            // 
            // lblNotificationsTitle
            // 
            this.lblNotificationsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNotificationsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotificationsTitle.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotificationsTitle.ForeColor = System.Drawing.Color.White;
            this.lblNotificationsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblNotificationsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationsTitle.Name = "lblNotificationsTitle";
            this.lblNotificationsTitle.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.lblNotificationsTitle.Size = new System.Drawing.Size(1073, 36);
            this.lblNotificationsTitle.TabIndex = 1;
            this.lblNotificationsTitle.Text = "📢 System Notifications";
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.flowLayoutPanelNotifications);
            this.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotifications.Location = new System.Drawing.Point(821, 150);
            this.pnlNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(1075, 901);
            this.pnlNotifications.TabIndex = 1;
            this.pnlNotifications.Visible = false;
            // 
            // flowLayoutPanelNotifications
            // 
            this.flowLayoutPanelNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelNotifications.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelNotifications.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNotifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelNotifications.Name = "flowLayoutPanelNotifications";
            this.flowLayoutPanelNotifications.Size = new System.Drawing.Size(1073, 899);
            this.flowLayoutPanelNotifications.TabIndex = 0;
            // 
            // timerToast
            // 
            this.timerToast.Interval = 5000;
            // 
            // grpAppointmentForm
            // 
            this.grpAppointmentForm.Location = new System.Drawing.Point(0, 0);
            this.grpAppointmentForm.Name = "grpAppointmentForm";
            this.grpAppointmentForm.Size = new System.Drawing.Size(200, 100);
            this.grpAppointmentForm.TabIndex = 0;
            this.grpAppointmentForm.TabStop = false;
            // 
            // lblAppointmentPlaceholder
            // 
            this.lblAppointmentPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblAppointmentPlaceholder.Name = "lblAppointmentPlaceholder";
            this.lblAppointmentPlaceholder.Size = new System.Drawing.Size(100, 23);
            this.lblAppointmentPlaceholder.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1896, 1051);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1911, 1084);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.tabControlReports.ResumeLayout(false);
            this.tabDoctorTodaySchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorTodaySchedule)).EndInit();
            this.pnlDoctorTodayScheduleTop.ResumeLayout(false);
            this.pnlDoctorTodayScheduleTop.PerformLayout();
            this.tabPatientRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).EndInit();
            this.pnlPatientRecordsTop.ResumeLayout(false);
            this.pnlPatientRecordsTop.PerformLayout();
            this.tabUpcomingAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).EndInit();
            this.pnlUpcomingApptTop.ResumeLayout(false);
            this.pnlUpcomingApptTop.PerformLayout();
            this.tabPatientClinicalSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientClinicalSummary)).EndInit();
            this.pnlPatientClinicalSummaryTop.ResumeLayout(false);
            this.pnlPatientClinicalSummaryTop.PerformLayout();
            this.pnlDoctorManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.grpDoctorMgmt.ResumeLayout(false);
            this.grpDoctorMgmt.PerformLayout();
            this.layoutDoctorActions.ResumeLayout(false);
            this.layoutDoctorActions.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpAdminForm.ResumeLayout(false);
            this.grpAdminForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlDoctorScheduling.ResumeLayout(false);
            this.grpDoctorScheduling.ResumeLayout(false);
            this.layoutSchedulingContent.ResumeLayout(false);
            this.layoutSchedulingContent.PerformLayout();
            this.layoutHours.ResumeLayout(false);
            this.layoutHours.PerformLayout();
            this.layoutSchedulingHeader.ResumeLayout(false);
            this.pnlDoctorPicker.ResumeLayout(false);
            this.layoutSchedulingActions.ResumeLayout(false);
            this.layoutSchedulingActions.PerformLayout();
            this.pnlAppointmentManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.grpApptMgmt.ResumeLayout(false);
            this.grpApptMgmt.PerformLayout();
            this.layoutApptButtons.ResumeLayout(false);
            this.layoutApptButtons.PerformLayout();
            this.pnlPatientRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPatients)).EndInit();
            this.grpPatientRegistration.ResumeLayout(false);
            this.grpPatientRegistration.PerformLayout();
            this.layoutPatientButtons.ResumeLayout(false);
            this.layoutPatientButtons.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlNotificationsTop.ResumeLayout(false);
            this.pnlNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnPatientRegistration;
        private System.Windows.Forms.Button btnDoctorScheduling;
        private System.Windows.Forms.Button btnDoctorManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAppointmentManagement;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.DataGridView dgvRegPatients;
        private System.Windows.Forms.GroupBox grpPatientRegistration;
        private System.Windows.Forms.TableLayoutPanel layoutPatientButtons;
        private System.Windows.Forms.Button btnPCreate;
        private System.Windows.Forms.Button btnPSearch;
        private System.Windows.Forms.TextBox txtPPhone;
        private System.Windows.Forms.Label lblPPhone;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtMedicalNumber;
        private System.Windows.Forms.Label lblMedicalNumber;
        private System.Windows.Forms.TextBox txtPLName;
        private System.Windows.Forms.Label lblPLName;
        private System.Windows.Forms.TextBox txtPFName;
        private System.Windows.Forms.Label lblPFName;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpAdminForm;
        private System.Windows.Forms.TableLayoutPanel pnlPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.TextBox txtUsrPassword;
        private System.Windows.Forms.Button btnGenPassword;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsrUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlDoctorManagement;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.GroupBox grpDoctorMgmt;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TextBox txtDoctorLName;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblDoctorLName;
        private System.Windows.Forms.TextBox txtDoctorFName;
        private System.Windows.Forms.Label lblDoctorFName;
        private System.Windows.Forms.Panel pnlDoctorScheduling;
        private System.Windows.Forms.GroupBox grpDoctorScheduling;
        private System.Windows.Forms.TableLayoutPanel layoutSchedulingContent;
        private System.Windows.Forms.TableLayoutPanel layoutHours;
        private System.Windows.Forms.Label lblHour12;
        private System.Windows.Forms.Label lblHour11;
        private System.Windows.Forms.Label lblHour10;
        private System.Windows.Forms.Label lblHour9;
        private System.Windows.Forms.Label lblHour8;
        private System.Windows.Forms.Label lblHour7;
        private System.Windows.Forms.Label lblHour6;
        private System.Windows.Forms.Label lblHour5;
        private System.Windows.Forms.Label lblHour4;
        private System.Windows.Forms.Label lblHour3;
        private System.Windows.Forms.Label lblHour2;
        private System.Windows.Forms.Label lblHour1;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.Label lblDay7;
        private System.Windows.Forms.ListBox lbSunday;
        private System.Windows.Forms.ListBox lbMonday;
        private System.Windows.Forms.ListBox lbTuesday;
        private System.Windows.Forms.ListBox lbWednesday;
        private System.Windows.Forms.ListBox lbThursday;
        private System.Windows.Forms.ListBox lbFriday;
        private System.Windows.Forms.ListBox lbSaturday;
        private System.Windows.Forms.TableLayoutPanel layoutSchedulingHeader;
        private System.Windows.Forms.Panel pnlDoctorPicker;
        private System.Windows.Forms.ComboBox cmbDoctorSelect;
        private System.Windows.Forms.Label lblDoctorSelect;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Timer timerToast;
        private System.Windows.Forms.GroupBox grpAppointmentForm;
        private System.Windows.Forms.Label lblAppointmentPlaceholder;
        private System.Windows.Forms.Button btnPCancel;
        private System.Windows.Forms.Button btnPDisplay;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.TableLayoutPanel layoutDoctorActions;
        private System.Windows.Forms.Button btnDoctorCreate;
        private System.Windows.Forms.Button btnDoctorUpdate;
        private System.Windows.Forms.Button btnDoctorSearch;
        private System.Windows.Forms.Button btnDoctorDelete;
        private System.Windows.Forms.Button btnDoctorDisplay;
        private System.Windows.Forms.Button btnDoctorCancel;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TableLayoutPanel layoutSchedulingActions;
        private System.Windows.Forms.Button btnScheduleRevert;
        private System.Windows.Forms.Button btnScheduleSave;
        private System.Windows.Forms.TextBox txtUsrId;
        private System.Windows.Forms.Label lblUsrId;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnUsrCreate;
        private System.Windows.Forms.Button btnUsrUpdate;
        private System.Windows.Forms.Button btnUsrSearch;
        private System.Windows.Forms.Button btnUsrDelete;
        private System.Windows.Forms.Button btnUsrDisplay;
        private System.Windows.Forms.Button btnUsrCancel;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Panel pnlAppointmentManagement;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.GroupBox grpApptMgmt;
        private System.Windows.Forms.TableLayoutPanel layoutApptButtons;
        private System.Windows.Forms.Button btnApptCreate;
        private System.Windows.Forms.Button btnApptUpdate;
        private System.Windows.Forms.Button btnApptSearch;
        private System.Windows.Forms.Button btnApptDisplay;
        private System.Windows.Forms.Button btnApptCancel;
        private System.Windows.Forms.Label lblApptDoctor;
        private System.Windows.Forms.ComboBox cmbApptDoctor;
        private System.Windows.Forms.Label lblApptPatient;
        private System.Windows.Forms.ComboBox cmbApptPatient;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.DateTimePicker dtpApptDate;
        private System.Windows.Forms.Label lblApptTimeSlot;
        private System.Windows.Forms.ComboBox cmbApptTimeSlots;
        private System.Windows.Forms.Label lblApptNotes;
        private System.Windows.Forms.TextBox txtApptNotes;
        private System.Windows.Forms.Label lblApptStatus;
        private System.Windows.Forms.ComboBox cmbApptStatus;
        private System.Windows.Forms.Label lblApptId;
        private System.Windows.Forms.TextBox txtApptId;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtDoctorLicense;
        private System.Windows.Forms.Label lblDoctorLicense;
        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabPatientRecords;
        private System.Windows.Forms.DataGridView dgvPatientRecords;
        private System.Windows.Forms.Panel pnlPatientRecordsTop;
        private System.Windows.Forms.ComboBox cmbVwPatientSelect;
        private System.Windows.Forms.Label lblVwPatientSelect;
        private System.Windows.Forms.TabPage tabUpcomingAppointments;
        private System.Windows.Forms.DataGridView dgvUpcomingAppointments;
        private System.Windows.Forms.Panel pnlUpcomingApptTop;
        private System.Windows.Forms.ComboBox cmbVwDoctorSelect;
        private System.Windows.Forms.Label lblVwDoctorSelect;
        private System.Windows.Forms.TabPage tabDoctorTodaySchedule;
        private System.Windows.Forms.DataGridView dgvDoctorTodaySchedule;
        private System.Windows.Forms.Panel pnlDoctorTodayScheduleTop;
        private System.Windows.Forms.ComboBox cmbVwDoctorScheduleSelect;
        private System.Windows.Forms.Label lblVwDoctorScheduleSelect;
        private System.Windows.Forms.TabPage tabPatientClinicalSummary;
        private System.Windows.Forms.DataGridView dgvPatientClinicalSummary;
        private System.Windows.Forms.Panel pnlPatientClinicalSummaryTop;
        private System.Windows.Forms.ComboBox cmbVwPatientSelectClinical;
        private System.Windows.Forms.Label lblVwPatientSelectClinical;
        public System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel pnlNotificationsTop;
        private System.Windows.Forms.Label lblToast;
        private System.Windows.Forms.Label lblNotificationsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNotifications;
    }
}
