
namespace CarStoreFormGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create_button = new System.Windows.Forms.Button();
            this.Create_groupBox = new System.Windows.Forms.GroupBox();
            this.CC_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.brand_label = new System.Windows.Forms.Label();
            this.Condition_checkBox = new System.Windows.Forms.CheckBox();
            this.Colour_textBox = new System.Windows.Forms.TextBox();
            this.Engine_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.Make_textBox = new System.Windows.Forms.TextBox();
            this.Condition_label = new System.Windows.Forms.Label();
            this.Colour_label = new System.Windows.Forms.Label();
            this.Engine_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Model_label = new System.Windows.Forms.Label();
            this.Make_label = new System.Windows.Forms.Label();
            this.Inventory_groupBox = new System.Windows.Forms.GroupBox();
            this.Inventory_listBox = new System.Windows.Forms.ListBox();
            this.CheckOut_groupBox = new System.Windows.Forms.GroupBox();
            this.CheckOut_listBox = new System.Windows.Forms.ListBox();
            this.Inventory_button = new System.Windows.Forms.Button();
            this.CheckOut_button = new System.Windows.Forms.Button();
            this.TotalCost_label = new System.Windows.Forms.Label();
            this.Currency_label = new System.Windows.Forms.Label();
            this.Create_groupBox.SuspendLayout();
            this.Inventory_groupBox.SuspendLayout();
            this.CheckOut_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(85, 335);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(96, 23);
            this.Create_button.TabIndex = 0;
            this.Create_button.Text = "Create a car";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Create_groupBox
            // 
            this.Create_groupBox.Controls.Add(this.CC_label);
            this.Create_groupBox.Controls.Add(this.type_label);
            this.Create_groupBox.Controls.Add(this.brand_label);
            this.Create_groupBox.Controls.Add(this.Condition_checkBox);
            this.Create_groupBox.Controls.Add(this.Colour_textBox);
            this.Create_groupBox.Controls.Add(this.Engine_textBox);
            this.Create_groupBox.Controls.Add(this.Price_textBox);
            this.Create_groupBox.Controls.Add(this.Model_textBox);
            this.Create_groupBox.Controls.Add(this.Make_textBox);
            this.Create_groupBox.Controls.Add(this.Condition_label);
            this.Create_groupBox.Controls.Add(this.Colour_label);
            this.Create_groupBox.Controls.Add(this.Engine_label);
            this.Create_groupBox.Controls.Add(this.Price_label);
            this.Create_groupBox.Controls.Add(this.Model_label);
            this.Create_groupBox.Controls.Add(this.Make_label);
            this.Create_groupBox.Controls.Add(this.Create_button);
            this.Create_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Create_groupBox.Name = "Create_groupBox";
            this.Create_groupBox.Size = new System.Drawing.Size(270, 426);
            this.Create_groupBox.TabIndex = 1;
            this.Create_groupBox.TabStop = false;
            this.Create_groupBox.Text = "CREATE A CAR: ";
            // 
            // CC_label
            // 
            this.CC_label.AutoSize = true;
            this.CC_label.Location = new System.Drawing.Point(160, 130);
            this.CC_label.Name = "CC_label";
            this.CC_label.Size = new System.Drawing.Size(41, 15);
            this.CC_label.TabIndex = 15;
            this.CC_label.Text = "eg 1,4 ";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(160, 56);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(100, 15);
            this.type_label.TabIndex = 14;
            this.type_label.Text = "eg yaris, runX, etc";
            // 
            // brand_label
            // 
            this.brand_label.AutoSize = true;
            this.brand_label.Location = new System.Drawing.Point(160, 22);
            this.brand_label.Name = "brand_label";
            this.brand_label.Size = new System.Drawing.Size(79, 15);
            this.brand_label.TabIndex = 13;
            this.brand_label.Text = "Manufacturer";
            // 
            // Condition_checkBox
            // 
            this.Condition_checkBox.AutoSize = true;
            this.Condition_checkBox.Location = new System.Drawing.Point(85, 203);
            this.Condition_checkBox.Name = "Condition_checkBox";
            this.Condition_checkBox.Size = new System.Drawing.Size(69, 19);
            this.Condition_checkBox.TabIndex = 12;
            this.Condition_checkBox.Text = "New car";
            this.Condition_checkBox.UseVisualStyleBackColor = true;
            // 
            // Colour_textBox
            // 
            this.Colour_textBox.Location = new System.Drawing.Point(54, 164);
            this.Colour_textBox.Name = "Colour_textBox";
            this.Colour_textBox.Size = new System.Drawing.Size(100, 23);
            this.Colour_textBox.TabIndex = 11;
            // 
            // Engine_textBox
            // 
            this.Engine_textBox.Location = new System.Drawing.Point(54, 127);
            this.Engine_textBox.Name = "Engine_textBox";
            this.Engine_textBox.Size = new System.Drawing.Size(100, 23);
            this.Engine_textBox.TabIndex = 10;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(54, 90);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(100, 23);
            this.Price_textBox.TabIndex = 9;
            // 
            // Model_textBox
            // 
            this.Model_textBox.Location = new System.Drawing.Point(54, 53);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.Size = new System.Drawing.Size(100, 23);
            this.Model_textBox.TabIndex = 8;
            // 
            // Make_textBox
            // 
            this.Make_textBox.Location = new System.Drawing.Point(54, 18);
            this.Make_textBox.Name = "Make_textBox";
            this.Make_textBox.Size = new System.Drawing.Size(100, 23);
            this.Make_textBox.TabIndex = 7;
            // 
            // Condition_label
            // 
            this.Condition_label.AutoSize = true;
            this.Condition_label.Location = new System.Drawing.Point(6, 204);
            this.Condition_label.Name = "Condition_label";
            this.Condition_label.Size = new System.Drawing.Size(63, 15);
            this.Condition_label.TabIndex = 6;
            this.Condition_label.Text = "Condition:";
            // 
            // Colour_label
            // 
            this.Colour_label.AutoSize = true;
            this.Colour_label.Location = new System.Drawing.Point(6, 167);
            this.Colour_label.Name = "Colour_label";
            this.Colour_label.Size = new System.Drawing.Size(46, 15);
            this.Colour_label.TabIndex = 5;
            this.Colour_label.Text = "Colour:";
            // 
            // Engine_label
            // 
            this.Engine_label.AutoSize = true;
            this.Engine_label.Location = new System.Drawing.Point(6, 130);
            this.Engine_label.Name = "Engine_label";
            this.Engine_label.Size = new System.Drawing.Size(46, 15);
            this.Engine_label.TabIndex = 4;
            this.Engine_label.Text = "Engine:";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(6, 93);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(36, 15);
            this.Price_label.TabIndex = 3;
            this.Price_label.Text = "Price:";
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.Location = new System.Drawing.Point(6, 56);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(44, 15);
            this.Model_label.TabIndex = 2;
            this.Model_label.Text = "Model:";
            // 
            // Make_label
            // 
            this.Make_label.AutoSize = true;
            this.Make_label.Location = new System.Drawing.Point(6, 22);
            this.Make_label.Name = "Make_label";
            this.Make_label.Size = new System.Drawing.Size(39, 15);
            this.Make_label.TabIndex = 1;
            this.Make_label.Text = "Make:";
            // 
            // Inventory_groupBox
            // 
            this.Inventory_groupBox.Controls.Add(this.Inventory_listBox);
            this.Inventory_groupBox.Location = new System.Drawing.Point(288, 12);
            this.Inventory_groupBox.Name = "Inventory_groupBox";
            this.Inventory_groupBox.Size = new System.Drawing.Size(440, 426);
            this.Inventory_groupBox.TabIndex = 2;
            this.Inventory_groupBox.TabStop = false;
            this.Inventory_groupBox.Text = "INVENTORY:";
            // 
            // Inventory_listBox
            // 
            this.Inventory_listBox.FormattingEnabled = true;
            this.Inventory_listBox.ItemHeight = 15;
            this.Inventory_listBox.Location = new System.Drawing.Point(6, 22);
            this.Inventory_listBox.Name = "Inventory_listBox";
            this.Inventory_listBox.Size = new System.Drawing.Size(445, 394);
            this.Inventory_listBox.TabIndex = 0;
            // 
            // CheckOut_groupBox
            // 
            this.CheckOut_groupBox.Controls.Add(this.CheckOut_listBox);
            this.CheckOut_groupBox.Location = new System.Drawing.Point(735, 12);
            this.CheckOut_groupBox.Name = "CheckOut_groupBox";
            this.CheckOut_groupBox.Size = new System.Drawing.Size(440, 426);
            this.CheckOut_groupBox.TabIndex = 3;
            this.CheckOut_groupBox.TabStop = false;
            this.CheckOut_groupBox.Text = "CHECK OUT:";
            // 
            // CheckOut_listBox
            // 
            this.CheckOut_listBox.FormattingEnabled = true;
            this.CheckOut_listBox.ItemHeight = 15;
            this.CheckOut_listBox.Location = new System.Drawing.Point(6, 22);
            this.CheckOut_listBox.Name = "CheckOut_listBox";
            this.CheckOut_listBox.Size = new System.Drawing.Size(428, 394);
            this.CheckOut_listBox.TabIndex = 0;
            // 
            // Inventory_button
            // 
            this.Inventory_button.Location = new System.Drawing.Point(481, 456);
            this.Inventory_button.Name = "Inventory_button";
            this.Inventory_button.Size = new System.Drawing.Size(75, 23);
            this.Inventory_button.TabIndex = 0;
            this.Inventory_button.Text = "Add to cart";
            this.Inventory_button.UseVisualStyleBackColor = true;
            this.Inventory_button.Click += new System.EventHandler(this.Inventory_button_Click);
            // 
            // CheckOut_button
            // 
            this.CheckOut_button.Location = new System.Drawing.Point(925, 488);
            this.CheckOut_button.Name = "CheckOut_button";
            this.CheckOut_button.Size = new System.Drawing.Size(75, 23);
            this.CheckOut_button.TabIndex = 4;
            this.CheckOut_button.Text = "Purchase";
            this.CheckOut_button.UseVisualStyleBackColor = true;
            this.CheckOut_button.Click += new System.EventHandler(this.CheckOut_button_Click);
            // 
            // TotalCost_label
            // 
            this.TotalCost_label.AutoSize = true;
            this.TotalCost_label.Location = new System.Drawing.Point(908, 446);
            this.TotalCost_label.Name = "TotalCost_label";
            this.TotalCost_label.Size = new System.Drawing.Size(62, 15);
            this.TotalCost_label.TabIndex = 5;
            this.TotalCost_label.Text = "Total Cost:";
            // 
            // Currency_label
            // 
            this.Currency_label.AutoSize = true;
            this.Currency_label.Location = new System.Drawing.Point(976, 446);
            this.Currency_label.Name = "Currency_label";
            this.Currency_label.Size = new System.Drawing.Size(35, 15);
            this.Currency_label.TabIndex = 6;
            this.Currency_label.Text = "R0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 561);
            this.Controls.Add(this.Currency_label);
            this.Controls.Add(this.TotalCost_label);
            this.Controls.Add(this.CheckOut_button);
            this.Controls.Add(this.Inventory_button);
            this.Controls.Add(this.CheckOut_groupBox);
            this.Controls.Add(this.Inventory_groupBox);
            this.Controls.Add(this.Create_groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Create_groupBox.ResumeLayout(false);
            this.Create_groupBox.PerformLayout();
            this.Inventory_groupBox.ResumeLayout(false);
            this.CheckOut_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.GroupBox Create_groupBox;
        private System.Windows.Forms.TextBox Colour_textBox;
        private System.Windows.Forms.TextBox Engine_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Model_textBox;
        private System.Windows.Forms.TextBox Make_textBox;
        private System.Windows.Forms.Label Condition_label;
        private System.Windows.Forms.Label Colour_label;
        private System.Windows.Forms.Label Engine_label;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.Label Make_label;
        private System.Windows.Forms.GroupBox Inventory_groupBox;
        private System.Windows.Forms.ListBox Inventory_listBox;
        private System.Windows.Forms.GroupBox CheckOut_groupBox;
        private System.Windows.Forms.ListBox CheckOut_listBox;
        private System.Windows.Forms.Button Inventory_button;
        private System.Windows.Forms.Button CheckOut_button;
        private System.Windows.Forms.Label TotalCost_label;
        private System.Windows.Forms.Label Currency_label;
        private System.Windows.Forms.CheckBox Condition_checkBox;
        private System.Windows.Forms.Label CC_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label brand_label;
    }
}

