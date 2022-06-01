namespace obiskonya
{
    partial class HataBoxForm
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tamambtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.onayresim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.hataresim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.hatatext = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.hatabaslik = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onayresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataresim)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.BurlyWood;
            this.guna2GradientPanel1.Controls.Add(this.tamambtn);
            this.guna2GradientPanel1.Controls.Add(this.onayresim);
            this.guna2GradientPanel1.Controls.Add(this.hataresim);
            this.guna2GradientPanel1.Controls.Add(this.hatatext);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(34)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(540, 298);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // tamambtn
            // 
            this.tamambtn.Animated = true;
            this.tamambtn.AutoRoundedCorners = true;
            this.tamambtn.BackColor = System.Drawing.Color.Transparent;
            this.tamambtn.BorderRadius = 23;
            this.tamambtn.CheckedState.Parent = this.tamambtn;
            this.tamambtn.CustomImages.Parent = this.tamambtn;
            this.tamambtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.tamambtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.tamambtn.Font = new System.Drawing.Font("Exo 2 Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.tamambtn.ForeColor = System.Drawing.Color.White;
            this.tamambtn.HoverState.Parent = this.tamambtn;
            this.tamambtn.Location = new System.Drawing.Point(407, 237);
            this.tamambtn.Name = "tamambtn";
            this.tamambtn.ShadowDecoration.Parent = this.tamambtn;
            this.tamambtn.Size = new System.Drawing.Size(121, 49);
            this.tamambtn.TabIndex = 5;
            this.tamambtn.Text = "Tamam";
            this.tamambtn.Click += new System.EventHandler(this.tamambtn_Click);
            // 
            // onayresim
            // 
            this.onayresim.BackColor = System.Drawing.Color.Transparent;
            this.onayresim.Image = global::obiskonya.Properties.Resources.Onay;
            this.onayresim.Location = new System.Drawing.Point(31, 119);
            this.onayresim.Name = "onayresim";
            this.onayresim.ShadowDecoration.Parent = this.onayresim;
            this.onayresim.Size = new System.Drawing.Size(157, 119);
            this.onayresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onayresim.TabIndex = 4;
            this.onayresim.TabStop = false;
            // 
            // hataresim
            // 
            this.hataresim.BackColor = System.Drawing.Color.Transparent;
            this.hataresim.Image = global::obiskonya.Properties.Resources.carpi;
            this.hataresim.Location = new System.Drawing.Point(12, 119);
            this.hataresim.Name = "hataresim";
            this.hataresim.ShadowDecoration.Parent = this.hataresim;
            this.hataresim.Size = new System.Drawing.Size(191, 131);
            this.hataresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hataresim.TabIndex = 3;
            this.hataresim.TabStop = false;
            // 
            // hatatext
            // 
            this.hatatext.AutoSize = true;
            this.hatatext.BackColor = System.Drawing.Color.Transparent;
            this.hatatext.Font = new System.Drawing.Font("Exo 2 Medium", 13.25F, System.Drawing.FontStyle.Bold);
            this.hatatext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hatatext.Location = new System.Drawing.Point(209, 141);
            this.hatatext.Name = "hatatext";
            this.hatatext.Size = new System.Drawing.Size(59, 27);
            this.hatatext.TabIndex = 2;
            this.hatatext.Text = "HATA";
            this.hatatext.Click += new System.EventHandler(this.hatatext_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Black;
            this.guna2GradientPanel2.Controls.Add(this.hatabaslik);
            this.guna2GradientPanel2.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(540, 65);
            this.guna2GradientPanel2.TabIndex = 0;
            this.guna2GradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel2_MouseDown);
            // 
            // hatabaslik
            // 
            this.hatabaslik.AutoSize = true;
            this.hatabaslik.BackColor = System.Drawing.Color.Transparent;
            this.hatabaslik.Font = new System.Drawing.Font("Exo 2 Medium", 15.25F, System.Drawing.FontStyle.Bold);
            this.hatabaslik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hatabaslik.Location = new System.Drawing.Point(25, 12);
            this.hatabaslik.Name = "hatabaslik";
            this.hatabaslik.Size = new System.Drawing.Size(68, 31);
            this.hatabaslik.TabIndex = 1;
            this.hatabaslik.Text = "HATA";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(483, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // HataBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 298);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HataBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HataBoxForm";
            this.Load += new System.EventHandler(this.HataBoxForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onayresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataresim)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label hatatext;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label hatabaslik;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton tamambtn;
        public Guna.UI2.WinForms.Guna2PictureBox hataresim;
        public Guna.UI2.WinForms.Guna2PictureBox onayresim;
    }
}