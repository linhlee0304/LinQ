using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHThuCung.BUS;

namespace QLCHThuCung
{
    public partial class FDHNhanVien : Form
    {
        public int idD;
        public int maNV;
        BUS_DonHang bDonHang;
        public FDHNhanVien()
        {
            InitializeComponent();
            bDonHang = new BUS_DonHang();
        }

        private void LayDSDHNV(int maNV)
        {
            dgvDSDH.DataSource = null;
            bDonHang.LayDSDHNV(dgvDSDH, maNV);

            dgvDSDH.Columns[0].Width = (int)(dgvDSDH.Width * 0.25);
            dgvDSDH.Columns[1].Width = (int)(dgvDSDH.Width * 0.35);

            dgvDSDH.Columns[0].HeaderText = "ID";
            dgvDSDH.Columns[1].HeaderText = "Ngày Tạo";
        }
        private void FDonHangCuaKH_Load(object sender, EventArgs e)
        {
            LayDSDHNV(maNV);
        }

        private void dgvDSDH_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(dgvDSDH.CurrentRow.Cells[0].Value.ToString());
            FCTDonHang f = new FCTDonHang();
            f.maDH = ma;
            f.idCT = this.idD;
            f.ShowDialog();
        }
    }
}
