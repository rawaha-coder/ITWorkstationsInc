
namespace ITWorkstationsInc
{
    partial class FormITWorkstation
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPCCasePrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PCCaseListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainCalculButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.ProfitComboBox = new System.Windows.Forms.ComboBox();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.txtMainResultCalcul = new System.Windows.Forms.Label();
            this.FeeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.UpdateButton = new System.Windows.Forms.PictureBox();
            this.UpdateItemContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PCCaseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CPUV2StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CPUV3StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SDDStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDDStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RAMStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NVIDIAStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateButton)).BeginInit();
            this.UpdateItemContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPCCasePrice);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.PCCaseListComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workstation Component";
            // 
            // txtPCCasePrice
            // 
            this.txtPCCasePrice.AutoSize = true;
            this.txtPCCasePrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPCCasePrice.Location = new System.Drawing.Point(552, 42);
            this.txtPCCasePrice.Name = "txtPCCasePrice";
            this.txtPCCasePrice.Size = new System.Drawing.Size(37, 23);
            this.txtPCCasePrice.TabIndex = 6;
            this.txtPCCasePrice.Text = "0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITWorkstationsInc.Properties.Resources.WorkStation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PCCaseListComboBox
            // 
            this.PCCaseListComboBox.FormattingEnabled = true;
            this.PCCaseListComboBox.Location = new System.Drawing.Point(143, 42);
            this.PCCaseListComboBox.Name = "PCCaseListComboBox";
            this.PCCaseListComboBox.Size = new System.Drawing.Size(378, 23);
            this.PCCaseListComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "PC:";
            // 
            // MainCalculButton
            // 
            this.MainCalculButton.BackColor = System.Drawing.Color.Black;
            this.MainCalculButton.FlatAppearance.BorderSize = 0;
            this.MainCalculButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainCalculButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainCalculButton.Location = new System.Drawing.Point(464, 40);
            this.MainCalculButton.Name = "MainCalculButton";
            this.MainCalculButton.Size = new System.Drawing.Size(70, 38);
            this.MainCalculButton.TabIndex = 7;
            this.MainCalculButton.Text = "OK";
            this.MainCalculButton.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProfitLabel);
            this.groupBox2.Controls.Add(this.ProfitComboBox);
            this.groupBox2.Controls.Add(this.FeeLabel);
            this.groupBox2.Controls.Add(this.txtMainResultCalcul);
            this.groupBox2.Controls.Add(this.FeeComboBox);
            this.groupBox2.Controls.Add(this.MainCalculButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 538);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcul";
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProfitLabel.Location = new System.Drawing.Point(217, 50);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(65, 23);
            this.ProfitLabel.TabIndex = 8;
            this.ProfitLabel.Text = "Profit:";
            // 
            // ProfitComboBox
            // 
            this.ProfitComboBox.FormattingEnabled = true;
            this.ProfitComboBox.Location = new System.Drawing.Point(288, 50);
            this.ProfitComboBox.Name = "ProfitComboBox";
            this.ProfitComboBox.Size = new System.Drawing.Size(111, 23);
            this.ProfitComboBox.TabIndex = 9;
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeLabel.Location = new System.Drawing.Point(33, 50);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(46, 23);
            this.FeeLabel.TabIndex = 7;
            this.FeeLabel.Text = "Fee:";
            // 
            // txtMainResultCalcul
            // 
            this.txtMainResultCalcul.AutoSize = true;
            this.txtMainResultCalcul.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainResultCalcul.Location = new System.Drawing.Point(552, 50);
            this.txtMainResultCalcul.Name = "txtMainResultCalcul";
            this.txtMainResultCalcul.Size = new System.Drawing.Size(37, 23);
            this.txtMainResultCalcul.TabIndex = 7;
            this.txtMainResultCalcul.Text = "0.0";
            // 
            // FeeComboBox
            // 
            this.FeeComboBox.FormattingEnabled = true;
            this.FeeComboBox.Location = new System.Drawing.Point(85, 50);
            this.FeeComboBox.Name = "FeeComboBox";
            this.FeeComboBox.Size = new System.Drawing.Size(85, 23);
            this.FeeComboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MainRichTextBox);
            this.panel1.Location = new System.Drawing.Point(681, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 591);
            this.panel1.TabIndex = 2;
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(-2, -2);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(491, 591);
            this.MainRichTextBox.TabIndex = 0;
            this.MainRichTextBox.Text = "";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Image = global::ITWorkstationsInc.Properties.Resources.icons8_store_setting_50;
            this.UpdateButton.Location = new System.Drawing.Point(13, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(37, 37);
            this.UpdateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.TabStop = false;
            this.UpdateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateButton_MouseClick);
            // 
            // UpdateItemContextMenuStrip
            // 
            this.UpdateItemContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PCCaseStripMenuItem,
            this.CPUV2StripMenuItem,
            this.CPUV3StripMenuItem,
            this.SDDStripMenuItem,
            this.HDDStripMenuItem,
            this.RAMStripMenuItem,
            this.NVIDIAStripMenuItem});
            this.UpdateItemContextMenuStrip.Name = "UpdateItemContextMenuStrip";
            this.UpdateItemContextMenuStrip.Size = new System.Drawing.Size(114, 158);
            this.UpdateItemContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.UpdateItemContextMenuStrip_ItemClicked);
            // 
            // PCCaseStripMenuItem
            // 
            this.PCCaseStripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.WorkStation_icon;
            this.PCCaseStripMenuItem.Name = "PCCaseStripMenuItem";
            this.PCCaseStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.PCCaseStripMenuItem.Text = "PC";
            // 
            // CPUV2StripMenuItem
            // 
            this.CPUV2StripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.cpu;
            this.CPUV2StripMenuItem.Name = "CPUV2StripMenuItem";
            this.CPUV2StripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.CPUV2StripMenuItem.Text = "CPU V2";
            // 
            // CPUV3StripMenuItem
            // 
            this.CPUV3StripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.cpu;
            this.CPUV3StripMenuItem.Name = "CPUV3StripMenuItem";
            this.CPUV3StripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.CPUV3StripMenuItem.Text = "CPU V3";
            // 
            // SDDStripMenuItem
            // 
            this.SDDStripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.sdd;
            this.SDDStripMenuItem.Name = "SDDStripMenuItem";
            this.SDDStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.SDDStripMenuItem.Text = "SDD";
            // 
            // HDDStripMenuItem
            // 
            this.HDDStripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.drive_hdd;
            this.HDDStripMenuItem.Name = "HDDStripMenuItem";
            this.HDDStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.HDDStripMenuItem.Text = "HDD";
            // 
            // RAMStripMenuItem
            // 
            this.RAMStripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.computer_ram;
            this.RAMStripMenuItem.Name = "RAMStripMenuItem";
            this.RAMStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RAMStripMenuItem.Text = "RAM";
            // 
            // NVIDIAStripMenuItem
            // 
            this.NVIDIAStripMenuItem.Image = global::ITWorkstationsInc.Properties.Resources.video_card;
            this.NVIDIAStripMenuItem.Name = "NVIDIAStripMenuItem";
            this.NVIDIAStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.NVIDIAStripMenuItem.Text = "NVIDIA";
            // 
            // FormITWorkstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormITWorkstation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITWorkstation";
            this.Load += new System.EventHandler(this.ITWorkstation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateButton)).EndInit();
            this.UpdateItemContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtPCCasePrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox PCCaseListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainCalculButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.ComboBox ProfitComboBox;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.Label txtMainResultCalcul;
        private System.Windows.Forms.ComboBox FeeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox MainRichTextBox;
        private System.Windows.Forms.PictureBox UpdateButton;
        private System.Windows.Forms.ContextMenuStrip UpdateItemContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PCCaseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CPUV2StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CPUV3StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SDDStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDDStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RAMStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NVIDIAStripMenuItem;
    }
}

