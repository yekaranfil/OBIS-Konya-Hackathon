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
    }
}
