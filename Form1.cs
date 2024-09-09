using System.Windows.Forms.Design.Behavior;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int n;
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtN.Text);

            if (SNT(n))
                txtktsnt.Text = n + " là số nguyên tố ";
            else txtktsnt.Text = n + " không phải là số nguyên tố!!! ";

            List<int> list = new List<int>();
            string chuoi = " ";

            for (int i = 2; i < n; i++)
            {
                if (SNT(i))
                    list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                chuoi += list[i].ToString() + " ";
            }
            txtktn.Text = chuoi;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool SNT(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;

                    }
                }
                return true;
            }
        }
    }
}
           