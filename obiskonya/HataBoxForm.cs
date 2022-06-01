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
    public partial class HataBoxForm : Form
    {

        public static String baslik, text;
        public HataBoxForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tamambtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HataYazdir(String baslik, String text)
        {
            hatabaslik.Text = baslik;
            hatatext.Text = text;
        }
        private void guna2GradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void hatatext_Click(object sender, EventArgs e)
        {

        }

        private void HataBoxForm_Load(object sender, EventArgs e)
        {
            HataYazdir(baslik, text);

        }
    }
}
