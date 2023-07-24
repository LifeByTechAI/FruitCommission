namespace FruitSoftware_SelfProject
{
    partial class Truck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truck));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearchTradeNo = new System.Windows.Forms.TextBox();
            this.txtTradeNumber = new System.Windows.Forms.TextBox();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.txtTruckNumber = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.truckDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 52);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(684, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(544, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 52);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearchTradeNo
            // 
            this.txtSearchTradeNo.Location = new System.Drawing.Point(551, 30);
            this.txtSearchTradeNo.Name = "txtSearchTradeNo";
            this.txtSearchTradeNo.Size = new System.Drawing.Size(248, 20);
            this.txtSearchTradeNo.TabIndex = 4;
            this.txtSearchTradeNo.Text = "Search Trade Number";
            this.txtSearchTradeNo.TextChanged += new System.EventHandler(this.txtSearchTradeNo_TextChanged);
            // 
            // txtTradeNumber
            // 
            this.txtTradeNumber.Location = new System.Drawing.Point(30, 30);
            this.txtTradeNumber.Name = "txtTradeNumber";
            this.txtTradeNumber.Size = new System.Drawing.Size(222, 20);
            this.txtTradeNumber.TabIndex = 6;
            this.txtTradeNumber.Text = "Trade Number";
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(258, 30);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(210, 20);
            this.txtArrivalTime.TabIndex = 7;
            this.txtArrivalTime.Text = "Arrival Time";
            // 
            // txtTruckNumber
            // 
            this.txtTruckNumber.Location = new System.Drawing.Point(30, 56);
            this.txtTruckNumber.Name = "txtTruckNumber";
            this.txtTruckNumber.Size = new System.Drawing.Size(222, 20);
            this.txtTruckNumber.TabIndex = 8;
            this.txtTruckNumber.Text = "Truck Number";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(258, 56);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(210, 20);
            this.txtRent.TabIndex = 9;
            this.txtRent.Text = "Rent";
            // 
            // truckDataGrid
            // 
            this.truckDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truckDataGrid.Location = new System.Drawing.Point(30, 92);
            this.truckDataGrid.Name = "truckDataGrid";
            this.truckDataGrid.Size = new System.Drawing.Size(438, 414);
            this.truckDataGrid.TabIndex = 10;
            this.truckDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.truckDataGrid_CellClick);
            // 
            // Truck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.truckDataGrid);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.txtTruckNumber);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.txtTradeNumber);
            this.Controls.Add(this.txtSearchTradeNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "Truck";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Truck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truckDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearchTradeNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTradeNumber;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.TextBox txtTruckNumber;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.DataGridView truckDataGrid;
    }
}