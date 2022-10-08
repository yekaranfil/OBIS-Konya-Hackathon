namespace obiskonya
{
    partial class AdminPanel
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
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ilcebox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.otoparkbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cikissaatbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.girissaatbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.plakabox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.panel.BorderRadius = 5;
            this.panel.BorderThickness = 2;
            this.panel.Controls.Add(this.ilcebox);
            this.panel.Controls.Add(this.otoparkbox);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.cikissaatbuton);
            this.panel.Controls.Add(this.girissaatbuton);
            this.panel.Controls.Add(this.plakabox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(1081, 425);
            this.panel.TabIndex = 0;
            // 
            // ilcebox
            // 
            this.ilcebox.BackColor = System.Drawing.Color.Transparent;
            this.ilcebox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.ilcebox.BorderThickness = 2;
            this.ilcebox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ilcebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilcebox.FocusedColor = System.Drawing.Color.Empty;
            this.ilcebox.FocusedState.Parent = this.ilcebox;
            this.ilcebox.Font = new System.Drawing.Font("Exo 2 Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.ilcebox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ilcebox.FormattingEnabled = true;
            this.ilcebox.HoverState.Parent = this.ilcebox;
            this.ilcebox.ItemHeight = 30;
            this.ilcebox.Items.AddRange(new object[] {
            "MERKEZ",
            "KARATAY",
            "SELÇUKLU",
            "MERAM"});
            this.ilcebox.ItemsAppearance.Parent = this.ilcebox;
            this.ilcebox.Location = new System.Drawing.Point(12, 37);
            this.ilcebox.Name = "ilcebox";
            this.ilcebox.ShadowDecoration.Parent = this.ilcebox;
            this.ilcebox.Size = new System.Drawing.Size(213, 36);
            this.ilcebox.TabIndex = 30;
            this.ilcebox.SelectedValueChanged += new System.EventHandler(this.ilcebox_SelectedValueChanged);
            // 
            // otoparkbox
            // 
            this.otoparkbox.BackColor = System.Drawing.Color.Transparent;
            this.otoparkbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.otoparkbox.BorderThickness = 2;
            this.otoparkbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.otoparkbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.otoparkbox.FocusedColor = System.Drawing.Color.Empty;
            this.otoparkbox.FocusedState.Parent = this.otoparkbox;
            this.otoparkbox.Font = new System.Drawing.Font("Exo 2 Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.otoparkbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otoparkbox.FormattingEnabled = true;
            this.otoparkbox.HoverState.Parent = this.otoparkbox;
            this.otoparkbox.ItemHeight = 30;
            this.otoparkbox.ItemsAppearance.Parent = this.otoparkbox;
            this.otoparkbox.Location = new System.Drawing.Point(12, 96);
            this.otoparkbox.Name = "otoparkbox";
            this.otoparkbox.ShadowDecoration.Parent = this.otoparkbox;
            this.otoparkbox.Size = new System.Drawing.Size(213, 36);
            this.otoparkbox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(320, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kalınan Süre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(609, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ücret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(609, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ücret";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(321, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kalınan Süre";
            this.label4.Visible = false;
            // 
            // cikissaatbuton
            // 
            this.cikissaatbuton.Animated = true;
            this.cikissaatbuton.AutoRoundedCorners = true;
            this.cikissaatbuton.BackColor = System.Drawing.Color.Transparent;
            this.cikissaatbuton.BorderRadius = 29;
            this.cikissaatbuton.CheckedState.Parent = this.cikissaatbuton;
            this.cikissaatbuton.CustomImages.Parent = this.cikissaatbuton;
            this.cikissaatbuton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.cikissaatbuton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(34)))));
            this.cikissaatbuton.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.cikissaatbuton.ForeColor = System.Drawing.Color.White;
            this.cikissaatbuton.HoverState.Parent = this.cikissaatbuton;
            this.cikissaatbuton.Location = new System.Drawing.Point(543, 217);
            this.cikissaatbuton.Name = "cikissaatbuton";
            this.cikissaatbuton.ShadowDecoration.Parent = this.cikissaatbuton;
            this.cikissaatbuton.Size = new System.Drawing.Size(206, 61);
            this.cikissaatbuton.TabIndex = 21;
            this.cikissaatbuton.Text = "Otopark Çıkış";
            this.cikissaatbuton.UseTransparentBackground = true;
            this.cikissaatbuton.Click += new System.EventHandler(this.cikissaatbuton_Click);
            // 
            // girissaatbuton
            // 
            this.girissaatbuton.Animated = true;
            this.girissaatbuton.AutoRoundedCorners = true;
            this.girissaatbuton.BackColor = System.Drawing.Color.Transparent;
            this.girissaatbuton.BorderRadius = 29;
            this.girissaatbuton.CheckedState.Parent = this.girissaatbuton;
            this.girissaatbuton.CustomImages.Parent = this.girissaatbuton;
            this.girissaatbuton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.girissaatbuton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(34)))));
            this.girissaatbuton.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.girissaatbuton.ForeColor = System.Drawing.Color.White;
            this.girissaatbuton.HoverState.Parent = this.girissaatbuton;
            this.girissaatbuton.Location = new System.Drawing.Point(288, 217);
            this.girissaatbuton.Name = "girissaatbuton";
            this.girissaatbuton.ShadowDecoration.Parent = this.girissaatbuton;
            this.girissaatbuton.Size = new System.Drawing.Size(206, 61);
            this.girissaatbuton.TabIndex = 20;
            this.girissaatbuton.Text = "Otopark Giriş ";
            this.girissaatbuton.UseTransparentBackground = true;
            this.girissaatbuton.Click += new System.EventHandler(this.girissaatbuton_Click);
            // 
            // plakabox
            // 
            this.plakabox.Animated = true;
            this.plakabox.AutoRoundedCorners = true;
            this.plakabox.BackColor = System.Drawing.Color.Transparent;
            this.plakabox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.plakabox.BorderRadius = 25;
            this.plakabox.BorderThickness = 2;
            this.plakabox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plakabox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plakabox.DefaultText = "PLAKA";
            this.plakabox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.plakabox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.plakabox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plakabox.DisabledState.Parent = this.plakabox;
            this.plakabox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plakabox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plakabox.FocusedState.Parent = this.plakabox;
            this.plakabox.Font = new System.Drawing.Font("Exo 2 Medium", 11.75F, System.Drawing.FontStyle.Bold);
            this.plakabox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plakabox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plakabox.HoverState.Parent = this.plakabox;
            this.plakabox.IconLeft = global::obiskonya.Properties.Resources.plaka__1_;
            this.plakabox.IconLeftSize = new System.Drawing.Size(30, 20);
            this.plakabox.IconRightSize = new System.Drawing.Size(35, 20);
            this.plakabox.Location = new System.Drawing.Point(370, 121);
            this.plakabox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plakabox.Name = "plakabox";
            this.plakabox.PasswordChar = '\0';
            this.plakabox.PlaceholderText = "";
            this.plakabox.SelectedText = "";
            this.plakabox.SelectionStart = 5;
            this.plakabox.ShadowDecoration.Parent = this.plakabox;
            this.plakabox.Size = new System.Drawing.Size(257, 52);
            this.plakabox.TabIndex = 19;
            this.plakabox.TextOffset = new System.Drawing.Point(0, -5);
            this.plakabox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plakabox_KeyPress);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1081, 425);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private Guna.UI2.WinForms.Guna2TextBox plakabox;
        private Guna.UI2.WinForms.Guna2GradientButton cikissaatbuton;
        private Guna.UI2.WinForms.Guna2GradientButton girissaatbuton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ilcebox;
        private Guna.UI2.WinForms.Guna2ComboBox otoparkbox;
    }
}