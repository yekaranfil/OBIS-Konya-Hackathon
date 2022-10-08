/*
 *  DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 *  Copyright © (C) 2022 Tunex Digital Yazılım Ltd Şti - All Rights Reserved
 *  Unauthorized copying of this file, via any medium is strictly prohibited
 *  Proprietary and confidential.
 *  
 *  Copyright ©  August 2022 Tunex Digital @ http://tunexdigital.com
 *  
 *  Written by Yusuf Emre Karanfil & M.Sait Kocabaş <emrekaranfil@tunexdigital.com>, August 2022
 *   :Contributors:
 *        Y.Emre Karanfil
 *        M.Sait Kocabaş
 *        Necmettin Zıvlak
 *        Fatih Tün
 */


using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace obiskonya
{
    

    public partial class OtoparkDurumForm : Form
    {
        ArrayList bosyerler = new ArrayList();
        String otoparkad, otoparkid, otoparkadres, otoparkkonum, yerid,bos,dolu;

        DataTable tablo = new DataTable();
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=obiskonya;user=root;password=1234;SslMode=none");
        public OtoparkDurumForm()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OtoparkDurumForm_Load(object sender, EventArgs e)
        {
            try
            {

                otoparktablo.ColumnCount = 1;            
                otoparktablo.Columns[0].Name = "Boş Sayısı";
                otoparktablo.Columns[0].ValueType = typeof(String);
                baglanti.Close();
                baglanti.Open();
                MySqlDataAdapter otoparkveri = new MySqlDataAdapter("SELECT *FROM otoparklar ORDER BY otopark_id",baglanti);
                otoparkveri.Fill(tablo);
                otoparktablo.DataSource = tablo;
                baglanti.Close();

                otoparktablo.Columns[0].Visible = false;
                otoparktablo.Columns[1].Visible = false;
                otoparktablo.Columns[4].Visible = false;
                boslbl.Visible = true;
                otoparkadilbl.Visible = true;
                ilcelbl.Visible = true;
               

                baglanti.Open();
                MySqlCommand otoparkidgetir = new MySqlCommand("SELECT otopark_id FROM otoparklar ", baglanti);
                MySqlDataReader id = otoparkidgetir.ExecuteReader();
                while(id.Read())
                {
                    bosyerler.Add(id["otopark_id"].ToString());
                }
                baglanti.Close();

                
                for(int i=0; i<bosyerler.Count;i++)
                {
                    baglanti.Open();
                    MySqlCommand bossayisigetir = new MySqlCommand("SELECT bossayisi FROM yerbilgisi WHERE otoparklar_otopark_id=@otoparkid", baglanti);
                    bossayisigetir.Parameters.AddWithValue("@otoparkid", bosyerler[i]);
                    MySqlDataReader bossayi = bossayisigetir.ExecuteReader();
                    bossayi.Read();
                    bos = bossayi["bossayisi"].ToString();
                    otoparktablo.Rows[i].Cells[5].Value = bos;

                    baglanti.Close();
                        

                }
                
                

                
                
            }
            catch
            {

            }
        }
    }
}
