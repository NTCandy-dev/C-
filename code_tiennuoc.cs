using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienNuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sonhankhau_tb.Enabled = false;
            tieuthu_tb.Enabled = false;
            dinhmuc_tb.Enabled = false;
            vuotdinhmuc_tb.Enabled = false;
            tiensudung_tb.Enabled = false;
            phiphantram_tb.Enabled = false;
            tienphaitra_tb.Enabled = false;
            hienthi.Enabled = false;

        }

        private void sonhankhau_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void sonhankhau_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] sonhankhau = {2,4,6,7,1,8,9,3,2,4};
            int choosedItem = username.SelectedIndex;
            for (int i = 0; i<sonhankhau.Length; i++)
            {
                if(i == choosedItem)
                {
                    sonhankhau_tb.Text = sonhankhau[i].ToString();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sonhankhau_tb.Text) ||
            String.IsNullOrEmpty(chisocu_tb.Text) ||
            String.IsNullOrEmpty(chisomoi_tb.Text))
            {
                MessageBox.Show("Vẫn còn thông tin bị thiếu !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            int chisocu = int.Parse(chisocu_tb.Text);
            int chisomoi = int.Parse(chisomoi_tb.Text);
            int tieuthu = chisomoi - chisocu;

            int dinhmuc ;
            int vuotdinhmuc ;
            int sonhankhau = int.Parse(sonhankhau_tb.Text);

            double tiensudung;
            double phiphantram;
            double tienphaitra;

            if (chisocu >= chisomoi)
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //tìm định mức
            if (sonhankhau <= 4)
            {
                dinhmuc = 12;
                vuotdinhmuc = 0;
            }
            else
            {
                dinhmuc = sonhankhau * 4;
                vuotdinhmuc = tieuthu - dinhmuc;
            }

            //tìm vượt định mức
            if (tieuthu < dinhmuc)
            {
                MessageBox.Show("Chỉ số tiêu thụ không thể nhỏ hơn chỉ số định mức !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

                
              
            
            tiensudung = 4000 * dinhmuc + 8000 * vuotdinhmuc;
            phiphantram = tiensudung * 0.1;
            tienphaitra = tiensudung + phiphantram;

            tieuthu_tb.Text = tieuthu.ToString();
            dinhmuc_tb.Text = dinhmuc.ToString();
            vuotdinhmuc_tb.Text = vuotdinhmuc.ToString();
            tiensudung_tb.Text = tiensudung.ToString();
            phiphantram_tb.Text = phiphantram.ToString();
            tienphaitra_tb.Text = tienphaitra.ToString();

            hienthi.Text = "Họ tên: " + username.SelectedIndex.ToString() +
                           "\nSố nhân khẩu: " + sonhankhau.ToString() +
                           "\nTiêu thụ: " + tieuthu.ToString() +
                           "\nTiền sử dụng" + tiensudung.ToString() +
                           "\nPhí phần trăm" + phiphantram.ToString() +
                           "\nTiền phải trả" +tienphaitra.ToString();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo !",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chisocu_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
                e.Handled = true;
        }

        private void chisomoi_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
