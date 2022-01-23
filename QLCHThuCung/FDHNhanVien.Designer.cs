
namespace QLCHThuCung
{
    partial class FDHNhanVien
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
            this.lbQLKH = new System.Windows.Forms.Label();
            this.dgvDSDH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLKH
            // 
            this.lbQLKH.AutoSize = true;
            this.lbQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLKH.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbQLKH.Location = new System.Drawing.Point(312, 106);
            this.lbQLKH.Name = "lbQLKH";
            this.lbQLKH.Size = new System.Drawing.Size(1031, 58);
            this.lbQLKH.TabIndex = 4;
            this.lbQLKH.Text = "DANH SÁCH ĐƠN HÀNG CỦA NHÂN VIÊN";
            // 
            // dgvDSDH
            // 
            this.dgvDSDH.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvDSDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDH.Location = new System.Drawing.Point(233, 246);
            this.dgvDSDH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDH.Name = "dgvDSDH";
            this.dgvDSDH.RowHeadersWidth = 51;
            this.dgvDSDH.Size = new System.Drawing.Size(1339, 527);
            this.dgvDSDH.TabIndex = 6;
            this.dgvDSDH.DoubleClick += new System.EventHandler(this.dgvDSDH_DoubleClick);
            // 
            // FDHNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.dgvDSDH);
            this.Controls.Add(this.lbQLKH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDHNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDonHangCuaKH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLKH;
        private System.Windows.Forms.DataGridView dgvDSDH;
    }
}