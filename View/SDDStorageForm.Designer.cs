
namespace ITWorkstationsInc.View
{
    partial class SDDStorageForm
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
            this.buttonCloseSDDAddForm = new System.Windows.Forms.Button();
            this.buttonDeleteSDDData = new System.Windows.Forms.Button();
            this.buttonEditSDDData = new System.Windows.Forms.Button();
            this.buttonAddSDDData = new System.Windows.Forms.Button();
            this.PCCaseAddGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddSDDPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAddSDD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.PCCaseAddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonCloseSDDAddForm);
            this.groupBox1.Controls.Add(this.buttonDeleteSDDData);
            this.groupBox1.Controls.Add(this.buttonEditSDDData);
            this.groupBox1.Controls.Add(this.buttonAddSDDData);
            this.groupBox1.Location = new System.Drawing.Point(44, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // buttonCloseSDDAddForm
            // 
            this.buttonCloseSDDAddForm.Location = new System.Drawing.Point(511, 50);
            this.buttonCloseSDDAddForm.Name = "buttonCloseSDDAddForm";
            this.buttonCloseSDDAddForm.Size = new System.Drawing.Size(87, 30);
            this.buttonCloseSDDAddForm.TabIndex = 3;
            this.buttonCloseSDDAddForm.Text = "Close";
            this.buttonCloseSDDAddForm.UseVisualStyleBackColor = true;
            this.buttonCloseSDDAddForm.Click += new System.EventHandler(this.buttonCloseSDDAddForm_Click);
            // 
            // buttonDeleteSDDData
            // 
            this.buttonDeleteSDDData.Location = new System.Drawing.Point(366, 50);
            this.buttonDeleteSDDData.Name = "buttonDeleteSDDData";
            this.buttonDeleteSDDData.Size = new System.Drawing.Size(87, 30);
            this.buttonDeleteSDDData.TabIndex = 2;
            this.buttonDeleteSDDData.Text = "Delete";
            this.buttonDeleteSDDData.UseVisualStyleBackColor = true;
            this.buttonDeleteSDDData.Click += new System.EventHandler(this.buttonDeleteSDDData_Click);
            // 
            // buttonEditSDDData
            // 
            this.buttonEditSDDData.Location = new System.Drawing.Point(205, 50);
            this.buttonEditSDDData.Name = "buttonEditSDDData";
            this.buttonEditSDDData.Size = new System.Drawing.Size(87, 30);
            this.buttonEditSDDData.TabIndex = 1;
            this.buttonEditSDDData.Text = "Update";
            this.buttonEditSDDData.UseVisualStyleBackColor = true;
            this.buttonEditSDDData.Click += new System.EventHandler(this.buttonEditSDDData_Click);
            // 
            // buttonAddSDDData
            // 
            this.buttonAddSDDData.Location = new System.Drawing.Point(50, 50);
            this.buttonAddSDDData.Name = "buttonAddSDDData";
            this.buttonAddSDDData.Size = new System.Drawing.Size(87, 30);
            this.buttonAddSDDData.TabIndex = 0;
            this.buttonAddSDDData.Text = "Add";
            this.buttonAddSDDData.UseVisualStyleBackColor = true;
            this.buttonAddSDDData.Click += new System.EventHandler(this.buttonAddSDDData_Click);
            // 
            // PCCaseAddGroupBox
            // 
            this.PCCaseAddGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PCCaseAddGroupBox.Controls.Add(this.label2);
            this.PCCaseAddGroupBox.Controls.Add(this.label1);
            this.PCCaseAddGroupBox.Controls.Add(this.textBoxAddSDDPrice);
            this.PCCaseAddGroupBox.Controls.Add(this.comboBoxAddSDD);
            this.PCCaseAddGroupBox.Location = new System.Drawing.Point(44, 43);
            this.PCCaseAddGroupBox.Name = "PCCaseAddGroupBox";
            this.PCCaseAddGroupBox.Size = new System.Drawing.Size(657, 232);
            this.PCCaseAddGroupBox.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU V3:";
            // 
            // textBoxAddSDDPrice
            // 
            this.textBoxAddSDDPrice.Location = new System.Drawing.Point(128, 132);
            this.textBoxAddSDDPrice.Name = "textBoxAddSDDPrice";
            this.textBoxAddSDDPrice.Size = new System.Drawing.Size(147, 23);
            this.textBoxAddSDDPrice.TabIndex = 1;
            // 
            // comboBoxAddSDD
            // 
            this.comboBoxAddSDD.FormattingEnabled = true;
            this.comboBoxAddSDD.Location = new System.Drawing.Point(128, 73);
            this.comboBoxAddSDD.Name = "comboBoxAddSDD";
            this.comboBoxAddSDD.Size = new System.Drawing.Size(441, 23);
            this.comboBoxAddSDD.TabIndex = 0;
            this.comboBoxAddSDD.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddSDD_SelectedIndexChanged);
            // 
            // SDDStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PCCaseAddGroupBox);
            this.Name = "SDDStorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDDStorageForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SDDStorageForm_FormClosed);
            this.Load += new System.EventHandler(this.SDDStorageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.PCCaseAddGroupBox.ResumeLayout(false);
            this.PCCaseAddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCloseSDDAddForm;
        private System.Windows.Forms.Button buttonDeleteSDDData;
        private System.Windows.Forms.Button buttonEditSDDData;
        private System.Windows.Forms.Button buttonAddSDDData;
        private System.Windows.Forms.GroupBox PCCaseAddGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddSDDPrice;
        private System.Windows.Forms.ComboBox comboBoxAddSDD;
    }
}