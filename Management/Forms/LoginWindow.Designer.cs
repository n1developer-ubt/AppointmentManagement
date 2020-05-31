namespace Management
{
    partial class LoginWindow
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.login = new Management.Controls.Login();
            this.signup = new Management.Controls.Signup();
            this.SuspendLayout();
            // 
            // transition
            // 
            this.transition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.login, BunifuAnimatorNS.DecorationType.None);
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Location = new System.Drawing.Point(20, 60);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(256, 380);
            this.login.TabIndex = 1;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.signup, BunifuAnimatorNS.DecorationType.None);
            this.signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup.Location = new System.Drawing.Point(20, 60);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(256, 380);
            this.signup.TabIndex = 0;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 460);
            this.Controls.Add(this.login);
            this.Controls.Add(this.signup);
            this.transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Signup signup;
        private Controls.Login login;
        private BunifuAnimatorNS.BunifuTransition transition;
    }
}

