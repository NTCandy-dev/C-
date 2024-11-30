using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class ChuviDientich : Form
    {
        public ChuviDientich()
        {
            InitializeComponent();
        }

        private void textbox_a_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ChuviDientich_Load(object sender, EventArgs e)
        {
            chuvi_vuong.Enabled = false;
            dientich_vuong.Enabled = false;
            chuvi_tamgiac.Enabled = false;
            dientich_tamgiac.Enabled = false;
            chuvi_chunhat.Enabled = false;
            dientich_chunhat.Enabled = false;
            chuvi_tron.Enabled = false;
            dientich_tron.Enabled = false;
            hienthi_loai.Enabled = false;
            phanloai_chunhat.Enabled = false;
            nhapc_chunhat.Enabled = false;
            nhapb_tron.Enabled = false;
            nhapc_tron.Enabled = false;

        }

        private void hienthiloai_tamgiac_TextChanged(object sender, EventArgs e)
        {

        }

        private void hienthiloai_tamgiac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
