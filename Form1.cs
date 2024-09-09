namespace HaHuyHung_Buoi1_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> arr_daySo = new List<int>();
        private void btnnhap_Click(object sender, EventArgs e)
        {
            int so = int.Parse(txtns.Text);
            int tong = 0;
            arr_daySo.Add(so);
            txtdvn.Text = " ";
            foreach (int i in arr_daySo)
            {
                txtdvn.Text += i + " ";
                tong += i;
            }
            txtns.Text = " ";

            int sum = 0;
            for (int i = 0; i < arr_daySo.Count; i++)
            {
                sum += arr_daySo[i];
                txttong.Text = sum.ToString();
            }

            int tongchan = 0;
            for (int i = 0; i < arr_daySo.Count; i++)
            {
                if (arr_daySo[i] % 2 == 0)
                {
                    tongchan += arr_daySo[i];
                    txtchan.Text = tongchan.ToString();
                }
            }

            int tongle = 0;
            for (int i = 0; i < arr_daySo.Count; i++)
            {
                if (arr_daySo[i] % 2 != 0)
                {
                    tongle += arr_daySo[i];
                    txtle.Text = tongle.ToString();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            txtns.ResetText();
            txtdvn.ResetText();
            txttong.ResetText();
            txtle.ResetText();
            txtchan.ResetText();
        }
    }
}
