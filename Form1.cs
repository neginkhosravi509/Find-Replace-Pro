using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string strfind = txtfind.Text.Trim();
            int position = txtpaper.Text.IndexOf(strfind, 0);
            if (position >= 0)
            {
                txtpaper.Focus();
                txtpaper.Select(position, strfind.Length);
            }
            else
                MessageBox.Show("واژه یافت نشد");
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            string strfind = txtfind.Text.Trim();
            string strreplace = txtreplace.Text.Trim();
            txtpaper.Text = txtpaper.Text.Replace(strfind, strreplace);
        }
    }
}
