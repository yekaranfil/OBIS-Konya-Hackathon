using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obiskonya
{
    public partial class GirisMenu : Form
    {
        ArrayList tarihler = new ArrayList();
        ArrayList girisler = new ArrayList();
        ArrayList cikislar = new ArrayList();
        ArrayList odendimiler = new ArrayList();
        ArrayList ucretler = new ArrayList();
        ArrayList plakalar = new ArrayList();
        ArrayList aracidler = new ArrayList();
        ArrayList kayitidler = new ArrayList();
        String tcno, plaka, araccinsi,kullaniciid, kullaniciadsoyad,kayitid,otoparkid,aracid,odendimi,ucret,gsaat,csaat,tarih;
        int a = 0;
        public GirisMenu()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=obiskonya;user=root;password=1234;SslMode=none");
        int secim;

        private void bilgilertablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secim = e.RowIndex;
            if (bilgilertablo.Rows[secim].Cells[5].Value.Equals("EVET"))
            {
                odebuton.Enabled = false;
            }
            else
            {
                odebuton.Enabled = true;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            bilgilertablo.Refresh();
            if (bilgilertablo.Rows[secim].Cells[5].Value.Equals("HAYIR"))
            {
                odebuton.Enabled = false;
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitguncelle = new MySqlCommand("UPDATE odemeler SET odendimi='" + "EVET" + "' WHERE kayitlar_kayit_id=@id ", baglanti);
                kayitguncelle.Parameters.AddWithValue("@id", kayitidler[secim]);
                kayitguncelle.ExecuteNonQuery();
                baglanti.Close();
                bilgilertablo.Refresh();

                HataBoxForm hata = new HataBoxForm();
                HataBoxForm.baslik = "Ödeme Bilgi";
                HataBoxForm.text = "Ödeme İşlemi Başarılı.";
                hata.hataresim.Visible = false;
                hata.Show();

                bilgilertablo.Rows[secim].Cells[5].Value = "EVET";

            }
        }

        public bool TcKontrol(String _tcno)
        {

            _tcno = _tcno.Trim();
            if (_tcno.Length != 11)
            {
                tcbox.Focus();
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
                tcbox.Focus();
                return false;
            }
        }
        private void otoparklistelebtn2_Click(object sender, EventArgs e)
        {
            OtoparkDurumForm otopark = new OtoparkDurumForm();
            arkapanel.Controls.Add(otopark);
            otopark.TopLevel = false;
            otopark.Show();
            otopark.Dock = DockStyle.Fill;
            otopark.BringToFront();
        }

        private void arackayitbtn_Click(object sender, EventArgs e)
        {
            plakakayitbox.Visible = true;
            tcbox.Visible = true;
            araccinsibox.Visible = true;
            arackaydet.Visible = true;
            bilgilertablo.Visible = false;
        }

        private void tcbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tcbox.Text.Equals("T.C. Kimlik Numarası"))
            {
                tcbox.Clear();
            }
        }

        private void plakakayitbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (plakakayitbox.Text.Equals("PLAKA"))
            {
                plakakayitbox.Clear();
            }
        }

        private void plakakayitbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void odemelerbtn_Click(object sender, EventArgs e)
        {
            tarihler.Clear();
            girisler.Clear();
            cikislar.Clear();
            plakalar.Clear();
            odendimiler.Clear();
            ucretler.Clear();
            aracidler.Clear();
            kayitidler.Clear();
            bilgilertablo.Rows.Clear();
            bilgilertablo.Refresh();
            bilgilertablo.ColumnCount = 6;
            bilgilertablo.Columns[0].Name = "Tarih";
            bilgilertablo.Columns[0].ValueType = typeof(String);
            bilgilertablo.Columns[1].Name = "Giriş Saat";
            bilgilertablo.Columns[1].ValueType = typeof(String);
            bilgilertablo.Columns[2].Name = "Çıkış Saat";
            bilgilertablo.Columns[2].ValueType = typeof(String);
            bilgilertablo.Columns[3].Name = "Plaka";
            bilgilertablo.Columns[3].ValueType = typeof(String);
            bilgilertablo.Columns[4].Name = "Ücret";
            bilgilertablo.Columns[4].ValueType = typeof(String);
            bilgilertablo.Columns[5].Name = "Ödendi Mi";
            bilgilertablo.Columns[5].ValueType = typeof(String);
            odebuton.Visible = true;   
            plakakayitbox.Visible = false;
            tcbox.Visible = false;
            araccinsibox.Visible = false;
            arackaydet.Visible = false;
            bilgilertablo.Visible = true;

            try
            {

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomutidd = new MySqlCommand("SELECT *FROM odemeler WHERE araclar_kullanicilar_kullanici_id=@id", baglanti);
                kayitkomutidd.Parameters.AddWithValue("@id", kullaniciid);
                MySqlDataReader ddr = kayitkomutidd.ExecuteReader();
                while (ddr.Read())
                {
                    kayitid = ddr["kayitlar_kayit_id"].ToString();
                    kayitidler.Add(kayitid);

                }
                baglanti.Close();
                for(int i=0;i<kayitidler.Count;i++)
                {
                    baglanti.Open();
                    MySqlCommand kayitkomutid = new MySqlCommand("SELECT araclar_arac_id,odendimi,ucret FROM odemeler WHERE kayitlar_kayit_id=@id", baglanti);
                    kayitkomutid.Parameters.AddWithValue("@id", kayitidler[i]);
                    MySqlDataReader dr = kayitkomutid.ExecuteReader();
                    while(dr.Read())
                    {
                        aracid = dr["araclar_arac_id"].ToString();
                        odendimi = dr["odendimi"].ToString();
                        ucret = dr["ucret"].ToString();
                        ucretler.Add(ucret+" TL");
                        odendimiler.Add(odendimi);
                        aracidler.Add(aracid);
                    }
                    baglanti.Close();
                }
                for (int i = 0; i < kayitidler.Count; i++)
                {
                    baglanti.Open();
                    MySqlCommand kayitkomutid2 = new MySqlCommand("SELECT kayit_girissaat,kayit_cikissaat,kayit_tarih FROM kayitlar WHERE kayit_id=@kytid", baglanti);
                    kayitkomutid2.Parameters.AddWithValue("@kytid", kayitidler[i]);
                    MySqlDataReader dr2 = kayitkomutid2.ExecuteReader();
                    while (dr2.Read())
                    {
                        gsaat = dr2["kayit_girissaat"].ToString();
                        csaat = dr2["kayit_cikissaat"].ToString();
                        tarih = dr2["kayit_tarih"].ToString();
                        girisler.Add(gsaat);
                        cikislar.Add(csaat);
                        tarihler.Add(tarih);
                    }
                    baglanti.Close();

                }
                for(int i = 0;i<aracidler.Count;i++)
                {
                    baglanti.Open();
                    MySqlCommand kayitkomutid3 = new MySqlCommand("SELECT arac_plaka FROM araclar WHERE arac_id=@aid", baglanti);
                    kayitkomutid3.Parameters.AddWithValue("@aid", aracidler[i]);
                    MySqlDataReader dr3 = kayitkomutid3.ExecuteReader();
                    while (dr3.Read())
                    {
                        plaka = dr3["arac_plaka"].ToString();
                        plakalar.Add(plaka);
                    }
                    baglanti.Close();
                }
                for(int i = 0;i<kayitidler.Count;i++)
                {
                    bilgilertablo.Rows.Add(tarihler[i], girisler[i], cikislar[i], plakalar[i], ucretler[i], odendimiler[i]);
                    
                }



            }
            catch(Exception)
            {

            }
            


        }

        private void GirisMenu_Load(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            MySqlCommand kullanicibilgi = new MySqlCommand("SELECT *FROM kullanicilar WHERE kullanici_tc=@tc", baglanti);
            kullanicibilgi.Parameters.AddWithValue("@tc", AnaSayfa.tc);
            MySqlDataReader dre = kullanicibilgi.ExecuteReader();
            while (dre.Read())
            {
                kullaniciid = dre["kullanici_id"].ToString();
                kullaniciadsoyad = dre["kullanici_adsoyad"].ToString();
            }
            baglanti.Close();
            klncbilgi.Text = kullaniciadsoyad;
        }

        private void araccinsibox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void araccinsibox_SelectedValueChanged(object sender, EventArgs e)
        {
            araccinsi = araccinsibox.SelectedItem.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            tcno = tcbox.Text;
            plaka = plakakayitbox.Text;
            
            //tc kontrol etme
            if (TcKontrol(tcno) == false)
            {
                HataBoxForm hata = new HataBoxForm();
                HataBoxForm.baslik = "Veri Hatası";
                HataBoxForm.text = "Lütfen Geçerli Bir \nT.C Numarası Giriniz";
                hata.onayresim.Visible = false;
                hata.Show();


            }
            else
            {
                    // kullanici id ye göre plakayı kontrol etme
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kayitkomutplaka = new MySqlCommand("SELECT arac_plaka FROM araclar WHERE arac_plaka=@plaka", baglanti);
                    kayitkomutplaka.Parameters.AddWithValue("@plaka", plaka);
                    MySqlDataReader dr2 = kayitkomutplaka.ExecuteReader();
                    if (dr2.Read())
                    {
                        HataBoxForm f1 = new HataBoxForm();
                        HataBoxForm.baslik = "Kayıt Hatası";
                        HataBoxForm.text = "Bu Plaka \nZaten Kayıtlı";
                    f1.onayresim.Visible = false;
                        f1.Show();
                    }
                    else
                    {

                    //kimliğe göre kullanici id çekme
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kayitkomutid = new MySqlCommand("SELECT kullanici_id FROM kullanicilar WHERE kullanici_tc=@tc", baglanti);
                    kayitkomutid.Parameters.AddWithValue("@tc", tcno);
                    MySqlDataReader dr = kayitkomutid.ExecuteReader();
                    while (dr.Read())
                    {
                        kullaniciid = dr["kullanici_id"].ToString();
                    }


                    //baglanti veri kaydı
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kayitkomut1 = new MySqlCommand("INSERT INTO araclar (arac_plaka,arac_cinsi,kullanicilar_kullanici_id) VALUES ('" + plaka + "','" + araccinsi + "','" + kullaniciid + "')", baglanti);
                    kayitkomut1.ExecuteNonQuery();
                    baglanti.Close();
                    HataBoxForm f = new HataBoxForm();
                    HataBoxForm.baslik = "Kayıt Başarılı";
                    HataBoxForm.text = "Araç Kaydınız başarılı bir \nşekilde tamamlanmıştır!";
                    f.hataresim.Visible = false;
                    f.onayresim.Visible = true;
                    f.Show();
                    
                }





            }
        }
    }

}
