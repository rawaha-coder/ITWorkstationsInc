
namespace ITWorkstationsInc.View
{
    partial class HDDStorageForm
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
            this.buttonCloseHDDAddForm = new System.Windows.Forms.Button();
            this.buttonDeleteHDDData = new System.Windows.Forms.Button();
            this.buttonEditHDDData = new System.Windows.Forms.Button();
            this.buttonAddHDDData = new System.Windows.Forms.Button();
            this.PCCaseAddGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddHDDPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAddHDD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.PCCaseAddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonCloseHDDAddForm);
            this.groupBox1.Controls.Add(this.buttonDeleteHDDData);
            this.groupBox1.Controls.Add(this.buttonEditHDDData);
            this.groupBox1.Controls.Add(this.buttonAddHDDData);
            this.groupBox1.Location = new System.Drawing.Point(44, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonCloseHDDAddForm
            // 
            this.buttonCloseHDDAddForm.Location = new System.Drawing.Point(511, 50);
            this.buttonCloseHDDAddForm.Name = "buttonCloseHDDAddForm";
            this.buttonCloseHDDAddForm.Size = new System.Drawing.Size(87, 30);
            this.buttonCloseHDDAddForm.TabIndex = 3;
            this.buttonCloseHDDAddForm.Text = "Close";
            this.buttonCloseHDDAddForm.UseVisualStyleBackColor = true;
            this.buttonCloseHDDAddForm.Click += new System.EventHandler(this.buttonCloseHDDAddForm_Click);
            // 
            // buttonDeleteHDDData
            // 
            this.buttonDeleteHDDData.Location = new System.Drawing.Point(366, 50);
            this.buttonDeleteHDDData.Name = "buttonDeleteHDDData";
            this.buttonDeleteHDDData.Size = new System.Drawing.Size(87, 30);
            this.buttonDeleteHDDData.TabIndex = 2;
            this.buttonDeleteHDDData.Text = "Delete";
            this.buttonDeleteHDDData.UseVisualStyleBackColor = true;
            this.buttonDeleteHDDData.Click += new System.EventHandler(this.buttonDeleteHDDData_Click);
            // 
            // buttonEditHDDData
            // 
            this.buttonEditHDDData.Location = new System.Drawing.Point(205, 50);
            this.buttonEditHDDData.Name = "buttonEditHDDData";
            this.buttonEditHDDData.Size = new System.Drawing.Size(87, 30);
            this.buttonEditHDDData.TabIndex = 1;
            this.buttonEditHDDData.Text = "Update";
            this.buttonEditHDDData.UseVisualStyleBackColor = true;
            this.buttonEditHDDData.Click += new System.EventHandler(this.buttonEditHDDData_Click);
            // 
            // buttonAddHDDData
            // 
            this.buttonAddHDDData.Location = new System.Drawing.Point(50, 50);
            this.buttonAddHDDData.Name = "buttonAddHDDData";
            this.buttonAddHDDData.Size = new System.Drawing.Size(87, 30);
            this.buttonAddHDDData.TabIndex = 0;
            this.buttonAddHDDData.Text = "Add";
            this.buttonAddHDDData.UseVisualStyleBackColor = true;
            this.buttonAddHDDData.Click += new System.EventHandler(this.buttonAddHDDData_Click);
            // 
            // PCCaseAddGroupBox
            // 
            this.PCCaseAddGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PCCaseAddGroupBox.Controls.Add(this.label2);
            this.PCCaseAddGroupBox.Controls.Add(this.label1);
            this.PCCaseAddGroupBox.Controls.Add(this.textBoxAddHDDPrice);
            this.PCCaseAddGroupBox.Controls.Add(this.comboBoxAddHDD);
            this.PCCaseAddGroupBox.Location = new System.Drawing.Point(44, 43);
            this.PCCaseAddGroupBox.Name = "PCCaseAddGroupBox";
            this.PCCaseAddGroupBox.Size = new System.Drawing.Size(657, 232);
            this.PCCaseAddGroupBox.TabIndex = 9;
            this.PCCaseAddGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "HDD:";
            // 
            // textBoxAddHDDPrice
            // 
            this.textBoxAddHDDPrice.Location = new System.Drawing.Point(128, 132);
            this.textBoxAddHDDPrice.Name = "textBoxAddHDDPrice";
            this.textBoxAddHDDPrice.Size = new System.Drawing.Size(147, 23);
            this.textBoxAddHDDPrice.TabIndex = 1;
            // 
            // comboBoxAddHDD
            // 
            this.comboBoxAddHDD.FormattingEnabled = true;
            this.comboBoxAddHDD.Location = new System.Drawing.Point(128, 73);
            this.comboBoxAddHDD.Name = "comboBoxAddHDD";
            this.comboBoxAddHDD.Size = new System.Drawing.Size(441, 23);
            this.comboBoxAddHDD.TabIndex = 0;
            this.comboBoxAddHDD.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddHDD_SelectedIndexChanged);
            // 
            // HDDStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PCCaseAddGroupBox);
            this.Name = "HDDStorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDDStorageForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HDDStorageForm_FormClosed);
            this.Load += new System.EventHandler(this.HDDStorageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.PCCaseAddGroupBox.ResumeLayout(false);
            this.PCCaseAddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCloseHDDAddForm;
        private System.Windows.Forms.Button buttonDeleteHDDData;
        private System.Windows.Forms.Button buttonEditHDDData;
        private System.Windows.Forms.Button buttonAddHDDData;
        private System.Windows.Forms.GroupBox PCCaseAddGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddHDDPrice;
        private System.Windows.Forms.ComboBox comboBoxAddHDD;
    }
}