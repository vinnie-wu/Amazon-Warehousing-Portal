
namespace Amazoom
{
    partial class WarehouseViewer
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ItemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberRestockItem = new System.Windows.Forms.NumericUpDown();
            this.restockButton = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ordersOutForDelivery = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ordersWaitingForDelivery = new System.Windows.Forms.ListBox();
            this.testOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxTruckWeight = new System.Windows.Forms.NumericUpDown();
            this.deliveryButton = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.Label();
            this.itemPosition = new System.Windows.Forms.Label();
            this.addRobot = new System.Windows.Forms.Button();
            this.removeRobot = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.removeItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.qtyUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.weightUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.rightOrLeftBox = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.ItemsName = new System.Windows.Forms.RichTextBox();
            this.warehouseWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberRestockItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTruckWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Location = new System.Drawing.Point(24, 26);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(587, 565);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDraw);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.MainSimTimerEvent);
            // 
            // ItemList
            // 
            this.ItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 16;
            this.ItemList.Location = new System.Drawing.Point(640, 55);
            this.ItemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(150, 164);
            this.ItemList.TabIndex = 1;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items in stock";
            // 
            // numberOfItems
            // 
            this.numberOfItems.AutoSize = true;
            this.numberOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfItems.Location = new System.Drawing.Point(791, 103);
            this.numberOfItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfItems.Name = "numberOfItems";
            this.numberOfItems.Size = new System.Drawing.Size(122, 18);
            this.numberOfItems.TabIndex = 3;
            this.numberOfItems.Text = "Number of Items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(791, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restock Item";
            // 
            // numberRestockItem
            // 
            this.numberRestockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRestockItem.Location = new System.Drawing.Point(914, 129);
            this.numberRestockItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberRestockItem.Name = "numberRestockItem";
            this.numberRestockItem.Size = new System.Drawing.Size(60, 26);
            this.numberRestockItem.TabIndex = 5;
            this.numberRestockItem.ValueChanged += new System.EventHandler(this.numberRestockItem_ValueChanged);
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(812, 163);
            this.restockButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(162, 23);
            this.restockButton.TabIndex = 6;
            this.restockButton.Text = "Restock Item";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(919, 15);
            this.refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(60, 27);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Orders Waiting";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ordersOutForDelivery
            // 
            this.ordersOutForDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersOutForDelivery.FormattingEnabled = true;
            this.ordersOutForDelivery.ItemHeight = 20;
            this.ordersOutForDelivery.Location = new System.Drawing.Point(982, 454);
            this.ordersOutForDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ordersOutForDelivery.Name = "ordersOutForDelivery";
            this.ordersOutForDelivery.Size = new System.Drawing.Size(148, 124);
            this.ordersOutForDelivery.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(662, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "for delivery";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(996, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Orders Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(996, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "for delivery";
            // 
            // ordersWaitingForDelivery
            // 
            this.ordersWaitingForDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersWaitingForDelivery.FormattingEnabled = true;
            this.ordersWaitingForDelivery.ItemHeight = 20;
            this.ordersWaitingForDelivery.Location = new System.Drawing.Point(651, 454);
            this.ordersWaitingForDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ordersWaitingForDelivery.Name = "ordersWaitingForDelivery";
            this.ordersWaitingForDelivery.Size = new System.Drawing.Size(148, 124);
            this.ordersWaitingForDelivery.TabIndex = 15;
            // 
            // testOrder
            // 
            this.testOrder.Location = new System.Drawing.Point(1000, 225);
            this.testOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testOrder.Name = "testOrder";
            this.testOrder.Size = new System.Drawing.Size(120, 22);
            this.testOrder.TabIndex = 16;
            this.testOrder.Text = "Order Random Item";
            this.testOrder.UseVisualStyleBackColor = true;
            this.testOrder.Click += new System.EventHandler(this.testOrder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(810, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Delivery Truck:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(818, 484);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 40);
            this.label9.TabIndex = 18;
            this.label9.Text = "Maximum Loading \r\nWeight Kg";
            // 
            // maxTruckWeight
            // 
            this.maxTruckWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTruckWeight.Location = new System.Drawing.Point(904, 504);
            this.maxTruckWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxTruckWeight.Name = "maxTruckWeight";
            this.maxTruckWeight.Size = new System.Drawing.Size(42, 26);
            this.maxTruckWeight.TabIndex = 20;
            // 
            // deliveryButton
            // 
            this.deliveryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryButton.Location = new System.Drawing.Point(852, 536);
            this.deliveryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(82, 37);
            this.deliveryButton.TabIndex = 21;
            this.deliveryButton.Text = "Delivery Items";
            this.deliveryButton.UseVisualStyleBackColor = true;
            this.deliveryButton.Click += new System.EventHandler(this.deliveryButton_Click);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(791, 55);
            this.itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(52, 18);
            this.itemName.TabIndex = 22;
            this.itemName.Text = "Name:";
            // 
            // itemPosition
            // 
            this.itemPosition.AutoSize = true;
            this.itemPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPosition.Location = new System.Drawing.Point(792, 77);
            this.itemPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemPosition.Name = "itemPosition";
            this.itemPosition.Size = new System.Drawing.Size(66, 18);
            this.itemPosition.TabIndex = 23;
            this.itemPosition.Text = "Position:";
            // 
            // addRobot
            // 
            this.addRobot.Location = new System.Drawing.Point(1024, 135);
            this.addRobot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRobot.Name = "addRobot";
            this.addRobot.Size = new System.Drawing.Size(78, 34);
            this.addRobot.TabIndex = 25;
            this.addRobot.Text = "Add Robot";
            this.addRobot.UseVisualStyleBackColor = true;
            this.addRobot.Click += new System.EventHandler(this.addRobot_Click);
            // 
            // removeRobot
            // 
            this.removeRobot.Location = new System.Drawing.Point(1024, 178);
            this.removeRobot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeRobot.Name = "removeRobot";
            this.removeRobot.Size = new System.Drawing.Size(78, 34);
            this.removeRobot.TabIndex = 26;
            this.removeRobot.Text = "Remove Robot";
            this.removeRobot.UseVisualStyleBackColor = true;
            this.removeRobot.Click += new System.EventHandler(this.removeRobot_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(860, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 27;
            this.label10.Text = "Add Item";
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(812, 196);
            this.removeItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(162, 23);
            this.removeItem.TabIndex = 28;
            this.removeItem.Text = "Remove Item";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(699, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quantity";
            // 
            // qtyUpAndDown
            // 
            this.qtyUpAndDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyUpAndDown.Location = new System.Drawing.Point(770, 351);
            this.qtyUpAndDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qtyUpAndDown.Name = "qtyUpAndDown";
            this.qtyUpAndDown.Size = new System.Drawing.Size(60, 26);
            this.qtyUpAndDown.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(841, 354);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Weight";
            // 
            // weightUpAndDown
            // 
            this.weightUpAndDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightUpAndDown.Location = new System.Drawing.Point(903, 351);
            this.weightUpAndDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightUpAndDown.Name = "weightUpAndDown";
            this.weightUpAndDown.Size = new System.Drawing.Size(54, 26);
            this.weightUpAndDown.TabIndex = 34;
            // 
            // rightOrLeftBox
            // 
            this.rightOrLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOrLeftBox.FormattingEnabled = true;
            this.rightOrLeftBox.ItemHeight = 20;
            this.rightOrLeftBox.Items.AddRange(new object[] {
            "Right",
            "Left"});
            this.rightOrLeftBox.Location = new System.Drawing.Point(982, 351);
            this.rightOrLeftBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightOrLeftBox.Name = "rightOrLeftBox";
            this.rightOrLeftBox.Size = new System.Drawing.Size(56, 44);
            this.rightOrLeftBox.TabIndex = 35;
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(1024, 297);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(78, 34);
            this.addItemButton.TabIndex = 36;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // ItemsName
            // 
            this.ItemsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsName.Location = new System.Drawing.Point(709, 297);
            this.ItemsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsName.Name = "ItemsName";
            this.ItemsName.Size = new System.Drawing.Size(302, 32);
            this.ItemsName.TabIndex = 30;
            this.ItemsName.Text = "Item\'s Name";
            this.ItemsName.TextChanged += new System.EventHandler(this.ItemsName_TextChanged);
            // 
            // warehouseWarning
            // 
            this.warehouseWarning.AutoSize = true;
            this.warehouseWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseWarning.Location = new System.Drawing.Point(716, 225);
            this.warehouseWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warehouseWarning.Name = "warehouseWarning";
            this.warehouseWarning.Size = new System.Drawing.Size(0, 20);
            this.warehouseWarning.TabIndex = 37;
            // 
            // WarehouseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 634);
            this.Controls.Add(this.warehouseWarning);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.rightOrLeftBox);
            this.Controls.Add(this.weightUpAndDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.qtyUpAndDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ItemsName);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.removeRobot);
            this.Controls.Add(this.addRobot);
            this.Controls.Add(this.itemPosition);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.deliveryButton);
            this.Controls.Add(this.maxTruckWeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.testOrder);
            this.Controls.Add(this.ordersWaitingForDelivery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ordersOutForDelivery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.numberRestockItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WarehouseViewer";
            this.Text = "Warehouse Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosedManually);
            this.Load += new System.EventHandler(this.WarehouseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberRestockItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTruckWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberRestockItem;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button testOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxTruckWeight;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemPosition;
        public System.Windows.Forms.ListBox ordersWaitingForDelivery;
        private System.Windows.Forms.Button addRobot;
        private System.Windows.Forms.Button removeRobot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown qtyUpAndDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown weightUpAndDown;
        private System.Windows.Forms.ListBox rightOrLeftBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.RichTextBox ItemsName;
        private System.Windows.Forms.Label warehouseWarning;
        public System.Windows.Forms.ListBox ordersOutForDelivery;
    }
}

