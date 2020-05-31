namespace Management.Controls
{
    partial class StaffControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffControl));
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnNewStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQualifiaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(823, 493);
            this.panel14.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(623, 493);
            this.panel15.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dgvData);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 32);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(623, 461);
            this.panel16.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.clAddress2,
            this.clCity,
            this.clCountry,
            this.clPostalCode,
            this.clPhoneNumber,
            this.clQualifiaction,
            this.clUsername,
            this.clPassword});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(623, 461);
            this.dgvData.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label3);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(623, 32);
            this.panel17.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Staff";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.btnNewStaff);
            this.panel18.Controls.Add(this.btnUpdateStaff);
            this.panel18.Controls.Add(this.btnDeleteStaff);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(623, 0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(5);
            this.panel18.Size = new System.Drawing.Size(200, 493);
            this.panel18.TabIndex = 1;
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Active = false;
            this.btnNewStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewStaff.BorderRadius = 0;
            this.btnNewStaff.ButtonText = "New Staff";
            this.btnNewStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewStaff.Iconimage")));
            this.btnNewStaff.Iconimage_right = null;
            this.btnNewStaff.Iconimage_right_Selected = null;
            this.btnNewStaff.Iconimage_Selected = null;
            this.btnNewStaff.IconMarginLeft = 0;
            this.btnNewStaff.IconMarginRight = 0;
            this.btnNewStaff.IconRightVisible = false;
            this.btnNewStaff.IconRightZoom = 0D;
            this.btnNewStaff.IconVisible = false;
            this.btnNewStaff.IconZoom = 90D;
            this.btnNewStaff.IsTab = false;
            this.btnNewStaff.Location = new System.Drawing.Point(5, 372);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnNewStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewStaff.selected = false;
            this.btnNewStaff.Size = new System.Drawing.Size(188, 38);
            this.btnNewStaff.TabIndex = 10;
            this.btnNewStaff.Text = "New Staff";
            this.btnNewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewStaff.Textcolor = System.Drawing.Color.White;
            this.btnNewStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Active = false;
            this.btnUpdateStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateStaff.BorderRadius = 0;
            this.btnUpdateStaff.ButtonText = "Update Staff";
            this.btnUpdateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateStaff.Iconimage")));
            this.btnUpdateStaff.Iconimage_right = null;
            this.btnUpdateStaff.Iconimage_right_Selected = null;
            this.btnUpdateStaff.Iconimage_Selected = null;
            this.btnUpdateStaff.IconMarginLeft = 0;
            this.btnUpdateStaff.IconMarginRight = 0;
            this.btnUpdateStaff.IconRightVisible = false;
            this.btnUpdateStaff.IconRightZoom = 0D;
            this.btnUpdateStaff.IconVisible = false;
            this.btnUpdateStaff.IconZoom = 90D;
            this.btnUpdateStaff.IsTab = false;
            this.btnUpdateStaff.Location = new System.Drawing.Point(5, 410);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnUpdateStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateStaff.selected = false;
            this.btnUpdateStaff.Size = new System.Drawing.Size(188, 38);
            this.btnUpdateStaff.TabIndex = 9;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateStaff.Textcolor = System.Drawing.Color.White;
            this.btnUpdateStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Active = false;
            this.btnDeleteStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStaff.BorderRadius = 0;
            this.btnDeleteStaff.ButtonText = "Delete Staff";
            this.btnDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStaff.Iconimage")));
            this.btnDeleteStaff.Iconimage_right = null;
            this.btnDeleteStaff.Iconimage_right_Selected = null;
            this.btnDeleteStaff.Iconimage_Selected = null;
            this.btnDeleteStaff.IconMarginLeft = 0;
            this.btnDeleteStaff.IconMarginRight = 0;
            this.btnDeleteStaff.IconRightVisible = false;
            this.btnDeleteStaff.IconRightZoom = 0D;
            this.btnDeleteStaff.IconVisible = false;
            this.btnDeleteStaff.IconZoom = 90D;
            this.btnDeleteStaff.IsTab = false;
            this.btnDeleteStaff.Location = new System.Drawing.Point(5, 448);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnDeleteStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteStaff.selected = false;
            this.btnDeleteStaff.Size = new System.Drawing.Size(188, 38);
            this.btnDeleteStaff.TabIndex = 8;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteStaff.Textcolor = System.Drawing.Color.White;
            this.btnDeleteStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Address 1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // clAddress2
            // 
            this.clAddress2.HeaderText = "Address 2";
            this.clAddress2.Name = "clAddress2";
            this.clAddress2.ReadOnly = true;
            // 
            // clCity
            // 
            this.clCity.HeaderText = "City";
            this.clCity.Name = "clCity";
            this.clCity.ReadOnly = true;
            // 
            // clCountry
            // 
            this.clCountry.HeaderText = "Country";
            this.clCountry.Name = "clCountry";
            this.clCountry.ReadOnly = true;
            // 
            // clPostalCode
            // 
            this.clPostalCode.HeaderText = "Postal Code";
            this.clPostalCode.Name = "clPostalCode";
            this.clPostalCode.ReadOnly = true;
            // 
            // clPhoneNumber
            // 
            this.clPhoneNumber.HeaderText = "Phone Number";
            this.clPhoneNumber.Name = "clPhoneNumber";
            this.clPhoneNumber.ReadOnly = true;
            // 
            // clQualifiaction
            // 
            this.clQualifiaction.HeaderText = "Qualification";
            this.clQualifiaction.Name = "clQualifiaction";
            this.clQualifiaction.ReadOnly = true;
            // 
            // clUsername
            // 
            this.clUsername.HeaderText = "Username";
            this.clUsername.Name = "clUsername";
            this.clUsername.ReadOnly = true;
            // 
            // clPassword
            // 
            this.clPassword.HeaderText = "Password";
            this.clPassword.Name = "clPassword";
            this.clPassword.ReadOnly = true;
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel14);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(823, 493);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel18;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQualifiaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPassword;
    }
}
