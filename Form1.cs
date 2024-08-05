namespace CSharp_TinhLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tiengui = Convert.ToDouble(txtTienGui.Text);
            double laisuat = Convert.ToDouble(txtLaiSuat.Text) / 100;
            double sonam = Convert.ToDouble(txtSoNam.Text);
            

            double tienlai = tiengui * laisuat * sonam;
            double tongsotien = tiengui + tienlai;

            lblKQ.Text = tongsotien.ToString();
            lblTienLai.Text = tienlai.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
