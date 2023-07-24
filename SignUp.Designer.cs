namespace FruitSoftware_SelfProject
{
    partial class SignUp
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.textpw = new System.Windows.Forms.TextBox();
            this.textrepw = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(161, 208);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(296, 20);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "Full Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(164, 253);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(293, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "User Name";
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(164, 297);
            this.textpw.Name = "textpw";
            this.textpw.Size = new System.Drawing.Size(293, 20);
            this.textpw.TabIndex = 3;
            this.textpw.Text = "Password";
            // 
            // textrepw
            // 
            this.textrepw.Location = new System.Drawing.Point(164, 339);
            this.textrepw.Name = "textrepw";
            this.textrepw.Size = new System.Drawing.Size(293, 20);
            this.textrepw.TabIndex = 4;
            this.textrepw.Text = "Reenter Password";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Location = new System.Drawing.Point(197, 418);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(227, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Signup";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(197, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitSoftware_SelfProject.Properties.Resources.SignUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textrepw);
            this.Controls.Add(this.textpw);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.DoubleBuffered = true;
            this.Name = "SignUp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.TextBox textrepw;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
    }
}