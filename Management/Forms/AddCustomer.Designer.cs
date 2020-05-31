namespace Management.Forms
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPhoneNumber = new UBTStandardLibrary.UBTTextBox();
            this.txtCity = new UBTStandardLibrary.UBTTextBox();
            this.txtPostalAddress = new UBTStandardLibrary.UBTTextBox();
            this.txtAddress2 = new UBTStandardLibrary.UBTTextBox();
            this.txtCountry = new UBTStandardLibrary.UBTTextBox();
            this.txtAddress1 = new UBTStandardLibrary.UBTTextBox();
            this.txtName = new UBTStandardLibrary.UBTTextBox();
            this.pnlWindow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.panel1);
            this.pnlWindow.Size = new System.Drawing.Size(303, 444);
            this.pnlWindow.Controls.SetChildIndex(this.panel1, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtPostalAddress);
            this.panel1.Controls.Add(this.txtAddress2);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.txtAddress1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 444);
            this.panel1.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Active = false;
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = false;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(173, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(102, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPhoneNumber.BorderThickness = 2;
            this.txtPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(26, 300);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(249, 38);
            this.txtPhoneNumber.TabIndex = 15;
            this.txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            // 
            // txtCity
            // 
            this.txtCity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCity.BorderThickness = 2;
            this.txtCity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCity.Hint = "City";
            this.txtCity.isPassword = false;
            this.txtCity.Location = new System.Drawing.Point(26, 162);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(249, 38);
            this.txtCity.TabIndex = 12;
            this.txtCity.Text = "City";
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPostalAddress
            // 
            this.txtPostalAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPostalAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPostalAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPostalAddress.BorderThickness = 2;
            this.txtPostalAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPostalAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostalAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPostalAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtPostalAddress.Hint = "Postal Address";
            this.txtPostalAddress.isPassword = false;
            this.txtPostalAddress.Location = new System.Drawing.Point(26, 254);
            this.txtPostalAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalAddress.MaxLength = 32767;
            this.txtPostalAddress.Name = "txtPostalAddress";
            this.txtPostalAddress.Size = new System.Drawing.Size(249, 38);
            this.txtPostalAddress.TabIndex = 14;
            this.txtPostalAddress.Text = "Postal Address";
            this.txtPostalAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress2.BorderThickness = 2;
            this.txtAddress2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress2.Hint = "Address 2";
            this.txtAddress2.isPassword = false;
            this.txtAddress2.Location = new System.Drawing.Point(26, 116);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress2.MaxLength = 32767;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(249, 38);
            this.txtAddress2.TabIndex = 11;
            this.txtAddress2.Text = "Address 2";
            this.txtAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCountry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCountry.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCountry.BorderThickness = 2;
            this.txtCountry.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtCountry.Hint = "Country";
            this.txtCountry.isPassword = false;
            this.txtCountry.Location = new System.Drawing.Point(26, 208);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.MaxLength = 32767;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(249, 38);
            this.txtCountry.TabIndex = 13;
            this.txtCountry.Text = "Country";
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress1.BorderThickness = 2;
            this.txtAddress1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtAddress1.Hint = "Address 1";
            this.txtAddress1.isPassword = false;
            this.txtAddress1.Location = new System.Drawing.Point(26, 70);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress1.MaxLength = 32767;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(249, 38);
            this.txtAddress1.TabIndex = 10;
            this.txtAddress1.Text = "Address 1";
            this.txtAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtName.BorderThickness = 2;
            this.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtName.Hint = "Name";
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(26, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 38);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(306, 484);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LogoImage = global::Management.Properties.Resources.email;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomer";
            this.Resizeable = false;
            this.Text = "Add Customer";
            this.TitleText = "Add Customer";
            this.ToolBox = UBTStandardLibrary.Forms.ToolBoxProp.MinExit;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.pnlWindow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private UBTStandardLibrary.UBTTextBox txtPhoneNumber;
        private UBTStandardLibrary.UBTTextBox txtCity;
        private UBTStandardLibrary.UBTTextBox txtPostalAddress;
        private UBTStandardLibrary.UBTTextBox txtAddress2;
        private UBTStandardLibrary.UBTTextBox txtCountry;
        private UBTStandardLibrary.UBTTextBox txtAddress1;
        private UBTStandardLibrary.UBTTextBox txtName;
    }
}