using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace obiskonya
{
    public partial class AnaSayfa : Form
    {
        public static string tc;
        String sifre, mail, adsoyad;
        int sayac = 0;

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=obiskonya;user=root;password=1234;SslMode=none");
        public AnaSayfa()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public bool TcKontrol(String _tcno)
        {

            _tcno = _tcno.Trim();
            if (_tcno.Length != 11)
            {
                txtgiris.Focus();
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < _tcno.Length; i++)
            {
                sayilar[i] = Int32.Parse(_tcno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < _tcno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                return true;
            }
            else
            {
                txtgiris.Focus();
                return false;
            }
        }

        private void AnaSayfaUstPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            mailbox.Visible = false;
            geribtn.Visible = false;
            adsoyadbox.Visible = false;
            kayitolbtn.Location = new Point(140, 211);
            a = 0;
            girisbtn.Visible = false;
            girisyapbtn.Visible = true;
            txtgiris.Visible = true;
            txtgirissifre.Visible = true;
            kayitolbtn.Visible = true;
            kayitpanel.Visible = true;
            islemlerpanel.Visible = false;

        }


        private void AnaSayfaPanel_MouseEnter(object sender, EventArgs e)
        {
            if (txtgirissifre.Text.Equals(""))
            {
                txtgirissifre.Text = "Şifre";
                txtgirissifre.PasswordChar = '\0';
                sayac = 0;
            }

            if (txtgiris.Text.Equals(""))
            {
                txtgiris.Text = "T.C. Kimlik Numarası";
            }


            if (mailbox.Text.Equals(""))
            {
                mailbox.Text = "Mail Adresi";
            }

            if (adsoyadbox.Text.Equals(""))
            {
                adsoyadbox.Text = "İsim Soyisim";
            }
        }








        private void txtgiris_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txtgiris.Text.Equals("T.C. Kimlik Numarası"))
            {
                txtgiris.Clear();
            }
        }

        private void txtgirissifre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (sayac == 0)
            {
                txtgirissifre.Clear();
                sayac++;

            }

            if (txtgirissifre.Text.Equals(""))
            {
                txtgirissifre.PasswordChar = '\0';
            }
            else
            {
                txtgirissifre.PasswordChar = '*';
            }
        }

        private void mailbox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (mailbox.Text.Equals("Mail Adresi"))
            {
                mailbox.Clear();
            }
        }

        private void kayitolbtn_Click_1(object sender, EventArgs e)
        {
            if (kayitolbtn.Text.Equals("Kayıt Ol"))
            {
                mailbox.Visible = true;
                girisyapbtn.Visible = false;
                kayitolbtn.Text = "Kayıt Tamamla";
                kayitolbtn.Location = new Point(140, 253);
                geribtn.Visible = true;
                adsoyadbox.Visible = true;
            }
            else
            {



                tc = txtgiris.Text;
                sifre = txtgirissifre.Text;
                mail = mailbox.Text;
                adsoyad = adsoyadbox.Text;

                if (TcKontrol(tc) == false)
                {
                    HataBoxForm hata = new HataBoxForm();
                    HataBoxForm.baslik = "Veri Hatası";
                    HataBoxForm.text = "Lütfen Geçerli Bir \nT.C Numarası Giriniz";
                    hata.onayresim.Visible = false;
                    hata.Show();
                }
                else
                {
                    tc = Convert.ToString(txtgiris.Text);
                    sifre = Convert.ToString(txtgirissifre.Text);
                    mail = Convert.ToString(mailbox.Text);

                    //boş kontrol
                    if (tc == "" || sifre == "" || mail == "" || adsoyad == "" || tc == "T.C Kimlik Numarası" || sifre == "Şifre" || mail == "Mail Adresi" || adsoyad == "İsim Soyisim")
                    {
                        HataBoxForm f = new HataBoxForm();  
                        HataBoxForm.baslik = "Uyarı";
                        HataBoxForm.text = "Zorunlu alanlar boş geçilemez!";
                        f.onayresim.Visible = false;

                        f.Show();
                        // MessageBox.Show("Zorunlu alanlar boş geçilemez!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //tc kontrol
                        if (TcKontrol(tc) == false)
                        {
                            HataBoxForm.baslik = "Yanlış Veri";
                            HataBoxForm.text = "Lütfen Geçerli Bir T.C kimlik \nNumarası Giriniz";
                            HataBoxForm f = new HataBoxForm();
                            f.onayresim.Visible = false;
                            f.hataresim.Visible = true;
                            f.Show();
                            //tc kayıtlı mı?
                        }
                        else if (TcKontrol(tc) == true)
                        {
                            baglanti.Close();
                            baglanti.Open();
                            MySqlCommand kayitkomuttc = new MySqlCommand("SELECT kullanici_tc FROM kullanicilar WHERE kullanici_tc = @tc", baglanti);
                            kayitkomuttc.Parameters.AddWithValue("@tc", tc);
                            MySqlDataReader dr = kayitkomuttc.ExecuteReader();
                            if (dr.Read())
                            {
                                HataBoxForm f = new HataBoxForm();
                                HataBoxForm.baslik = "Kayıt Hatası";
                                HataBoxForm.text = "Bu T.C Kimlik Numarası \nZaten Kayıtlı";
                              
                                f.onayresim.Visible = false;
                                f.hataresim.Visible = true;
                                f.Show();
                            }

                            // tc veritabanında kayıtlıysa 
                            else
                            {
                                //baglanti veri kaydı
                                baglanti.Close();
                                baglanti.Open();
                                MySqlCommand kayitkomut1 = new MySqlCommand("INSERT INTO kullanicilar (kullanici_tc,kullanici_mail,kullanici_sifre,kullanici_adsoyad) VALUES ('" + tc + "','" + mail + "','" + sifre + "','" + adsoyad + "')", baglanti);
                                kayitkomut1.ExecuteNonQuery();
                                baglanti.Close();
                                HataBoxForm f = new HataBoxForm();
                                HataBoxForm.baslik = "Kayıt Başarılı";
                                HataBoxForm.text = "Kaydınız başarılı bir şekilde \ntamamlanmıştır!";
                                f.hataresim.Visible = false;
                                f.onayresim.Visible = true;
                                f.Show();
                                // kayit ekranı geri çıkış
                                girisyapbtn.Visible = true;
                                mailbox.Visible = false;
                                kayitolbtn.Visible = true;
                                adsoyadbox.Visible = false;
                                geribtn.Visible = false;
                                kayitolbtn.Text = "Kayıt Ol";
                                kayitolbtn.Location = new Point(140, 211);
                                txtgiris.BorderColor = Color.Blue;
                                txtgirissifre.BorderColor = Color.Blue;

                            }
                        }






                    }
                }



            }
        }

        int a = 0;
        private void otoparklistelebtn_Click(object sender, EventArgs e)
        {
            kayitpanel.Visible = false;
            if (a == 0)
            {

                islemlerpanel.Visible = true;
                girisbtn.Visible = true;
                islemlerpanel.Controls.Clear();
                OtoparkDurumForm otoparkform = new OtoparkDurumForm();
                otoparkform.TopLevel = false;
                islemlerpanel.Controls.Add(otoparkform);
                otoparkform.Show();
                otoparkform.Dock = DockStyle.Fill;
                otoparkform.BringToFront();
                a = 1;
            }
            else
            {
                islemlerpanel.Controls.Clear();
                islemlerpanel.Refresh();
                //islemlerpanel.Visible = false;
                a = 0;

            }

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            islemlerpanel.Visible = false;
        }

        private void adminbuton_Click(object sender, EventArgs e)
        {
            kayitpanel.Visible = false;
            islemlerpanel.Visible = true;
            girisbtn.Visible = true;
            //girisbtn.Visible = true;
            islemlerpanel.Controls.Clear();
            AdminPanel adminpnl = new AdminPanel();
            adminpnl.TopLevel = false;
            islemlerpanel.Controls.Add(adminpnl);
            adminpnl.Show();
            adminpnl.Dock = DockStyle.Fill;
            adminpnl.BringToFront();
        }




        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            kayitolbtn.Text = "Kayıt Ol";
            kayitolbtn.Location = new Point(140, 211);
            girisyapbtn.Visible = true;
            mailbox.Visible = false;
            kayitolbtn.Visible = true;
            adsoyadbox.Visible = false;
            geribtn.Visible = false;
        }

        private void adsoyadbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (adsoyadbox.Text.Equals("İsim Soyisim"))
            {
                adsoyadbox.Clear();
            }
        }

        private void girisyapbtn_Click_1(object sender, EventArgs e)
        {

            //giriş ekranı veritabanı tc şifre kontrolü
            tc = txtgiris.Text;
            sifre = txtgirissifre.Text;

            baglanti.Close();
            baglanti.Open();
            MySqlCommand kontroltc = new MySqlCommand("SELECT kullanici_tc,kullanici_sifre FROM kullanicilar WHERE (kullanici_tc = @tc AND kullanici_sifre = @sifre)", baglanti);
            kontroltc.Parameters.AddWithValue("@tc", tc);
            kontroltc.Parameters.AddWithValue("@sifre", sifre);
            MySqlDataReader dr = kontroltc.ExecuteReader();

            if (dr.Read())
            {
                HataBoxForm.baslik = "Giriş başarılı";
                HataBoxForm.text = "Giriş Yapıldı";
                HataBoxForm hataform = new HataBoxForm();
                this.Hide();
                girisbtn.Visible = false;
                this.Show();
                hataform.Show();
                islemlerpanel.Visible = true;
                GirisMenu girismenu = new GirisMenu();
                girismenu.TopLevel = false;
                islemlerpanel.Controls.Add(girismenu);
                girismenu.Show();
                girismenu.Dock = DockStyle.Fill;
                girismenu.BringToFront();
                kayitpanel.Visible = false;
            }
            else
            {
                HataBoxForm.baslik = "Hatalı Giriş";
                HataBoxForm.text = "Kullanıcı Adı Veya Şifre Hatalı!";
                HataBoxForm f = new HataBoxForm();
                f.onayresim.Visible = false;
                f.Show();
            }

        }
    }
}
