namespace Management.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabAppointments = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.btnNewAppointment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateAppointment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteAppointment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabCustomer = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnNewCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabReports = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabStaff = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.staffControl1 = new Management.Controls.StaffControl();
            this.pnlWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.panel1);
            this.pnlWindow.Size = new System.Drawing.Size(817, 489);
            this.pnlWindow.Controls.SetChildIndex(this.panel1, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(576, 369);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabPane1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 489);
            this.panel1.TabIndex = 5;
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.tabPane1.Appearance.Options.UseBorderColor = true;
            this.tabPane1.AppearanceButton.Normal.BorderColor = System.Drawing.Color.Black;
            this.tabPane1.AppearanceButton.Normal.Options.UseBorderColor = true;
            this.tabPane1.Controls.Add(this.tabAppointments);
            this.tabPane1.Controls.Add(this.tabCustomer);
            this.tabPane1.Controls.Add(this.tabReports);
            this.tabPane1.Controls.Add(this.tabStaff);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabAppointments,
            this.tabCustomer,
            this.tabStaff,
            this.tabReports});
            this.tabPane1.RegularSize = new System.Drawing.Size(814, 489);
            this.tabPane1.SelectedPage = this.tabAppointments;
            this.tabPane1.Size = new System.Drawing.Size(814, 489);
            this.tabPane1.TabIndex = 2;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabAppointments
            // 
            this.tabAppointments.Caption = "Appointments";
            this.tabAppointments.Controls.Add(this.panel2);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Size = new System.Drawing.Size(814, 462);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 462);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 462);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(614, 430);
            this.panel5.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Start,
            this.End,
            this.clDate,
            this.Customer,
            this.CustomerGroup,
            this.clLocation,
            this.Requestor,
            this.ConfirmedBy});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(614, 430);
            this.dgvData.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.MinimumWidth = 50;
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // End
            // 
            this.End.HeaderText = "End";
            this.End.MinimumWidth = 50;
            this.End.Name = "End";
            this.End.ReadOnly = true;
            // 
            // clDate
            // 
            this.clDate.HeaderText = "Date";
            this.clDate.MinimumWidth = 50;
            this.clDate.Name = "clDate";
            this.clDate.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 50;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // CustomerGroup
            // 
            this.CustomerGroup.HeaderText = "Customer Group";
            this.CustomerGroup.MinimumWidth = 50;
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.ReadOnly = true;
            // 
            // clLocation
            // 
            this.clLocation.HeaderText = "Location";
            this.clLocation.MinimumWidth = 50;
            this.clLocation.Name = "clLocation";
            this.clLocation.ReadOnly = true;
            // 
            // Requestor
            // 
            this.Requestor.HeaderText = "Requestor";
            this.Requestor.MinimumWidth = 50;
            this.Requestor.Name = "Requestor";
            this.Requestor.ReadOnly = true;
            // 
            // ConfirmedBy
            // 
            this.ConfirmedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConfirmedBy.HeaderText = "Confirmed By";
            this.ConfirmedBy.MinimumWidth = 100;
            this.ConfirmedBy.Name = "ConfirmedBy";
            this.ConfirmedBy.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 32);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upcomming Appointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rgType);
            this.panel8.Controls.Add(this.btnNewAppointment);
            this.panel8.Controls.Add(this.btnUpdateAppointment);
            this.panel8.Controls.Add(this.btnDeleteAppointment);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(614, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(200, 462);
            this.panel8.TabIndex = 1;
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(8, 32);
            this.rgType.Name = "rgType";
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Weekly"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Monthly")});
            this.rgType.Size = new System.Drawing.Size(100, 96);
            this.rgType.TabIndex = 11;
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Active = false;
            this.btnNewAppointment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAppointment.BorderRadius = 0;
            this.btnNewAppointment.ButtonText = "New Appointment";
            this.btnNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAppointment.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewAppointment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewAppointment.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewAppointment.Iconimage")));
            this.btnNewAppointment.Iconimage_right = null;
            this.btnNewAppointment.Iconimage_right_Selected = null;
            this.btnNewAppointment.Iconimage_Selected = null;
            this.btnNewAppointment.IconMarginLeft = 0;
            this.btnNewAppointment.IconMarginRight = 0;
            this.btnNewAppointment.IconRightVisible = false;
            this.btnNewAppointment.IconRightZoom = 0D;
            this.btnNewAppointment.IconVisible = false;
            this.btnNewAppointment.IconZoom = 90D;
            this.btnNewAppointment.IsTab = false;
            this.btnNewAppointment.Location = new System.Drawing.Point(5, 343);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewAppointment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewAppointment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewAppointment.selected = false;
            this.btnNewAppointment.Size = new System.Drawing.Size(190, 38);
            this.btnNewAppointment.TabIndex = 10;
            this.btnNewAppointment.Text = "New Appointment";
            this.btnNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewAppointment.Textcolor = System.Drawing.Color.White;
            this.btnNewAppointment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Active = false;
            this.btnUpdateAppointment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateAppointment.BorderRadius = 0;
            this.btnUpdateAppointment.ButtonText = "Update Appointment";
            this.btnUpdateAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAppointment.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateAppointment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateAppointment.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAppointment.Iconimage")));
            this.btnUpdateAppointment.Iconimage_right = null;
            this.btnUpdateAppointment.Iconimage_right_Selected = null;
            this.btnUpdateAppointment.Iconimage_Selected = null;
            this.btnUpdateAppointment.IconMarginLeft = 0;
            this.btnUpdateAppointment.IconMarginRight = 0;
            this.btnUpdateAppointment.IconRightVisible = false;
            this.btnUpdateAppointment.IconRightZoom = 0D;
            this.btnUpdateAppointment.IconVisible = false;
            this.btnUpdateAppointment.IconZoom = 90D;
            this.btnUpdateAppointment.IsTab = false;
            this.btnUpdateAppointment.Location = new System.Drawing.Point(5, 381);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateAppointment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateAppointment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateAppointment.selected = false;
            this.btnUpdateAppointment.Size = new System.Drawing.Size(190, 38);
            this.btnUpdateAppointment.TabIndex = 9;
            this.btnUpdateAppointment.Text = "Update Appointment";
            this.btnUpdateAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateAppointment.Textcolor = System.Drawing.Color.White;
            this.btnUpdateAppointment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Active = false;
            this.btnDeleteAppointment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAppointment.BorderRadius = 0;
            this.btnDeleteAppointment.ButtonText = "Delete Appointment";
            this.btnDeleteAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAppointment.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteAppointment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteAppointment.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAppointment.Iconimage")));
            this.btnDeleteAppointment.Iconimage_right = null;
            this.btnDeleteAppointment.Iconimage_right_Selected = null;
            this.btnDeleteAppointment.Iconimage_Selected = null;
            this.btnDeleteAppointment.IconMarginLeft = 0;
            this.btnDeleteAppointment.IconMarginRight = 0;
            this.btnDeleteAppointment.IconRightVisible = false;
            this.btnDeleteAppointment.IconRightZoom = 0D;
            this.btnDeleteAppointment.IconVisible = false;
            this.btnDeleteAppointment.IconZoom = 90D;
            this.btnDeleteAppointment.IsTab = false;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(5, 419);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteAppointment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteAppointment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteAppointment.selected = false;
            this.btnDeleteAppointment.Size = new System.Drawing.Size(190, 38);
            this.btnDeleteAppointment.TabIndex = 8;
            this.btnDeleteAppointment.Text = "Delete Appointment";
            this.btnDeleteAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteAppointment.Textcolor = System.Drawing.Color.White;
            this.btnDeleteAppointment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Caption = "Customers";
            this.tabCustomer.Controls.Add(this.panel9);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(814, 462);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(814, 462);
            this.panel9.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(614, 462);
            this.panel10.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvCustomers);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 32);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(614, 430);
            this.panel11.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.GridColor = System.Drawing.Color.White;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(614, 430);
            this.dgvCustomers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(614, 32);
            this.panel12.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Customers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnNewCustomer);
            this.panel13.Controls.Add(this.btnUpdateCustomer);
            this.panel13.Controls.Add(this.btnDeleteCustomer);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(614, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(5);
            this.panel13.Size = new System.Drawing.Size(200, 462);
            this.panel13.TabIndex = 1;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Active = false;
            this.btnNewCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewCustomer.BorderRadius = 0;
            this.btnNewCustomer.ButtonText = "New Customer";
            this.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Iconimage")));
            this.btnNewCustomer.Iconimage_right = null;
            this.btnNewCustomer.Iconimage_right_Selected = null;
            this.btnNewCustomer.Iconimage_Selected = null;
            this.btnNewCustomer.IconMarginLeft = 0;
            this.btnNewCustomer.IconMarginRight = 0;
            this.btnNewCustomer.IconRightVisible = false;
            this.btnNewCustomer.IconRightZoom = 0D;
            this.btnNewCustomer.IconVisible = false;
            this.btnNewCustomer.IconZoom = 90D;
            this.btnNewCustomer.IsTab = false;
            this.btnNewCustomer.Location = new System.Drawing.Point(5, 343);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewCustomer.selected = false;
            this.btnNewCustomer.Size = new System.Drawing.Size(190, 38);
            this.btnNewCustomer.TabIndex = 10;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewCustomer.Textcolor = System.Drawing.Color.White;
            this.btnNewCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Active = false;
            this.btnUpdateCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCustomer.BorderRadius = 0;
            this.btnUpdateCustomer.ButtonText = "Update Customer";
            this.btnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.Iconimage")));
            this.btnUpdateCustomer.Iconimage_right = null;
            this.btnUpdateCustomer.Iconimage_right_Selected = null;
            this.btnUpdateCustomer.Iconimage_Selected = null;
            this.btnUpdateCustomer.IconMarginLeft = 0;
            this.btnUpdateCustomer.IconMarginRight = 0;
            this.btnUpdateCustomer.IconRightVisible = false;
            this.btnUpdateCustomer.IconRightZoom = 0D;
            this.btnUpdateCustomer.IconVisible = false;
            this.btnUpdateCustomer.IconZoom = 90D;
            this.btnUpdateCustomer.IsTab = false;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(5, 381);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.selected = false;
            this.btnUpdateCustomer.Size = new System.Drawing.Size(190, 38);
            this.btnUpdateCustomer.TabIndex = 9;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateCustomer.Textcolor = System.Drawing.Color.White;
            this.btnUpdateCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Active = false;
            this.btnDeleteCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCustomer.BorderRadius = 0;
            this.btnDeleteCustomer.ButtonText = "Delete Customer";
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Iconimage")));
            this.btnDeleteCustomer.Iconimage_right = null;
            this.btnDeleteCustomer.Iconimage_right_Selected = null;
            this.btnDeleteCustomer.Iconimage_Selected = null;
            this.btnDeleteCustomer.IconMarginLeft = 0;
            this.btnDeleteCustomer.IconMarginRight = 0;
            this.btnDeleteCustomer.IconRightVisible = false;
            this.btnDeleteCustomer.IconRightZoom = 0D;
            this.btnDeleteCustomer.IconVisible = false;
            this.btnDeleteCustomer.IconZoom = 90D;
            this.btnDeleteCustomer.IsTab = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(5, 419);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.selected = false;
            this.btnDeleteCustomer.Size = new System.Drawing.Size(190, 38);
            this.btnDeleteCustomer.TabIndex = 8;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCustomer.Textcolor = System.Drawing.Color.White;
            this.btnDeleteCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // tabReports
            // 
            this.tabReports.Caption = "Reports";
            this.tabReports.Controls.Add(this.bunifuFlatButton2);
            this.tabReports.Controls.Add(this.bunifuFlatButton1);
            this.tabReports.Controls.Add(this.btnSignup);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(814, 489);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Generate Customer per City Report";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(13, 100);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(321, 38);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.TabStop = false;
            this.bunifuFlatButton2.Text = "Generate Customer per City Report";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Generate Schedule for Staff Report";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(13, 56);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 38);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.TabStop = false;
            this.bunifuFlatButton1.Text = "Generate Schedule for Staff Report";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSignup
            // 
            this.btnSignup.Active = false;
            this.btnSignup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignup.BorderRadius = 0;
            this.btnSignup.ButtonText = "Generate Appointment Types per Month Report";
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignup.Iconimage")));
            this.btnSignup.Iconimage_right = null;
            this.btnSignup.Iconimage_right_Selected = null;
            this.btnSignup.Iconimage_Selected = null;
            this.btnSignup.IconMarginLeft = 0;
            this.btnSignup.IconMarginRight = 0;
            this.btnSignup.IconRightVisible = false;
            this.btnSignup.IconRightZoom = 0D;
            this.btnSignup.IconVisible = false;
            this.btnSignup.IconZoom = 90D;
            this.btnSignup.IsTab = false;
            this.btnSignup.Location = new System.Drawing.Point(13, 12);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSignup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSignup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignup.selected = false;
            this.btnSignup.Size = new System.Drawing.Size(321, 38);
            this.btnSignup.TabIndex = 8;
            this.btnSignup.TabStop = false;
            this.btnSignup.Text = "Generate Appointment Types per Month Report";
            this.btnSignup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignup.Textcolor = System.Drawing.Color.White;
            this.btnSignup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabStaff
            // 
            this.tabStaff.Caption = "Staff";
            this.tabStaff.Controls.Add(this.staffControl1);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Size = new System.Drawing.Size(814, 462);
            // 
            // staffControl1
            // 
            this.staffControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffControl1.Location = new System.Drawing.Point(0, 0);
            this.staffControl1.Name = "staffControl1";
            this.staffControl1.Size = new System.Drawing.Size(814, 462);
            this.staffControl1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(820, 529);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LogoImage = global::Management.Properties.Resources.email;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Management System";
            this.TitleText = "Appointment Management System";
            this.pnlWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabAppointments.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabAppointments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewAppointment;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateAppointment;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteAppointment;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabCustomer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteCustomer;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabReports;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignup;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmedBy;
        private Controls.StaffControl staffControl1;
    }
}