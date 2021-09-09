using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swicth_case_ile_ay_yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: l2.Text = ("OCAK"); break;
                case 2: l2.Text = ("ŞUBAT"); break;
                case 3: l2.Text = ("MART"); break;
                case 4: l2.Text = ("NİSAN"); break;
                case 5: l2.Text = ("MAYIS"); break;
                case 6: l2.Text = ("HAZİRAN"); break;
                case 7: l2.Text = ("TEMMUZ"); break;
                case 8: l2.Text = ("AĞUSTOS"); break;
                case 9: l2.Text = ("EYLÜL"); break;
                case 10: l2.Text = ("EKİM"); break;
                case 11: l2.Text = ("KASIM"); break;
                case 12: l2.Text = ("ARALIK"); break;
                default: l2.Text = ("HATALI GİRİŞ"); break;

            }
        }
    }
}
