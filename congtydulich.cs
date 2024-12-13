using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Dichvu
{   
    public partial class congtydulich : Form
    {
  
        public congtydulich()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void congtydulich_Load(object sender, EventArgs e)
        {
            tongngay.Enabled = false;
            diemden.SelectedIndex = 0;
            diemdi.SelectedIndex = 0;
            
            ngaydi.Format = DateTimePickerFormat.Short;
            ngayve.Format = DateTimePickerFormat.Short;
            ngaysinh.Format = DateTimePickerFormat.Short;

            ngaydi.MinDate = DateTime.Now.AddMonths(-12);
            ngaydi.ValueChanged += ngaydi_ValueChanged;

            ngayve.MinDate = ngaydi.Value.Date;
            ngayve.MaxDate = DateTime.Now.AddMonths(24);

            ngaysinh.MaxDate = DateTime.Now.AddMonths(-6);
            ngaysinh.MinDate = new DateTime(1930, 1, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc chắn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tongngay.Clear();
            hienthi_result.Clear();
            name.Clear();
            diachi.Clear();
            ngaydi.Value = DateTime.Now.Date;
            ngayve.Value = DateTime.Now.Date;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(diachi.Text))
            {
                MessageBox.Show("Thông tin không thể để trống !! ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
                double tinh_tongngay = (ngayve.Value - ngaydi.Value).TotalDays;
                tongngay.Text = ($"{tinh_tongngay:F0}").ToString();
                hienthi_result.Text = "Khách hàng: " + name.Text +
                                      "\n Ngày sinh: " + ngaysinh.Text +
                                      "\nĐịa chỉ: " + diachi.Text +
                                      "\nĐịa điểm xuất phát: " + diemdi.SelectedItem.ToString() +
                                      "\nĐịa điểm đến: " + diemden.SelectedItem.ToString();

        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !(e.KeyChar >= 'a' && e.KeyChar <= 'z')
                                          && !(e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
                e.Handled = true;
        }

        private void ngayve_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ngaydi_ValueChanged(object sender, EventArgs e)
        {     
            ngayve.MinDate = ngaydi.Value.Date;
            //ngayve.MinDate = ngaydi.Value.Date;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
