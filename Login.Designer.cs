namespace FruitSoftware_SelfProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginField = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.NewMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginField
            // 
            this.LoginField.AutoSize = true;
            this.LoginField.BackColor = System.Drawing.Color.Transparent;
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.Location = new System.Drawing.Point(453, 53);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(240, 31);
            this.LoginField.TabIndex = 0;
            this.LoginField.Text = "Login Fruit System";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(470, 222);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(210, 20);
            this.txtBoxUserName.TabIndex = 1;
            this.txtBoxUserName.Text = "Username";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(470, 267);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(210, 20);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.Text = "New Password";
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.AccessibleName = "btnLogin";
            this.btnLoginForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginForm.Location = new System.Drawing.Point(497, 360);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(152, 28);
            this.btnLoginForm.TabIndex = 3;
            this.btnLoginForm.Text = "Login";
            this.btnLoginForm.UseVisualStyleBackColor = false;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // NewMember
            // 
            this.NewMember.Location = new System.Drawing.Point(596, 312);
            this.NewMember.Name = "NewMember";
            this.NewMember.Size = new System.Drawing.Size(110, 23);
            this.NewMember.TabIndex = 4;
            this.NewMember.Text = "New Member?";
            this.NewMember.UseVisualStyleBackColor = true;
            this.NewMember.Click += new System.EventHandler(this.NewMember_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 515);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.btnLoginForm);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.LoginField);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginField;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.Button NewMember;
    }
}