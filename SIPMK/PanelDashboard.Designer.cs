
namespace SIPMK
{
    partial class PanelDashboard
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
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTransaksiPenjualan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksiPenjualan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtCari.BorderRadius = 10;
            this.txtCari.BorderThickness = 2;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.Parent = this.txtCari;
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.FocusedState.Parent = this.txtCari;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.HoverState.Parent = this.txtCari;
            this.txtCari.Location = new System.Drawing.Point(39, 41);
            this.txtCari.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtCari.PlaceholderText = "Cari";
            this.txtCari.SelectedText = "";
            this.txtCari.ShadowDecoration.Parent = this.txtCari;
            this.txtCari.Size = new System.Drawing.Size(701, 50);
            this.txtCari.TabIndex = 93;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::SIPMK.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(761, 39);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(153, 52);
            this.btnRefresh.TabIndex = 92;
            this.btnRefresh.Text = "SEGARKAN";
            // 
            // dgvTransaksiPenjualan
            // 
            this.dgvTransaksiPenjualan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.dgvTransaksiPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaksiPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksiPenjualan.GridColor = System.Drawing.Color.White;
            this.dgvTransaksiPenjualan.Location = new System.Drawing.Point(39, 148);
            this.dgvTransaksiPenjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTransaksiPenjualan.Name = "dgvTransaksiPenjualan";
            this.dgvTransaksiPenjualan.RowHeadersWidth = 51;
            this.dgvTransaksiPenjualan.Size = new System.Drawing.Size(876, 335);
            this.dgvTransaksiPenjualan.TabIndex = 91;
            this.dgvTransaksiPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksiPenjualan_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(37, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 43);
            this.panel2.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "SELAMAT DATANG DI SISTEM PENJADWALAN MATA KULIAH";
            // 
            // PanelDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(953, 523);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTransaksiPenjualan);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelDashboard";
            this.Text = "PanelDashboard";
            this.Load += new System.EventHandler(this.PanelDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksiPenjualan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTransaksiPenjualan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}