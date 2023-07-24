namespace FruitSoftware_SelfProject
{
    partial class Expenditures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenditures));
            this.DataGridExpenditures = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDriverCnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtFarmerCnic = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnUpdate4 = new System.Windows.Forms.Button();
            this.txtTotalExpenditure = new System.Windows.Forms.TextBox();
            this.txtTotalCommission = new System.Windows.Forms.TextBox();
            this.TxtTruckRent = new System.Windows.Forms.TextBox();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExpenditures)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridExpenditures
            // 
            this.DataGridExpenditures.AllowUserToAddRows = false;
            this.DataGridExpenditures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridExpenditures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridExpenditures.Location = new System.Drawing.Point(12, 284);
            this.DataGridExpenditures.MultiSelect = false;
            this.DataGridExpenditures.Name = "DataGridExpenditures";
            this.DataGridExpenditures.ReadOnly = true;
            this.DataGridExpenditures.RowHeadersWidth = 51;
            this.DataGridExpenditures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridExpenditures.Size = new System.Drawing.Size(776, 396);
            this.DataGridExpenditures.TabIndex = 47;
            this.DataGridExpenditures.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridExpenditures_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Driver CNIC";
            // 
            // txtDriverCnic
            // 
            this.txtDriverCnic.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtDriverCnic.Location = new System.Drawing.Point(167, 50);
            this.txtDriverCnic.Name = "txtDriverCnic";
            this.txtDriverCnic.Size = new System.Drawing.Size(232, 26);
            this.txtDriverCnic.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Company Id\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Search CNIC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtCompanyId.Location = new System.Drawing.Point(167, 18);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(232, 26);
            this.txtCompanyId.TabIndex = 44;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtSearch.Location = new System.Drawing.Point(529, 217);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 26);
            this.txtSearch.TabIndex = 46;
//            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtFarmerCnic
            // 
            this.txtFarmerCnic.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtFarmerCnic.Location = new System.Drawing.Point(167, 84);
            this.txtFarmerCnic.Name = "txtFarmerCnic";
            this.txtFarmerCnic.Size = new System.Drawing.Size(232, 26);
            this.txtFarmerCnic.TabIndex = 48;
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtQuant.Location = new System.Drawing.Point(167, 126);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(232, 26);
            this.txtQuant.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Farmer CNIC";
            // 
            // btnSave1
            // 
            this.btnSave1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnSave1.Location = new System.Drawing.Point(550, 31);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(87, 30);
            this.btnSave1.TabIndex = 50;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnClear2.Location = new System.Drawing.Point(669, 85);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(87, 30);
            this.btnClear2.TabIndex = 51;
            this.btnClear2.Text = "Clear All";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete3
            // 
            this.btnDelete3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnDelete3.Location = new System.Drawing.Point(550, 85);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(87, 30);
            this.btnDelete3.TabIndex = 52;
            this.btnDelete3.Text = "Delete";
            this.btnDelete3.UseVisualStyleBackColor = true;
            this.btnDelete3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate4
            // 
            this.btnUpdate4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnUpdate4.Location = new System.Drawing.Point(669, 31);
            this.btnUpdate4.Name = "btnUpdate4";
            this.btnUpdate4.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate4.TabIndex = 53;
            this.btnUpdate4.Text = "Update";
            this.btnUpdate4.UseVisualStyleBackColor = true;
            this.btnUpdate4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTotalExpenditure
            // 
            this.txtTotalExpenditure.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtTotalExpenditure.Location = new System.Drawing.Point(167, 253);
            this.txtTotalExpenditure.Name = "txtTotalExpenditure";
            this.txtTotalExpenditure.Size = new System.Drawing.Size(232, 26);
            this.txtTotalExpenditure.TabIndex = 54;
            // 
            // txtTotalCommission
            // 
            this.txtTotalCommission.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtTotalCommission.Location = new System.Drawing.Point(167, 220);
            this.txtTotalCommission.Name = "txtTotalCommission";
            this.txtTotalCommission.Size = new System.Drawing.Size(232, 26);
            this.txtTotalCommission.TabIndex = 55;
            // 
            // TxtTruckRent
            // 
            this.TxtTruckRent.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.TxtTruckRent.Location = new System.Drawing.Point(167, 186);
            this.TxtTruckRent.Name = "TxtTruckRent";
            this.TxtTruckRent.Size = new System.Drawing.Size(232, 26);
            this.TxtTruckRent.TabIndex = 56;
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtTotalSale.Location = new System.Drawing.Point(167, 152);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.Size = new System.Drawing.Size(232, 26);
            this.txtTotalSale.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Total Commission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Truck Rent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Total Sale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "Total Expanditure";
            // 
            // Expenditures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 688);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DataGridExpenditures);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDriverCnic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.TxtTruckRent);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTotalCommission);
            this.Controls.Add(this.txtFarmerCnic);
            this.Controls.Add(this.txtTotalExpenditure);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.btnUpdate4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.btnClear2);
            this.Name = "Expenditures";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Expenditures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExpenditures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridExpenditures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDriverCnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtFarmerCnic;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnUpdate4;
        private System.Windows.Forms.TextBox txtTotalExpenditure;
        private System.Windows.Forms.TextBox txtTotalCommission;
        private System.Windows.Forms.TextBox TxtTruckRent;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}