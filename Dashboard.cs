using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class DashboardPage : Form
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Criminals ff = new Criminals();
            this.Hide();
            ff.Show();
        }

        private void OFFICER_Click(object sender, EventArgs e)
        {
            Polices ff = new Polices();
            this.Hide();
            ff.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cases ff = new Cases();
            this.Hide();
            ff.Show();
        }

        private void CHARGES_Click(object sender, EventArgs e)
        {
            Charges ff = new Charges();
            this.Hide();
            ff.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            Login ff = new Login();
            this.Hide();
            ff.Show();
        }
    }
}
