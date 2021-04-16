
namespace ITWorkstationsInc.View
{
    partial class RAMComponentForm
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
            this.buttonCloseRAMComponentAddForm = new System.Windows.Forms.Button();
            this.buttonDeleteRAMComponentData = new System.Windows.Forms.Button();
            this.buttonEditRAMComponentData = new System.Windows.Forms.Button();
            this.buttonAddRAMComponentData = new System.Windows.Forms.Button();
            this.PCCaseAddGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddRAMComponentPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAddRAMComponent = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.PCCaseAddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonCloseRAMComponentAddForm);
            this.groupBox1.Controls.Add(this.buttonDeleteRAMComponentData);
            this.groupBox1.Controls.Add(this.buttonEditRAMComponentData);
            this.groupBox1.Controls.Add(this.buttonAddRAMComponentData);
            this.groupBox1.Location = new System.Drawing.Point(44, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // buttonCloseRAMComponentAddForm
            // 
            this.buttonCloseRAMComponentAddForm.Location = new System.Drawing.Point(511, 50);
            this.buttonCloseRAMComponentAddForm.Name = "buttonCloseRAMComponentAddForm";
            this.buttonCloseRAMComponentAddForm.Size = new System.Drawing.Size(87, 30);
            this.buttonCloseRAMComponentAddForm.TabIndex = 3;
            this.buttonCloseRAMComponentAddForm.Text = "Close";
            this.buttonCloseRAMComponentAddForm.UseVisualStyleBackColor = true;
            this.buttonCloseRAMComponentAddForm.Click += new System.EventHandler(this.buttonCloseRAMComponentAddForm_Click);
            // 
            // buttonDeleteRAMComponentData
            // 
            this.buttonDeleteRAMComponentData.Location = new System.Drawing.Point(366, 50);
            this.buttonDeleteRAMComponentData.Name = "buttonDeleteRAMComponentData";
            this.buttonDeleteRAMComponentData.Size = new System.Drawing.Size(87, 30);
            this.buttonDeleteRAMComponentData.TabIndex = 2;
            this.buttonDeleteRAMComponentData.Text = "Delete";
            this.buttonDeleteRAMComponentData.UseVisualStyleBackColor = true;
            this.buttonDeleteRAMComponentData.Click += new System.EventHandler(this.buttonDeleteRAMComponentData_Click);
            // 
            // buttonEditRAMComponentData
            // 
            this.buttonEditRAMComponentData.Location = new System.Drawing.Point(205, 50);
            this.buttonEditRAMComponentData.Name = "buttonEditRAMComponentData";
            this.buttonEditRAMComponentData.Size = new System.Drawing.Size(87, 30);
            this.buttonEditRAMComponentData.TabIndex = 1;
            this.buttonEditRAMComponentData.Text = "Update";
            this.buttonEditRAMComponentData.UseVisualStyleBackColor = true;
            this.buttonEditRAMComponentData.Click += new System.EventHandler(this.buttonEditRAMComponentData_Click);
            // 
            // buttonAddRAMComponentData
            // 
            this.buttonAddRAMComponentData.Location = new System.Drawing.Point(50, 50);
            this.buttonAddRAMComponentData.Name = "buttonAddRAMComponentData";
            this.buttonAddRAMComponentData.Size = new System.Drawing.Size(87, 30);
            this.buttonAddRAMComponentData.TabIndex = 0;
            this.buttonAddRAMComponentData.Text = "Add";
            this.buttonAddRAMComponentData.UseVisualStyleBackColor = true;
            this.buttonAddRAMComponentData.Click += new System.EventHandler(this.buttonAddRAMComponentData_Click);
            // 
            // PCCaseAddGroupBox
            // 
            this.PCCaseAddGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PCCaseAddGroupBox.Controls.Add(this.label2);
            this.PCCaseAddGroupBox.Controls.Add(this.label1);
            this.PCCaseAddGroupBox.Controls.Add(this.textBoxAddRAMComponentPrice);
            this.PCCaseAddGroupBox.Controls.Add(this.comboBoxAddRAMComponent);
            this.PCCaseAddGroupBox.Location = new System.Drawing.Point(44, 43);
            this.PCCaseAddGroupBox.Name = "PCCaseAddGroupBox";
            this.PCCaseAddGroupBox.Size = new System.Drawing.Size(657, 232);
            this.PCCaseAddGroupBox.TabIndex = 11;
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
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "RAM:";
            // 
            // textBoxAddRAMComponentPrice
            // 
            this.textBoxAddRAMComponentPrice.Location = new System.Drawing.Point(128, 132);
            this.textBoxAddRAMComponentPrice.Name = "textBoxAddRAMComponentPrice";
            this.textBoxAddRAMComponentPrice.Size = new System.Drawing.Size(147, 23);
            this.textBoxAddRAMComponentPrice.TabIndex = 1;
            // 
            // comboBoxAddRAMComponent
            // 
            this.comboBoxAddRAMComponent.FormattingEnabled = true;
            this.comboBoxAddRAMComponent.Location = new System.Drawing.Point(128, 73);
            this.comboBoxAddRAMComponent.Name = "comboBoxAddRAMComponent";
            this.comboBoxAddRAMComponent.Size = new System.Drawing.Size(441, 23);
            this.comboBoxAddRAMComponent.TabIndex = 0;
            this.comboBoxAddRAMComponent.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddRAMRAMComponent_SelectedIndexChanged);
            // 
            // RAMComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PCCaseAddGroupBox);
            this.Name = "RAMComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAMComponentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RAMComponentForm_FormClosed);
            this.Load += new System.EventHandler(this.RAMComponentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.PCCaseAddGroupBox.ResumeLayout(false);
            this.PCCaseAddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCloseRAMComponentAddForm;
        private System.Windows.Forms.Button buttonDeleteRAMComponentData;
        private System.Windows.Forms.Button buttonEditRAMComponentData;
        private System.Windows.Forms.Button buttonAddRAMComponentData;
        private System.Windows.Forms.GroupBox PCCaseAddGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddRAMComponentPrice;
        private System.Windows.Forms.ComboBox comboBoxAddRAMComponent;
    }
}