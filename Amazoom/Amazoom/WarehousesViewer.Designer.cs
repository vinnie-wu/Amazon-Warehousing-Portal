
namespace Amazoom
{
    partial class WarehousesViewer
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
            this.listOfWarehouse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.orderStatus = new System.Windows.Forms.Label();
            this.orderItem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.warningMessage = new System.Windows.Forms.Label();
            this.orderQuantity = new System.Windows.Forms.Label();
            this.timerWarehouses = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfWarehouse
            // 
            this.listOfWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfWarehouse.FormattingEnabled = true;
            this.listOfWarehouse.ItemHeight = 20;
            this.listOfWarehouse.Location = new System.Drawing.Point(50, 84);
            this.listOfWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listOfWarehouse.Name = "listOfWarehouse";
            this.listOfWarehouse.Size = new System.Drawing.Size(218, 244);
            this.listOfWarehouse.TabIndex = 0;
            this.listOfWarehouse.SelectedIndexChanged += new System.EventHandler(this.listOfWarehouse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search for order by ID ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(309, 202);
            this.clientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(0, 20);
            this.clientName.TabIndex = 6;
            // 
            // orderStatus
            // 
            this.orderStatus.AutoSize = true;
            this.orderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatus.Location = new System.Drawing.Point(309, 230);
            this.orderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(0, 20);
            this.orderStatus.TabIndex = 9;
            // 
            // orderItem
            // 
            this.orderItem.AutoSize = true;
            this.orderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItem.Location = new System.Drawing.Point(310, 256);
            this.orderItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderItem.Name = "orderItem";
            this.orderItem.Size = new System.Drawing.Size(0, 20);
            this.orderItem.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(442, 152);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 27);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderIdnumericUpDown
            // 
            this.orderIdnumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdnumericUpDown.Location = new System.Drawing.Point(342, 152);
            this.orderIdnumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderIdnumericUpDown.Name = "orderIdnumericUpDown";
            this.orderIdnumericUpDown.Size = new System.Drawing.Size(91, 28);
            this.orderIdnumericUpDown.TabIndex = 14;
            // 
            // warningMessage
            // 
            this.warningMessage.AutoSize = true;
            this.warningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMessage.Location = new System.Drawing.Point(313, 187);
            this.warningMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningMessage.Name = "warningMessage";
            this.warningMessage.Size = new System.Drawing.Size(0, 20);
            this.warningMessage.TabIndex = 15;
            // 
            // orderQuantity
            // 
            this.orderQuantity.AutoSize = true;
            this.orderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQuantity.Location = new System.Drawing.Point(310, 282);
            this.orderQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(0, 20);
            this.orderQuantity.TabIndex = 16;
            // 
            // timerWarehouses
            // 
            this.timerWarehouses.Enabled = true;
            this.timerWarehouses.Interval = 2000;
            this.timerWarehouses.Tick += new System.EventHandler(this.MainPageTimerEvent);
            // 
            // WarehousesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 391);
            this.Controls.Add(this.orderQuantity);
            this.Controls.Add(this.warningMessage);
            this.Controls.Add(this.orderIdnumericUpDown);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderItem);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfWarehouse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WarehousesViewer";
            this.Text = "WarehousesViewer";
            ((System.ComponentModel.ISupportInitialize)(this.orderIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label orderStatus;
        private System.Windows.Forms.Label orderItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown orderIdnumericUpDown;
        private System.Windows.Forms.Label warningMessage;
        private System.Windows.Forms.Label orderQuantity;
        private System.Windows.Forms.Timer timerWarehouses;
    }
}