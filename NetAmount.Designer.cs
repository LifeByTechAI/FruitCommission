namespace FruitSoftware_SelfProject
{
    partial class NetAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetAmount));
            this.txtFarmerCNIC = new System.Windows.Forms.TextBox();
            this.txtTotalExpenditures = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtSearchCNIC = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dg_Amount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFarmerCNIC
            // 
            this.txtFarmerCNIC.Location = new System.Drawing.Point(22, 20);
            this.txtFarmerCNIC.Name = "txtFarmerCNIC";
            this.txtFarmerCNIC.Size = new System.Drawing.Size(204, 20);
            this.txtFarmerCNIC.TabIndex = 0;
            this.txtFarmerCNIC.Text = "Farmer CNIC";
            // 
            // txtTotalExpenditures
            // 
            this.txtTotalExpenditures.Location = new System.Drawing.Point(22, 57);
            this.txtTotalExpenditures.Name = "txtTotalExpenditures";
            this.txtTotalExpenditures.Size = new System.Drawing.Size(204, 20);
            this.txtTotalExpenditures.TabIndex = 1;
            this.txtTotalExpenditures.Text = "Total Expenditures";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(247, 20);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(204, 20);
            this.txtNetAmount.TabIndex = 2;
            this.txtNetAmount.Text = "Net Amount";
            // 
            // txtSearchCNIC
            // 
            this.txtSearchCNIC.Location = new System.Drawing.Point(502, 29);
            this.txtSearchCNIC.Name = "txtSearchCNIC";
            this.txtSearchCNIC.Size = new System.Drawing.Size(251, 20);
            this.txtSearchCNIC.TabIndex = 3;
            this.txtSearchCNIC.Text = "Search CNIC";
            this.txtSearchCNIC.TextChanged += new System.EventHandler(this.txtSearchCNIC_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(638, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 52);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(498, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 52);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(638, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 52);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dg_Amount
            // 
            this.dg_Amount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Amount.Location = new System.Drawing.Point(22, 96);
            this.dg_Amount.Name = "dg_Amount";
            this.dg_Amount.Size = new System.Drawing.Size(429, 342);
            this.dg_Amount.TabIndex = 8;
//            this.dg_Amount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Amount_CellContentClick);
            // 
            // NetAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_Amount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearchCNIC);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.txtTotalExpenditures);
            this.Controls.Add(this.txtFarmerCNIC);
            this.Name = "NetAmount";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NetAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFarmerCNIC;
        private System.Windows.Forms.TextBox txtTotalExpenditures;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtSearchCNIC;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dg_Amount;
    }
}