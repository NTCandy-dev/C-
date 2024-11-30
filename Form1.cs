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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new Form();
            new_mdi_child.Text = "Cửa sổ con MDI";
            new_mdi_child.MdiParent = this;
            new_mdi_child.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maytinhbotui comp = new Maytinhbotui();
            comp.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cài đặt", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cài đặt", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tínhChuViDiệnTíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChuviDientich sv = new ChuviDientich();
            sv.Show();
        }
    }
}
