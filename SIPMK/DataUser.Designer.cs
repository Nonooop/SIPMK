
namespace SIPMK
{
    partial class DataUser
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowseImg = new Guna.UI2.WinForms.Guna2Button();
            this.txtLokasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
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
            this.txtCari.Location = new System.Drawing.Point(631, 249);
            this.txtCari.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtCari.PlaceholderText = "Cari";
            this.txtCari.SelectedText = "";
            this.txtCari.ShadowDecoration.Parent = this.txtCari;
            this.txtCari.Size = new System.Drawing.Size(287, 50);
            this.txtCari.TabIndex = 113;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(36, 310);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 43);
            this.panel3.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA USER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 43);
            this.panel2.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM USER";
            // 
            // cbLevel
            // 
            this.cbLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.cbLevel.BorderRadius = 10;
            this.cbLevel.BorderThickness = 2;
            this.cbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.cbLevel.FocusedColor = System.Drawing.Color.Empty;
            this.cbLevel.FocusedState.Parent = this.cbLevel;
            this.cbLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.HoverState.Parent = this.cbLevel;
            this.cbLevel.ItemHeight = 35;
            this.cbLevel.Items.AddRange(new object[] {
            "Pilih Level",
            "Administrator",
            "User"});
            this.cbLevel.ItemsAppearance.Parent = this.cbLevel;
            this.cbLevel.Location = new System.Drawing.Point(713, 69);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.ShadowDecoration.Parent = this.cbLevel;
            this.cbLevel.Size = new System.Drawing.Size(203, 41);
            this.cbLevel.TabIndex = 116;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Empty;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(611, 128);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(307, 52);
            this.txtPassword.TabIndex = 115;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(235, 128);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(353, 52);
            this.txtEmail.TabIndex = 114;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtNama.BorderRadius = 10;
            this.txtNama.BorderThickness = 2;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.Parent = this.txtNama;
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.FocusedState.Parent = this.txtNama;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.HoverState.Parent = this.txtNama;
            this.txtNama.Location = new System.Drawing.Point(416, 66);
            this.txtNama.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(288, 52);
            this.txtNama.TabIndex = 109;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtID.BorderRadius = 10;
            this.txtID.BorderThickness = 2;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(233, 66);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtID.PlaceholderText = "ID User";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(172, 52);
            this.txtID.TabIndex = 107;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.GridColor = System.Drawing.Color.White;
            this.dgvUser.Location = new System.Drawing.Point(36, 347);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.Size = new System.Drawing.Size(881, 158);
            this.dgvUser.TabIndex = 104;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
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
            this.btnRefresh.Location = new System.Drawing.Point(460, 247);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(153, 52);
            this.btnRefresh.TabIndex = 112;
            this.btnRefresh.Text = "SEGARKAN";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::SIPMK.Properties.Resources.trash_can;
            this.btnDelete.Location = new System.Drawing.Point(319, 247);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(129, 52);
            this.btnDelete.TabIndex = 111;
            this.btnDelete.Text = "HAPUS";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::SIPMK.Properties.Resources.pencil__1_;
            this.btnEdit.Location = new System.Drawing.Point(177, 247);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(129, 52);
            this.btnEdit.TabIndex = 110;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BaseColor = System.Drawing.Color.White;
            this.PictureBox1.Location = new System.Drawing.Point(37, 69);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(183, 171);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 117;
            this.PictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::SIPMK.Properties.Resources.add__3_;
            this.btnAdd.Location = new System.Drawing.Point(37, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(129, 52);
            this.btnAdd.TabIndex = 108;
            this.btnAdd.Text = "TAMBAH";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.BorderRadius = 10;
            this.btnBrowseImg.CheckedState.Parent = this.btnBrowseImg;
            this.btnBrowseImg.CustomImages.Parent = this.btnBrowseImg;
            this.btnBrowseImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.btnBrowseImg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImg.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImg.HoverState.Parent = this.btnBrowseImg;
            this.btnBrowseImg.Image = global::SIPMK.Properties.Resources.add__3_;
            this.btnBrowseImg.Location = new System.Drawing.Point(713, 188);
            this.btnBrowseImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.ShadowDecoration.Parent = this.btnBrowseImg;
            this.btnBrowseImg.Size = new System.Drawing.Size(204, 52);
            this.btnBrowseImg.TabIndex = 118;
            this.btnBrowseImg.Text = "Pilih Foto";
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // txtLokasi
            // 
            this.txtLokasi.BackColor = System.Drawing.Color.Transparent;
            this.txtLokasi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtLokasi.BorderRadius = 10;
            this.txtLokasi.BorderThickness = 2;
            this.txtLokasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLokasi.DefaultText = "";
            this.txtLokasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLokasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLokasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLokasi.DisabledState.Parent = this.txtLokasi;
            this.txtLokasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLokasi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.txtLokasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLokasi.FocusedState.Parent = this.txtLokasi;
            this.txtLokasi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLokasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtLokasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLokasi.HoverState.Parent = this.txtLokasi;
            this.txtLokasi.Location = new System.Drawing.Point(233, 188);
            this.txtLokasi.Margin = new System.Windows.Forms.Padding(5);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.PasswordChar = '\0';
            this.txtLokasi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtLokasi.PlaceholderText = "Lokasi";
            this.txtLokasi.SelectedText = "";
            this.txtLokasi.ShadowDecoration.Parent = this.txtLokasi;
            this.txtLokasi.Size = new System.Drawing.Size(471, 52);
            this.txtLokasi.TabIndex = 119;
            this.txtLokasi.TextChanged += new System.EventHandler(this.txtLokasi_TextChanged);
            // 
            // DataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(953, 523);
            this.Controls.Add(this.txtLokasi);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataUser";
            this.Text = "DataUser";
            this.Load += new System.EventHandler(this.DataUser_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbLevel;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.DataGridView dgvUser;
        private Guna.UI.WinForms.GunaPictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnBrowseImg;
        private Guna.UI2.WinForms.Guna2TextBox txtLokasi;
    }
}