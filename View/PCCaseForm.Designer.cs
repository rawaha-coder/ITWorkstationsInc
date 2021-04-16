
namespace ITWorkstationsInc.View
{
    partial class PCCaseForm
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
            this.buttonClosePCCaseAddForm = new System.Windows.Forms.Button();
            this.buttonDeletePCCaseData = new System.Windows.Forms.Button();
            this.buttonEditPCCaseData = new System.Windows.Forms.Button();
            this.buttonAddPCCaseData = new System.Windows.Forms.Button();
            this.PCCaseAddGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddPCCasePrice = new System.Windows.Forms.TextBox();
            this.comboBoxAddPCCase = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.PCCaseAddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonClosePCCaseAddForm);
            this.groupBox1.Controls.Add(this.buttonDeletePCCaseData);
            this.groupBox1.Controls.Add(this.buttonEditPCCaseData);
            this.groupBox1.Controls.Add(this.buttonAddPCCaseData);
            this.groupBox1.Location = new System.Drawing.Point(36, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonClosePCCaseAddForm
            // 
            this.buttonClosePCCaseAddForm.Location = new System.Drawing.Point(511, 50);
            this.buttonClosePCCaseAddForm.Name = "buttonClosePCCaseAddForm";
            this.buttonClosePCCaseAddForm.Size = new System.Drawing.Size(87, 30);
            this.buttonClosePCCaseAddForm.TabIndex = 3;
            this.buttonClosePCCaseAddForm.Text = "Close";
            this.buttonClosePCCaseAddForm.UseVisualStyleBackColor = true;
            this.buttonClosePCCaseAddForm.Click += new System.EventHandler(this.buttonPCCaseAddForm_Click);
            // 
            // buttonDeletePCCaseData
            // 
            this.buttonDeletePCCaseData.Location = new System.Drawing.Point(366, 50);
            this.buttonDeletePCCaseData.Name = "buttonDeletePCCaseData";
            this.buttonDeletePCCaseData.Size = new System.Drawing.Size(87, 30);
            this.buttonDeletePCCaseData.TabIndex = 2;
            this.buttonDeletePCCaseData.Text = "Delete";
            this.buttonDeletePCCaseData.UseVisualStyleBackColor = true;
            this.buttonDeletePCCaseData.Click += new System.EventHandler(this.buttonDeletePCCaseData_Click);
            // 
            // buttonEditPCCaseData
            // 
            this.buttonEditPCCaseData.Location = new System.Drawing.Point(205, 50);
            this.buttonEditPCCaseData.Name = "buttonEditPCCaseData";
            this.buttonEditPCCaseData.Size = new System.Drawing.Size(87, 30);
            this.buttonEditPCCaseData.TabIndex = 1;
            this.buttonEditPCCaseData.Text = "Update";
            this.buttonEditPCCaseData.UseVisualStyleBackColor = true;
            this.buttonEditPCCaseData.Click += new System.EventHandler(this.buttonEditPCCaseData_Click);
            // 
            // buttonAddPCCaseData
            // 
            this.buttonAddPCCaseData.Location = new System.Drawing.Point(50, 50);
            this.buttonAddPCCaseData.Name = "buttonAddPCCaseData";
            this.buttonAddPCCaseData.Size = new System.Drawing.Size(87, 30);
            this.buttonAddPCCaseData.TabIndex = 0;
            this.buttonAddPCCaseData.Text = "Add";
            this.buttonAddPCCaseData.UseVisualStyleBackColor = true;
            this.buttonAddPCCaseData.Click += new System.EventHandler(this.buttonAddPCCaseData_Click);
            // 
            // PCCaseAddGroupBox
            // 
            this.PCCaseAddGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PCCaseAddGroupBox.Controls.Add(this.label2);
            this.PCCaseAddGroupBox.Controls.Add(this.label1);
            this.PCCaseAddGroupBox.Controls.Add(this.textBoxAddPCCasePrice);
            this.PCCaseAddGroupBox.Controls.Add(this.comboBoxAddPCCase);
            this.PCCaseAddGroupBox.Location = new System.Drawing.Point(36, 44);
            this.PCCaseAddGroupBox.Name = "PCCaseAddGroupBox";
            this.PCCaseAddGroupBox.Size = new System.Drawing.Size(657, 232);
            this.PCCaseAddGroupBox.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "PC:";
            // 
            // textBoxAddPCCasePrice
            // 
            this.textBoxAddPCCasePrice.Location = new System.Drawing.Point(128, 132);
            this.textBoxAddPCCasePrice.Name = "textBoxAddPCCasePrice";
            this.textBoxAddPCCasePrice.Size = new System.Drawing.Size(147, 23);
            this.textBoxAddPCCasePrice.TabIndex = 1;
            // 
            // comboBoxAddPCCase
            // 
            this.comboBoxAddPCCase.FormattingEnabled = true;
            this.comboBoxAddPCCase.Location = new System.Drawing.Point(128, 73);
            this.comboBoxAddPCCase.Name = "comboBoxAddPCCase";
            this.comboBoxAddPCCase.Size = new System.Drawing.Size(441, 23);
            this.comboBoxAddPCCase.TabIndex = 0;
            this.comboBoxAddPCCase.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddPCCase_SelectedIndexChanged);
            // 
            // PCCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PCCaseAddGroupBox);
            this.Name = "PCCaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCCaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PCCaseForm_FormClosed);
            this.Load += new System.EventHandler(this.PCCaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.PCCaseAddGroupBox.ResumeLayout(false);
            this.PCCaseAddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClosePCCaseAddForm;
        private System.Windows.Forms.Button buttonDeletePCCaseData;
        private System.Windows.Forms.Button buttonEditPCCaseData;
        private System.Windows.Forms.Button buttonAddPCCaseData;
        private System.Windows.Forms.GroupBox PCCaseAddGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddPCCasePrice;
        private System.Windows.Forms.ComboBox comboBoxAddPCCase;
    }
}