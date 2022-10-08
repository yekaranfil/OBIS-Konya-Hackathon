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

using System;
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
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.02;
            if (this.Opacity == 100)
            {
                timer1.Stop();
            }
        }

        private void Acilis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            AnaSayfa f = new AnaSayfa();
            f.Show();
            this.Hide();
            timer2.Stop();
        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
