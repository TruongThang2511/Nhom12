namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtmatkhau.Text == "admin")
                MessageBox.Show("Đăng nhập thành công nha.");
        }
    }
}