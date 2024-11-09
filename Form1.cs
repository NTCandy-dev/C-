using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khambenh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            
            if (h == DialogResult.Yes)
            {
                Application.Exit(); 
            }
           
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Chưa nhập tên");
                tbName.Focus();
                return;
            }
            else if (String.IsNullOrWhiteSpace(tbDay.Text))
            {
                MessageBox.Show("Chưa nhập ngày");
                tbDay.Focus();
                return;
            }
            else if (String.IsNullOrWhiteSpace(tbMonth.Text))
            {
                MessageBox.Show("Chưa nhập tháng");
                tbMonth.Focus();
                return;
            }
            else if (String.IsNullOrWhiteSpace(tbYear.Text))
            {
                MessageBox.Show("Chưa nhập năm");
                tbYear.Focus();
                return;
            }
            else if (result_list.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn dịch vụ");
                return;
            }
       
            // Year
            int a;
            if (!int.TryParse(tbYear.Text, out a))
            {
                MessageBox.Show("Năm không nhập chữ");
                return;
            }
            if (a < 1920 || a > 2024)
            {
                MessageBox.Show("Năm không tồn tại!");
                tbYear.Clear();
                return;
            }

            // Month
            int b;
            int maxday;
            if (!int.TryParse(tbMonth.Text, out b))
            {
                MessageBox.Show("Tháng không nhập chữ");
                return;
            }

            if (b < 1 || b > 12)
            {
                MessageBox.Show("Tháng không tồn tại!");
                tbMonth.Clear();
                return;
            }

            // Day
            int c;
            if (!int.TryParse(tbDay.Text, out c))
            {
                MessageBox.Show("Ngày không nhập chữ");
                return;
            }

           
            if (b == 2)
            {
                
                bool namnhuan = DateTime.IsLeapYear(a);
                maxday = namnhuan ? 29 : 28;

                if (c < 1 || c > maxday)
                {
                    MessageBox.Show($"Ngày không tồn tại !");
                    tbDay.Clear();
                    tbDay.Focus();
                    return;
                }
            }

            else if (b == 4 || b == 6 || b == 9 || b == 11)
            {
              
                maxday = 30;
                if (c < 1 || c > maxday)
                {
                    MessageBox.Show($"Ngày không tồn tại ! ");
                    tbDay.Clear();
                    tbDay.Focus();
                    return;
                }
            }
            else
            {
                
                maxday = 31;
                if (c < 1 || c > maxday)
                {
                    MessageBox.Show($"Ngày không tồn tại ! ");
                    tbDay.Clear();
                    tbDay.Focus();
                    return;
                }
            }

            string name = tbName.Text;
            string day = tbDay.Text;
            string month = tbMonth.Text;
            string year = tbYear.Text;


            var selectedServices = string.Join(", ", result_list.Items.Cast<string>());


            display_result.Text = $"Họ tên: {name}\n" +
                               $"Ngày Sinh: {day}/{month}/{year}\n" +
                               $"Dịch vụ đã chọn: {selectedServices}";
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pick_list.SelectedItem != null && !result_list.Items.Contains(pick_list.SelectedItem))
            {
                    result_list.Items.Add(pick_list.SelectedItem);
            }
        }

        private void tbMonth_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result_list.Items.Clear();
            tbName.Clear();
            tbDay.Clear();
            tbMonth.Clear();
            tbYear.Clear();
            display_result.Clear();
        }

        private void tbDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            result_list.Items.Remove(result_list.SelectedItems[0]);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
