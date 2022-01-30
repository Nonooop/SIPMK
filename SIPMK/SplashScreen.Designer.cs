namespace SIPMK
{
    partial class SplashScreen
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
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaCircleProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.Controls.Add(this.gunaProgressBar1);
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBar1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(115, 190);
            this.gunaCircleProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(225, 203);
            this.gunaCircleProgressBar1.TabIndex = 0;
            this.gunaCircleProgressBar1.UseProgressPercentText = true;
            this.gunaCircleProgressBar1.Click += new System.EventHandler(this.gunaCircleProgressBar1_Click);
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaProgressBar1.Location = new System.Drawing.Point(211, 180);
            this.gunaProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.Size = new System.Drawing.Size(267, 28);
            this.gunaProgressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIPMK.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 615);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.gunaCircleProgressBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
    }
}