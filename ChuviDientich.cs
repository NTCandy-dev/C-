using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class tinhchuvi_dientich : Form
    {
        public tinhchuvi_dientich()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tinhchuvi_dientich_Load(object sender, EventArgs e)
        {
            chuvi_tamgiac.Enabled = false;
            dientich_tamgiac.Enabled = false;
            nhap_b_vuong.Enabled = false;
            nhap_c_vuong.Enabled = false;
            chuvi_vuong.Enabled = false;
            dientich_vuong.Enabled = false;
            nhap_b_tron.Enabled = false;
            nhap_c_tron.Enabled = false;
            chuvi_tron.Enabled = false;
            dientich_tron.Enabled = false;
            Nhap_c_chunhat.Enabled = false;
            chuvi_chunhat.Enabled = false;
            dientich_chunhat.Enabled = false;
        }

        private void phanloai_tamgiac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true; 
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nhap_a_giac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nhap_b_giac_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhap_b_giac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nhap_c_giac_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhap_c_giac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cacula_Click(object sender, EventArgs e)
        {
            //tam_giac
            if (radio_tamgiac.Checked)
            {
                if (string.IsNullOrEmpty(nhap_a_giac.Text) || string.IsNullOrEmpty(nhap_b_giac.Text) || string.IsNullOrEmpty(nhap_c_giac.Text))
                {
                    MessageBox.Show("Không thể để trống dữ liệu","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double canha_giac = double.Parse(nhap_a_giac.Text);
                    double canhb_giac = double.Parse(nhap_b_giac.Text);
                    double canhc_giac = double.Parse(nhap_c_giac.Text);
                    if (canha_giac + canhb_giac <= canhc_giac || canha_giac + canhc_giac <= canhb_giac || canhb_giac + canhc_giac <= canha_giac)
                    {
                        MessageBox.Show("Tam giác không hợp lệ !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (canha_giac == canhb_giac && canhb_giac == canhc_giac && canhc_giac == canha_giac)
                        {
                            phanloai_tamgiac.Text = "Tam giác đều";
                        }
                        else if (canha_giac == canhb_giac || canhb_giac == canhc_giac || canhc_giac == canha_giac)
                        {
                            phanloai_tamgiac.Text = "Tam giác cân";
                        }
                        else if (Math.Pow(canha_giac,2) + Math.Pow(canhb_giac,2) == Math.Pow(canhc_giac,2) ||
                                 Math.Pow(canhb_giac, 2) + Math.Pow(canhc_giac, 2) == Math.Pow(canha_giac, 2) ||
                                 Math.Pow(canhc_giac, 2) + Math.Pow(canha_giac, 2) == Math.Pow(canhb_giac, 2))
                        {
                            phanloai_tamgiac.Text = "Tam giác vuông";
                        }
                        else
                        {
                            phanloai_tamgiac.Text = "Tam giác thường";
                        }
                        chuvi_tamgiac.Text = (canha_giac + canhb_giac + canhc_giac).ToString();
                        double nuachuvi = (canha_giac + canhb_giac + canhc_giac) / 2;
                        double ketqua = nuachuvi * (nuachuvi - canha_giac) * (nuachuvi - canhb_giac) * (nuachuvi - canhc_giac);
                        dientich_tamgiac.Text = (Math.Sqrt(ketqua)).ToString();
                    }
                }
            }

            //vuong
            else if (radio_vuong.Checked)
            {
                if (string.IsNullOrEmpty(nhap_a_vuong.Text))
                {
                    MessageBox.Show("Không thể để trống dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double canh_a_vuong = double.Parse(nhap_a_vuong.Text);
                    chuvi_vuong.Text = (4 * canh_a_vuong).ToString();
                    dientich_vuong.Text = (Math.Pow(canh_a_vuong, 2)).ToString();
                }
            }

            //tron
            else if (radio_tron.Checked)
            {
                if (string.IsNullOrEmpty(nhap_a_tron.Text))
                {
                    MessageBox.Show("Không thể để trống dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double pi = Math.PI;
                    double bankinh = double.Parse(nhap_a_tron.Text);
                    chuvi_tron.Text = (2 * pi * bankinh).ToString();
                    dientich_tron.Text = (pi * Math.Pow(bankinh, 2)).ToString();    
                }
            }

            //chunhat
            else if(radio_chunhat.Checked)
            {
                if(string.IsNullOrEmpty(Nhap_a_chunhat.Text) || string.IsNullOrEmpty(Nhap_b_chunhat.Text))
                {
                    MessageBox.Show("Không thể để trống dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double canhdai = double.Parse(Nhap_a_chunhat.Text);
                    double canhrong = double.Parse(Nhap_b_chunhat.Text);
                    chuvi_chunhat.Text = ((canhdai + canhrong)*2).ToString();
                    dientich_chunhat.Text = (canhdai * canhrong).ToString();
                }
            }
        }
        private void Hideall_groupbox(object sender, EventArgs e)
        {
            hinhvuong.Visible=false;
            hinhtron.Visible=false;
            hinhchunhat.Visible=false;
            tamgiac.Visible=false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_vuong.Checked)
            {
                Hideall_groupbox (sender, e);
                hinhvuong.Visible = true;
                nhap_a_vuong.Focus();
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_tron.Checked)
            {
                Hideall_groupbox(sender, e);
                hinhtron.Visible = true;
                nhap_a_tron.Focus();
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_chunhat.Checked)
            {
                Hideall_groupbox(sender, e);
                hinhchunhat.Visible = true;
                Nhap_a_chunhat.Focus();
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_tamgiac.Checked)
            {
                Hideall_groupbox(sender, e);
                tamgiac.Visible = true;
                nhap_a_giac.Focus();
            }
           
        }
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void nhap_a_tron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void nhap_a_vuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Nhap_a_chunhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Nhap_b_chunhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (radio_vuong.Checked)
            {
                nhap_a_vuong.Clear();
                chuvi_vuong.Clear();
                dientich_vuong.Clear();
            }
            else if (radio_tron.Checked)
            {
                nhap_a_tron.Clear();
                chuvi_tron.Clear();
                dientich_tron.Clear();
            }
            else if (radio_chunhat.Checked)
            {
                Nhap_a_chunhat.Clear();
                Nhap_b_chunhat.Clear();
                chuvi_chunhat.Clear();
                dientich_chunhat.Clear();
            }
            else if (radio_tamgiac.Checked)
            {
                nhap_a_giac.Clear();
                nhap_b_giac.Clear();
                nhap_c_giac.Clear();
                chuvi_tamgiac.Clear();
                dientich_tamgiac.Clear();
                phanloai_tamgiac.Clear(); 
            }
        }

        private void hinhvuong_Enter(object sender, EventArgs e)
        {
       
           
        }

        private void hinhtron_Enter(object sender, EventArgs e)
        {
           
         
        }

        private void hinhchunhat_Enter(object sender, EventArgs e)
        {
            
  
            
        }

        private void tamgiac_Enter(object sender, EventArgs e)
        {
            

        }

        private void nhap_a_tron_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
