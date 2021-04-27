
namespace ITWorkstationsInc.View
{
    partial class AllProduct
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
            this.dgvAllProduct = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsUpdateAllProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).BeginInit();
            this.cmsUpdateAllProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllProduct
            // 
            this.dgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.PriceColumn,
            this.TypeColumn});
            this.dgvAllProduct.Location = new System.Drawing.Point(35, 49);
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.RowTemplate.Height = 25;
            this.dgvAllProduct.Size = new System.Drawing.Size(698, 600);
            this.dgvAllProduct.TabIndex = 0;
            this.dgvAllProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllProduct_CellEndEdit);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 540;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 540;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 120;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 120;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Visible = false;
            // 
            // cmsUpdateAllProduct
            // 
            this.cmsUpdateAllProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate});
            this.cmsUpdateAllProduct.Name = "cmsUpdateAllProduct";
            this.cmsUpdateAllProduct.Size = new System.Drawing.Size(113, 26);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(112, 22);
            this.tsmiUpdate.Text = "Update";
            // 
            // AllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.dgvAllProduct);
            this.Name = "AllProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllProduct";
            this.Load += new System.EventHandler(this.AllProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.cmsUpdateAllProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllProduct;
        private System.Windows.Forms.ContextMenuStrip cmsUpdateAllProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
    }
}