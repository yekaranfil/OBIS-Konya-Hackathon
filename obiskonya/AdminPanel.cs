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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=obiskonya;user=root;password=1234;SslMode=none");
        Random rastgele = new Random();
        string plaka, giriskayit, cikiskayit,aracid,kullaniciid,kayitid,otoparkidd;
        string b = "B";
        int saat, dakika, kalinandakika, kalinansaat,bos,dolu;
        String tarih;
        private void ilcebox_SelectedValueChanged(object sender, EventArgs e)
        {
            String ilce_adi = ilcebox.SelectedItem.ToString();
            if (ilce_adi.Equals("MERKEZ"))
            {
                otoparkbox.Items.Clear();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomutid = new MySqlCommand("SELECT otopark_adi FROM otoparklar WHERE otopark_adres=@ilce", baglanti);
                kayitkomutid.Parameters.AddWithValue("@ilce", ilce_adi);
                MySqlDataReader dr = kayitkomutid.ExecuteReader();
                while (dr.Read())
                {
                    otoparkbox.Items.Add(dr["otopark_adi"].ToString());
                }

            }
            else if (ilce_adi.Equals("KARATAY"))
            {
                otoparkbox.Items.Clear();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomutid = new MySqlCommand("SELECT otopark_adi FROM otoparklar WHERE otopark_adres=@ilce", baglanti);
                kayitkomutid.Parameters.AddWithValue("@ilce", ilce_adi);
                MySqlDataReader dr = kayitkomutid.ExecuteReader();
                while (dr.Read())
                {
                    otoparkbox.Items.Add(dr["otopark_adi"].ToString());
                }
            }
            else if (ilce_adi.Equals("MERAM"))
            {
                otoparkbox.Items.Clear();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomutid = new MySqlCommand("SELECT otopark_adi FROM otoparklar WHERE otopark_adres=@ilce", baglanti);
                kayitkomutid.Parameters.AddWithValue("@ilce", ilce_adi);
                MySqlDataReader dr = kayitkomutid.ExecuteReader();
                while (dr.Read())
                {
                    otoparkbox.Items.Add(dr["otopark_adi"].ToString());
                }
            }
            else if (ilce_adi.Equals("SELÇUKLU"))
            {
                otoparkbox.Items.Clear();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomutid = new MySqlCommand("SELECT otopark_adi FROM otoparklar WHERE otopark_adres=@ilce", baglanti);
                kayitkomutid.Parameters.AddWithValue("@ilce", ilce_adi);
                MySqlDataReader dr = kayitkomutid.ExecuteReader();
                while (dr.Read())
                {
                    otoparkbox.Items.Add(dr["otopark_adi"].ToString());
                }
            }
            else
            {
                HataBoxForm f = new HataBoxForm();
                HataBoxForm.baslik = "Seçim Hatası";
                HataBoxForm.text = "Lütfen İlçe Seçiniz";

                f.onayresim.Visible = false;
                f.Show();
            }

        }

        ArrayList zaman = new ArrayList();

        private void cikissaatbuton_Click(object sender, EventArgs e)
        {
            try
            {
                kalinandakika = rastgele.Next(1, 60);
                kalinansaat = rastgele.Next(1, 6);
                plaka = plakabox.Text;
                giriskayit = DateTime.Now.ToString().Substring(11, 5);
                cikiskayit = DateTime.Now.ToString().Substring(11, 5);

                String[] sure = cikiskayit.Split(':');
                foreach (var sures in sure)
                {
                    zaman.Add(sures);
                }

                float ucretdakika = (kalinansaat * 60) + (kalinandakika);
                float ucret = (float)((float)ucretdakika * 0.10);
                //sistem saat ve dakika parçası
                saat = int.Parse(zaman[0].ToString());
                dakika = int.Parse(zaman[1].ToString());
                label5.Text = ucret + " " + "TL";
                int randomsaat = saat + kalinansaat;
                int randomdakika = dakika + kalinandakika;





                if (randomdakika >= 60)
                {

                    randomsaat++;
                    randomdakika = randomdakika % 60;

                }
                String cikissaatkayit = randomsaat.ToString() + ":" + randomdakika.ToString();


                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitk = new MySqlCommand("SELECT arac_id,kullanicilar_kullanici_id FROM araclar WHERE arac_plaka=@plaka", baglanti);
                kayitk.Parameters.AddWithValue("@plaka", plaka);
                MySqlDataReader dk = kayitk.ExecuteReader();
                if (dk.Read())
                {
                    kullaniciid = dk["kullanicilar_kullanici_id"].ToString();
                    aracid = dk["arac_id"].ToString();
                }
                baglanti.Close();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitk1 = new MySqlCommand("SELECT kayit_id,otoparklar_otopark_id FROM kayitlar WHERE kayit_cikissaat=@c AND araclar_kullanicilar_kullanici_id=@kullaniciid", baglanti);
                kayitk1.Parameters.AddWithValue("@c", b);
                kayitk1.Parameters.AddWithValue("@kullaniciid", kullaniciid);
                MySqlDataReader dk1 = kayitk1.ExecuteReader();
                if (dk1.Read())
                {
                    kayitid = dk1["kayit_id"].ToString();
                    otoparkidd = dk1["otoparklar_otopark_id"].ToString();
                }
                baglanti.Close();

                baglanti.Close();
                baglanti.Open();
                MySqlCommand cikisupdate = new MySqlCommand("UPDATE kayitlar SET kayit_cikissaat=@cikis WHERE kayit_cikissaat=@c AND araclar_kullanicilar_kullanici_id=@kullaniciid", baglanti);
                cikisupdate.Parameters.AddWithValue("@cikis", cikissaatkayit);
                cikisupdate.Parameters.AddWithValue("@c", b);
                cikisupdate.Parameters.AddWithValue("@kullaniciid", kullaniciid);
                cikisupdate.ExecuteNonQuery();
                baglanti.Close();


                label4.Text = "Otoparkta Kalınan süre\n" + kalinansaat.ToString() + " Saat " + kalinandakika.ToString() + " Dakika'dır. ";

                label4.Visible = true;
                label5.Visible = true;

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomut = new MySqlCommand("SELECT bossayisi,dolusayisi FROM yerbilgisi WHERE otoparklar_otopark_id=@id", baglanti);
                kayitkomut.Parameters.AddWithValue("@id", otoparkid);
                MySqlDataReader dr1 = kayitkomut.ExecuteReader();
                if (dr1.Read())
                {
                    bos = int.Parse(dr1["bossayisi"].ToString());
                    dolu = int.Parse(dr1["dolusayisi"].ToString());

                }

                bos++;
                dolu--;

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitguncelle = new MySqlCommand("UPDATE yerbilgisi SET bossayisi=@bos , dolusayisi=@dolu WHERE otoparklar_otopark_id=@otoparkid ", baglanti);
                kayitguncelle.Parameters.AddWithValue("@bos", bos.ToString());
                kayitguncelle.Parameters.AddWithValue("@dolu", dolu.ToString());
                kayitguncelle.Parameters.AddWithValue("@otoparkid", otoparkid);
                kayitguncelle.ExecuteNonQuery();
                baglanti.Close();

                //cıkış veri kaydı
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kayitkomut1 = new MySqlCommand("INSERT INTO odemeler (kayitlar_kayit_id,kayitlar_otoparklar_otopark_id,araclar_arac_id,araclar_kullanicilar_kullanici_id,odendimi,ucret) VALUES ('" + kayitid + "','" + otoparkidd + "','" + aracid + "','" + kullaniciid + "','" + "HAYIR" + "','" + ucret + "')", baglanti);

                kayitkomut1.ExecuteNonQuery();
                baglanti.Close();
                HataBoxForm f = new HataBoxForm();
                HataBoxForm.baslik = "Kayıt Başarılı";
                HataBoxForm.text = "Araç Çıkış Kaydınız başarılı \nbir  şekilde tamamlanmıştır!";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;
                f.Show();
            }
            catch
            {

            }
            



        }
        String otoparkad, otoparkid;
        private void girissaatbuton_Click(object sender, EventArgs e)
        {

            
            otoparkad = otoparkbox.SelectedItem.ToString();
            tarih = DateTime.Now.ToString().Substring(0, 10).ToString();

            baglanti.Close();
            baglanti.Open();
            MySqlCommand kayitkomutid = new MySqlCommand("SELECT otopark_id FROM otoparklar WHERE otopark_adi=@ad", baglanti);
            kayitkomutid.Parameters.AddWithValue("@ad", otoparkad);
            MySqlDataReader dr = kayitkomutid.ExecuteReader();
            while (dr.Read())
            {
               otoparkid = dr["otopark_id"].ToString();
            }
            baglanti.Close();



            plaka = plakabox.Text;
            giriskayit = DateTime.Now.ToString().Substring(11, 5);


            String[] sure = giriskayit.Split(':');
            foreach (var sures in sure)
            {
                zaman.Add(sures);
            }
            saat = int.Parse(zaman[0].ToString());
            dakika = int.Parse(zaman[1].ToString());



            //veri kaydı
            baglanti.Close();
            baglanti.Open();
            MySqlCommand kayitk = new MySqlCommand("SELECT arac_id,kullanicilar_kullanici_id FROM araclar WHERE arac_plaka=@plaka", baglanti);
            kayitk.Parameters.AddWithValue("@plaka", plaka);
            MySqlDataReader dk = kayitk.ExecuteReader();
            if (dk.Read())
            {
                aracid = dk["arac_id"].ToString();
                kullaniciid = dk["kullanicilar_kullanici_id"].ToString();
            }
            baglanti.Close();

            baglanti.Close();
            baglanti.Open();
            MySqlCommand kayitkomut1 = new MySqlCommand("INSERT INTO kayitlar (kayit_girissaat,kayit_cikissaat,kayit_tarih,otoparklar_otopark_id,araclar_arac_id,araclar_kullanicilar_kullanici_id) VALUES ('" + giriskayit + "','" + 'B' + "','" + tarih.ToString() + "','" + otoparkid + "','" + aracid + "','" + kullaniciid + "')", baglanti); ;
            kayitkomut1.ExecuteNonQuery();
            baglanti.Close();
            HataBoxForm f = new HataBoxForm();
            HataBoxForm.baslik = "Kayıt Başarılı";
            HataBoxForm.text = "Araç Giriş Kaydınız başarılı \nbir şekilde tamamlanmıştır!";
            f.hataresim.Visible = false;
            f.onayresim.Visible = true;
            f.Show();



            baglanti.Close();
            baglanti.Open();
            MySqlCommand kayitkomut = new MySqlCommand("SELECT bossayisi,dolusayisi FROM yerbilgisi WHERE otoparklar_otopark_id=@id", baglanti);
            kayitkomut.Parameters.AddWithValue("@id", otoparkid);
            MySqlDataReader dr1 = kayitkomut.ExecuteReader();
            if (dr1.Read())
            {
                bos = int.Parse(dr1["bossayisi"].ToString());
                dolu = int.Parse(dr1["dolusayisi"].ToString());

            }

            bos--;
            dolu++;

            baglanti.Close();
            baglanti.Open();
            MySqlCommand kayitguncelle = new MySqlCommand("UPDATE yerbilgisi SET bossayisi=@bos , dolusayisi=@dolu WHERE otoparklar_otopark_id=@otoparkid ", baglanti);
            kayitguncelle.Parameters.AddWithValue("@bos", bos.ToString());
            kayitguncelle.Parameters.AddWithValue("@dolu", dolu.ToString());
            kayitguncelle.Parameters.AddWithValue("@otoparkid", otoparkid);
            kayitguncelle.ExecuteNonQuery();
            baglanti.Close();

        }
        
        private void plakabox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (plakabox.Text.Equals("PLAKA"))
            {
                plakabox.Clear();
            }
        }
    }
}
