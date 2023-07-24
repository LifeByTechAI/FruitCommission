namespace FruitSoftware_SelfProject
{
    partial class Farmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmer));
            this.datagridFarmer = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTraderName = new System.Windows.Forms.Label();
            this.txtTraderName0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFarmerCNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLabelProvince = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtSearchCNIC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFarmer)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridFarmer
            // 
            this.datagridFarmer.AllowUserToAddRows = false;
            this.datagridFarmer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFarmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFarmer.Location = new System.Drawing.Point(12, 239);
            this.datagridFarmer.Name = "datagridFarmer";
            this.datagridFarmer.ReadOnly = true;
            this.datagridFarmer.RowHeadersWidth = 51;
            this.datagridFarmer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFarmer.Size = new System.Drawing.Size(776, 362);
            this.datagridFarmer.TabIndex = 20;
            this.datagridFarmer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFarmer_CellClick);
//          this.datagridFarmer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFarmer_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnSave.Location = new System.Drawing.Point(552, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnClear.Location = new System.Drawing.Point(645, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnUpdate.Location = new System.Drawing.Point(645, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnDelete.Location = new System.Drawing.Point(552, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTraderName
            // 
            this.txtTraderName.AutoSize = true;
            this.txtTraderName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraderName.Location = new System.Drawing.Point(28, 37);
            this.txtTraderName.Name = "txtTraderName";
            this.txtTraderName.Size = new System.Drawing.Size(106, 19);
            this.txtTraderName.TabIndex = 10;
            this.txtTraderName.Text = "Trader Name";
            // 
            // txtTraderName0
            // 
            this.txtTraderName0.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtTraderName0.Location = new System.Drawing.Point(160, 34);
            this.txtTraderName0.Name = "txtTraderName0";
            this.txtTraderName0.Size = new System.Drawing.Size(232, 26);
            this.txtTraderName0.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Farmer CNIC";
            // 
            // txtFarmerCNIC
            // 
            this.txtFarmerCNIC.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtFarmerCNIC.Location = new System.Drawing.Point(160, 65);
            this.txtFarmerCNIC.Name = "txtFarmerCNIC";
            this.txtFarmerCNIC.Size = new System.Drawing.Size(232, 26);
            this.txtFarmerCNIC.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mobile Number";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtMobileNumber.Location = new System.Drawing.Point(160, 96);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(232, 26);
            this.txtMobileNumber.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtAddress.Location = new System.Drawing.Point(160, 127);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 26);
            this.txtAddress.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtCity.Location = new System.Drawing.Point(160, 158);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(232, 26);
            this.txtCity.TabIndex = 18;
            // 
            // txtLabelProvince
            // 
            this.txtLabelProvince.AutoSize = true;
            this.txtLabelProvince.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelProvince.Location = new System.Drawing.Point(28, 191);
            this.txtLabelProvince.Name = "txtLabelProvince";
            this.txtLabelProvince.Size = new System.Drawing.Size(72, 19);
            this.txtLabelProvince.TabIndex = 10;
            this.txtLabelProvince.Text = "Province";
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtProvince.Location = new System.Drawing.Point(160, 189);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(232, 26);
            this.txtProvince.TabIndex = 18;
            // 
            // txtSearchCNIC
            // 
            this.txtSearchCNIC.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtSearchCNIC.Location = new System.Drawing.Point(537, 188);
            this.txtSearchCNIC.Name = "txtSearchCNIC";
            this.txtSearchCNIC.Size = new System.Drawing.Size(232, 26);
            this.txtSearchCNIC.TabIndex = 19;
            this.txtSearchCNIC.TextChanged += new System.EventHandler(this.txtSearchCNIC_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Search CNIC";
            // 
            // Farmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 622);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datagridFarmer);
            this.Controls.Add(this.txtSearchCNIC);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLabelProvince);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtTraderName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTraderName0);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFarmerCNIC);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.label3);
            this.Name = "Farmer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Farmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridFarmer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridFarmer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtTraderName;
        private System.Windows.Forms.TextBox txtTraderName0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFarmerCNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label txtLabelProvince;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtSearchCNIC;
        private System.Windows.Forms.Label label7;
    }
}