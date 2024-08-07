namespace CSharp_TinhTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soDien = Convert.ToDouble(txtSoDien.Text);
            if (soDien > 0 && soDien < 50)
            {
                lblKQ.Text = "Giá: " + soDien * 1400;
                listBoxKQ.Items.Add("Giá: " + soDien * 1400);
            }
            else if (soDien > 50 && soDien < 101)
            {
                lblKQ.Text = "Giá: " + (50 * 1400 + (soDien - 50) * 1500);
                listBoxKQ.Items.Add("Giá: " + (50 * 1400 + (soDien - 50) * 1500));
            }
            else if (soDien > 100 && soDien < 201)
            {
                lblKQ.Text = "Giá: " + (50 * 1400 + 50 * 1500 + (soDien - 100) * 1600);
                listBoxKQ.Items.Add("Giá: " + (50 * 1400 + 50 * 1500 + (soDien - 100) * 1600));
            }
            else
            {
                lblKQ.Text = "Giá: " + (50 * 1400 + 50 * 1500 + 100 * 1600 + (soDien - 200) * 1700);
                listBoxKQ.Items.Add("Giá: " + (50 * 1400 + 50 * 1500 + 100 * 1600 + (soDien - 200) * 1700));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxKQ.Items.Clear();
            lblKQ.Text = "";
            txtSoDien.Text = "";
        }
    }
}
