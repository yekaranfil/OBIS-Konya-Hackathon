namespace obiskonya
{
    partial class OtoparkDurumForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ilcelbl = new System.Windows.Forms.Label();
            this.otoparkadilbl = new System.Windows.Forms.Label();
            this.boslbl = new System.Windows.Forms.Label();
            this.otoparktablo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otoparktablo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.panel.BorderRadius = 5;
            this.panel.BorderThickness = 2;
            this.panel.Controls.Add(this.ilcelbl);
            this.panel.Controls.Add(this.otoparkadilbl);
            this.panel.Controls.Add(this.boslbl);
            this.panel.Controls.Add(this.otoparktablo);
            this.panel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(1097, 464);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // ilcelbl
            // 
            this.ilcelbl.AutoSize = true;
            this.ilcelbl.Font = new System.Drawing.Font("Exo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.ilcelbl.ForeColor = System.Drawing.Color.White;
            this.ilcelbl.Location = new System.Drawing.Point(310, 9);
            this.ilcelbl.Name = "ilcelbl";
            this.ilcelbl.Size = new System.Drawing.Size(146, 28);
            this.ilcelbl.TabIndex = 4;
            this.ilcelbl.Text = "Otopark İlçesi";
            this.ilcelbl.Visible = false;
            // 
            // otoparkadilbl
            // 
            this.otoparkadilbl.AutoSize = true;
            this.otoparkadilbl.Font = new System.Drawing.Font("Exo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.otoparkadilbl.ForeColor = System.Drawing.Color.White;
            this.otoparkadilbl.Location = new System.Drawing.Point(12, 9);
            this.otoparkadilbl.Name = "otoparkadilbl";
            this.otoparkadilbl.Size = new System.Drawing.Size(126, 28);
            this.otoparkadilbl.TabIndex = 3;
            this.otoparkadilbl.Text = "Otopark Adı";
            this.otoparkadilbl.Visible = false;
            // 
            // boslbl
            // 
            this.boslbl.AutoSize = true;
            this.boslbl.Font = new System.Drawing.Font("Exo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.boslbl.ForeColor = System.Drawing.Color.White;
            this.boslbl.Location = new System.Drawing.Point(625, 9);
            this.boslbl.Name = "boslbl";
            this.boslbl.Size = new System.Drawing.Size(138, 28);
            this.boslbl.TabIndex = 2;
            this.boslbl.Text = "Boş Park Yeri";
            this.boslbl.Visible = false;
            // 
            // otoparktablo
            // 
            this.otoparktablo.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Exo 2 Medium", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.otoparktablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.otoparktablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otoparktablo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.otoparktablo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otoparktablo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.otoparktablo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Exo 2 Medium", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.otoparktablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.otoparktablo.ColumnHeadersHeight = 30;
            this.otoparktablo.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Exo 2 Medium", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.otoparktablo.DefaultCellStyle = dataGridViewCellStyle3;
            this.otoparktablo.EnableHeadersVisualStyles = false;
            this.otoparktablo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.otoparktablo.Location = new System.Drawing.Point(3, 37);
            this.otoparktablo.Name = "otoparktablo";
            this.otoparktablo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Exo 2 Medium", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.otoparktablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.otoparktablo.RowHeadersVisible = false;
            this.otoparktablo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.otoparktablo.RowTemplate.Height = 32;
            this.otoparktablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.otoparktablo.Size = new System.Drawing.Size(947, 317);
            this.otoparktablo.TabIndex = 1;
            this.otoparktablo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.otoparktablo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.otoparktablo.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.otoparktablo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.otoparktablo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.otoparktablo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.otoparktablo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.otoparktablo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(4)))));
            this.otoparktablo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.otoparktablo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.otoparktablo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.otoparktablo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.otoparktablo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.otoparktablo.ThemeStyle.HeaderStyle.Height = 30;
            this.otoparktablo.ThemeStyle.ReadOnly = true;
            this.otoparktablo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(4)))));
            this.otoparktablo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.otoparktablo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.otoparktablo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.otoparktablo.ThemeStyle.RowsStyle.Height = 32;
            this.otoparktablo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.otoparktablo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // OtoparkDurumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 464);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtoparkDurumForm";
            this.Text = "OtoparkDurumForm";
            this.Load += new System.EventHandler(this.OtoparkDurumForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otoparktablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DataGridView otoparktablo;
        private System.Windows.Forms.Label ilcelbl;
        private System.Windows.Forms.Label otoparkadilbl;
        private System.Windows.Forms.Label boslbl;
        public Guna.UI2.WinForms.Guna2GradientPanel panel;
    }
}