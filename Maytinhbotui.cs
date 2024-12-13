using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class maytinhtay : Form
    {
        private String pheptoan = "";
        private double sothunhat = 0;
        private bool dieukien = true;
        public maytinhtay()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_ForeColorChanged(object sender, EventArgs e)
        {
            
        }

        private void hienthi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void maytinhtay_ForeColorChanged(object sender, EventArgs e)
        {
            hienthi.ForeColor = Color.Blue;
        }

        private void maytinhtay_Load(object sender, EventArgs e)
        {
            hienthi.SelectionStart = hienthi.Text.Length;
            hienthi.ScrollToCaret();
        }

        private void mot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void hai_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void ba_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void bon_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void nam_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void sau_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void bay_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void tam_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void chin_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void khong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hienthi.Text == "0" || dieukien)
            {
                hienthi.Clear();
            }
            dieukien = false;
            hienthi.Text += btn.Text;
        }

        private void cong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(!string.IsNullOrEmpty(pheptoan) || dieukien)
            {   
                pheptoan = btn.Text;
                hienthi.Text = pheptoan;
                return;
            }
            else if (string.IsNullOrEmpty(hienthi.Text))
                sothunhat = 0;
            else
            {
                if(sothunhat != 0 || string.IsNullOrEmpty(pheptoan))
                    bang.PerformClick();
                else 
                    sothunhat = double.Parse(hienthi.Text);
            }
            pheptoan = btn.Text;
            dieukien = true;
            hienthi.Text += btn.Text;
        }

        private void tru_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(pheptoan) && dieukien)
            {
                pheptoan = btn.Text;
                hienthi.Text = pheptoan;
                return;
            }

            else if(string.IsNullOrEmpty(hienthi.Text))
                sothunhat = 0;
            else
            {
                if (sothunhat != 0 && !string.IsNullOrEmpty(pheptoan))
                    bang.PerformClick();
                else
                    sothunhat = double.Parse(hienthi.Text);
            }
            pheptoan = btn.Text;
            dieukien = true;
            hienthi.Text += btn.Text;
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(pheptoan) && dieukien)
            {
                pheptoan = btn.Text;
                hienthi.Text = pheptoan;
                return;
            }

            else if(string.IsNullOrEmpty(hienthi.Text))
                sothunhat = 0;
            else
            {
                if (sothunhat != 0 && !string.IsNullOrEmpty(pheptoan))
                    bang.PerformClick();
                else
                    sothunhat = double.Parse(hienthi.Text);
            }
            pheptoan = btn.Text;
            dieukien = true;
            hienthi.Text += btn.Text;
        }

        private void chia_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(pheptoan) && dieukien)
            {
                pheptoan = btn.Text;
                hienthi.Text = pheptoan;
                return;
            }

            else if (string.IsNullOrEmpty(hienthi.Text))
                sothunhat = 0;
            else
            {
                if (sothunhat != 0 && !string.IsNullOrEmpty(pheptoan))
                    bang.PerformClick();
                else
                    sothunhat = double.Parse(hienthi.Text);
            }
            pheptoan = btn.Text;
            dieukien = true;
            hienthi.Text += btn.Text;
        }

        private void bang_Click(object sender, EventArgs e)
        {
            try
            {
                double sothuhai = double.Parse(hienthi.Text);
                switch (pheptoan)
                {
                    case "+":
                        hienthi.Text = (sothunhat + sothuhai).ToString();
                        break;
                    case "-":
                        hienthi.Text = (sothunhat - sothuhai).ToString();
                        break;
                    case "*":
                        hienthi.Text = (sothunhat * sothuhai).ToString();
                        break;
                    case "/":
                        if(sothuhai == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                            hienthi.Text = (sothunhat / sothuhai).ToString();
                            break;
                }
                sothunhat = double.Parse(hienthi.Text);
                pheptoan = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            hienthi.Text = "0";
            sothunhat = 0;
            pheptoan = "";
        }
    }
}
