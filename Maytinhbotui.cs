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
    public partial class Maytinhbotui : Form
    {
        private String input = "";
        private double sodau = 0;
        private String pheptoan = "";
        private String hienthi_ketqua = "";
        public Maytinhbotui()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button_Click(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            hienthi_ketqua += btn.Text;
            hienthi.Text = hienthi_ketqua;
            
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (input != "")
            {
                sodau = double.Parse(input);
                input = "";
            }
            pheptoan = btn.Text;
            hienthi_ketqua += " " + btn.Text + " "; 
            hienthi.Text = hienthi_ketqua;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            hienthi.Clear();
            sodau = 0;
            input = "";
            pheptoan = "";
        }

        private void Maytinhbotui_Load(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            double sotieptheo;
            if(double.TryParse(input, out sotieptheo))
            {
                double result = 0;
                switch (pheptoan)
                {
                    case "+":
                        result = sodau + sotieptheo;
                        break;
                    case "-":
                        result = sodau - sotieptheo;
                        break;
                    case "*":
                        result = sodau * sotieptheo;
                        break;
                    case "/":
                        if(sotieptheo == 0 )
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return;
                        }
                        else
                        {
                            result = sodau / sotieptheo;
                        }
                        break;    
                }
                hienthi_ketqua += " = " + result.ToString(); 
                hienthi.Text = hienthi_ketqua;
                input = result.ToString(); 
                pheptoan = "";
            }
        }

        private void cong_Click(object sender, EventArgs e)
        {
            hienthi.Text += "+";
        }

        private void mot_Click(object sender, EventArgs e)
        {
            hienthi.Text += "1";
        }

        private void hai_Click(object sender, EventArgs e)
        {
            hienthi.Text += "2";
        }

        private void ba_Click(object sender, EventArgs e)
        {
            hienthi.Text += "3";
        }

        private void bon_Click(object sender, EventArgs e)
        {
            hienthi.Text += "4";
        }

        private void nam_Click(object sender, EventArgs e)
        {
            hienthi.Text += "5";
        }

        private void sau_Click(object sender, EventArgs e)
        {
            hienthi.Text += "6";
        }

        private void bay_Click(object sender, EventArgs e)
        {
            hienthi.Text += "7";
        }

        private void tam_Click(object sender, EventArgs e)
        {
            hienthi.Text += "8";
        }

        private void chin_Click(object sender, EventArgs e)
        {
            hienthi.Text += "9";
        }

        private void khong_Click(object sender, EventArgs e)
        {
            hienthi.Text += "0";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            hienthi.Text += "-";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            hienthi.Text += "*";
        }

        private void chia_Click(object sender, EventArgs e)
        {
            hienthi.Text += "/";
        }
    }
}
