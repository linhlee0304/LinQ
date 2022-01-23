using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHThuCung
{
    public partial class fNhanVien : Form
    {
        public int idNV;
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            fDangNhap fDN = new fDangNhap();

            this.Close();
            fDN.Show();
        }
    }
}
