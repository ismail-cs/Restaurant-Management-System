
namespace Restaurant_Management_System.Presentation_Layer
{
    partial class ManageFoodType
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
            this.foodTypeListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addFoodTypeButton = new System.Windows.Forms.Button();
            this.addFoodTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteFoodTypeButton = new System.Windows.Forms.Button();
            this.deleteFoodTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateFoodTypeNameButton = new System.Windows.Forms.Button();
            this.updateFoodTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchFoodTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.foodTypeWiseMenuListComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.foodTypeWiseMenuListDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeListDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeWiseMenuListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodTypeListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(461, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Type List";
            // 
            // foodTypeListDataGridView
            // 
            this.foodTypeListDataGridView.AllowUserToAddRows = false;
            this.foodTypeListDataGridView.AllowUserToDeleteRows = false;
            this.foodTypeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodTypeListDataGridView.Location = new System.Drawing.Point(23, 68);
            this.foodTypeListDataGridView.Name = "foodTypeListDataGridView";
            this.foodTypeListDataGridView.ReadOnly = true;
            this.foodTypeListDataGridView.RowHeadersWidth = 62;
            this.foodTypeListDataGridView.RowTemplate.Height = 28;
            this.foodTypeListDataGridView.Size = new System.Drawing.Size(352, 206);
            this.foodTypeListDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addFoodTypeButton);
            this.groupBox2.Controls.Add(this.addFoodTypeNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Food Type";
            // 
            // addFoodTypeButton
            // 
            this.addFoodTypeButton.Location = new System.Drawing.Point(177, 92);
            this.addFoodTypeButton.Name = "addFoodTypeButton";
            this.addFoodTypeButton.Size = new System.Drawing.Size(156, 36);
            this.addFoodTypeButton.TabIndex = 2;
            this.addFoodTypeButton.Text = "Add";
            this.addFoodTypeButton.UseVisualStyleBackColor = true;
            this.addFoodTypeButton.Click += new System.EventHandler(this.addFoodTypeButton_Click);
            // 
            // addFoodTypeNameTextBox
            // 
            this.addFoodTypeNameTextBox.Location = new System.Drawing.Point(177, 46);
            this.addFoodTypeNameTextBox.Name = "addFoodTypeNameTextBox";
            this.addFoodTypeNameTextBox.Size = new System.Drawing.Size(156, 26);
            this.addFoodTypeNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Type Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteFoodTypeButton);
            this.groupBox3.Controls.Add(this.deleteFoodTypeTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(30, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Food Type";
            // 
            // deleteFoodTypeButton
            // 
            this.deleteFoodTypeButton.Location = new System.Drawing.Point(177, 89);
            this.deleteFoodTypeButton.Name = "deleteFoodTypeButton";
            this.deleteFoodTypeButton.Size = new System.Drawing.Size(156, 36);
            this.deleteFoodTypeButton.TabIndex = 2;
            this.deleteFoodTypeButton.Text = "Delete";
            this.deleteFoodTypeButton.UseVisualStyleBackColor = true;
            this.deleteFoodTypeButton.Click += new System.EventHandler(this.deleteFoodTypeButton_Click);
            // 
            // deleteFoodTypeTextBox
            // 
            this.deleteFoodTypeTextBox.Location = new System.Drawing.Point(177, 45);
            this.deleteFoodTypeTextBox.Name = "deleteFoodTypeTextBox";
            this.deleteFoodTypeTextBox.Size = new System.Drawing.Size(156, 26);
            this.deleteFoodTypeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Type Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateFoodTypeNameButton);
            this.groupBox4.Controls.Add(this.updateFoodTypeNameTextBox);
            this.groupBox4.Controls.Add(this.searchButton);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.searchFoodTypeTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(30, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 191);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Food Type";
            // 
            // updateFoodTypeNameButton
            // 
            this.updateFoodTypeNameButton.Location = new System.Drawing.Point(177, 135);
            this.updateFoodTypeNameButton.Name = "updateFoodTypeNameButton";
            this.updateFoodTypeNameButton.Size = new System.Drawing.Size(156, 36);
            this.updateFoodTypeNameButton.TabIndex = 4;
            this.updateFoodTypeNameButton.Text = "Save";
            this.updateFoodTypeNameButton.UseVisualStyleBackColor = true;
            this.updateFoodTypeNameButton.Click += new System.EventHandler(this.updateFoodTypeNameButton_Click);
            // 
            // updateFoodTypeNameTextBox
            // 
            this.updateFoodTypeNameTextBox.Location = new System.Drawing.Point(177, 87);
            this.updateFoodTypeNameTextBox.Name = "updateFoodTypeNameTextBox";
            this.updateFoodTypeNameTextBox.Size = new System.Drawing.Size(156, 26);
            this.updateFoodTypeNameTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(255, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 39);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Food Type Name";
            // 
            // searchFoodTypeTextBox
            // 
            this.searchFoodTypeTextBox.Location = new System.Drawing.Point(177, 45);
            this.searchFoodTypeTextBox.Name = "searchFoodTypeTextBox";
            this.searchFoodTypeTextBox.Size = new System.Drawing.Size(51, 26);
            this.searchFoodTypeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Food Type Id";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.foodTypeWiseMenuListComboBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.foodTypeWiseMenuListDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(461, 363);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(396, 244);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Food Type Wise Menu List";
            // 
            // foodTypeWiseMenuListComboBox
            // 
            this.foodTypeWiseMenuListComboBox.FormattingEnabled = true;
            this.foodTypeWiseMenuListComboBox.Location = new System.Drawing.Point(207, 36);
            this.foodTypeWiseMenuListComboBox.Name = "foodTypeWiseMenuListComboBox";
            this.foodTypeWiseMenuListComboBox.Size = new System.Drawing.Size(165, 28);
            this.foodTypeWiseMenuListComboBox.TabIndex = 3;
            this.foodTypeWiseMenuListComboBox.SelectedIndexChanged += new System.EventHandler(this.foodTypeWiseMenuListComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Select A Food Type";
            // 
            // foodTypeWiseMenuListDataGridView
            // 
            this.foodTypeWiseMenuListDataGridView.AllowUserToAddRows = false;
            this.foodTypeWiseMenuListDataGridView.AllowUserToDeleteRows = false;
            this.foodTypeWiseMenuListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodTypeWiseMenuListDataGridView.Location = new System.Drawing.Point(14, 77);
            this.foodTypeWiseMenuListDataGridView.Name = "foodTypeWiseMenuListDataGridView";
            this.foodTypeWiseMenuListDataGridView.ReadOnly = true;
            this.foodTypeWiseMenuListDataGridView.RowHeadersWidth = 62;
            this.foodTypeWiseMenuListDataGridView.RowTemplate.Height = 28;
            this.foodTypeWiseMenuListDataGridView.Size = new System.Drawing.Size(355, 155);
            this.foodTypeWiseMenuListDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(30, 568);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 39);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageFoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 636);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageFoodType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Type management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageFoodType_FormClosing);
            this.Load += new System.EventHandler(this.ManageFoodType_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeListDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeWiseMenuListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView foodTypeListDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addFoodTypeButton;
        private System.Windows.Forms.TextBox addFoodTypeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteFoodTypeButton;
        private System.Windows.Forms.TextBox deleteFoodTypeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button updateFoodTypeNameButton;
        private System.Windows.Forms.TextBox updateFoodTypeNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchFoodTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox foodTypeWiseMenuListComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView foodTypeWiseMenuListDataGridView;
        private System.Windows.Forms.Button backButton;
    }
}