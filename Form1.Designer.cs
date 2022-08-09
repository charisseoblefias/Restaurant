
namespace WindowsFormsApp6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.MenuItemTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.TotalBillButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.QuantityListBox = new System.Windows.Forms.ListBox();
            this.MenuItemListBox = new System.Windows.Forms.ListBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(143, 48);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(122, 22);
            this.QuantityTextBox.TabIndex = 3;
            // 
            // MenuItemTextBox
            // 
            this.MenuItemTextBox.Location = new System.Drawing.Point(143, 104);
            this.MenuItemTextBox.Name = "MenuItemTextBox";
            this.MenuItemTextBox.Size = new System.Drawing.Size(122, 22);
            this.MenuItemTextBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(143, 157);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(122, 22);
            this.PriceTextBox.TabIndex = 5;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(291, 48);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(85, 32);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // TotalBillButton
            // 
            this.TotalBillButton.Location = new System.Drawing.Point(291, 102);
            this.TotalBillButton.Name = "TotalBillButton";
            this.TotalBillButton.Size = new System.Drawing.Size(85, 31);
            this.TotalBillButton.TabIndex = 7;
            this.TotalBillButton.Text = "Total Bill";
            this.TotalBillButton.UseVisualStyleBackColor = true;
            this.TotalBillButton.Click += new System.EventHandler(this.TotalBillButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Menu Item:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Cost: ";
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Enabled = false;
            this.TotalCostTextBox.Location = new System.Drawing.Point(291, 410);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.Size = new System.Drawing.Size(103, 22);
            this.TotalCostTextBox.TabIndex = 15;
            // 
            // QuantityListBox
            // 
            this.QuantityListBox.FormattingEnabled = true;
            this.QuantityListBox.ItemHeight = 16;
            this.QuantityListBox.Location = new System.Drawing.Point(41, 268);
            this.QuantityListBox.Name = "QuantityListBox";
            this.QuantityListBox.Size = new System.Drawing.Size(98, 100);
            this.QuantityListBox.TabIndex = 16;
            // 
            // MenuItemListBox
            // 
            this.MenuItemListBox.FormattingEnabled = true;
            this.MenuItemListBox.ItemHeight = 16;
            this.MenuItemListBox.Location = new System.Drawing.Point(157, 268);
            this.MenuItemListBox.Name = "MenuItemListBox";
            this.MenuItemListBox.Size = new System.Drawing.Size(108, 100);
            this.MenuItemListBox.TabIndex = 17;
            // 
            // PriceListBox
            // 
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 16;
            this.PriceListBox.Location = new System.Drawing.Point(282, 268);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(103, 100);
            this.PriceListBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 462);
            this.Controls.Add(this.PriceListBox);
            this.Controls.Add(this.MenuItemListBox);
            this.Controls.Add(this.QuantityListBox);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalBillButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.MenuItemTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox MenuItemTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button TotalBillButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalCostTextBox;
        private System.Windows.Forms.ListBox QuantityListBox;
        private System.Windows.Forms.ListBox MenuItemListBox;
        private System.Windows.Forms.ListBox PriceListBox;
    }
}

