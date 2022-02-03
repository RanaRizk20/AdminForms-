using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addproduct apd = new Addproduct();
            apd.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Products pd = new Products();
            pd.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdCustomers cus = new AdCustomers();
            cus.Show();
            this.Hide();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            SignupAd sig = new SignupAd();
            sig.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProducts epd = new EditProducts();
            epd.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteProduct dpd = new DeleteProduct();
            dpd.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
