
namespace Restaurant_Management_System.Presentation_Layer
{
    partial class ManageFoodMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.foodMenuListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.addTypeNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addFoodPriceTextBox = new System.Windows.Forms.TextBox();
            this.addFoodMenuTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteFoodButton = new System.Windows.Forms.Button();
            this.deleteFoodIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateFoodIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateFoodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updatePriceTextBox = new System.Windows.Forms.TextBox();
            this.updateFoodMenuTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchFoodNameTextBox = new System.Windows.Forms.TextBox();
            this.searchFoodDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodMenuListDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFoodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodMenuListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(403, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food List";
            // 
            // foodMenuListDataGridView
            // 
            this.foodMenuListDataGridView.AllowUserToAddRows = false;
            this.foodMenuListDataGridView.AllowUserToDeleteRows = false;
            this.foodMenuListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodMenuListDataGridView.Location = new System.Drawing.Point(19, 43);
            this.foodMenuListDataGridView.Name = "foodMenuListDataGridView";
            this.foodMenuListDataGridView.ReadOnly = true;
            this.foodMenuListDataGridView.RowHeadersWidth = 62;
            this.foodMenuListDataGridView.RowTemplate.Height = 28;
            this.foodMenuListDataGridView.Size = new System.Drawing.Size(541, 183);
            this.foodMenuListDataGridView.TabIndex = 0;
            this.foodMenuListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodMenuListDataGridView_CellClick);
            this.foodMenuListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodMenuListDataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addFoodButton);
            this.groupBox2.Controls.Add(this.addTypeNameComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addFoodPriceTextBox);
            this.groupBox2.Controls.Add(this.addFoodMenuTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(33, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Food";
            // 
            // addFoodButton
            // 
            this.addFoodButton.Location = new System.Drawing.Point(152, 157);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(146, 36);
            this.addFoodButton.TabIndex = 6;
            this.addFoodButton.Text = "Add";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // addTypeNameComboBox
            // 
            this.addTypeNameComboBox.FormattingEnabled = true;
            this.addTypeNameComboBox.Location = new System.Drawing.Point(152, 115);
            this.addTypeNameComboBox.Name = "addTypeNameComboBox";
            this.addTypeNameComboBox.Size = new System.Drawing.Size(146, 28);
            this.addTypeNameComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // addFoodPriceTextBox
            // 
            this.addFoodPriceTextBox.Location = new System.Drawing.Point(152, 75);
            this.addFoodPriceTextBox.Name = "addFoodPriceTextBox";
            this.addFoodPriceTextBox.Size = new System.Drawing.Size(146, 26);
            this.addFoodPriceTextBox.TabIndex = 3;
            // 
            // addFoodMenuTextBox
            // 
            this.addFoodMenuTextBox.Location = new System.Drawing.Point(152, 35);
            this.addFoodMenuTextBox.Name = "addFoodMenuTextBox";
            this.addFoodMenuTextBox.Size = new System.Drawing.Size(146, 26);
            this.addFoodMenuTextBox.TabIndex = 1;
            this.addFoodMenuTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteFoodButton);
            this.groupBox3.Controls.Add(this.deleteFoodIdTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(33, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 149);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Food";
            // 
            // deleteFoodButton
            // 
            this.deleteFoodButton.Location = new System.Drawing.Point(152, 73);
            this.deleteFoodButton.Name = "deleteFoodButton";
            this.deleteFoodButton.Size = new System.Drawing.Size(146, 36);
            this.deleteFoodButton.TabIndex = 7;
            this.deleteFoodButton.Text = "Delete";
            this.deleteFoodButton.UseVisualStyleBackColor = true;
            this.deleteFoodButton.Click += new System.EventHandler(this.deleteFoodButton_Click);
            // 
            // deleteFoodIdTextBox
            // 
            this.deleteFoodIdTextBox.Location = new System.Drawing.Point(152, 35);
            this.deleteFoodIdTextBox.Name = "deleteFoodIdTextBox";
            this.deleteFoodIdTextBox.Size = new System.Drawing.Size(146, 26);
            this.deleteFoodIdTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Food Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateFoodIdTextBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.updateButton);
            this.groupBox4.Controls.Add(this.updateFoodTypeComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.updatePriceTextBox);
            this.groupBox4.Controls.Add(this.updateFoodMenuTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(33, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 242);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Food";
            // 
            // updateFoodIdTextBox
            // 
            this.updateFoodIdTextBox.Enabled = false;
            this.updateFoodIdTextBox.Location = new System.Drawing.Point(152, 32);
            this.updateFoodIdTextBox.Name = "updateFoodIdTextBox";
            this.updateFoodIdTextBox.Size = new System.Drawing.Size(146, 26);
            this.updateFoodIdTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Food Id";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(152, 192);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 36);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Save";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateFoodTypeComboBox
            // 
            this.updateFoodTypeComboBox.FormattingEnabled = true;
            this.updateFoodTypeComboBox.Location = new System.Drawing.Point(152, 150);
            this.updateFoodTypeComboBox.Name = "updateFoodTypeComboBox";
            this.updateFoodTypeComboBox.Size = new System.Drawing.Size(146, 28);
            this.updateFoodTypeComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // updatePriceTextBox
            // 
            this.updatePriceTextBox.Location = new System.Drawing.Point(152, 110);
            this.updatePriceTextBox.Name = "updatePriceTextBox";
            this.updatePriceTextBox.Size = new System.Drawing.Size(146, 26);
            this.updatePriceTextBox.TabIndex = 3;
            // 
            // updateFoodMenuTextBox
            // 
            this.updateFoodMenuTextBox.Location = new System.Drawing.Point(152, 70);
            this.updateFoodMenuTextBox.Name = "updateFoodMenuTextBox";
            this.updateFoodMenuTextBox.Size = new System.Drawing.Size(146, 26);
            this.updateFoodMenuTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Menu";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchFoodNameTextBox);
            this.groupBox5.Controls.Add(this.searchFoodDataGridView);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(403, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(580, 284);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Menu";
            // 
            // searchFoodNameTextBox
            // 
            this.searchFoodNameTextBox.Location = new System.Drawing.Point(228, 46);
            this.searchFoodNameTextBox.Name = "searchFoodNameTextBox";
            this.searchFoodNameTextBox.Size = new System.Drawing.Size(205, 26);
            this.searchFoodNameTextBox.TabIndex = 6;
            this.searchFoodNameTextBox.TextChanged += new System.EventHandler(this.searchFoodNameTextBox_TextChanged);
            // 
            // searchFoodDataGridView
            // 
            this.searchFoodDataGridView.AllowUserToAddRows = false;
            this.searchFoodDataGridView.AllowUserToDeleteRows = false;
            this.searchFoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchFoodDataGridView.Location = new System.Drawing.Point(19, 136);
            this.searchFoodDataGridView.Name = "searchFoodDataGridView";
            this.searchFoodDataGridView.ReadOnly = true;
            this.searchFoodDataGridView.RowHeadersWidth = 62;
            this.searchFoodDataGridView.RowTemplate.Height = 28;
            this.searchFoodDataGridView.Size = new System.Drawing.Size(541, 128);
            this.searchFoodDataGridView.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Menu";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(33, 649);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 36);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 711);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageFoodMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Food Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageFoodMenu_FormClosing);
            this.Load += new System.EventHandler(this.ManageFoodMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodMenuListDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFoodDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView foodMenuListDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addFoodPriceTextBox;
        private System.Windows.Forms.TextBox addFoodMenuTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.ComboBox addTypeNameComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteFoodButton;
        private System.Windows.Forms.TextBox deleteFoodIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox updateFoodIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox updateFoodTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updatePriceTextBox;
        private System.Windows.Forms.TextBox updateFoodMenuTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox searchFoodNameTextBox;
        private System.Windows.Forms.DataGridView searchFoodDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button backButton;
    }
}