namespace BaiTap4_4_FastFood
{
    public partial class FrmFastFood : Form
    {
        public FrmFastFood()
        {
            InitializeComponent();
        }

        private void FrmFastFood_Load(object sender, EventArgs e)
        {
            lstMenu.Items.Add(new MonAn { Ten = "Hamburger", Gia = 50000 });
            lstMenu.Items.Add(new MonAn { Ten = "Pizza", Gia = 120000 });
            lstMenu.Items.Add(new MonAn { Ten = "Gà Rán", Gia = 35000 });
            lstMenu.Items.Add(new MonAn { Ten = "Pepsi", Gia = 15000 });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);
                TinhTong();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                TinhTong();
            }
        }

        private void TinhTong()
        {
            int tong = 0;
            foreach (MonAn mon in lstSelected.Items)
            {
                tong = tong + mon.Gia;
            }
            lblTotal.Text = "Tổng tiền: " + tong + "đ";
        }
    }
}
