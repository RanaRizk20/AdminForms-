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
    public partial class Addproduct : Form
    {
        public Addproduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {
            Addproduct adp = new Addproduct();
            adp.Show();
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
    }
}
