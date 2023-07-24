namespace NetProjectType_FruitCommission
{
    partial class Fruits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruits));
            this.datagridFruit = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFarmerCNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFruitName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalePerStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchCNIC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTradeNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridFruit
            // 
            this.datagridFruit.AllowUserToAddRows = false;
            this.datagridFruit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFruit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFruit.Location = new System.Drawing.Point(12, 251);
            this.datagridFruit.MultiSelect = false;
            this.datagridFruit.Name = "datagridFruit";
            this.datagridFruit.ReadOnly = true;
            this.datagridFruit.RowHeadersWidth = 51;
            this.datagridFruit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFruit.Size = new System.Drawing.Size(776, 384);
            this.datagridFruit.TabIndex = 3;
            this.datagridFruit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFruit_CellClick);
            this.datagridFruit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFruit_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnSave.Location = new System.Drawing.Point(551, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnClear.Location = new System.Drawing.Point(644, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 30);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnUpdate.Location = new System.Drawing.Point(644, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "";
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.btnDelete.Location = new System.Drawing.Point(551, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farmer CNIC";
            // 
            // txtFarmerCNIC
            // 
            this.txtFarmerCNIC.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtFarmerCNIC.Location = new System.Drawing.Point(146, 27);
            this.txtFarmerCNIC.Name = "txtFarmerCNIC";
            this.txtFarmerCNIC.Size = new System.Drawing.Size(232, 26);
            this.txtFarmerCNIC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtDate.Location = new System.Drawing.Point(146, 57);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(232, 26);
            this.txtDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fruit Name";
            // 
            // txtFruitName
            // 
            this.txtFruitName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtFruitName.Location = new System.Drawing.Point(146, 92);
            this.txtFruitName.Name = "txtFruitName";
            this.txtFruitName.Size = new System.Drawing.Size(232, 26);
            this.txtFruitName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stock No.";
            // 
            // txtStockNumber
            // 
            this.txtStockNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtStockNumber.Location = new System.Drawing.Point(146, 127);
            this.txtStockNumber.Name = "txtStockNumber";
            this.txtStockNumber.Size = new System.Drawing.Size(232, 26);
            this.txtStockNumber.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sale Per Stock";
            // 
            // txtSalePerStock
            // 
            this.txtSalePerStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtSalePerStock.Location = new System.Drawing.Point(146, 165);
            this.txtSalePerStock.Name = "txtSalePerStock";
            this.txtSalePerStock.Size = new System.Drawing.Size(232, 26);
            this.txtSalePerStock.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search CNIC";
            // 
            // txtSearchCNIC
            // 
            this.txtSearchCNIC.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtSearchCNIC.Location = new System.Drawing.Point(519, 178);
            this.txtSearchCNIC.Name = "txtSearchCNIC";
            this.txtSearchCNIC.Size = new System.Drawing.Size(232, 26);
            this.txtSearchCNIC.TabIndex = 2;
            this.txtSearchCNIC.TextChanged += new System.EventHandler(this.txtSearchCNIC_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trade Number";
            // 
            // txtTradeNumber
            // 
            this.txtTradeNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.txtTradeNumber.Location = new System.Drawing.Point(146, 202);
            this.txtTradeNumber.Name = "txtTradeNumber";
            this.txtTradeNumber.Size = new System.Drawing.Size(232, 26);
            this.txtTradeNumber.TabIndex = 5;
            // 
            // Fruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 653);
            this.Controls.Add(this.txtTradeNumber);
            this.Controls.Add(this.datagridFruit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearchCNIC);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSalePerStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFarmerCNIC);
            this.Controls.Add(this.txtStockNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtFruitName);
            this.Controls.Add(this.label3);
            this.Name = "Fruits";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fruits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridFruit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFarmerCNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFruitName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalePerStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCNIC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTradeNumber;
    }
}