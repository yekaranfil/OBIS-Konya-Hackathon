namespace obiskonya
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AnaSayfaPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.adminbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.islemlerpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.kayitpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.geribtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.adsoyadbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtgiris = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayitolbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mailbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.girisyapbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtgirissifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.AnaSayfaUstPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.otoparklistelebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.girisbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnaSayfaPanel.SuspendLayout();
            this.kayitpanel.SuspendLayout();
            this.AnaSayfaUstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AnaSayfaPanel
            // 
            this.AnaSayfaPanel.BackColor = System.Drawing.Color.Yellow;
            this.AnaSayfaPanel.BackgroundImage = global::obiskonya.Properties.Resources.panel1son;
            this.AnaSayfaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnaSayfaPanel.Controls.Add(this.adminbuton);
            this.AnaSayfaPanel.Controls.Add(this.islemlerpanel);
            this.AnaSayfaPanel.Controls.Add(this.kayitpanel);
            this.AnaSayfaPanel.Controls.Add(this.AnaSayfaUstPanel);
            this.AnaSayfaPanel.Controls.Add(this.otoparklistelebtn);
            this.AnaSayfaPanel.Controls.Add(this.girisbtn);
            this.AnaSayfaPanel.Font = new System.Drawing.Font("Exo 2 Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.AnaSayfaPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnaSayfaPanel.Location = new System.Drawing.Point(-59, -30);
            this.AnaSayfaPanel.Name = "AnaSayfaPanel";
            this.AnaSayfaPanel.ShadowDecoration.Parent = this.AnaSayfaPanel;
            this.AnaSayfaPanel.Size = new System.Drawing.Size(1280, 718);
            this.AnaSayfaPanel.TabIndex = 0;
            this.AnaSayfaPanel.MouseEnter += new System.EventHandler(this.AnaSayfaPanel_MouseEnter);
            // 
            // adminbuton
            // 
            this.adminbuton.Animated = true;
            this.adminbuton.AutoRoundedCorners = true;
            this.adminbuton.BackColor = System.Drawing.Color.Transparent;
            this.adminbuton.BorderRadius = 24;
            this.adminbuton.CheckedState.Parent = this.adminbuton;
            this.adminbuton.CustomImages.Parent = this.adminbuton;
            this.adminbuton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.adminbuton.FillColor2 = System.Drawing.Color.Black;
            this.adminbuton.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.adminbuton.ForeColor = System.Drawing.Color.White;
            this.adminbuton.HoverState.Parent = this.adminbuton;
            this.adminbuton.Location = new System.Drawing.Point(457, 114);
            this.adminbuton.Name = "adminbuton";
            this.adminbuton.ShadowDecoration.Parent = this.adminbuton;
            this.adminbuton.Size = new System.Drawing.Size(175, 50);
            this.adminbuton.TabIndex = 17;
            this.adminbuton.Text = "Admin";
            this.adminbuton.UseTransparentBackground = true;
            this.adminbuton.Click += new System.EventHandler(this.adminbuton_Click);
            // 
            // islemlerpanel
            // 
            this.islemlerpanel.BackColor = System.Drawing.Color.Transparent;
            this.islemlerpanel.Location = new System.Drawing.Point(97, 170);
            this.islemlerpanel.Name = "islemlerpanel";
            this.islemlerpanel.ShadowDecoration.Parent = this.islemlerpanel;
            this.islemlerpanel.Size = new System.Drawing.Size(1097, 464);
            this.islemlerpanel.TabIndex = 16;
            this.islemlerpanel.Visible = false;
            // 
            // kayitpanel
            // 
            this.kayitpanel.BackColor = System.Drawing.Color.Transparent;
            this.kayitpanel.BackgroundImage = global::obiskonya.Properties.Resources.giriskayitpanel;
            this.kayitpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kayitpanel.Controls.Add(this.geribtn);
            this.kayitpanel.Controls.Add(this.adsoyadbox);
            this.kayitpanel.Controls.Add(this.txtgiris);
            this.kayitpanel.Controls.Add(this.kayitolbtn);
            this.kayitpanel.Controls.Add(this.mailbox);
            this.kayitpanel.Controls.Add(this.girisyapbtn);
            this.kayitpanel.Controls.Add(this.txtgirissifre);
            this.kayitpanel.Location = new System.Drawing.Point(156, 199);
            this.kayitpanel.Name = "kayitpanel";
            this.kayitpanel.ShadowDecoration.Parent = this.kayitpanel;
            this.kayitpanel.Size = new System.Drawing.Size(407, 362);
            this.kayitpanel.TabIndex = 14;
            this.kayitpanel.Visible = false;
            // 
            // geribtn
            // 
            this.geribtn.BackColor = System.Drawing.Color.Transparent;
            this.geribtn.BackgroundImage = global::obiskonya.Properties.Resources.gerialbtn1;
            this.geribtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geribtn.CheckedState.Parent = this.geribtn;
            this.geribtn.HoverState.Parent = this.geribtn;
            this.geribtn.Location = new System.Drawing.Point(88, 258);
            this.geribtn.Name = "geribtn";
            this.geribtn.PressedState.Parent = this.geribtn;
            this.geribtn.Size = new System.Drawing.Size(50, 38);
            this.geribtn.TabIndex = 18;
            this.geribtn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // adsoyadbox
            // 
            this.adsoyadbox.Animated = true;
            this.adsoyadbox.AutoRoundedCorners = true;
            this.adsoyadbox.BackColor = System.Drawing.Color.Transparent;
            this.adsoyadbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.adsoyadbox.BorderRadius = 17;
            this.adsoyadbox.BorderThickness = 2;
            this.adsoyadbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adsoyadbox.DefaultText = "İsim Soyisim";
            this.adsoyadbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adsoyadbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adsoyadbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adsoyadbox.DisabledState.Parent = this.adsoyadbox;
            this.adsoyadbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adsoyadbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adsoyadbox.FocusedState.Parent = this.adsoyadbox;
            this.adsoyadbox.Font = new System.Drawing.Font("Exo 2 Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.adsoyadbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adsoyadbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adsoyadbox.HoverState.Parent = this.adsoyadbox;
            this.adsoyadbox.IconLeft = global::obiskonya.Properties.Resources.kullanici;
            this.adsoyadbox.IconLeftSize = new System.Drawing.Size(20, 18);
            this.adsoyadbox.Location = new System.Drawing.Point(111, 211);
            this.adsoyadbox.Margin = new System.Windows.Forms.Padding(4);
            this.adsoyadbox.Name = "adsoyadbox";
            this.adsoyadbox.PasswordChar = '\0';
            this.adsoyadbox.PlaceholderText = "";
            this.adsoyadbox.SelectedText = "";
            this.adsoyadbox.SelectionStart = 12;
            this.adsoyadbox.ShadowDecoration.Parent = this.adsoyadbox;
            this.adsoyadbox.Size = new System.Drawing.Size(200, 36);
            this.adsoyadbox.TabIndex = 15;
            this.adsoyadbox.TextOffset = new System.Drawing.Point(0, -3);
            this.adsoyadbox.Visible = false;
            this.adsoyadbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adsoyadbox_KeyPress);
            // 
            // txtgiris
            // 
            this.txtgiris.Animated = true;
            this.txtgiris.AutoRoundedCorners = true;
            this.txtgiris.BackColor = System.Drawing.Color.Transparent;
            this.txtgiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.txtgiris.BorderRadius = 17;
            this.txtgiris.BorderThickness = 2;
            this.txtgiris.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiris.DefaultText = "T.C. Kimlik Numarası";
            this.txtgiris.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiris.DisabledState.Parent = this.txtgiris;
            this.txtgiris.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiris.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiris.FocusedState.Parent = this.txtgiris;
            this.txtgiris.Font = new System.Drawing.Font("Exo 2 Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.txtgiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtgiris.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiris.HoverState.Parent = this.txtgiris;
            this.txtgiris.IconLeft = global::obiskonya.Properties.Resources.kullanici;
            this.txtgiris.IconLeftSize = new System.Drawing.Size(20, 18);
            this.txtgiris.Location = new System.Drawing.Point(111, 70);
            this.txtgiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.PasswordChar = '\0';
            this.txtgiris.PlaceholderText = "";
            this.txtgiris.SelectedText = "";
            this.txtgiris.SelectionStart = 20;
            this.txtgiris.ShadowDecoration.Parent = this.txtgiris;
            this.txtgiris.Size = new System.Drawing.Size(200, 36);
            this.txtgiris.TabIndex = 9;
            this.txtgiris.TextOffset = new System.Drawing.Point(0, -3);
            this.txtgiris.Visible = false;
            this.txtgiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiris_KeyPress_1);
            // 
            // kayitolbtn
            // 
            this.kayitolbtn.Animated = true;
            this.kayitolbtn.AutoRoundedCorners = true;
            this.kayitolbtn.BackColor = System.Drawing.Color.Transparent;
            this.kayitolbtn.BorderRadius = 21;
            this.kayitolbtn.CheckedState.Parent = this.kayitolbtn;
            this.kayitolbtn.CustomImages.Parent = this.kayitolbtn;
            this.kayitolbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.kayitolbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(34)))));
            this.kayitolbtn.Font = new System.Drawing.Font("Exo 2 Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.kayitolbtn.ForeColor = System.Drawing.Color.White;
            this.kayitolbtn.HoverState.Parent = this.kayitolbtn;
            this.kayitolbtn.Location = new System.Drawing.Point(140, 211);
            this.kayitolbtn.Name = "kayitolbtn";
            this.kayitolbtn.ShadowDecoration.Parent = this.kayitolbtn;
            this.kayitolbtn.Size = new System.Drawing.Size(125, 45);
            this.kayitolbtn.TabIndex = 13;
            this.kayitolbtn.Text = "Kayıt Ol";
            this.kayitolbtn.UseTransparentBackground = true;
            this.kayitolbtn.Visible = false;
            this.kayitolbtn.Click += new System.EventHandler(this.kayitolbtn_Click_1);
            // 
            // mailbox
            // 
            this.mailbox.Animated = true;
            this.mailbox.AutoRoundedCorners = true;
            this.mailbox.BackColor = System.Drawing.Color.Transparent;
            this.mailbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.mailbox.BorderRadius = 17;
            this.mailbox.BorderThickness = 2;
            this.mailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailbox.DefaultText = "Mail Adresi";
            this.mailbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailbox.DisabledState.Parent = this.mailbox;
            this.mailbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailbox.FocusedState.Parent = this.mailbox;
            this.mailbox.Font = new System.Drawing.Font("Exo 2 Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.mailbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mailbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailbox.HoverState.Parent = this.mailbox;
            this.mailbox.IconLeft = global::obiskonya.Properties.Resources.mail;
            this.mailbox.Location = new System.Drawing.Point(111, 166);
            this.mailbox.Margin = new System.Windows.Forms.Padding(4);
            this.mailbox.Name = "mailbox";
            this.mailbox.PasswordChar = '\0';
            this.mailbox.PlaceholderText = "";
            this.mailbox.SelectedText = "";
            this.mailbox.SelectionStart = 11;
            this.mailbox.ShadowDecoration.Parent = this.mailbox;
            this.mailbox.Size = new System.Drawing.Size(200, 36);
            this.mailbox.TabIndex = 12;
            this.mailbox.TextOffset = new System.Drawing.Point(0, -3);
            this.mailbox.Visible = false;
            this.mailbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailbox_KeyPress_1);
            // 
            // girisyapbtn
            // 
            this.girisyapbtn.Animated = true;
            this.girisyapbtn.AutoRoundedCorners = true;
            this.girisyapbtn.BackColor = System.Drawing.Color.Transparent;
            this.girisyapbtn.BorderRadius = 21;
            this.girisyapbtn.CheckedState.Parent = this.girisyapbtn;
            this.girisyapbtn.CustomImages.Parent = this.girisyapbtn;
            this.girisyapbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.girisyapbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(34)))));
            this.girisyapbtn.Font = new System.Drawing.Font("Exo 2 Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.girisyapbtn.ForeColor = System.Drawing.Color.White;
            this.girisyapbtn.HoverState.Parent = this.girisyapbtn;
            this.girisyapbtn.Location = new System.Drawing.Point(140, 160);
            this.girisyapbtn.Name = "girisyapbtn";
            this.girisyapbtn.ShadowDecoration.Parent = this.girisyapbtn;
            this.girisyapbtn.Size = new System.Drawing.Size(125, 45);
            this.girisyapbtn.TabIndex = 11;
            this.girisyapbtn.Text = "Giriş Yap";
            this.girisyapbtn.UseTransparentBackground = true;
            this.girisyapbtn.Visible = false;
            this.girisyapbtn.Click += new System.EventHandler(this.girisyapbtn_Click_1);
            // 
            // txtgirissifre
            // 
            this.txtgirissifre.Animated = true;
            this.txtgirissifre.AutoRoundedCorners = true;
            this.txtgirissifre.BackColor = System.Drawing.Color.Transparent;
            this.txtgirissifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.txtgirissifre.BorderRadius = 17;
            this.txtgirissifre.BorderThickness = 2;
            this.txtgirissifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgirissifre.DefaultText = "Şifre";
            this.txtgirissifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgirissifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgirissifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgirissifre.DisabledState.Parent = this.txtgirissifre;
            this.txtgirissifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgirissifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgirissifre.FocusedState.Parent = this.txtgirissifre;
            this.txtgirissifre.Font = new System.Drawing.Font("Exo 2 Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.txtgirissifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtgirissifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgirissifre.HoverState.Parent = this.txtgirissifre;
            this.txtgirissifre.IconLeft = global::obiskonya.Properties.Resources.parola;
            this.txtgirissifre.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtgirissifre.Location = new System.Drawing.Point(111, 118);
            this.txtgirissifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtgirissifre.Name = "txtgirissifre";
            this.txtgirissifre.PasswordChar = '\0';
            this.txtgirissifre.PlaceholderText = "";
            this.txtgirissifre.SelectedText = "";
            this.txtgirissifre.SelectionStart = 5;
            this.txtgirissifre.ShadowDecoration.Parent = this.txtgirissifre;
            this.txtgirissifre.Size = new System.Drawing.Size(200, 36);
            this.txtgirissifre.TabIndex = 10;
            this.txtgirissifre.TextOffset = new System.Drawing.Point(0, -3);
            this.txtgirissifre.Visible = false;
            this.txtgirissifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgirissifre_KeyPress_1);
            // 
            // AnaSayfaUstPanel
            // 
            this.AnaSayfaUstPanel.BackColor = System.Drawing.Color.Transparent;
            this.AnaSayfaUstPanel.Controls.Add(this.guna2ControlBox2);
            this.AnaSayfaUstPanel.Controls.Add(this.guna2ControlBox1);
            this.AnaSayfaUstPanel.Location = new System.Drawing.Point(30, 22);
            this.AnaSayfaUstPanel.Name = "AnaSayfaUstPanel";
            this.AnaSayfaUstPanel.ShadowDecoration.Parent = this.AnaSayfaUstPanel;
            this.AnaSayfaUstPanel.Size = new System.Drawing.Size(1210, 86);
            this.AnaSayfaUstPanel.TabIndex = 0;
            this.AnaSayfaUstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaSayfaUstPanel_MouseDown);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1102, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1153, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // otoparklistelebtn
            // 
            this.otoparklistelebtn.Animated = true;
            this.otoparklistelebtn.AutoRoundedCorners = true;
            this.otoparklistelebtn.BackColor = System.Drawing.Color.Transparent;
            this.otoparklistelebtn.BorderRadius = 24;
            this.otoparklistelebtn.CheckedState.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.CustomImages.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.otoparklistelebtn.FillColor2 = System.Drawing.Color.Black;
            this.otoparklistelebtn.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.otoparklistelebtn.ForeColor = System.Drawing.Color.White;
            this.otoparklistelebtn.HoverState.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.Location = new System.Drawing.Point(63, 114);
            this.otoparklistelebtn.Name = "otoparklistelebtn";
            this.otoparklistelebtn.ShadowDecoration.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.Size = new System.Drawing.Size(175, 50);
            this.otoparklistelebtn.TabIndex = 15;
            this.otoparklistelebtn.Text = "Otopark Durumları";
            this.otoparklistelebtn.UseTransparentBackground = true;
            this.otoparklistelebtn.Click += new System.EventHandler(this.otoparklistelebtn_Click);
            // 
            // girisbtn
            // 
            this.girisbtn.Animated = true;
            this.girisbtn.AutoRoundedCorners = true;
            this.girisbtn.BackColor = System.Drawing.Color.Transparent;
            this.girisbtn.BorderRadius = 24;
            this.girisbtn.CheckedState.Parent = this.girisbtn;
            this.girisbtn.CustomImages.Parent = this.girisbtn;
            this.girisbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
            this.girisbtn.FillColor2 = System.Drawing.Color.Black;
            this.girisbtn.Font = new System.Drawing.Font("Exo 2 Medium", 12.25F, System.Drawing.FontStyle.Bold);
            this.girisbtn.ForeColor = System.Drawing.Color.White;
            this.girisbtn.HoverState.Parent = this.girisbtn;
            this.girisbtn.Location = new System.Drawing.Point(259, 114);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.ShadowDecoration.Parent = this.girisbtn;
            this.girisbtn.Size = new System.Drawing.Size(175, 50);
            this.girisbtn.TabIndex = 1;
            this.girisbtn.Text = "Kullanıcı Girişi";
            this.girisbtn.UseTransparentBackground = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 662);
            this.Controls.Add(this.AnaSayfaPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.AnaSayfaPanel.ResumeLayout(false);
            this.kayitpanel.ResumeLayout(false);
            this.AnaSayfaUstPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel AnaSayfaPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel AnaSayfaUstPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton girisbtn;
        private Guna.UI2.WinForms.Guna2GradientButton kayitolbtn;
        private Guna.UI2.WinForms.Guna2TextBox mailbox;
        private Guna.UI2.WinForms.Guna2GradientButton girisyapbtn;
        private Guna.UI2.WinForms.Guna2TextBox txtgirissifre;
        private Guna.UI2.WinForms.Guna2TextBox txtgiris;
        private Guna.UI2.WinForms.Guna2GradientPanel kayitpanel;
        private Guna.UI2.WinForms.Guna2TextBox adsoyadbox;
        private Guna.UI2.WinForms.Guna2GradientButton otoparklistelebtn;
        public Guna.UI2.WinForms.Guna2GradientPanel islemlerpanel;
        private Guna.UI2.WinForms.Guna2GradientButton adminbuton;
        private Guna.UI2.WinForms.Guna2ImageButton geribtn;
    }
}

